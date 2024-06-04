using Crud_Core_Mvc.Data;
using Crud_Core_Mvc.Models;

namespace Crud_Core_Mvc.Services
{
    public class SellerService
    {

        private readonly Crud_Core_MvcContext _context;

        public SellerService(Crud_Core_MvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
