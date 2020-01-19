namespace TicketApp
{
    partial class RegisterForm
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
            this.txbx_sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(151, 60);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(149, 20);
            this.txbx_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txbx_sname
            // 
            this.txbx_sname.Location = new System.Drawing.Point(151, 105);
            this.txbx_sname.Name = "txbx_sname";
            this.txbx_sname.Size = new System.Drawing.Size(149, 20);
            this.txbx_sname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(151, 147);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(149, 20);
            this.txbx_email.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // txbx_pass
            // 
            this.txbx_pass.Location = new System.Drawing.Point(151, 192);
            this.txbx_pass.Name = "txbx_pass";
            this.txbx_pass.Size = new System.Drawing.Size(149, 20);
            this.txbx_pass.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(78, 256);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(178, 37);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 330);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_pass);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.txbx_sname);
            this.Controls.Add(this.txbx_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_register;
    }
}

