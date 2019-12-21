using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using FluentValidation;

namespace ChangeManager.Service.Validators
{
    public class RegisterCoinValidator : AbstractValidator<RegisterCoin>
    {
        public RegisterCoinValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(c => throw new ArgumentException("Can't found this object."));

            RuleFor(c => c.Quantity)
                .NotNull().WithMessage("Must have quantity")
                .NotEmpty().WithMessage("must have quantity");
        }
    }
}
