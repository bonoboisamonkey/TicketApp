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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
           User LogedUser =  Database.GetUser(txbx_email.Text, txbx_pass.Text);
            if (LogedUser != null)
            {
                TicketForm TicketForm = new TicketForm();
                TicketForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong data");
            }
        }
    }
}
