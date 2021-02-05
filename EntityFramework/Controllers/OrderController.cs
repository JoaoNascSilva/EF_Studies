using EntityFramework.Controllers.ViewModel;
using EntityFramework.Infra;
using EntityFramework.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFramework.Controllers
{
    [Route("test")]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderController(DataContext context)
        {
            _context = context;
        }


        [HttpPost]
        public ActionResult<Order> Add()
        {
            Order order = new Order();

            order = order.AddOrder();

            _context.Add(order);
            _context.SaveChanges();

            //var res = _context.Orders.Include(x => x.OrderItens).First();

            return Ok(new { message = "Inserido com sucesso.", data = order});
        }

        [HttpGet]
        [Route("")]
        public ActionResult<OrderViewModel> GetAll()
        {
            OrderViewModel orderViewModel = new OrderViewModel();

            var order = _context.Orders.Include(x => x.OrderItens).First();

            orderViewModel.Id = order.Id;
            orderViewModel.Description = order.Description;
            //orderViewModel.CreateDate = order.CreateDate;

            orderViewModel.Itens = order.OrderItens.ToList();
            //var p = new Product()
            //{
            //    Description = "iPhone XS",
            //    IsActive = true,
            //    Price = 5999.00M,
            //};
            //orderViewModel.Itens.Add(new OrderItem()
            //{
            //    Product = p,
            //    IdProduct = p.Id,
            //    Price = p.Price,
            //    Quantity = 2
            //});

            return orderViewModel;
        }
    }
}

