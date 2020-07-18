namespace DBKeys
{
    partial class RegisterField
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
            this.backToLog = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.logField = new System.Windows.Forms.TextBox();
            this.mailField = new System.Windows.Forms.TextBox();
            this.passConfirmField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backToLog
            // 
            this.backToLog.AutoSize = true;
            this.backToLog.LinkColor = System.Drawing.Color.Black;
            this.backToLog.Location = new System.Drawing.Point(143, 116);
            this.backToLog.Name = "backToLog";
            this.backToLog.Size = new System.Drawing.Size(69, 13);
            this.backToLog.TabIndex = 11;
            this.backToLog.TabStop = true;
            this.backToLog.Text = "Back to login";
            this.backToLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backToLog_LinkClicked);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(72, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Licenses";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(72, 138);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Register";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(72, 37);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(140, 20);
            this.passField.TabIndex = 7;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passField_KeyPress);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // logField
            // 
            this.logField.Location = new System.Drawing.Point(72, 11);
            this.logField.Name = "logField";
            this.logField.Size = new System.Drawing.Size(140, 20);
            this.logField.TabIndex = 6;
            this.logField.Enter += new System.EventHandler(this.logField_Enter);
            this.logField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logField_KeyPress);
            this.logField.Leave += new System.EventHandler(this.logField_Leave);
            // 
            // mailField
            // 
            this.mailField.Location = new System.Drawing.Point(72, 89);
            this.mailField.Name = "mailField";
            this.mailField.Size = new System.Drawing.Size(140, 20);
            this.mailField.TabIndex = 12;
            this.mailField.Enter += new System.EventHandler(this.mailField_Enter);
            this.mailField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailField_KeyPress);
            this.mailField.Leave += new System.EventHandler(this.mailField_Leave);
            // 
            // passConfirmField
            // 
            this.passConfirmField.Location = new System.Drawing.Point(72, 63);
            this.passConfirmField.Name = "passConfirmField";
            this.passConfirmField.Size = new System.Drawing.Size(140, 20);
            this.passConfirmField.TabIndex = 13;
            this.passConfirmField.Enter += new System.EventHandler(this.passConfirmField_Enter);
            this.passConfirmField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passConfirmField_KeyPress);
            this.passConfirmField.Leave += new System.EventHandler(this.passConfirmField_Leave);
            // 
            // RegisterField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 173);
            this.Controls.Add(this.passConfirmField);
            this.Controls.Add(this.mailField);
            this.Controls.Add(this.backToLog);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.logField);
            this.MaximumSize = new System.Drawing.Size(309, 212);
            this.MinimumSize = new System.Drawing.Size(309, 212);
            this.Name = "RegisterField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterField_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterField_FormClosed);
            this.Load += new System.EventHandler(this.RegisterField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel backToLog;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox logField;
        private System.Windows.Forms.TextBox mailField;
        private System.Windows.Forms.TextBox passConfirmField;
    }
}