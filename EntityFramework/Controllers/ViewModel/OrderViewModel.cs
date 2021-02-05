using EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Controllers.ViewModel
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            Itens = new List<OrderItem>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public List<OrderItem> Itens { get; set; }

    }
}
