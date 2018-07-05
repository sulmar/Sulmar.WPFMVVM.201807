using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Internal;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.Models
{
    // Install-Package PropertyChanged.Fody
    // Add xml file FodyWeavers.xaml

    public abstract class Base : INotifyPropertyChanged, IDataErrorInfo
    {
        private IValidator validator => new AttributedValidatorFactory().GetValidator(this.GetType());

        public string this[string columnName] => Validate(columnName);


        private string Validate(string propertyName)
        {
            if (validator == null)
                return null;

            var properties = new List<string> { propertyName };

            var context = new ValidationContext(this, new PropertyChain(), new MemberNameValidatorSelector(properties));

            var result = validator.Validate(context);

            if (result.IsValid)
            {
                return null;
            }
            else
            {
                return GetString(result);
            }
        }

        private static string GetString(ValidationResult result)
        {
            return string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage));
        }

        public string Error => validator == null ? null : GetString(validator.Validate(this));

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
