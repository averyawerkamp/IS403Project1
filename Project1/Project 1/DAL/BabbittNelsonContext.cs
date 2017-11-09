using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project_1.Models;


namespace Project_1.DAL
{
    public class BabbittNelsonContext : DbContext
    {
        public BabbittNelsonContext() : base("DefaultConnection")
        {

        }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Client> Clients { get; set; }
        
    }
}