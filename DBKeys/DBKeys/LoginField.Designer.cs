namespace DBKeys
{
    partial class LoginField
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.logField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.regField = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // logField
            // 
            this.logField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.logField.Location = new System.Drawing.Point(75, 39);
            this.logField.Name = "logField";
            this.logField.Size = new System.Drawing.Size(133, 20);
            this.logField.TabIndex = 0;
            this.logField.Text = "Введите логин";
            this.logField.Enter += new System.EventHandler(this.logField_Enter);
            this.logField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logField_KeyPress);
            this.logField.Leave += new System.EventHandler(this.logField_Leave);
            // 
            // passField
            // 
            this.passField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.passField.Location = new System.Drawing.Point(75, 65);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(133, 20);
            this.passField.TabIndex = 1;
            this.passField.Text = "Введите пароль";
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passField_KeyPress);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(75, 91);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // regField
            // 
            this.regField.AutoSize = true;
            this.regField.LinkColor = System.Drawing.Color.Black;
            this.regField.Location = new System.Drawing.Point(117, 117);
            this.regField.Name = "regField";
            this.regField.Size = new System.Drawing.Size(46, 13);
            this.regField.TabIndex = 5;
            this.regField.TabStop = true;
            this.regField.Text = "Register";
            this.regField.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regField_LinkClicked);
            // 
            // LoginField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 173);
            this.Controls.Add(this.regField);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.logField);
            this.MaximumSize = new System.Drawing.Size(309, 212);
            this.MinimumSize = new System.Drawing.Size(309, 212);
            this.Name = "LoginField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginField_FormClosed);
            this.Load += new System.EventHandler(this.LoginField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel regField;
    }
}

