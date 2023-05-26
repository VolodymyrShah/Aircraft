using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Aircraft
{
    public partial class flights : Form
    {
        private NpgsqlConnection connection;
        private object oldAircraftId;
        private object oldRoutesId;
        private object oldroutesid;
        private object oldaircraftid;

        public flights()
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
            string sql = "SELECT * FROM flights";

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
            if (!int.TryParse(aircraft_id.Text, out int aircraftId) || aircraftId <= 0)
            {
                MessageBox.Show("Ідентифікатор літака повинен бути додатнім цілим числом.");
                return;
            }

            if (!int.TryParse(routes_id.Text, out int routesId) || routesId <= 0)
            {
                MessageBox.Show("Ідентифікатор маршруту повинен бути додатнім цілим числом.");
                return;
            }

            if (!int.TryParse(flight_num.Text, out int flightNumber) || flightNumber <= 0)
            {
                MessageBox.Show("Номер рейсу повинен бути додатнім цілим числом.");
                return;
            }

            if (!DateTime.TryParse(departure_date.Text, out DateTime departureDate))
            {
                MessageBox.Show("Дата відправлення повинна бути вказана у форматі dd/MM/yyyy.");
                return;
            }

            if (!TimeSpan.TryParse(departure_time.Text, out TimeSpan departureTime))
            {
                MessageBox.Show("Час відправлення повинен бути вказаний у форматі hh:mm:ss.");
                return;
            }

            // Створення запиту на вставку даних
            string sql = "INSERT INTO flights (aircraft_id, routes_id, flight_number, departure_date, departure_time) VALUES (@aircraft_id, @routes_id, @flight_number, @departure_date, @departure_time) RETURNING id";

            // Створення об'єкту команди та передача параметрів
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@aircraft_id", NpgsqlDbType.Integer, aircraftId);
            command.Parameters.AddWithValue("@routes_id", NpgsqlDbType.Integer, routesId);
            command.Parameters.AddWithValue("@flight_number", NpgsqlDbType.Integer, flightNumber);
            command.Parameters.AddWithValue("@departure_date", NpgsqlDbType.Date, departureDate);
            command.Parameters.AddWithValue("@departure_time", NpgsqlDbType.Time, departureTime);

            // Виконання запиту та відображення результату
            int newFlightId;
            try
            {
                newFlightId = (int)command.ExecuteScalar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Виникла помилка під час додавання рейсу до бази даних: " + ex.Message);
                return;
            }

            if (newFlightId > 0)
            {
                MessageBox.Show($"Рейс додано з ідентифікатором: {newFlightId}");
                LoadData(); // Оновлення таблиці у DataGridView
            }
            else
            {
                MessageBox.Show("Виникла помилка під час додавання рейсу до бази даних.");
            }

            // Очищення полів введення
            aircraft_id.Text = "";
            routes_id.Text = "";
            flight_num.Text = "";
            departure_date.Text = "";
            departure_time.Text = "";

            MessageBox.Show("Дані є коректними.");
        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            routes secondForm = new routes();
            secondForm.Show();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            int routesId;
            int aircraftId;

            // Перевірка та отримання значень ідентифікаторів маршруту та літака
            if (!int.TryParse(routes_id.Text, out routesId) || routesId <= 0)
            {
                MessageBox.Show("Ідентифікатор маршруту повинен бути додатнім цілим числом.");
                return;
            }

            if (!int.TryParse(aircraft_id.Text, out aircraftId) || aircraftId <= 0)
            {
                MessageBox.Show("Ідентифікатор літака повинен бути додатнім цілим числом.");
                return;
            }

            // Оновлення даних в таблиці routes_id та aircraft_id
            string updateSql = "UPDATE flights SET id = @id, aircraft_id = @aircraftId WHERE id = @flightId";

            using (NpgsqlConnection connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=arline;"))
            {
                connection.Open();
                NpgsqlCommand updateCommand = new NpgsqlCommand(updateSql, connection);
                updateCommand.Parameters.AddWithValue("@routesId", NpgsqlDbType.Integer, routesId);
                updateCommand.Parameters.AddWithValue("@aircraftId", NpgsqlDbType.Integer, aircraftId);

                // Отримання ідентифікатора рейсу з вибраного рядка
                if (GridView.SelectedRows.Count > 0)
                {
                    int flightId = Convert.ToInt32(GridView.SelectedRows[0].Cells["id"].Value);
                    updateCommand.Parameters.AddWithValue("@flightId", NpgsqlDbType.Integer, flightId);

                    try
                    {
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Дані успішно оновлені.");
                            LoadData(); // Оновлення таблиці у DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Не вдалося знайти запис для оновлення.");
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Виникла помилка під час оновлення даних: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть рядок для оновлення.");
                }
            }

            // Очищення полів введення
            routes_id.Text = "";
            aircraft_id.Text = "";
            flight_num.Text = "";
            departure_date.Text = "";
            departure_time.Text = "";
        }

        private void aircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel secondForm = new AdminPanel();
            secondForm.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tickets secondForm = new tickets();
            //secondForm.Show();
        }

        private void flights_Load(object sender, EventArgs e)
        {

        }

        private void DeletButton_Click(object sender, EventArgs e)
        {
            if (GridView.SelectedRows.Count > 0)
            {
                // Використання класу MessageBox для запиту користувача, чи він дійсно хоче видалити вибраний рядок
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити вибраний рядок?", "Підтвердження видалення", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Створення об'єкта з'єднання з базою даних та адаптера для взаємодії з даними
                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=arline;"))
                    {
                        connection.Open();
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM flights", connection);

                        // Видалення вибраних рядків з DataGridView
                        foreach (DataGridViewRow row in GridView.SelectedRows)
                        {
                            GridView.Rows.Remove(row);
                        }

                        // Збереження змін у базі даних
                        NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);
                        adapter.Update((DataTable)GridView.DataSource);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для видалення");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
