namespace YP02_Kisel.Forms
{
    partial class AddOrEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.pointsPtn = new System.Windows.Forms.Button();
            this.imageTxt = new System.Windows.Forms.TextBox();
            this.typeMaterialCmb = new System.Windows.Forms.ComboBox();
            this.unitCmb = new System.Windows.Forms.ComboBox();
            this.inpackNumeric = new System.Windows.Forms.NumericUpDown();
            this.inskladNumeric = new System.Windows.Forms.NumericUpDown();
            this.minNumeric = new System.Windows.Forms.NumericUpDown();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inpackNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inskladNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во в упаковке:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Единица измерения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во на складе:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Минимальное кол-во:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(120, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Описание:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(167, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "Изображение:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(56, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "Тип материала:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTxt.Location = new System.Drawing.Point(258, 10);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(325, 36);
            this.nameTxt.TabIndex = 9;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTxt.Location = new System.Drawing.Point(258, 257);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(325, 87);
            this.descriptionTxt.TabIndex = 14;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(127, 533);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 53);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(354, 533);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(137, 53);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pointsPtn
            // 
            this.pointsPtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.pointsPtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsPtn.Location = new System.Drawing.Point(593, 420);
            this.pointsPtn.Name = "pointsPtn";
            this.pointsPtn.Size = new System.Drawing.Size(41, 36);
            this.pointsPtn.TabIndex = 20;
            this.pointsPtn.Text = "...";
            this.pointsPtn.UseVisualStyleBackColor = false;
            this.pointsPtn.Click += new System.EventHandler(this.pointsPtn_Click);
            // 
            // imageTxt
            // 
            this.imageTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imageTxt.Location = new System.Drawing.Point(258, 420);
            this.imageTxt.Name = "imageTxt";
            this.imageTxt.Size = new System.Drawing.Size(325, 36);
            this.imageTxt.TabIndex = 21;
            // 
            // typeMaterialCmb
            // 
            this.typeMaterialCmb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeMaterialCmb.FormattingEnabled = true;
            this.typeMaterialCmb.Location = new System.Drawing.Point(258, 474);
            this.typeMaterialCmb.Name = "typeMaterialCmb";
            this.typeMaterialCmb.Size = new System.Drawing.Size(121, 36);
            this.typeMaterialCmb.TabIndex = 22;
            // 
            // unitCmb
            // 
            this.unitCmb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unitCmb.FormattingEnabled = true;
            this.unitCmb.Items.AddRange(new object[] {
            "л",
            "м",
            "кг"});
            this.unitCmb.Location = new System.Drawing.Point(258, 102);
            this.unitCmb.Name = "unitCmb";
            this.unitCmb.Size = new System.Drawing.Size(121, 36);
            this.unitCmb.TabIndex = 23;
            // 
            // inpackNumeric
            // 
            this.inpackNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inpackNumeric.Location = new System.Drawing.Point(259, 54);
            this.inpackNumeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inpackNumeric.Name = "inpackNumeric";
            this.inpackNumeric.Size = new System.Drawing.Size(151, 36);
            this.inpackNumeric.TabIndex = 24;
            // 
            // inskladNumeric
            // 
            this.inskladNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inskladNumeric.Location = new System.Drawing.Point(258, 151);
            this.inskladNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.inskladNumeric.Name = "inskladNumeric";
            this.inskladNumeric.Size = new System.Drawing.Size(151, 36);
            this.inskladNumeric.TabIndex = 25;
            this.inskladNumeric.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // minNumeric
            // 
            this.minNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minNumeric.Location = new System.Drawing.Point(259, 204);
            this.minNumeric.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(151, 36);
            this.minNumeric.TabIndex = 26;
            // 
            // priceNumeric
            // 
            this.priceNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceNumeric.Location = new System.Drawing.Point(259, 365);
            this.priceNumeric.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(151, 36);
            this.priceNumeric.TabIndex = 27;
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 598);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.minNumeric);
            this.Controls.Add(this.inskladNumeric);
            this.Controls.Add(this.inpackNumeric);
            this.Controls.Add(this.unitCmb);
            this.Controls.Add(this.typeMaterialCmb);
            this.Controls.Add(this.imageTxt);
            this.Controls.Add(this.pointsPtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditForm";
            this.Load += new System.EventHandler(this.AddOrEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inpackNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inskladNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox nameTxt;
        private TextBox descriptionTxt;
        private Button saveBtn;
        private Button backBtn;
        private Button pointsPtn;
        private TextBox imageTxt;
        private ComboBox typeMaterialCmb;
        private ComboBox unitCmb;
        private NumericUpDown inpackNumeric;
        private NumericUpDown inskladNumeric;
        private NumericUpDown minNumeric;
        private NumericUpDown priceNumeric;
    }
}