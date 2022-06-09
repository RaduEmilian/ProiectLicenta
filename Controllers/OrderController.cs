using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.DAL.Interfaces;
using TestFinal.Models;
using TestFinal.ViewModels;
using System.Security.Claims;
using TestFinal.Models.Repositores;
using TestFinal.Data;
using Stripe;

namespace TestFinal.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly MyDbContext context;
        private readonly UserManager<ApplicationUser> _userManager;


        public OrderController(IOrderService orderRepository, ShoppingCart shoppingCart, MyDbContext _context, UserManager<ApplicationUser> userManager)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            context = _context;
            _userManager = userManager;
        }
        [Authorize(Roles = "User")]

        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> List()
        {
            return View(await context.Orders.ToListAsync());
        }
        [Authorize(Roles = "User")]

        public IActionResult ListOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            return View(context.OrderDetails.Where(c => c.UserID.Contains(userId)).ToList());

        }
        public async Task<IActionResult> Info(int id)
        {
            var order = await context.OrderDetails.FindAsync(id);
            ViewBag.Nume = order.Order.FirstName;
            ViewBag.LastName = order.Order.LastName;
            ViewBag.Produs = order.Nume_Produs;
            ViewData["id"] = order.OrderId;
            return (IActionResult)order;

        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await context.Orders.FindAsync(id);

            await _orderRepository.Delete(order);

            return RedirectToAction("List", "order");
        }


        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult Checkout(string stripeToken, TestFinal.Models.Order order)
        {
            StripeConfiguration.ApiKey = "sk_test_51L8PatFMF8OhrQQKSrgrZH5c0veFpWUkASt7Nlzq8oAoCusG4LPRKU5Jl0xoURBjjY04GLVDxn8j04PMZeq8ci0a00mbpq10BM";

            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var user = User.Identity.Name;
                order.UserId = userId;
                _orderRepository.CreateOrder(order);

                var optionsCust = new CustomerCreateOptions
                {
                    Email = User.Identity.Name,
                    Name = order.FirstName
                };
                var serviceCust = new CustomerService();
                Customer customer = serviceCust.Create(optionsCust);

                var options = new ChargeCreateOptions
                {
                    Amount = (long?)order.OrderTotal * 100,
                    Description = order.FirstName,
                    Currency = "RON",
                    Source = stripeToken,
                    ReceiptEmail = customer.Email
                };
                var service = new ChargeService();
                Charge charge = service.Create(options);

                var model = new ChangeViewModel();
                model.ChargeId = charge.Id;

                _shoppingCart.ClearCart();
                return View("CheckoutComplete", model);

            }

            return View(order);
        }

        [Authorize(Roles = "User")]

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order. Enjoy your products";
            return View();
        }

    }
}