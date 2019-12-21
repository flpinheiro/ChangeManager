using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using FluentValidation;

namespace ChangeManager.Service.Validators
{
    public class ChangeValidator: AbstractValidator<Change>
    {
        public ChangeValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(c => throw new ArgumentException("Can't find object"));
        }
    }
}
