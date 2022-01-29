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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

      

        private void LogginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

        }

        private void LogginButton_MouseHover(object sender, EventArgs e)
        {
            LogginButton.ForeColor = Color.Black;
            
        }

        private void LogginButton_MouseDown(object sender, MouseEventArgs e)
        {
            LogginButton.ForeColor = Color.Black;
        }

        private void LogginButton_MouseEnter(object sender, EventArgs e)
        {
           // LogginButton.BackColor = Color.White;
            LogginButton.Size = new Size(150, 150);
        }

        private void LogginButton_MouseLeave(object sender, EventArgs e)
        {
           // LogginButton.BackColor = Color.Transparent;
            LogginButton.Size = new Size(120, 120);
        }

        private void RegistrButton_MouseEnter(object sender, EventArgs e)
        {
            RegistrButton.Size = new Size(150, 150);
        }

        private void RegistrButton_MouseLeave(object sender, EventArgs e)
        {
            RegistrButton.Size = new Size(120, 120);
        }

        private void LogginButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

        }

        private void LogginButton_MouseEnter_1(object sender, EventArgs e)
        {
            LogginButton.Size = new Size(150, 150);
        }

        private void LogginButton_MouseLeave_1(object sender, EventArgs e)
        {
            LogginButton.Size = new Size(120, 120);
        }
    }
}
