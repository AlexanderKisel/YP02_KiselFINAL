namespace YP02_Kisel.Forms
{
    partial class RaschetForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.raschBtn = new System.Windows.Forms.Button();
            this.typeMaterialCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.typeProductCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlinaNumeric = new System.Windows.Forms.NumericUpDown();
            this.shirinaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kolvoNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kolvo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dlinaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirinaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(243, 389);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(137, 53);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // raschBtn
            // 
            this.raschBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.raschBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raschBtn.Location = new System.Drawing.Point(12, 389);
            this.raschBtn.Name = "raschBtn";
            this.raschBtn.Size = new System.Drawing.Size(137, 53);
            this.raschBtn.TabIndex = 15;
            this.raschBtn.Text = "Рассчитать";
            this.raschBtn.UseVisualStyleBackColor = false;
            this.raschBtn.Click += new System.EventHandler(this.raschBtn_Click);
            // 
            // typeMaterialCmb
            // 
            this.typeMaterialCmb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeMaterialCmb.FormattingEnabled = true;
            this.typeMaterialCmb.Location = new System.Drawing.Point(243, 24);
            this.typeMaterialCmb.Name = "typeMaterialCmb";
            this.typeMaterialCmb.Size = new System.Drawing.Size(121, 36);
            this.typeMaterialCmb.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(23, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "Тип материала:";
            // 
            // typeProductCmb
            // 
            this.typeProductCmb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeProductCmb.FormattingEnabled = true;
            this.typeProductCmb.Location = new System.Drawing.Point(243, 92);
            this.typeProductCmb.Name = "typeProductCmb";
            this.typeProductCmb.Size = new System.Drawing.Size(121, 36);
            this.typeProductCmb.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Тип продукта:";
            // 
            // dlinaNumeric
            // 
            this.dlinaNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dlinaNumeric.Location = new System.Drawing.Point(243, 194);
            this.dlinaNumeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.dlinaNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dlinaNumeric.Name = "dlinaNumeric";
            this.dlinaNumeric.Size = new System.Drawing.Size(151, 36);
            this.dlinaNumeric.TabIndex = 28;
            this.dlinaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shirinaNumeric
            // 
            this.shirinaNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shirinaNumeric.Location = new System.Drawing.Point(243, 236);
            this.shirinaNumeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.shirinaNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shirinaNumeric.Name = "shirinaNumeric";
            this.shirinaNumeric.Size = new System.Drawing.Size(151, 36);
            this.shirinaNumeric.TabIndex = 29;
            this.shirinaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Длина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(120, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ширина:";
            // 
            // kolvoNumeric
            // 
            this.kolvoNumeric.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kolvoNumeric.Location = new System.Drawing.Point(243, 152);
            this.kolvoNumeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.kolvoNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kolvoNumeric.Name = "kolvoNumeric";
            this.kolvoNumeric.Size = new System.Drawing.Size(151, 36);
            this.kolvoNumeric.TabIndex = 32;
            this.kolvoNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 33);
            this.label4.TabIndex = 33;
            this.label4.Text = "Кол-во продукта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Для создания продукта нужно: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(211, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 33);
            this.label6.TabIndex = 35;
            this.label6.Text = "сырья";
            // 
            // kolvo
            // 
            this.kolvo.AutoSize = true;
            this.kolvo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kolvo.Location = new System.Drawing.Point(120, 341);
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(0, 33);
            this.kolvo.TabIndex = 36;
            // 
            // RaschetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 467);
            this.Controls.Add(this.kolvo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kolvoNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shirinaNumeric);
            this.Controls.Add(this.dlinaNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeProductCmb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.typeMaterialCmb);
            this.Controls.Add(this.raschBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "RaschetForm";
            this.Text = "Расчет";
            ((System.ComponentModel.ISupportInitialize)(this.dlinaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirinaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private Button raschBtn;
        private ComboBox typeMaterialCmb;
        private Label label9;
        private ComboBox typeProductCmb;
        private Label label1;
        private NumericUpDown dlinaNumeric;
        private NumericUpDown shirinaNumeric;
        private Label label2;
        private Label label3;
        private NumericUpDown kolvoNumeric;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label kolvo;
    }
}