using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApiConnection.Models
{
    public class GmailUser
    {

            public string EmailAddress { get; set; }
            public int MessagesTotal { get; set; }
            public int ThreadsTotal { get; set; }
            public string HistoryId { get; set; }

    }
}
