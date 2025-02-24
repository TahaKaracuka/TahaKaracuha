using ECommerce.MVC.Abstract;
using ECommerce.MVC.ComplexTypes;
using ECommerce.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace ECommerce.MVC.Controllers
{

    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBasketService _basketService;
        private readonly IToastNotification _toaster;

        public OrderController(IOrderService orderService, IToastNotification toaster, IBasketService basketService)
        {
            _orderService = orderService;
            _toaster = toaster;
            _basketService = basketService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByUserAsync(userId);
            return View(response);
        }

        [Authorize]
        public async Task<IActionResult> GetOrdersByStatus(OrderStatus status)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByStatusAsync(status, userId);
            return View(response);
        }

        [Authorize]
        public async Task<IActionResult> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByDateRangeAsync(startDate, endDate, userId);
            return View(response);
        }

        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var basket = await _basketService.GetBasketAsync(userId);
            decimal totalPrice = (decimal)basket.BasketItems.Sum(x => x.Quantity * x.Product.Price);
            return View(totalPrice);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderModel orderModel)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var basket = await _basketService.GetBasketAsync(userId);
            orderModel.ApplicationUserId= userId;
            orderModel.OrderItems = basket.BasketItems.Select(x => new OrderItemModel
            {
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                UnitPrice = x.Product.Price
            }).ToList();
            orderModel.CreatedDate = DateTime.Now;
            await _orderService.AddAsync(orderModel);
            await _basketService.ClearBasketAsync(userId);
            _toaster.AddSuccessToastMessage("Siparişiniz başarıyla verilmiştir");
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> GetShippedOrders()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByStatusAsync(OrderStatus.Shipped, userId);
            return View(response);
        }

        public async Task<IActionResult> GetDeliveredOrders()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _orderService.GetByStatusAsync(OrderStatus.Delivered, userId);
            return View(response);
        }
    }
}
