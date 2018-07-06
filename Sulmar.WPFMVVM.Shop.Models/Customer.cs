using FluentValidation.Attributes;
using Sulmar.WPFMVVM.Shop.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.Models
{
    [Validator(typeof(CustomerValidator))]
    public class Customer : Base
    {
        private string _firstName;

        public int Id { get; set; }

        //private string _firstName;
        //private string _lastName;


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


        //public string FirstName
        //{
        //    get { return _firstName; }
        //    set
        //    {
        //        if (value?.Length < 3)
        //        {
        //            throw new ArgumentException("Imię musi zawierać minimum 3 znaki");
        //        }

        //        _firstName = value;
        //        OnPropertyChanged();
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


        public Customer()
        {
            Birthday = DateTime.Today;
        }


        #region IDataErrorInfo

        //public string this[string columnName]
        //{
        //    get
        //    {
        //        switch (columnName)
        //        {
        //            case nameof(LastName): return string.IsNullOrEmpty(LastName) ? "Nazwisko jest wymagane" : null;
        //            case nameof(EMail): return !string.IsNullOrEmpty(EMail) && !EMail.Contains("@") ? "Nieprawidłowy format adresu email" : null;

        //            default: return null;
        //        }
        //    }
        //}

        //public string Error
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}


        #endregion

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
