namespace YP02_Kisel
{
    partial class SpisokUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleTxt = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.Label();
            this.inPackTxt = new System.Windows.Forms.Label();
            this.inSkladTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleTxt.Location = new System.Drawing.Point(157, 11);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(71, 28);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "titleTxt";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.AutoSize = true;
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTxt.Location = new System.Drawing.Point(157, 39);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(128, 28);
            this.descriptionTxt.TabIndex = 2;
            this.descriptionTxt.Text = "descriptionTxt";
            // 
            // priceTxt
            // 
            this.priceTxt.AutoSize = true;
            this.priceTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceTxt.Location = new System.Drawing.Point(157, 67);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(78, 28);
            this.priceTxt.TabIndex = 3;
            this.priceTxt.Text = "priceTxt";
            // 
            // inPackTxt
            // 
            this.inPackTxt.AutoSize = true;
            this.inPackTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inPackTxt.Location = new System.Drawing.Point(157, 95);
            this.inPackTxt.Name = "inPackTxt";
            this.inPackTxt.Size = new System.Drawing.Size(92, 28);
            this.inPackTxt.TabIndex = 4;
            this.inPackTxt.Text = "inPackTxt";
            // 
            // inSkladTxt
            // 
            this.inSkladTxt.AutoSize = true;
            this.inSkladTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inSkladTxt.Location = new System.Drawing.Point(393, 49);
            this.inSkladTxt.Name = "inSkladTxt";
            this.inSkladTxt.Size = new System.Drawing.Size(99, 28);
            this.inSkladTxt.TabIndex = 5;
            this.inSkladTxt.Text = "inSkladTxt";
            // 
            // SpisokUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inSkladTxt);
            this.Controls.Add(this.inPackTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SpisokUserControl";
            this.Size = new System.Drawing.Size(505, 138);
            this.Load += new System.EventHandler(this.SpisokUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label titleTxt;
        private Label descriptionTxt;
        private Label priceTxt;
        private Label inPackTxt;
        private Label inSkladTxt;
    }
}
