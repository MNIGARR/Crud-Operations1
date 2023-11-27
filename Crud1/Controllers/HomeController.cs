using Crud1.Data;
using Crud1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crud1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList().Select(p =>
            {
                return new ProductViewModel
                {
                    Name = p.Name,
                    Price = p.Price
                };
            });

            var categories = _context.Categories.ToList().Select(p =>
            {
                return new CategoryViewModel
                {
                    Title = p.Title,
                };
            });

            var vm = new ProductListViewModel { Products = products, Categories = categories };

            return View(vm);
        }


    }
}