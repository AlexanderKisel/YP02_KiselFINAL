namespace YP02_Kisel
{
    partial class MaterialsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsForm));
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AutorithashionBtn = new System.Windows.Forms.Button();
            this.materialDgv = new System.Windows.Forms.DataGridView();
            this.UserLbl = new System.Windows.Forms.Label();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortCmb = new System.Windows.Forms.ComboBox();
            this.ybRadioButton = new System.Windows.Forms.RadioButton();
            this.vRadioButton = new System.Windows.Forms.RadioButton();
            this.filterCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spisokBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.AddBtn.Enabled = false;
            this.AddBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBtn.Location = new System.Drawing.Point(15, 483);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(137, 53);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавление";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.MouseEnter += new System.EventHandler(this.AddBtn_MouseEnter);
            this.AddBtn.MouseLeave += new System.EventHandler(this.AddBtn_MouseLeave);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.DelBtn.Enabled = false;
            this.DelBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelBtn.Location = new System.Drawing.Point(189, 483);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(137, 53);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Удаление";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            this.DelBtn.MouseEnter += new System.EventHandler(this.DelBtn_MouseEnter);
            this.DelBtn.MouseLeave += new System.EventHandler(this.DelBtn_MouseLeave);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.EditBtn.Enabled = false;
            this.EditBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(361, 483);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(155, 53);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Редактирование";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            this.EditBtn.MouseEnter += new System.EventHandler(this.EditBtn_MouseEnter);
            this.EditBtn.MouseLeave += new System.EventHandler(this.EditBtn_MouseLeave);
            // 
            // AutorithashionBtn
            // 
            this.AutorithashionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.AutorithashionBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AutorithashionBtn.Location = new System.Drawing.Point(548, 483);
            this.AutorithashionBtn.Name = "AutorithashionBtn";
            this.AutorithashionBtn.Size = new System.Drawing.Size(137, 53);
            this.AutorithashionBtn.TabIndex = 4;
            this.AutorithashionBtn.Text = "Авторизация";
            this.AutorithashionBtn.UseVisualStyleBackColor = false;
            this.AutorithashionBtn.Click += new System.EventHandler(this.AutorithashionBtn_Click);
            this.AutorithashionBtn.MouseEnter += new System.EventHandler(this.AutorithashionBtn_MouseEnter);
            this.AutorithashionBtn.MouseLeave += new System.EventHandler(this.AutorithashionBtn_MouseLeave);
            // 
            // materialDgv
            // 
            this.materialDgv.AllowUserToAddRows = false;
            this.materialDgv.AllowUserToDeleteRows = false;
            this.materialDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDgv.Location = new System.Drawing.Point(12, 12);
            this.materialDgv.Name = "materialDgv";
            this.materialDgv.ReadOnly = true;
            this.materialDgv.RowTemplate.Height = 25;
            this.materialDgv.Size = new System.Drawing.Size(776, 402);
            this.materialDgv.TabIndex = 5;
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLbl.Location = new System.Drawing.Point(15, 436);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(263, 28);
            this.UserLbl.TabIndex = 6;
            this.UserLbl.Text = "Пользователь не авторизован";
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitLbl.Location = new System.Drawing.Point(972, 495);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(100, 28);
            this.ExitLbl.TabIndex = 7;
            this.ExitLbl.Text = "Выйти 🚪";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            this.ExitLbl.MouseEnter += new System.EventHandler(this.ExitLbl_MouseEnter);
            this.ExitLbl.MouseLeave += new System.EventHandler(this.ExitLbl_MouseLeave);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.Location = new System.Drawing.Point(874, 12);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(223, 36);
            this.searchTxt.TabIndex = 8;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchLbl.Location = new System.Drawing.Point(808, 15);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(60, 28);
            this.SearchLbl.TabIndex = 9;
            this.SearchLbl.Text = "Поиск";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortCmb);
            this.groupBox1.Controls.Add(this.ybRadioButton);
            this.groupBox1.Controls.Add(this.vRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(794, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по названию";
            // 
            // sortCmb
            // 
            this.sortCmb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortCmb.FormattingEnabled = true;
            this.sortCmb.Items.AddRange(new object[] {
            "Наименование",
            "Остаток на складе",
            "Стоимость",
            "Вернуть обратно"});
            this.sortCmb.Location = new System.Drawing.Point(14, 22);
            this.sortCmb.Name = "sortCmb";
            this.sortCmb.Size = new System.Drawing.Size(279, 36);
            this.sortCmb.TabIndex = 13;
            this.sortCmb.Text = "-Выберете свойство-";
            this.sortCmb.SelectedIndexChanged += new System.EventHandler(this.sortCmb_SelectedIndexChanged);
            // 
            // ybRadioButton
            // 
            this.ybRadioButton.AutoSize = true;
            this.ybRadioButton.Location = new System.Drawing.Point(24, 89);
            this.ybRadioButton.Name = "ybRadioButton";
            this.ybRadioButton.Size = new System.Drawing.Size(102, 19);
            this.ybRadioButton.TabIndex = 1;
            this.ybRadioButton.TabStop = true;
            this.ybRadioButton.Text = "По убыванию";
            this.ybRadioButton.UseVisualStyleBackColor = true;
            this.ybRadioButton.CheckedChanged += new System.EventHandler(this.ybRadioButton_CheckedChanged);
            // 
            // vRadioButton
            // 
            this.vRadioButton.AutoSize = true;
            this.vRadioButton.Location = new System.Drawing.Point(24, 64);
            this.vRadioButton.Name = "vRadioButton";
            this.vRadioButton.Size = new System.Drawing.Size(116, 19);
            this.vRadioButton.TabIndex = 0;
            this.vRadioButton.TabStop = true;
            this.vRadioButton.Text = "По возрастанию";
            this.vRadioButton.UseVisualStyleBackColor = true;
            this.vRadioButton.CheckedChanged += new System.EventHandler(this.vRadioButton_CheckedChanged);
            // 
            // filterCmb
            // 
            this.filterCmb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterCmb.FormattingEnabled = true;
            this.filterCmb.Items.AddRange(new object[] {
            "Все типы",
            "Гранулы",
            "Рулон",
            "Нарезка",
            "Пресс"});
            this.filterCmb.Location = new System.Drawing.Point(818, 239);
            this.filterCmb.Name = "filterCmb";
            this.filterCmb.Size = new System.Drawing.Size(279, 36);
            this.filterCmb.TabIndex = 11;
            this.filterCmb.Text = "Все типы";
            this.filterCmb.SelectedIndexChanged += new System.EventHandler(this.filterCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(818, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фильтрация";
            // 
            // spisokBtn
            // 
            this.spisokBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.spisokBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spisokBtn.Location = new System.Drawing.Point(712, 483);
            this.spisokBtn.Name = "spisokBtn";
            this.spisokBtn.Size = new System.Drawing.Size(137, 53);
            this.spisokBtn.TabIndex = 13;
            this.spisokBtn.Text = "Список";
            this.spisokBtn.UseVisualStyleBackColor = false;
            this.spisokBtn.Click += new System.EventHandler(this.spisokBtn_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 548);
            this.Controls.Add(this.spisokBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterCmb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.ExitLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.materialDgv);
            this.Controls.Add(this.AutorithashionBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaterialsForm";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddBtn;
        private Button DelBtn;
        private Button EditBtn;
        private Button AutorithashionBtn;
        private DataGridView materialDgv;
        private Label UserLbl;
        private Label ExitLbl;
        private TextBox searchTxt;
        private Label SearchLbl;
        private GroupBox groupBox1;
        private RadioButton ybRadioButton;
        private RadioButton vRadioButton;
        private ComboBox filterCmb;
        private Label label1;
        private ComboBox sortCmb;
        private Button spisokBtn;
    }
}