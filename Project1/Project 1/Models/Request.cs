using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    [Table("Request")]
    public class Request
    {
        [Key]
        public int RequestID { get; set; }
        public int RequestedByID { get; set; }
        public DateTime RequestDate { get; set; }
        public int ClientID { get; set; }
        public string ProjectName { get; set; }
        public string RequestDesc { get; set; }
        public virtual Client Client { get; set; }
        

    }
}