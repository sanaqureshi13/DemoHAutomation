using DemoHAutomation.BAL.Services;
using DemoHAutomation.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoHAutomation.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var products = _service.GetAll();
            return View(products);
        }

        [HttpPost]
        public IActionResult Add(string name, decimal price)
        {
            _service.Add(new Product { Name = name, Price = price });
            return RedirectToAction("Index");
        }
    }

}
