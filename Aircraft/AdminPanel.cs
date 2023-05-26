using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Aircraft
{
    public partial class AdminPanel : Form
    {
        private NpgsqlConnection connection;
        private object dataGridView;
        private object table;
        private NpgsqlDataAdapter adapter;
        private object dataSet;

        public AdminPanel()
        {
            InitializeComponent();
            NpgsqlConnection connection = new NpgsqlConnection(" Host = 127.0.0.1;  Port = 5432 ;Username = postgres; Password = 1111; Database = arline;");
            connection.Open();
            LoadData();
        }

        private void AdmPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadData() {
            // Встановлення з'єднання з базою даних
            connection = new NpgsqlConnection(" Host = 127.0.0.1;  Port = 5432 ;Username = postgres; Password = 1111; Database = arline;");
            connection.Open();

            // Створення запиту до бази даних
            string sql = "SELECT * FROM aircraft";

            // Створення об'єкту команди для виконання запиту
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            // Виконання запиту та збереження результатів у об'єкті DataTable
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(table);
            GridView.DataSource = table;
           

        }
     

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void addButton_Click(object sender, EventArgs e)
        {
          
            string value1 = name.Text;
            string value2 = number_of_seats.Text;

            // Перевірка, що поля не порожні
            if (string.IsNullOrEmpty(value1) || string.IsNullOrEmpty(value2))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Перевірка коректності введених даних
            if (!char.IsUpper(value1[0]))
            {
                MessageBox.Show("Ім'я повинно починатись з великої літери.");
                return;
            }

            if (!int.TryParse(value2, out int numberOfSeats) || numberOfSeats > 30)
            {
                MessageBox.Show("Кількість місць повинна бути числом, не більше 30.");
                return;
            }

            // Створення запиту на вставку даних
            string sql = "INSERT INTO aircraft (name, number_of_seats) VALUES (@name, @number_of_seats)";

            // Створення об'єкту команди та передача параметрів
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", value1);
            command.Parameters.AddWithValue("@number_of_seats", value2);

            // Виконання запиту та відображення результату
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Дані успішно додані до бази даних.");
                LoadData(); // Оновлення таблиці у DataGridView
            }
            else
            {
                MessageBox.Show("Виникла помилка під час додавання даних до бази даних.");
            }
            name.Text = "";
            number_of_seats.Text = "";
            MessageBox.Show("Дані є коректними.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
          

            // отримання нових значень для оновлення
            string newName = name.Text;
            int id;
            int newNumberOfSeats;
            if (!int.TryParse(number_of_seats.Text, out newNumberOfSeats ) || !int.TryParse(id_text.Text,out id))
            {
                MessageBox.Show("Некоректне значення в полі ID або Місця");
                return;
            }


            using (NpgsqlConnection connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=arline;"))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("UPDATE aircraft SET name = @name, number_of_seats = @numberOfSeats WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("name", newName);
                    command.Parameters.AddWithValue("numberOfSeats", newNumberOfSeats);
                    command.Parameters.AddWithValue("id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Дані успішно оновлено.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити дані.");
                    }
                    id_text .Text = "";
                    name.Text = "";
                    number_of_seats.Text = "";
                }
            }
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
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM aircraft", connection);

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

        private void CheckDataButton_Click(object sender, EventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void number_of_seats_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                flights secondForm = new flights();
                secondForm.Show();
            
        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            routes secondForm = new routes();
            secondForm.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets secondForm = new tickets();
            secondForm.Show();
        }

        private void aircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
