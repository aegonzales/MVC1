using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.Data.Entity;

namespace WebApplication1.DataAccessLayer
{
    using WebApplication1.Models;
    public class CounterDAL : DbContext
    {
        public CounterDAL() : base("CounterERPDAL")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Counter>().ToTable("TblCounter");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Counter> Counters { get; set; }
    }
}