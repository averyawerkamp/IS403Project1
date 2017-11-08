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
        public BabbittNelsonContext() : base("BabbittNelson")
        {

        }
        public DbSet<Client> Clients { get; set; }

    }
}