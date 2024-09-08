using System.Diagnostics;
using ToDoApp.BAL.UserServices;
using ToDoApp.DAL.AppDBContext;
using ToDoApp.UI.AppForm;
using ToDoApp.UI.RegisterForms;

namespace ToDoApp
{
    public partial class Login : Form
    {
        private readonly UserServices _userServices;

        public Login()
        {
            InitializeComponent();
            AppDbContext dbContext = new AppDbContext();
            _userServices = new UserServices(dbContext);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUserName.Text;
                var password = txtUserPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Lütfen kullanýcý adý veya þifre giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = _userServices.AuthenticateUser(username, password);
                if (user != null)
                {
                    ToDoAppForm mainForm = new ToDoAppForm(user.UserID);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklblForgetMyPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Týklanan baðlantý açýlamýyor.");
            }
        }

        private void VisitLink()
        {
            try
            {
                lnkIForgetMyPassword.LinkVisited = true;

                string mailto = "mailto:muhammed.kilic8@outlook.com";

                var psi = new ProcessStartInfo
                {
                    FileName = mailto,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Týklanan baðlantý açýlamýyor: " + ex.Message);
            }
        }

        private void cbShowMyPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowMyPassword.Checked)
                txtUserPassword.PasswordChar = default;
            else
                txtUserPassword.PasswordChar = '*';
        }
    }
}
