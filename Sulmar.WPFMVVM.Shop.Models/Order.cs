using System;
using System.Collections.Generic;
using System.Linq;

namespace Sulmar.WPFMVVM.Shop.Models
{
    public class Order : Base
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> Details { get; set; } = Enumerable.Empty<OrderDetail>().ToList();

        public decimal Total => Details.Sum(d => d.TotalAmount);

        public Order()
        {
           // Details = Enumerable.Empty<OrderDetail>().ToList();

            foreach (var detail in Details)
            {
                detail.PropertyChanged += Detail_PropertyChanged;
            }
        }

        private void Detail_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "TotalAmount")
            {
                OnPropertyChanged(nameof(Total));
            }
        }
    }
}
