using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;
using System.Data.Entity;

namespace FormsLib
{
    public partial class FormSignIn : Form
    {
        private ClassLib.UsersDBEntities ctx;

        public FormSignIn()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';

            ctx = new ClassLib.UsersDBEntities();
            ctx.RegisteredUsers.Load();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxLogin.Text)&&!String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                var user = (from u in ctx.RegisteredUsers where (u.login == textBoxLogin.Text) select u).Any();
                if (!user)
                {
                    MessageBox.Show("User with this name is not exist");
                }
                else
                {
                    user= (from u in ctx.RegisteredUsers where (u.login == textBoxLogin.Text && u.password==textBoxPassword.Text) select u).Any();
                    if (!user)
                    {
                        MessageBox.Show("Login or password is incorrect");
                    }
                    else
                    {
                        ClassLib.RegisteredUsers logedInUser = (from u in ctx.RegisteredUsers where (u.login == textBoxLogin.Text && u.password == textBoxPassword.Text) select u).First();
                        FormMain formMain = new FormMain(logedInUser);
                        this.Hide();
                        formMain.ShowDialog();
                        formMain.Dispose();
                        this.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to fill login and password fields");
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Hide();
            formSignUp.ShowDialog(this);
            formSignUp.Dispose();
            this.Show();
            ctx = new ClassLib.UsersDBEntities();
            ctx.RegisteredUsers.Load();
        }

        private void buttonSignUp_Click_1(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Hide();
            formSignUp.ShowDialog(this);
            formSignUp.Dispose();
            this.Show();
            ctx = new ClassLib.UsersDBEntities();
            ctx.RegisteredUsers.Load();
        }
    }
}
