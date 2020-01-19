using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp.TicketControls
{
    public partial class EditableTicketContol : UserControl
    {
        public EditableTicketContol()
        {
            InitializeComponent();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            TicketMessageForm tm = new TicketMessageForm(lbl_name.Text);
            tm.ShowDialog();
        }
    }
}
