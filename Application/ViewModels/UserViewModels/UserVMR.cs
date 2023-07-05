namespace Application.ViewModels.UserViewModels
{
    public class UserVMR
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
