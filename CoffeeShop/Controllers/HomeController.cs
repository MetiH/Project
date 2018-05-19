using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using CoffeeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public HomeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public IActionResult Index()
        {
            var coffees = _coffeeRepository.GetAllCoffees().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Coffees = coffees.ToList(),
                Title = "Welcome to Meti's Coffee Shop"
            };

            return View(homeViewModel);
        }

        public IActionResult Details (int id)
        {
            var coffee = _coffeeRepository.GetCoffeeById(id);
            if (coffee == null)
                return NotFound();
            return View(coffee);
        }

       
    }
}
