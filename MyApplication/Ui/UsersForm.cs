using Application.IServices;
using Application.ViewModels.UserViewModels;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Ui;
using System.Resources;

namespace MyApplication
{
    public partial class UsersForm : Usf.WinForms.Forms.Form
    {
        private readonly IUserService _userService;

        public UsersForm(IUserService userService)
        {
            _userService = userService;

            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            UserNewButton.Text =
                resource.GetString(name: nameof(UserNewButton));

            UserEditButton.Text =
                resource.GetString(name: nameof(UserEditButton));

            UserDeleteButton.Text =
                resource.GetString(name: nameof(UserDeleteButton));

            UserGridView.Columns[1].Caption =
                resource.GetString(name: nameof(FirstName));

            UserGridView.Columns[2].Caption =
                resource.GetString(name: nameof(LastName));

            UserGridView.Columns[3].Caption =
                resource.GetString(name: nameof(colPhoneNumber));

            UserGridView.Columns[4].Caption =
                resource.GetString(name: nameof(Username));

            UserGridView.Columns[5].Caption =
                resource.GetString(name: nameof(Role));

            UserGridView.Columns[6].Caption =
               resource.GetString(name: nameof(Status));

            UserGridView.Columns[7].Caption =
                resource.GetString(name: nameof(Birthdate));

            UserGridView.Columns[8].Caption =
                resource.GetString(name: nameof(Email));

            UserGridView.Columns[9].Caption =
                resource.GetString(name: nameof(Address));

            UserGridView.Columns[10].Caption =
                resource.GetString(name: nameof(Description));

            this.Text =
                resource.GetString(name: nameof(UsersForm));

            #endregion / Language

        }

        // Loaded
        private async void UsersForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;

                this.RightToLeftLayout = true;
            }

            RefreshFormAsync();
        }

        // Refresh
        private async void RefreshFormAsync()
        {
            var usersUF = await _userService.GetUsersAsync(CancellationToken.None);

            UserGridControl.DataSource = usersUF.ToList();

        }

        // Add
        private void UserNewButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<UsersAddOrEditForm>();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }

        // Edit
        private void UserEditButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<UsersAddOrEditForm>();

                var CurrentID = (Guid)UserGridView.GetRowCellValue(UserGridView.FocusedRowHandle, colId);

                form.UserIdForm = CurrentID;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }

        // Delete
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var CurrentID = (Guid)UserGridView.GetRowCellValue(UserGridView.FocusedRowHandle, colId);
                string FName = (string)UserGridView.GetRowCellValue(UserGridView.FocusedRowHandle, colFirstName);
                string LName = (string)UserGridView.GetRowCellValue(UserGridView.FocusedRowHandle, colLastName);
                var FullName = FName + " " + LName;

                UserVMId userVMCU = new()
                {
                    Id = CurrentID,
                };

                if (MessageBox.Show($"آیا {FullName} حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    await _userService.DeleteUserAsync(userVMCU, CancellationToken.None);

                    RefreshFormAsync();
                }
            }
        }
    }
}