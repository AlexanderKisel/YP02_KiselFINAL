using System.Data;
using YP02_Kisel.Models;
using Mydl;

namespace YP02_Kisel.Forms
{
    public partial class AddOrEditForm : Form
    {
        List<Int32> materialTypeIds = new List<Int32>();


        OpenFileDialog openFileDialog = new OpenFileDialog();
        public AddOrEditForm()
        {
            InitializeComponent();
            this.Text = "Добавление";
            openFileDialog.Filter = "Файлы изображений(*.jpg, *.png,*.jpeg)|*.jpg; *.png;*.jpeg";
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                typeMaterialCmb.DataSource = db.MaterialTypes.Select(x => x.Title).ToList();
                materialTypeIds = db.MaterialTypes.Select(x => x.Id).ToList();
            }
        }
        public AddOrEditForm(bool edit)
        {
            InitializeComponent();
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                typeMaterialCmb.DataSource = db.MaterialTypes.Select(x => x.Title).ToList();
                materialTypeIds = db.MaterialTypes.Select(x => x.Id).ToList();
            }
            this.Text = "Редактирование";
            if (ForEdit.Id != null)
            {
                nameTxt.Text = ForEdit.Title.ToString();
                inpackNumeric.Value = ForEdit.CountInPack;
                unitCmb.SelectedItem = ForEdit.Unit.ToString();
                inskladNumeric.Value = decimal.Parse(ForEdit.CountInStock.ToString());
                minNumeric.Value = decimal.Parse(ForEdit.MinCount.ToString());
                descriptionTxt.Text = ForEdit.Description.ToString();
                priceNumeric.Value = decimal.Parse(ForEdit.Cost.ToString());
                imageTxt.Text = ForEdit.Image;
                typeMaterialCmb.SelectedIndex = ForEdit.MaterialTypeId - 1;
            }
            openFileDialog.Filter = "Файлы изображений(*.jpg, *.png,*.jpeg)|*.jpg; *.png;*.jpeg";

            return;
        }
        private void pointsPtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect= true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] forcheck = Directory.GetFiles($"X:\\УП.02_Кисель\\Picture\\materials");
                string check = openFileDialog.FileName;
                for (int i = 0; i <= forcheck.Length; i++)
                {
                    if (check == forcheck[i])
                    {
                        imageTxt.Text = Path.GetFileName(openFileDialog.FileName);
                    }
                    else
                    {
                        string dir = @"X:\УП.02_Кисель\Picture\materials";
                        string[] files = openFileDialog.FileNames;
                        FileInfo fi = new FileInfo(openFileDialog.FileName);
                        string dirSource = fi.DirectoryName;
                        foreach (String file in files)
                        {
                            string fname = file.Substring(dirSource.Length + 1);
                            System.IO.File.Copy(Path.Combine(dirSource, fname), Path.Combine(dir, fname), true);
                        }
                        imageTxt.Text = Path.GetFileName(openFileDialog.FileName);
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(this.Text == "Редактирование" && nameTxt.Text != null && unitCmb.SelectedIndex.ToString() != null && priceNumeric.Value.ToString() != "0")
            {
                using (Kisel_var_5Context db = new Kisel_var_5Context())
                {
                    Material? material = db.Materials.FirstOrDefault(x => x.Id == ForEdit.Id);
                    if (material != null)
                    {
                        material.Title = nameTxt.Text;
                        material.CountInPack = int.Parse(inpackNumeric.Text);
                        material.Unit = unitCmb.Text;
                        material.CountInStock = double.Parse(inskladNumeric.Text);
                        material.MinCount = double.Parse(minNumeric.Text);
                        material.Description = descriptionTxt.Text;
                        material.Cost = decimal.Parse(priceNumeric.Text);
                        if (imageTxt.Text != null)
                        {
                            material.Image = $"\\materials\\{imageTxt.Text}";
                        }else if(imageTxt.Text == null)
                        {
                            material.Image = $"X:\\УП.02_Кисель\\Picture\\materials\\picture.png";
                        }
                        material.MaterialTypeId = materialTypeIds[typeMaterialCmb.SelectedIndex];

                        db.Materials.Update(material);
                        db.SaveChanges();
                        MessageBox.Show("Запись сохранена в БД!", "Информация", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                    }
                }
            }
            else
            if (this.Text == "Добавление" && nameTxt.Text != null && unitCmb.SelectedIndex.ToString() != null && priceNumeric.Value.ToString() != "0")
            {
                var newMaterial = new Material();
                newMaterial.Title = nameTxt.Text;
                newMaterial.CountInPack = int.Parse(inpackNumeric.Text);
                newMaterial.Unit = unitCmb.Text;
                newMaterial.CountInStock = double.Parse(inskladNumeric.Text);
                newMaterial.MinCount = double.Parse(minNumeric.Text);
                newMaterial.Description = descriptionTxt.Text;
                newMaterial.Cost = decimal.Parse(priceNumeric.Text);
                if (imageTxt.Text != null)
                {
                    newMaterial.Image = $"\\materials\\{imageTxt.Text}";
                }
                else
                {
                    newMaterial.Image = $"X:\\УП.02_Кисель\\Picture\\materials\\picture.png";
                }
                newMaterial.MaterialTypeId = materialTypeIds[typeMaterialCmb.SelectedIndex];
                using (Kisel_var_5Context db = new Kisel_var_5Context())
                {
                    db.Materials.Add(newMaterial);
                    db.SaveChanges();
                    MessageBox.Show("Запись сохранена в БД!", "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Некоторые поля не заполнены или неверно введены!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddOrEditForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
