using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Aircraft
{
    public partial class routes : Form
    {
        private NpgsqlConnection connection;
        private object dataGridView;

        public routes()
        {
            InitializeComponent();
            NpgsqlConnection connection = new NpgsqlConnection(" Host = 127.0.0.1;  Port = 5432 ;Username = postgres; Password = 1111; Database = arline;");
            connection.Open();
            LoadData();
        }
        private void LoadData()
        {
            // Встановлення з'єднання з базою даних
            connection = new NpgsqlConnection(" Host = 127.0.0.1;  Port = 5432 ;Username = postgres; Password = 1111; Database = arline;");
            connection.Open();

            // Створення запиту до бази даних
            string sql = "SELECT * FROM routes";

            // Створення об'єкту команди для виконання запиту
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            // Виконання запиту та збереження результатів у об'єкті DataTable
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(table);
            GridView.DataSource = table;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string placeOfDeparture = place_of_departure.Text;
            string placeOfDestination = place_of_destination.Text;
            if (string.IsNullOrEmpty(placeOfDeparture) || string.IsNullOrEmpty(placeOfDestination))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            string distanceValue = distance.Text;

            // Створення запиту на вставку даних
            string sql = "INSERT INTO routes (place_of_departure, place_of_destination, distance) VALUES (@place_of_departure, @place_of_destination, @distance) RETURNING id";

            // Створення об'єкту команди та передача параметрів
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@place_of_departure", NpgsqlDbType.Char, placeOfDeparture);
            command.Parameters.AddWithValue("@place_of_destination", NpgsqlDbType.Char, placeOfDestination);
            command.Parameters.AddWithValue("@distance", NpgsqlDbType.Text, distanceValue);

            // Виконання запиту та отримання згенерованого значення id
            int newRouteId;
            try
            {
                newRouteId = (int)command.ExecuteScalar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Виникла помилка під час додавання даних до бази даних: " + ex.Message);
                return;
            }

            if (newRouteId > 0)
            {
                MessageBox.Show("Дані успішно додані до бази даних з ідентифікатором: " + newRouteId);
                LoadData(); // Оновлення таблиці у DataGridView
            }
            else
            {
                MessageBox.Show("Не вдалося отримати ідентифікатор нового запису.");
            }

            place_of_departure.Text = "";
            place_of_destination.Text = "";
            distance.Text = "";
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flights secondForm = new flights();
            secondForm.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets secondform = new tickets();
            secondform.Show();
        }

        private void aircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel secondForm = new AdminPanel();
            secondForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // перевірка, чи вибраний конкретний рядок
            if (GridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть рядок, який потрібно оновити.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = (int)GridView.SelectedRows[0].Cells["id"].Value;

            string placeOfDeparture = place_of_departure.Text;
            string placeOfDestination = place_of_destination.Text;

            // Перевірка, чи введені місця відправлення та прибуття
            if (string.IsNullOrEmpty(placeOfDeparture) || string.IsNullOrEmpty(placeOfDestination))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            string distanceValue = distance.Text;

            // Створення запиту на оновлення даних
            string sql = "UPDATE routes SET distance = @distance, place_of_departure = @place_of_departure, place_of_destination = @place_of_destination WHERE id = @id";

            // Створення об'єкту команди та передача параметрів
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@distance", NpgsqlDbType.Text, distanceValue);
            command.Parameters.AddWithValue("@place_of_departure", NpgsqlDbType.Char, placeOfDeparture);
            command.Parameters.AddWithValue("@place_of_destination", NpgsqlDbType.Char, placeOfDestination);
            command.Parameters.AddWithValue("@id", NpgsqlDbType.Integer, id);

            // Виконання запиту на оновлення даних
            int rowsAffected;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Виникла помилка під час оновлення даних: " + ex.Message);
                return;
            }

            if (rowsAffected > 0)
            {
                MessageBox.Show("Дані успішно оновлені.");
                LoadData(); // Оновлення таблиці у DataGridView
            }
            else
            {
                MessageBox.Show("Не вдалося знайти запис для оновлення.");
            }

            // Очищення полів введення
            place_of_departure.Text = "";
            place_of_destination.Text = "";
            distance.Text = "";

        }

        private void DeletButton_Click(object sender, EventArgs e)
        {
            if (GridView.SelectedRows.Count > 0)
            {
                if (GridView.SelectedRows.Count > 0)
                {
                    // Використання класу MessageBox для запиту користувача, чи він дійсно хоче видалити вибраний рядок
                    DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити вибраний рядок?", "Підтвердження видалення", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Створення об'єкта з'єднання з базою даних
                        using (NpgsqlConnection connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=arline;"))
                        {
                            connection.Open();

                            // Видалення вибраних рядків з таблиці flights
                            foreach (DataGridViewRow row in GridView.SelectedRows)
                            {
                                int routeId = Convert.ToInt32(row.Cells["id"].Value);

                                // Видалення записів з таблиці flights з відповідним route_id
                                string deleteFlightsSql = "DELETE FROM flights WHERE routes_id = @routes_id";
                                NpgsqlCommand deleteFlightsCommand = new NpgsqlCommand(deleteFlightsSql, connection);
                                deleteFlightsCommand.Parameters.AddWithValue("@routes_id", routeId);
                                deleteFlightsCommand.ExecuteNonQuery();
                            }

                            // Видалення вибраних рядків з таблиці routes
                            foreach (DataGridViewRow row in GridView.SelectedRows)
                            {
                                int routeId = Convert.ToInt32(row.Cells["id"].Value);

                                // Видалення запису з таблиці routes з відповідним route_id
                                string deleteRouteSql = "DELETE FROM routes WHERE id = @id";
                                NpgsqlCommand deleteRouteCommand = new NpgsqlCommand(deleteRouteSql, connection);
                                deleteRouteCommand.Parameters.AddWithValue("@id", routeId);
                                deleteRouteCommand.ExecuteNonQuery();
                            }

                            // Після видалення оновлення таблиці GridView
                            LoadData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть рядок для видалення");
                }
            }
            }
    }
}
