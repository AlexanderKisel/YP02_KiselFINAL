namespace YP02_Kisel.Forms
{
    partial class AutorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.AutorizationLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.EnterAdd = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pswdCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AutorizationLbl
            // 
            this.AutorizationLbl.AutoSize = true;
            this.AutorizationLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AutorizationLbl.Location = new System.Drawing.Point(132, 9);
            this.AutorizationLbl.Name = "AutorizationLbl";
            this.AutorizationLbl.Size = new System.Drawing.Size(148, 33);
            this.AutorizationLbl.TabIndex = 0;
            this.AutorizationLbl.Text = "Авторизация";
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLbl.Location = new System.Drawing.Point(23, 66);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(74, 33);
            this.LoginLbl.TabIndex = 1;
            this.LoginLbl.Text = "Логин";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLbl.Location = new System.Drawing.Point(12, 116);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(85, 33);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Пароль";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTxt.Location = new System.Drawing.Point(112, 63);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(267, 36);
            this.LoginTxt.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxt.Location = new System.Drawing.Point(112, 117);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(267, 36);
            this.PasswordTxt.TabIndex = 4;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // EnterAdd
            // 
            this.EnterAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.EnterAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterAdd.Location = new System.Drawing.Point(33, 210);
            this.EnterAdd.Name = "EnterAdd";
            this.EnterAdd.Size = new System.Drawing.Size(137, 53);
            this.EnterAdd.TabIndex = 5;
            this.EnterAdd.Text = "Войти";
            this.EnterAdd.UseVisualStyleBackColor = false;
            this.EnterAdd.Click += new System.EventHandler(this.EnterAdd_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.BackBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.Location = new System.Drawing.Point(232, 210);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(137, 53);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pswdCheckBox
            // 
            this.pswdCheckBox.AutoSize = true;
            this.pswdCheckBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswdCheckBox.Location = new System.Drawing.Point(203, 172);
            this.pswdCheckBox.Name = "pswdCheckBox";
            this.pswdCheckBox.Size = new System.Drawing.Size(176, 32);
            this.pswdCheckBox.TabIndex = 7;
            this.pswdCheckBox.Text = "Показать пароль";
            this.pswdCheckBox.UseVisualStyleBackColor = true;
            this.pswdCheckBox.CheckedChanged += new System.EventHandler(this.pswdCheckBox_CheckedChanged);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 275);
            this.Controls.Add(this.pswdCheckBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EnterAdd);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.AutorizationLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AutorizationLbl;
        private Label LoginLbl;
        private Label PasswordLbl;
        private TextBox LoginTxt;
        private TextBox PasswordTxt;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button EnterAdd;
        private Button BackBtn;
        private CheckBox pswdCheckBox;
    }
}