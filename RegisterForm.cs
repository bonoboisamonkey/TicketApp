using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                name = txbx_name.Text,
                surname = txbx_sname.Text,
                email = txbx_email.Text,
                password = txbx_pass.Text
            };

            User[] users = Database.GetAllUsers();
            foreach(User _user in users)
            {
                if(_user.name != user.name && _user.email != user.email && _user.password != user.password)
                {

                    MessageBox.Show("User added");
                    Database.AddUser(user);
                    LoginForm LoginForm = new LoginForm();
                    LoginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User already exist");
                    LoginForm LoginForm = new LoginForm();
                    LoginForm.ShowDialog();
                }
            }
            
        }
    }
}
