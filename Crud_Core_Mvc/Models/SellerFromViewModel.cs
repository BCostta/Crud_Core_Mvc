using Crud_Core_Mvc.Models.Departments;
using System.Collections.Generic;

namespace Crud_Core_Mvc.Models
{
    public class SellerFromViewModel
    {

        public Seller seller { get; set; }
        public ICollection<Department> departments { get; set; } = new List<Department>();

    }
}
