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
    public partial class FormSignUp : Form
    {
        private ClassLib.UsersDBEntities ctx;

        public FormSignUp()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';

            ctx = new ClassLib.UsersDBEntities();
            ctx.RegisteredUsers.Load();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (IsPasswordValid()&&IsLoginValid()&&IsAdminCodeValid())
            {
                ClassLib.RegisteredUsers newuser = new ClassLib.RegisteredUsers();
                System.Nullable<int> ID = (int)(from u in ctx.RegisteredUsers select u.ID).Max() + 1;
                newuser.ID = (int)ID;
                newuser.login = textBoxLogin.Text;
                newuser.password = textBoxPassword.Text;
                if (textBoxAdminCode.Text == "I am ADMIN")
                    newuser.access_lvl = 2;
                else newuser.access_lvl = 0;

                ctx.RegisteredUsers.Add(newuser);
                ctx.SaveChanges();

                this.Dispose();
            }
        }

        bool IsPasswordValid()
        {
            if (textBoxPassword.Text.Length>50)
            {
                MessageBox.Show("Password is too long (it must contain less then 50 symbols)");
                return false;
            }
            else
            {
                if (textBoxPassword.Text.Length<8)
                {
                    MessageBox.Show("Password is to short (it must contain more then 8 symbols");
                    return false;
                }
                else
                {
                    if (IsStringContainUnvalidSymbol(textBoxPassword.Text))
                    {
                        MessageBox.Show("Password must consist of 0-9 and a-z");
                        return false;
                    }
                    else if (textBoxPassword.Text!=textBoxConfirmPassword.Text)
                    {
                        MessageBox.Show("Please, check if your passwords are similar");
                        return false;
                    }
                }
            }
            return true;
        }

        bool IsLoginValid()
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("User name must be filled");
                return false;
            }
            else if (textBoxLogin.Text.Length>50)
            {
                MessageBox.Show("User name is too long");
                return false;
            }
            else if (IsStringContainUnvalidSymbol(textBoxLogin.Text))
            {
                MessageBox.Show("Login must consist of 0-9 and a-z");
                return false;
            }
            else
            {
                var isUserWithThisName = (from u in ctx.RegisteredUsers where (u.login == textBoxLogin.Text) select u).Any();
                if (isUserWithThisName)
                {
                    MessageBox.Show("This user name is occupied, choose another one, please.");
                    return false;
                }
            }
            return true;
        }

        bool IsAdminCodeValid()
        {
            if (String.IsNullOrWhiteSpace(textBoxAdminCode.Text))
            {
                return true;
            }
            return true;
        }

        bool IsStringContainUnvalidSymbol(string input)
        {
            for (int i=0; i<input.Length;++i)
            {
                if (!((input[i]>='0' && (input[i]<='9'))||(input[i]>='a' && input[i]<='z')))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
