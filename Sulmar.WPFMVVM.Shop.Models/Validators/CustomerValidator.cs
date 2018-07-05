using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.Models.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName)
               .MinimumLength(3)
               .WithMessage("Brak imienia");

            RuleFor(p => p.LastName)
                .NotEmpty();

            RuleFor(p => p.EMail)
                .Must(s => s.Contains("@"));
        }
    }
}
