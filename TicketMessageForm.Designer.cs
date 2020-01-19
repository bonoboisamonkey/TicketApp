namespace TicketApp
{
    partial class TicketMessageForm
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
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_short = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_details = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(219, 34);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(156, 20);
            this.txbx_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name your problem";
            // 
            // txbx_short
            // 
            this.txbx_short.Location = new System.Drawing.Point(196, 95);
            this.txbx_short.Name = "txbx_short";
            this.txbx_short.Size = new System.Drawing.Size(199, 20);
            this.txbx_short.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short Description";
            // 
            // txbx_details
            // 
            this.txbx_details.Location = new System.Drawing.Point(114, 190);
            this.txbx_details.Multiline = true;
            this.txbx_details.Name = "txbx_details";
            this.txbx_details.Size = new System.Drawing.Size(384, 174);
            this.txbx_details.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Details";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(262, 386);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // TicketMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 468);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_short);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_name);
            this.Name = "TicketMessageForm";
            this.Text = "TicketMessageForm";
            this.Load += new System.EventHandler(this.TicketMessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_short;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
    }
}