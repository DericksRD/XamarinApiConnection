using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinApiConnection.Models;
using XamarinApiConnection.Services;

namespace XamarinApiConnection.ViewModels
{
    class ApiInformationViewModel : INotifyPropertyChanged
    {
        public GmailUser GmailSelectedUser { get; set; }
        public String email;
        public String Email { 
            get 
            {
                return email;
            }
            set 
            {
                email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }

        public ICommand GetUserCommand => new Command(GetUserProfileAsync);

        public event PropertyChangedEventHandler PropertyChanged;

        public async void GetUserProfileAsync()
        {
            IGmailApiService gmailApi = new GmailApiService();
            GmailSelectedUser = await gmailApi.GetProfileAsync();

            Email =  GmailSelectedUser.EmailAddress;
        }
    }
}