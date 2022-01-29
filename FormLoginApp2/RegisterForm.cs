using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginApp2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.UserField.Size.Width, 64);
            userNameField.Text = "Skriv in namn";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Skriv in efternamn";
            userSurnameField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == "Skriv in namn")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
            
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Skriv in namn";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Skriv in efternamn")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Skriv in efternamn";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(userNameField.Text == "Skriv in namn")
            {
                MessageBox.Show("Skriv in namn!");
                return;
            }

            if (userSurnameField.Text == "Skriv in efternamn")
            {
                MessageBox.Show("Skriv in efternamn!");
                return;
            }

            if (UserField.Text == "")
            {
                MessageBox.Show("Skriv in login!");
                return;
            }

            if (PasswordField.Text == "")
            {
                MessageBox.Show("Skriv in password!");
                return;
            }

            if(IsUserExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login",MySqlDbType.VarChar).Value=UserField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kontot har skapats");
            }
            else
            {
                MessageBox.Show("Kontot har inte skapats");
            }
            db.closeConnection();
        }

        public Boolean IsUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@ul", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = UserField.Text;           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Detta login finns redan, vänligen ange ett annat login!");
                return true;
            }

            else
                return false;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
