using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;
using Sulmar.WPFMVVM.Shop.Models.Extensions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.Models
{
    // Install-Package PropertyChanged.Fody
    // Add xml file FodyWeavers.xaml

    public abstract class Base : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private IValidator validator => new AttributedValidatorFactory().GetValidator(this.GetType());

        #region IDataErrorInfo

        //public string this[string columnName] => Validate(columnName);

        //private string Validate(string propertyName)
        //{
        //    if (validator == null)
        //        return null;

        //    var result = validator.Validate(this, propertyName);

        //    if (result.IsValid)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return GetString(result);
        //    }
        //}

        //private static string GetString(ValidationResult result)
        //{
        //    return string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage));
        //}

        //public string Error => validator == null ? null : GetString(validator.Validate(this));

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        #region INotifyDataErrorInfo

        public bool HasErrors => !(validator?.Validate(this).IsValid ?? true);

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            var result = validator.Validate(this, propertyName);

            return result.Errors;
        }

        #endregion
    }
}
