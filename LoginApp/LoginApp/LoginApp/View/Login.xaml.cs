using LoginApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LoginApp.Constants;
using LoginApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private LoginViewModel viewModel;
        public Login()
        {
            InitializeComponent();
            viewModel = new LoginViewModel();
            BindingContext = viewModel;
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Regex regex = new Regex(StringConstants.UserNamePattern);
                var entry = (Entry)sender;
                if (!entry.Text.IsEmpty() && !regex.IsMatch(entry.Text))
                {
                    entry.Text = e.OldTextValue;
                }
                if (entry.Text != null && (string.IsNullOrEmpty(entry.Text.Trim()) || entry.Text[0] == '.'))
                {
                    entry.Text = "";
                }

                if (!entry.Text.IsEmpty())
                    viewModel.Model.IsUserNameErrorMessageVisible = false;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Regex regex = new Regex(StringConstants.UserNamePattern);
                var entry = (Entry)sender;

                if (!entry.Text.IsEmpty())
                    viewModel.Model.IsPasswordErrorMessageVisible= false;
            }
            catch (Exception ex)
            {

            }
        }
    }
}