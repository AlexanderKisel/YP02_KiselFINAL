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

namespace YP02_Kisel.Forms
{
    public partial class MaketForm : Form
    {
        public MaketForm()
        {
            InitializeComponent();
        }

        private void MaketForm_Load(object sender, EventArgs e)
        {
            using(Kisel_var_5Context db = new Kisel_var_5Context())
            {
                var materials = db.Materials.ToList();
                foreach (var material in materials)
                {
                    var userControl = new SpisokUserControl(material);
                    userControl.Parent = materialFLP;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
