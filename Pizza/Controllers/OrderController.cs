using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp1.Models;

namespace PizzaOrderApp1.Controllers
{
    public class OrderController : Controller
    {
        [HttpPost]
        public IActionResult Checkout(OrderViewModel model)
        {
            // Calculate total price and process order (you can store it in a database, etc.)

            // For simplicity, just pass data to the confirmation view
            return View(model);
        }
        public IActionResult Confirmation(OrderViewModel model)
        {
            return View(model);
        }
    }
}
