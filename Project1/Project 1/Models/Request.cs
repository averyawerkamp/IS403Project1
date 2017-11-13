using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Request ID")]
        public int RequestID { get; set; }
        [DisplayName("Requester ID")]
        public int RequestedByID { get; set; }
        [DisplayName("Request Date")]
        public DateTime RequestDate { get; set; }
            [DisplayName("Client")]
        public int ClientID { get; set; }
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Description")]
        public string RequestDesc { get; set; }
        [DisplayName("Client")]
        public virtual Client Client { get; set; }
        

    }
}