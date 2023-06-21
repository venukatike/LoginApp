using LoginApp.Model;

namespace LoginApp.Validators.Interface
{
    public interface IUserValidations
    {
        bool ValidateUserLogin(LoginModel model);
    }
}