using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Versta.DataAccess;
using Versta.Models;
using Versta.Repositories.Interfaces;

namespace Versta.Controllers
{
    public class OrderController(IOrderRepository orderRepository) : Controller
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var order = await orderRepository.GetAll();
            return View("GetAllOrders", order);
        }

        [HttpGet]
        public async Task<ViewResult> GetById(Order orderFind)
        {
            var order = await orderRepository.GetById(orderFind.id);
        
            return View("GetById", order);
        }

        public IActionResult GetById()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            await orderRepository.AddOrder(order);
            return View();
        }
        
        public ActionResult AddOrder()
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