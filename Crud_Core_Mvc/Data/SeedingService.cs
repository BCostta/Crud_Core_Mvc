using Crud_Core_Mvc.Models;
using Crud_Core_Mvc.Models.Departments;
using Crud_Core_Mvc.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Org.BouncyCastle.Crypto.Paddings;

namespace Crud_Core_Mvc.Data
{
    public class SeedingService
    {

        private Crud_Core_MvcContext _context;

        public SeedingService(Crud_Core_MvcContext context)
        {
            _context = context;
        }

        public SeedingService() { }

        public void seed()
        {
  
            try
            {

                if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
                {
                    return; //Db has been seeded
                }


                Department d1 = new Department(1, "Computers");
                Department d2 = new Department(2, "Eletronics");
                Department d3 = new Department(3, "Fashion");
                Department d4 = new Department(1, "Books");

                Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998, 4, 21), 20000.0, d1);
                Seller s2 = new Seller(1, "Martin Junior", "martin@gmail.com", new DateTime(1998, 4, 21), 15000.0, d2);
                Seller s3 = new Seller(1, "Albert Einstein", "albert@gmail.com", new DateTime(1998, 4, 21), 10000.0, d3);
                Seller s4 = new Seller(1, "Thomas Edson", "thomas@gmail.com", new DateTime(1998, 4, 21), 10000.0, d4);

                SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s1);
                SalesRecord r2 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s3);
                SalesRecord r3 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s4);
                SalesRecord r4 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s2);
                SalesRecord r5 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s2);
                SalesRecord r6 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s1);
                SalesRecord r7 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s3);

                _context.Department.AddRange(d1, d2, d3, d4);

                _context.Seller.AddRange(s1, s2, s3, s4);

                _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7);

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                string ViewBag = ex.Message;
            }

                                         
        }                                
                                         
    }
}
