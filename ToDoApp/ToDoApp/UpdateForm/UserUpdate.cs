using ToDoApp.DAL.AppDBContext;
using ToDoApp.Domain;
using ToDoApp.BAL.UserServices;


namespace ToDoApp.UI.RegisterForms
{
    public partial class UserUpdate : Form
    {
        private readonly int _userId;
        private readonly UserServices _userServices;
        private User _user;
        public UserUpdate(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _userServices = new UserServices(new AppDbContext());
            LoadUserDetails();
        }
        private void LoadUserDetails()
        {
            _user = _userServices.GetUserById(_userId);

            if (_user != null)
            {
                txtUpdateUserName.Text = _user.UserName;
                txtUpdatePassword.Text = _user.Password;
                txtUpdateName.Text = _user.UserDetail?.FirstName ?? string.Empty;
                txtUpdateLastName.Text = _user.UserDetail?.LastName ?? string.Empty;

                if (_user.GenderID == 1)
                {
                    rbtnUpdateMan.Checked = true;
                }
                else if (_user.GenderID == 2)
                {
                    rbtnUpdateWomen.Checked = true;
                }

                dtUpdateBirthdate.Value = _user.UserDetail?.BirthDate ?? DateTime.Now;
                txtUpdateEmail.Text = _user.Email;
                txtUpdatePhone.Text = _user.Phone;

                var address = _user.UserDetail?.Addresses?.FirstOrDefault();
                if (address != null)
                {
                    txtUpdateCountry.Text = address.Country;
                    txtUpdateCity.Text = address.City;
                    txtUpdatePostalCode.Text = address.PostalCode;
                }
            }
        }
        private void btnRegisterUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _user.UserName = txtUpdateUserName.Text;
                _user.Password = txtUpdatePassword.Text;
                _user.Email = txtUpdateEmail.Text;
                _user.Phone = txtUpdatePhone.Text;
                _user.GenderID = rbtnUpdateMan.Checked ? 1 : 2;

                if (_user.UserDetail != null)
                {
                    _user.UserDetail.FirstName = txtUpdateName.Text;
                    _user.UserDetail.LastName = txtUpdateLastName.Text;
                    _user.UserDetail.BirthDate = dtUpdateBirthdate.Value;

                    var address = _user.UserDetail.Addresses.FirstOrDefault();
                    if (address != null)
                    {
                        address.Country = txtUpdateCountry.Text;
                        address.City = txtUpdateCity.Text;
                        address.PostalCode = txtUpdatePostalCode.Text;
                    }
                }

                _userServices.UpdateUser(_user);

                MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegisterUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
