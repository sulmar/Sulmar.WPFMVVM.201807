using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.Models
{
    public class Customer : Base
    {
        //private string _firstName;
        //private string _lastName;

        public int Id { get; set; }
        //public string FirstName
        //{
        //    get => _firstName;
        //    set
        //    {
        //        _firstName = value;

        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}

        //public string LastName
        //{
        //    get => _lastName;
        //    set
        //    {
        //        _lastName = value;

        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

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
