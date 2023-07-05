using Application.ViewModels.UserViewModels;
using FluentValidation.Results;

namespace Application.IServices
{
    public interface IUserVMValidator
    {
        ValidationResult Validate(UserVMCU userVM);
    }

}
