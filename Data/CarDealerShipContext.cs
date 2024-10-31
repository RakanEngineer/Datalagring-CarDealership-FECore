using Datalagring_CarDealership_FECore.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Datalagring_CarDealership_FECore.Data
{
     class CarDealerShipContext : DbContext
    {
        private string connectionString;

        public DbSet<Car> Car { get; set; }

        public CarDealerShipContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
