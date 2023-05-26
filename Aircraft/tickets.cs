using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aircraft
{
    public partial class tickets : Form
    {
        private NpgsqlConnection connection;

        public tickets()
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
            string sql = "SELECT * FROM tickets";

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
            if (!int.TryParse(flights_id.Text, out int flight_Id) || flight_Id <= 0)
            {
                MessageBox.Show("Ідентифікатор рейсу повинен бути додатнім цілим числом.");
                return;
            }

            if (!float.TryParse(price.Text, out float ticketsPrice) || ticketsPrice <= 0)
            {
                MessageBox.Show("Ціна квитка повинна бути додатнім числом.");
                return;
            }

            // Створення запиту на вставку даних
            string insertSql = "INSERT INTO tickets (flights_id, price) VALUES (@flights_id, @ticketsPrice) RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=arline;"))
            {
                connection.Open();
                NpgsqlCommand insertCommand = new NpgsqlCommand(insertSql, connection);
                insertCommand.Parameters.AddWithValue("@flights_id", NpgsqlDbType.Integer, flight_Id);
                insertCommand.Parameters.AddWithValue("@ticketsPrice", NpgsqlDbType.Real, ticketsPrice);

                try
                {
                    int newTicketId = (int)insertCommand.ExecuteScalar();
                    if (newTicketId > 0)
                    {
                        MessageBox.Show($"Квиток додано з ідентифікатором: {newTicketId}");
                        LoadData(); // Оновлення таблиці у DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час додавання квитка до бази даних.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Виникла помилка під час додавання квитка до бази даних: " + ex.Message);
                }
            }

            // Очищення полів введення
            flights_id.Text = "";
            price.Text = "";

            MessageBox.Show("Дані є коректними.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {


            if (!int.TryParse(id.Text, out int ticketId) || ticketId <= 0)
            {
                MessageBox.Show("Ідентифікатор квитка повинен бути додатнім цілим числом.");
                return;
            }

            if (!int.TryParse(id.Text, out int flightId) || flightId <= 0)
            {
                MessageBox.Show("Ідентифікатор рейсу повинен бути додатнім цілим числом.");
                return;
            }

            if (!float.TryParse(price.Text, out float ticketPrice) || ticketPrice <= 0)
            {
                MessageBox.Show("Ціна квитка повинна бути додатнім числом.");
                return;
            }

            // Оновлення даних в таблиці tickets
            string updateSql = "UPDATE tickets SET id =  @flightId, price = @ticketPrice WHERE id = @ticketId";
            string updateSql1 = $"UPDATE tickets SET id =  {flightId}, price = {ticketPrice} WHERE id = {ticketId}";

            using (NpgsqlConnection connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=arline;"))
            {

                connection.Open();

                NpgsqlCommand updateCommand = new NpgsqlCommand(updateSql1, connection);
                //updateCommand.Parameters.AddWithValue("@flightId", NpgsqlDbType.Integer, flightId);
                //updateCommand.Parameters.AddWithValue("@ticketPrice", NpgsqlDbType.Real, ticketPrice);
                //updateCommand.Parameters.AddWithValue("@ticketId", NpgsqlDbType.Integer, ticketId);

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                 
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Дані успішно оновлені." + rowsAffected);
                        LoadData(); // Оновлення таблиці у DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося знайти запис для оновлення." + rowsAffected);
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Виникла помилка під час оновлення даних: " + ex.Message);
                }
            }

            // Очищення полів введення
            id.Text = "";
            flights_id.Text = "";
            price.Text = "";

            MessageBox.Show("Дані є коректними.");

        }
    }
}
