using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.Models
{
    public class Customer : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public string EMail { get; set; }

        public int Age => DateTime.Today.Year - Birthday.Year;

        public bool IsAdult => Age >= 18;

        //public override string ToString()
        //{
        //    return FirstName;
        //}
    }

    public enum Sex
    {
        Male,
        Female
    }
}
