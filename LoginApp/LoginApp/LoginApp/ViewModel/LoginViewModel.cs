using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using LoginApp.Model;
using LoginApp.Validators.Implementation;
using LoginApp.Validators.Interface;
using Xamarin.Forms;

namespace LoginApp.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        #region Commands
        public ICommand LoginCommand { get; set; }
        public ICommand ForgetPasswordCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        #endregion
        #region Properties

        public LoginModel Model { get; set; } 
        public IUserValidations _UserValidations { get; set; } 
        #endregion

        public LoginViewModel()
        {
            Model = new LoginModel();
            _UserValidations = new UserValidations();
            LoginCommand = new Command(OnLoginClick);
            ForgetPasswordCommand = new Command(OnForgetPasswordClick);
            SignUpCommand = new Command(OnSignUpClick);
        }

        #region Private Methods

        private void OnSignUpClick()
        {

        }

        private void OnForgetPasswordClick()
        {
        }

        private void OnLoginClick()
        {

            if (_UserValidations.ValidateUserLogin(Model))
            {
                
            }
        } 
        #endregion
    }
}
