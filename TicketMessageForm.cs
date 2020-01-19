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
    public partial class TicketMessageForm : Form
    {
        public TicketMessageForm()
        {
            InitializeComponent();
        }

        public TicketMessageForm(string name)
        {
            InitializeComponent();
            txbx_name.Text = name;
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {

            Ticket ticket = new Ticket();
            ticket.ticketName = txbx_name.Text;
            ticket.shortDescription = txbx_short.Text;
            ticket.details = txbx_details.Text;
            Database.AddTicket(ticket);
            MessageBox.Show("your ticket added.");
            Close();
        }

        private void TicketMessageForm_Load(object sender, EventArgs e)
        {
            Ticket ticket = Database.GetTickets(txbx_name.Text);

            if (ticket != null)
            {
                txbx_details.Text = ticket.details;
                txbx_short.Text = ticket.shortDescription;
            }
        }

    }
}
