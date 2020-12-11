using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinApiConnection.Models;

namespace XamarinApiConnection.Services
{
    public interface IGmailApiService
    {
         Task<GmailUser> GetProfileAsync();
    }
}
