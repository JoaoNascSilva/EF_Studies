using System;

namespace EntityFramework.Model
{
    public class OrderItem : Entity
    {
        public Guid IdOrder { get; set; }
        public Order Order { get; set; }

        public Guid IdProduct{ get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}