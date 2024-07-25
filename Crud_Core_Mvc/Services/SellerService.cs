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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
        }
    }
}
