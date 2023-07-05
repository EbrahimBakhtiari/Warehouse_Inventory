using Application.ViewModels.UserViewModels;

namespace Application.IServices
{
    public interface IUserCommandService
    {
        Task CreateUserAsync(UserVMCU userVM, CancellationToken cancellationToken);
        Task UpdateUserAsync(UserVMCU userVM, CancellationToken cancellationToken);
    }
}
