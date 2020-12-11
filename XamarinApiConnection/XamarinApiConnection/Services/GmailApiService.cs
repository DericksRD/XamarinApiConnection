using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinApiConnection.Models;

namespace XamarinApiConnection.Services
{
    class GmailApiService : IGmailApiService
    {
        public async Task<GmailUser> GetProfileAsync()
        {
            GmailUser responseUser = null;
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://gmail.googleapis.com/gmail/v1/users/{userId}/profile");

            if (response.IsSuccessStatusCode)
            {
                responseUser = JsonConvert.DeserializeObject<GmailUser>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                responseUser = new GmailUser();
                responseUser.EmailAddress = "derick_sRD";
            }

            return responseUser;
        }
    }
}
 