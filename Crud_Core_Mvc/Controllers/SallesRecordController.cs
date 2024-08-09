using Crud_Core_Mvc.Models;
using Crud_Core_Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Core_Mvc.Controllers
{

    public class SallesRecordController : Controller
    {
        private readonly SallesRecordService _sallesRecordService;

        public SallesRecordController(SallesRecordService sallesRecordService)
        {
            _sallesRecordService = sallesRecordService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = minDate.Value.ToString("yyyy-MM-dd");

            var result = await _sallesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = minDate.Value.ToString("yyyy-MM-dd");

            var result = await _sallesRecordService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }

    }
}
