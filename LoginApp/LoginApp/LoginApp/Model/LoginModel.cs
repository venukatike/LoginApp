using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Model
{
    public class LoginModel: BaseModel
    {
        #region UserName
        private string userName = string.Empty;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string userNameErrorMsg;
        public string UserNameErrorMsg
        {
            get { return userNameErrorMsg; }
            set
            {
                userNameErrorMsg = value;
                OnPropertyChanged(nameof(UserNameErrorMsg));
            }
        }

        private bool isUserNameErrorMessageVisible = false;
        public bool IsUserNameErrorMessageVisible
        {
            get { return isUserNameErrorMessageVisible; }
            set
            {
                isUserNameErrorMessageVisible = value;
                OnPropertyChanged(nameof(IsUserNameErrorMessageVisible));
            }
        }
        #endregion

        #region PasswordFields

        private string password = string.Empty;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }



        private bool isPasswordVisibility = true;
        public bool IsPasswordVisibility
        {
            get { return isPasswordVisibility; }
            set
            {
                isPasswordVisibility = value;
                OnPropertyChanged(nameof(IsPasswordVisibility));
            }
        }

        private bool ispasswordErrorMessageVisible = false;
        public bool IsPasswordErrorMessageVisible
        {
            get { return ispasswordErrorMessageVisible; }
            set
            {
                ispasswordErrorMessageVisible = value;
                OnPropertyChanged(nameof(IsPasswordErrorMessageVisible));
            }
        }



        private string passwordErrorMsg;
        public string PasswordErrorMsg
        {
            get { return passwordErrorMsg; }
            set
            {
                passwordErrorMsg = value;
                OnPropertyChanged(nameof(PasswordErrorMsg));
            }
        }

        private string showPassword = ResourceFile.ShowText;
        public string ShowPassword
        {
            get { return showPassword; }
            set
            {
                showPassword = value;
                OnPropertyChanged(nameof(ShowPassword));
            }
        }

        #endregion
    }
}
