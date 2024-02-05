using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YP02_Kisel.Models;

namespace YP02_Kisel
{
    public partial class SpisokUserControl : UserControl
    {
        public SpisokUserControl(Material material)
        {
            InitializeComponent();
            InitOrder(material);
        }

        private void InitOrder(Material material)
        {
            titleTxt.Text = material.Title;
            descriptionTxt.Text = material.Description;
            inPackTxt.Text = material.CountInPack.ToString();
            inSkladTxt.Text = material.CountInStock.ToString();
            priceTxt.Text = material.Cost.ToString();
            if(material.Image.ToString() != "")
            {
                pictureBox1.Image = Image.FromFile($"X:\\УП.02_Кисель\\Picture\\{material.Image}");
            }
            else
            {
                pictureBox1.Image = Image.FromFile($"X:\\УП.02_Кисель\\Picture\\materials\\picture.png"); ;
            }
        }

        private void SpisokUserControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
