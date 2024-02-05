using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using YP02_Kisel.Forms;
using YP02_Kisel.Models;
using Mydl;

namespace YP02_Kisel
{
    public partial class MaterialsForm : Form
    {
        List<Int32> materialTypeIds = new List<Int32>();
        DataTable dataTable = new DataTable();
        public MaterialsForm()
        {
            InitializeComponent();
            if (UserLbl.Text == "Пользователь не авторизован")
            {
                ExitLbl.Visible = false;
            }
            else
            {
                ExitLbl.Visible = true;
            }
            materialDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materialDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Название");
            dataTable.Columns.Add("Количество в упаковке");
            dataTable.Columns.Add("Единица измерения");
            dataTable.Columns.Add("Количество на складе");
            dataTable.Columns.Add("Минимальное количество");
            dataTable.Columns.Add("Описание");
            dataTable.Columns.Add("Цена");
            dataTable.Columns.Add("Изображение");
            dataTable.Columns.Add("Тип материала");
            UpdateDgv();
        }

        private void UpdateDgv()
        {
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                var materials = db.Materials
                    .Include(x => x.MaterialType)
                    .ToList();
                dataTable.Clear();
                foreach (var material in materials)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = material.Id;
                    row["Название"] = material.Title;
                    row["Количество в упаковке"] = material.CountInPack;
                    row["Единица измерения"] = material.Unit;
                    row["Количество на складе"] = material.CountInStock;
                    row["Минимальное количество"] = material.MinCount;
                    row["Описание"] = material.Description;
                    row["Цена"] = material.Cost;
                    row["Изображение"] = material.Image;
                    row["Тип материала"] = $"{material.MaterialType.Title}";
                    dataTable.Rows.Add(row);
                }

                materialDgv.DataSource = dataTable;
                materialDgv.Columns[0].Visible = false;
                materialTypeIds = db.MaterialTypes.Select(x => x.Id).ToList();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrEditForm addOrEditForm = new AddOrEditForm();
            addOrEditForm.Closed += formClosed;
            Hide();
            addOrEditForm.Show();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                var id = Int32.Parse(materialDgv.Rows[materialDgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                var selected = db.Materials.FirstOrDefault(x => x.Id== id);
                if (selected != null)
                {
                    db.Materials.Remove(selected);
                    db.SaveChanges();
                    UpdateDgv();
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                var id = Int32.Parse(materialDgv.Rows[materialDgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                var selected = db.Materials.FirstOrDefault(x => x.Id == id);
                var edit = true;
                if(selected != null)
                {
                    ForEdit.Id = selected.Id;
                    ForEdit.Title = selected.Title;
                    ForEdit.CountInPack = selected.CountInPack;
                    ForEdit.Unit = selected.Unit;
                    ForEdit.CountInStock = selected.CountInStock;
                    ForEdit.MinCount = selected.MinCount;
                    ForEdit.Description= selected.Description;
                    ForEdit.Cost = selected.Cost;
                    ForEdit.Image = selected.Image;
                    ForEdit.MaterialTypeId = selected.MaterialTypeId;   
                    AddOrEditForm addOrEditForm = new AddOrEditForm(edit);
                    addOrEditForm.Closed += formClosed;
                    Hide();
                    addOrEditForm.Show();
                }
            }
        }

        private void AutorithashionBtn_Click(object sender, EventArgs e)
        {
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Closed += formClosed;
            Hide();
            autorizationForm.Show();
        }

        private void formClosed(object sender, EventArgs e)
        {
            Show();
            UpdateDgv();
            UserLbl.Text = ForAutoriz.Role.ToString();
            if (UserLbl.Text == "Пользователь не авторизован")
            {
                ExitLbl.Visible = false;
            }
            else if (UserLbl.Text == "User")
            {
                ExitLbl.Visible = true;
                AddBtn.Enabled = false;
                EditBtn.Enabled = false;
                DelBtn.Enabled = false;
                AutorithashionBtn.Enabled = false;
            }
            else
            {
                ExitLbl.Visible = true;
                AddBtn.Enabled = true;
                EditBtn.Enabled = true;
                DelBtn.Enabled = true;
                AutorithashionBtn.Enabled = false;
            }
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            UserLbl.Text = "Пользователь не авторизован";
            AddBtn.Enabled = false;
            EditBtn.Enabled = false;
            DelBtn.Enabled = false;
            AutorithashionBtn.Enabled = true;
        }

        private void ExitLbl_MouseEnter(object sender, EventArgs e)
        {
            string colorcode = "#EAB14D";
            int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
            ExitLbl.ForeColor = Color.FromArgb(argb);
        }

        private void ExitLbl_MouseLeave(object sender, EventArgs e)
        {
            ExitLbl.ForeColor = Color.Black;
        }

        private void AddBtn_MouseLeave(object sender, EventArgs e)
        {
            AddBtn.BackColor = Color.FromArgb(254, 169, 171);
        }

        private void DelBtn_MouseLeave(object sender, EventArgs e)
        {
            DelBtn.BackColor = Color.FromArgb(254, 169, 171);
        }

        private void EditBtn_MouseLeave(object sender, EventArgs e)
        {
            EditBtn.BackColor = Color.FromArgb(254, 169, 171);
        }

        private void AutorithashionBtn_MouseLeave(object sender, EventArgs e)
        {
            AutorithashionBtn.BackColor = Color.FromArgb(254, 169, 171);
        }

        private void AddBtn_MouseEnter(object sender, EventArgs e)
        {
            AddBtn.BackColor = Color.FromArgb(234, 177, 77);
        }

        private void DelBtn_MouseEnter(object sender, EventArgs e)
        {
            DelBtn.BackColor = Color.FromArgb(234, 177, 77);
        }

        private void EditBtn_MouseEnter(object sender, EventArgs e)
        {
            EditBtn.BackColor = Color.FromArgb(234, 177, 77);
        }

        private void AutorithashionBtn_MouseEnter(object sender, EventArgs e)
        {
            AutorithashionBtn.BackColor = Color.FromArgb(234, 177, 77);
        }

        private void sbrosBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
            vRadioButton.Checked = false;
            ybRadioButton.Checked = false;
        }

        private void filterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterCmb.SelectedIndex)
            {
                case 0: 
                    UpdateDgv();
                    break;
                case 1: filter(); break;
                case 2: filter(); break;
                case 3: filter(); break;
                case 4: filter(); break;
            }
        }

        void filter()
        {
            using (Kisel_var_5Context db = new Kisel_var_5Context())
            {
                    var materials = db.Materials
                        .Include(x => x.MaterialType)
                        .ToList();
                    dataTable.Clear();
                    foreach (var material in materials)
                    {
                        if (filterCmb.SelectedItem.ToString() == material.MaterialType.Title.ToString())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Id"] = material.Id;
                            row["Название"] = material.Title;
                            row["Количество в упаковке"] = material.CountInPack;
                            row["Единица измерения"] = material.Unit;
                            row["Количество на складе"] = material.CountInStock;
                            row["Минимальное количество"] = material.MinCount;
                            row["Описание"] = material.Description;
                            row["Цена"] = material.Cost;
                            row["Изображение"] = material.Image;
                            row["Тип материала"] = $"{material.MaterialType.Title}";
                            dataTable.Rows.Add(row);
                        }
                    }
                materialTypeIds = db.MaterialTypes.Select(x => x.Id).ToList();
                materialDgv.DataSource = dataTable;
                materialDgv.Columns[0].Visible = false;
            }
        }

        private void ybRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ybRadioButton.Checked == true)
            {
                switch (sortCmb.SelectedIndex)
                {
                    case 0:
                        materialDgv.Sort(materialDgv.Columns[1], System.ComponentModel.ListSortDirection.Descending);
                        break;
                    case 1:
                        materialDgv.Sort(materialDgv.Columns[4], System.ComponentModel.ListSortDirection.Descending);
                        break;
                    case 2:
                        materialDgv.Sort(materialDgv.Columns[7], System.ComponentModel.ListSortDirection.Descending);
                        break;
                }
            }
        }

        private void vRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (vRadioButton.Checked == true)
            {
                switch (sortCmb.SelectedIndex)
                {
                    case 0:
                        materialDgv.Sort(materialDgv.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                        break;
                    case 1:
                        materialDgv.Sort(materialDgv.Columns[4], System.ComponentModel.ListSortDirection.Ascending);
                        break;
                    case 2:
                        materialDgv.Sort(materialDgv.Columns[7], System.ComponentModel.ListSortDirection.Ascending);
                        break;
                }
            }
        }

        private void sortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortCmb.SelectedIndex == 3)
            {
                UpdateDgv();
                vRadioButton.Checked = false;
                ybRadioButton.Checked = false;
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            materialDgv.ClearSelection();
            for (int i = 0; i < materialDgv.RowCount; i++)
            {
                for (int j = 0; j < materialDgv.ColumnCount; j++)
                {
                    if (materialDgv.Rows[i].Cells[j].Value.ToString().Contains(searchTxt.Text))
                    {
                        materialDgv.Rows[i].Selected = true;
                        materialDgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                }
            }
        }

        private void spisokBtn_Click(object sender, EventArgs e)
        {
            MaketForm maketForm = new MaketForm();
            maketForm.Closed += formClosed;
            Hide();
            maketForm.Show();
        }
    }
}