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

namespace Aircraft
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 64);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = login.Text;
            String passUser = password.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("Select * From users where  login = @uL and password = @uP ",db.getConnection());

            command.Parameters.Add("@uL",NpgsqlDbType.Varchar).Value = loginUser ;
            command.Parameters.Add("@uP", NpgsqlDbType.Varchar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0) {
               
                AdminPanel FormAdmin = new AdminPanel();
                FormAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Admin");
            }
                

        }
    }
}
