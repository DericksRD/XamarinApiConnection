using System;
using System.Collections.Generic;
using System.Text;
using XamarinApiConnection.Models;
using XamarinApiConnection.Services;

namespace XamarinApiConnection.ViewModels
{
    class ApiInformationViewModel
    {
        public GmailUser GmailSelectedUser { get; set; }
        public ApiInformationViewModel ApiInformation => new ApiInformationViewModel();
        public async System.Threading.Tasks.Task<string> getUserProfileAsync()
        {
            GmailApiService gmailApi = new GmailApiService();
            GmailSelectedUser = await gmailApi.GetProfileAsync();

            return GmailSelectedUser.EmailAddress;
        }
    }
}