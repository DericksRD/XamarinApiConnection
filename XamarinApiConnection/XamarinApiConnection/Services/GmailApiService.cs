using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XamarinApiConnection.Models;

namespace XamarinApiConnection.Services
{
    class GmailApiService : IGmailApiService
    {
        public async Task<GmailUser> GetProfileAsync()
        {
            Authetincation();
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

        public void Authetincation()
        {
            /*
             * If you want to use any api from google, 
             * you need to add the authentication Oatuh v.2
             */
            string[] Scopes = { GmailService.Scope.GmailReadonly };
            //string AppliactionName = "Gmail API .Net";

            UserCredential credential;

            using (var stream = new FileStream(@"D:\Documentos\Repos\XamarinApiConnection\XamarinApiConnection\XamarinApiConnection\credentials.json",
                                    FileMode.Open, FileAccess.Read))
            {
                string path = "token.json";
                //token.json is created automatically and include the user's access.
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(path, true)).Result;
                /*
                 * With that code above, we saved the credential file to token.json
                 */
            }
        }
    }
    
}
 