using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Client Name")]
        public String ClientName { get; set; }
        [DisplayName("Contact Name")]
        public String ContactName { get; set; }
        [DisplayName("Contact Phone Number")]
        public String ContactPhone { get; set; }
        [DisplayName("Address Line 1")]
        public String AddressLine1 { get; set; }
        [DisplayName("Address Line 2")]
        public String AddressLine2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Email { get; set; }

    }
}