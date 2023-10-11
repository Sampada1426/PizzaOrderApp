using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp1.Models;

namespace PizzaOrderApp1.Controllers
{
    public class PizzaController : Controller
    {
        private readonly List<PizzaItem> pizzas = new List<PizzaItem>
        {
            new PizzaItem { Id = 1, Name = "Margherita", Price = 150M, ImageUrl = "/images/margheritapizza.jpg" },
            new PizzaItem { Id = 2, Name = "Pepperoni", Price = 200M, ImageUrl = "/images/pepperonipizza.jpg" },
            new PizzaItem { Id = 3, Name = "Vegetarian", Price = 250M, ImageUrl = "/images/vegetarian.jpg" },
        };

        public IActionResult Index()
        {
            return View(pizzas);
        }
    }
}
