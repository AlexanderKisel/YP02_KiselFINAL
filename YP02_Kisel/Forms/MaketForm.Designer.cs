namespace YP02_Kisel.Forms
{
    partial class MaketForm
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
            this.materialFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialFLP
            // 
            this.materialFLP.AutoScroll = true;
            this.materialFLP.Location = new System.Drawing.Point(12, 12);
            this.materialFLP.Name = "materialFLP";
            this.materialFLP.Size = new System.Drawing.Size(776, 365);
            this.materialFLP.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(12, 385);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(137, 53);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MaketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.materialFLP);
            this.Name = "MaketForm";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.MaketForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel materialFLP;
        private Button backBtn;
    }
}