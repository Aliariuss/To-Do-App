using ToDoApp.BAL.UserServices;
using ToDoApp.DAL.AppDBContext;
using ToDoApp.Domain;

namespace ToDoApp.UI.RegisterForms
{
    public partial class Register : Form
    {
        private readonly UserServices _userServices;
        private readonly AppDbContext _context;

        public Register()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _userServices = new UserServices(_context);
        }
        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRegisterAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User
                {
                    UserName = txtRegisterUserName.Text,
                    Password = txtRegisterPassword.Text,
                    Email = txtRegisterEmail.Text,
                    Phone = txtRegisterPhone.Text,
                    GenderID = rbtnMan.Checked ? 1 : 2
                };

                UserDetail userDetail = new UserDetail
                {
                    FirstName = txtRegisterName.Text,
                    LastName = txtRegisterLastName.Text,
                    BirthDate = dtRegisterBirthdate.Value
                };

                Address address = new Address
                {
                    City = txtRegisterCity.Text,
                    Country = txtRegisterCountry.Text,
                    PostalCode = txtRegisterPostalCode.Text,
                    Region = ""
                };

                _userServices.AddUser(user, userDetail, address);
                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
