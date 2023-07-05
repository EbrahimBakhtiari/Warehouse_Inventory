using Application.IServices;
using Application.ViewModels.UserViewModels;
using MyApplication;
using System.Resources;

namespace MyApp.Ui
{
    public partial class UsersAddOrEditForm : Usf.WinForms.Forms.Form
    {
        private readonly IUserService _userService;

        private readonly IUserVMValidator _userVMValidator;

        public Guid UserIdForm { get; set; } = Guid.Empty;

        // Constractor
        public UsersAddOrEditForm(IUserService userService, IUserVMValidator userVMValidator)
        {
            InitializeComponent();

            _userService = userService;

            _userVMValidator = userVMValidator;

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            FirstNameLabelControl.Text =
                resource.GetString(name: nameof(FirstNameLabelControl));

            LastNameLabelControl.Text =
                resource.GetString(name: nameof(LastNameLabelControl));

            PhoneLabelControl.Text =
                resource.GetString(name: nameof(PhoneLabelControl));

            UsernameLabelControl.Text =
                resource.GetString(name: nameof(UsernameLabelControl));

            PasswordLabelControl.Text =
                resource.GetString(name: nameof(PasswordLabelControl));

            RoleLabelControl.Text =
                resource.GetString(name: nameof(RoleLabelControl));

            EmailLabelControl.Text =
                resource.GetString(name: nameof(EmailLabelControl));

            BirthdateLabelControl.Text =
                resource.GetString(name: nameof(BirthdateLabelControl));

            AddressLabelControl.Text =
                resource.GetString(name: nameof(AddressLabelControl));

            DescriptionLabelControl.Text =
                resource.GetString(name: nameof(DescriptionLabelControl));

            ActiveCheckEdit.Text =
                resource.GetString(name: nameof(ActiveCheckEdit));

            SaveButton.Text =
                resource.GetString(name: nameof(SaveButton));

            this.Text = resource.GetString(name: nameof(UsersAddOrEditForm));
            _userVMValidator = userVMValidator;

            #endregion / Language
        }

        // Loaded
        private async void UsersAddOrEditForm_Load(object sender, EventArgs e)
        {
            FirstNameTextEdit.Focus();

            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;

                this.RightToLeftLayout = true;
            }

            if (UserIdForm != Guid.Empty)
            {
                var user = new UserVMId
                {
                    Id = UserIdForm
                };
                var userVM = await _userService.GetUserByIdAsync(user, CancellationToken.None);
                FirstNameTextEdit.Text = userVM.FirstName;
                LastNameTextEdit.Text = userVM.LastName;
                PhoneTextEdit.Text = userVM.PhoneNumber;
                UsernameTextEdit.Text = userVM.Username;
                RoleComboBoxEdit.Text = userVM.Role;
                EmailTextEdit.Text = userVM.Email;
                BirthdateTextEdit.Text = userVM.Birthdate.ToString();
                AddressTextEdit.Text = userVM.Address;
                DescriptionTextEdit.Text = userVM.Description;
            }
        }

        // Save
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var userVM = new Application.ViewModels.UserViewModels.UserVMCU
            {
                Id = UserIdForm != Guid.Empty ? UserIdForm : Guid.NewGuid(),
                FirstName = FirstNameTextEdit.Text,
                LastName = LastNameTextEdit.Text,
                PhoneNumber = PhoneTextEdit.Text,
                Username = UsernameTextEdit.Text,
                Password = PasswordTextEdit.Text,
                Role = RoleComboBoxEdit.Text,
                Birthdate = Convert.ToDateTime(BirthdateTextEdit.Text),
                Email = EmailTextEdit.Text,
                Address = AddressTextEdit.Text,
                Description = DescriptionTextEdit.Text,
                IsActive = ActiveCheckEdit.Checked,
                UsernameId = Program.usernameid,
            };

            var validationResult = _userVMValidator.Validate(userVM);

            if (validationResult.IsValid)
            {
                if (UserIdForm != Guid.Empty)
                {
                    // Update
                    await _userService.UpdateUserAsync(userVM, CancellationToken.None);
                }
                else
                {
                    if (await _userService.IsUsernameExistsAsync(userVM.Username, CancellationToken.None) && UserIdForm == Guid.Empty)
                    {
                        MessageBox.Show("Username is already exists");
                    }
                    // Insert
                    await _userService.CreateUserAsync(userVM, CancellationToken.None);
                }

                DialogResult = DialogResult.OK;

                MessageBox.Show("عملیات با موفقیت انجام شد");

            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    MessageBox.Show($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                }
            }
        }
    }
}
