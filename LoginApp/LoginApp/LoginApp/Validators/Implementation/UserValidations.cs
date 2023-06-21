using System;
using System.Collections.Generic;
using System.Text;
using LoginApp.Extensions;
using LoginApp.Model;
using LoginApp.Validators.Interface;
using LoginApp.ViewModel;

namespace LoginApp.Validators.Implementation
{
    public class UserValidations : IUserValidations
    {
        public bool ValidateUserLogin(LoginModel model)
        {
            if (model.UserName.IsEmpty())
            {
                model.IsUserNameErrorMessageVisible = true;
                model.UserNameErrorMsg = ResourceFile.UserNameEmptyErrMsgText;
            }
            else if (model.Password.IsEmpty())
            {
                model.IsPasswordErrorMessageVisible = true;
                model.PasswordErrorMsg = ResourceFile.PasswordEmptyErrMsgText;
            }
            else
            {
                return true;
            }

            return default;
        }
    }
}
