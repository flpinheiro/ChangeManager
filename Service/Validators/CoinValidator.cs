using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChangeManager.Domain.Entities;
using FluentValidation;

namespace ChangeManager.Service.Validators
{
    public class CoinValidator : AbstractValidator<Coin>
    {
        public CoinValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(c => throw new ArgumentException("Can't found this object."));

            RuleFor(c => c.Value)
                .NotNull().WithMessage("Must have value.")
                .NotEmpty().WithMessage("Must have value");
        }
    }
}
