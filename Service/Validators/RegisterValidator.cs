using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using FluentValidation;

namespace ChangeManager.Service.Validators
{
    public class RegisterValidator : AbstractValidator<Register>
    {
        public RegisterValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(c => throw new ArgumentException("Can't find object"));

            RuleFor(c => c.Name)
                .NotNull().WithMessage("Must Have Name")
                .NotEmpty().WithMessage("Must Have Name");

            //RuleFor(c => c.RegisterCoins)
            //    .NotNull()
            //    .NotEmpty();
        }
    }
}
