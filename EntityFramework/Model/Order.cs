using System;
using System.Collections.Generic;

namespace EntityFramework.Model
{
    public class Order : Entity
    {
        public Order()
        {
            this.OrderItens = new List<OrderItem>();
        }

        //public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public IList<OrderItem> OrderItens { get; set; }
        //public OrderItem OrderItens { get; set; }


        public Order AddOrder()
        {            
            var product = new Product();
            var MacBook = product.AddMacBook();
            var macBookItem = new OrderItem()
            {
                //IdOrder = this.Id,
                Product = MacBook,
                IdProduct = MacBook.Id,
                Price = MacBook.Price,
                Quantity = 1,
            };

            var RTX = product.AddNvidiaRTX();
            var RTXItem = new OrderItem()
            {
                ///IdOrder = this.Id,
                Product = RTX,
                IdProduct = RTX.Id,
                Price = RTX.Price,
                Quantity = 2,
            };

            return new Order()
            {
                Id = this.Id,
                Description = string.Format("Order number: {0}", new Random().Next(1, 100)),
                //OrderItens = macBookItem
                OrderItens = new List<OrderItem>()
                {
                    macBookItem,
                    RTXItem
                }
            };
        }
    }
}
