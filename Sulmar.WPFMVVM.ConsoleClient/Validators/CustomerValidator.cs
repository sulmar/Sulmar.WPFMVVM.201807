using FluentValidation;
using Sulmar.WPFMVVM.ConsoleClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.ConsoleClient.Validators
{
    class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName)
                .MinimumLength(3)
                .WithMessage("Brak imienia");

            RuleFor(p => p.LastName)
                .NotEmpty();

            RuleFor(p => p.Email)
                .Must(s => s.Contains("@"))
                .When(s => !string.IsNullOrEmpty(s.Email));
        }
    }
}
