namespace TicketApp.TicketControls
{
    partial class EditableTicketContol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_short = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txbx_details = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(36, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            // 
            // lbl_short
            // 
            this.lbl_short.AutoSize = true;
            this.lbl_short.Location = new System.Drawing.Point(107, 17);
            this.lbl_short.Name = "lbl_short";
            this.lbl_short.Size = new System.Drawing.Size(35, 13);
            this.lbl_short.TabIndex = 0;
            this.lbl_short.Text = "label1";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(477, 17);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // txbx_details
            // 
            this.txbx_details.Location = new System.Drawing.Point(174, 19);
            this.txbx_details.Name = "txbx_details";
            this.txbx_details.Size = new System.Drawing.Size(268, 20);
            this.txbx_details.TabIndex = 3;
            // 
            // EditableTicketContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbx_details);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_short);
            this.Controls.Add(this.lbl_name);
            this.Name = "EditableTicketContol";
            this.Size = new System.Drawing.Size(576, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_short;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.TextBox txbx_details;
    }
}
