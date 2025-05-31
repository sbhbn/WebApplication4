using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class NorthwndContext:DbContext
    {
       
        public DbSet<Customers> Customers { get; set; } //Error?

    }
}