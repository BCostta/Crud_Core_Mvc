using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_Core_Mvc.Models.Departments;

using Crud_Core_Mvc.Models;

namespace Crud_Core_Mvc.Data
{
    public class Crud_Core_MvcContext : DbContext
    {
        public Crud_Core_MvcContext (DbContextOptions<Crud_Core_MvcContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_Core_Mvc.Models.Departments.Department> Department { get; set; } //= default!;

        public DbSet<Crud_Core_Mvc.Models.Seller> Seller { get; set; } //= default!;
        public DbSet<Crud_Core_Mvc.Models.SalesRecord> SalesRecord { get; set; } //= default!;

    }
}
