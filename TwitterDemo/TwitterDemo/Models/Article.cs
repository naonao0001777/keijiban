using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace TwitterDemo.Models
{
    public class Article
    {
        public string ThreadId { get; set; }

        public string UserId { get; set; }

        public string Contents { get; set; }

        public string AccountName { get; set; }

        public int AccountType { get; set; }

        public string UpdateDateTime { get; set; }
    }
}