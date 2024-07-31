using Crud_Core_Mvc.Models.Departments;
using System.Collections.Generic;

namespace Crud_Core_Mvc.Models
{
    public class SellerFromViewModel
    {

        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; } = new List<Department>();

    }
}
