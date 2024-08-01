using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Single_Page_Task.Data;
using Single_Page_Task.Models;
using Single_Page_Task.Services;
using System.Diagnostics;

namespace Single_Page_Task.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IProduct _product;

        public DataContext _context { get; }

        public HomeController(IProduct product)
        {
            
            _product = product;
            
        }

        public IActionResult Index()
        {
            var data = _product.index();
              return View(data);
        }
        [HttpPost]
        public IActionResult Save([FromBody] IndexView model)
        {
            if (model != null)
            {
                if (model.MeetingMinutesMaster != null)
                {
                    _product.savetomastartable(model.MeetingMinutesMaster);
                }
                if (model.MeetingMinutesDetails != null)
                {
                    _product.savetodetailstable(model.MeetingMinutesDetails);
                }

            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}