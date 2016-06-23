using System;

using Xamarin.Forms;
namespace CustomRenderer
{
    class LoginPage : ContentPage
    {
        Entry usernameEntry, passwordEntry;
        Label messageLabel;
        Label username;
        Label password;
        
        public LoginPage()
        {
            var toolbarItem = new ToolbarItem
            {
                Text = "Sign Up"
            };
            
            // toolbarItem.Clicked += OnSignUpButtonClicked;
            ToolbarItems.Add(toolbarItem);
            
            messageLabel = new Label();
            username = new Label();
            password = new Label();
            messageLabel.TextColor = Color.FromHex("#000000");
            username.TextColor = Color.FromHex("#000000");
            password.TextColor = Color.FromHex("#000000");
            usernameEntry = new Entry
            {
                Placeholder = "username",TextColor = Color.FromHex("#000000")
        };
            usernameEntry.TextColor= Color.FromHex("#000000");
          
           
            passwordEntry = new Entry
            {
                IsPassword = true
            };
            passwordEntry.TextColor= Color.FromHex("#000000");
            passwordEntry.Placeholder = "pwd123";
            var loginButton = new Button
            {
                Text = "Login"
                
            };
            loginButton.BackgroundColor = Color.FromHex("#00ccff");
            BackgroundColor = Color.FromHex("#ffffff");
            loginButton.Clicked += OnLoginButtonClicked;

            Title = "Login";
            username.Text = "Username";
            password.Text = "Password";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children = {
                   username,
                    usernameEntry,
                    password,
                    passwordEntry,
                    loginButton,
                    messageLabel
                }
            };
        }

        //async void OnSignUpButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SignUpPageCS());
        //}

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }
    }
}
