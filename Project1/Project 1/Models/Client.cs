using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public String ClientName { get; set; }
        public String ContactName { get; set; }
        public String ContactPhone { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Email { get; set; }

    }
}