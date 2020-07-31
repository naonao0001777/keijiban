using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TwitterDemo.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string Password { get; set; }

        public string AccountName { get; set; }

        public int AccountType { get; set; }

        public DateTime UpdateDate { get; set; }

        public void Converter()
        {
            if (AccountType == 1)
            {

            }
        }
    }
}