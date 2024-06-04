using Microsoft.AspNetCore.Mvc;
using Crud_Core_Mvc.Services;

namespace Crud_Core_Mvc.Controllers
{
    public class SellersController : Controller
    {

        public readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
