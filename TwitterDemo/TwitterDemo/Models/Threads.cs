using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterDemo.Models
{
    [Table("Thread")]
    public class Threads
    {
        [Key]
        public string ThreadId { get; set; }
        public string UserId { get; set; }
        public string Contents { get; set; }
        public string UpdateDateTime { get; set; }
        public string DeleteKey { get; set; }
    }
}