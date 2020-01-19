namespace TicketApp
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ticket = new System.Windows.Forms.Label();
            this.list_ticket = new System.Windows.Forms.ListView();
            this.btn_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ticket
            // 
            this.lbl_ticket.AutoSize = true;
            this.lbl_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticket.Location = new System.Drawing.Point(279, 60);
            this.lbl_ticket.Name = "lbl_ticket";
            this.lbl_ticket.Size = new System.Drawing.Size(116, 33);
            this.lbl_ticket.TabIndex = 0;
            this.lbl_ticket.Text = "Tickets";
            // 
            // list_ticket
            // 
            this.list_ticket.HideSelection = false;
            this.list_ticket.Location = new System.Drawing.Point(12, 152);
            this.list_ticket.Name = "list_ticket";
            this.list_ticket.Size = new System.Drawing.Size(709, 263);
            this.list_ticket.TabIndex = 1;
            this.list_ticket.UseCompatibleStateImageBehavior = false;
            this.list_ticket.View = System.Windows.Forms.View.List;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(580, 69);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(123, 23);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 466);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.list_ticket);
            this.Controls.Add(this.lbl_ticket);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ticket;
        private System.Windows.Forms.ListView list_ticket;
        private System.Windows.Forms.Button btn_new;
    }
}