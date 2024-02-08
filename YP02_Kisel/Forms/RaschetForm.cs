using System.Data;
using YP02_Kisel.Models;
using Mydl;


namespace YP02_Kisel.Forms
{
    public partial class RaschetForm : Form
    {

        List<Int32> materialTypeIds = new List<Int32>();
        public RaschetForm()
        {
            InitializeComponent();
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                typeMaterialCmb.DataSource = db.MaterialTypes.Select(x => x.Title).ToList();
                typeProductCmb.DataSource = db.ProductTypes.Select(x => x.Title).ToList();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void raschBtn_Click(object sender, EventArgs e)
        {
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                var typeMaterial = db.MaterialTypes.Where(x => x.Title == typeMaterialCmb.Text).Select(x => x.DefectedPercent).ToList()[0];
                var typeProduct = db.ProductTypes.Where(x => x.Title == typeProductCmb.Text).Select(x => x.DefectedPercent).ToList()[0];

                kolvo.Text = ForRasch.Raschet(double.Parse(typeMaterial.ToString()), double.Parse(typeProduct.ToString()), kolvoNumeric.Value, dlinaNumeric.Value, shirinaNumeric.Value).ToString();
            }
        }
    }
}
