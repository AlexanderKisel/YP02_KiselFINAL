using YP02_Kisel.Models;

namespace YP02_Kisel.Forms
{
    public partial class AutorizationForm : Form
    {
        Autorization db = new Autorization();
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterAdd_Click(object sender, EventArgs e)
        {
            var login = LoginTxt.Text;
            var password = PasswordTxt.Text;

            using (Kisel_var_5Context context = new Kisel_var_5Context())
            {
                var user = context.Autorizations.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null)
                {
                    ForAutoriz.FIO = user.Fio;
                    ForAutoriz.Role = user.Role;
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pswdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pswdCheckBox.Checked == true)
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }else
            {
                PasswordTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
