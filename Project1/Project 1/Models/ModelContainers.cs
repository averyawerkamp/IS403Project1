using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public class RequestAndClients
    {
        public IEnumerable<Client> Clients { get; set; }
        public Request Request { get; set; }
    }
}