using System;
using System.Collections.Generic;

namespace Sulmar.WPFMVVM.Shop.Models
{
    public class Order : Base
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
    }
}
