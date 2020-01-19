using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.TicketControls;

namespace TicketApp
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            TicketMessageForm TMF = new TicketMessageForm();
            TMF.ShowDialog();
            DisplayTickets();
        }

        private void DisplayTickets()
        {
            Ticket[] tickets = Database.GetAllTickets();
            int y = 10;
            foreach (Ticket item in tickets)
            {
                EditableTicketContol panel = new EditableTicketContol();
                panel.lbl_name.Text = item.ticketName;
                panel.lbl_short.Text = item.shortDescription;
                panel.txbx_details.Text =item.details;
                panel.Location = new Point(10, y);
                y += 50;
                list_ticket.Controls.Add(panel);
            }
        }
    }
}
