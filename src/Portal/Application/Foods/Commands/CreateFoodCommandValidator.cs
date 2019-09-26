using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands
{
    class CreateFoodCommandValidator : AbstractValidator<CreateFoodCommand>
    {
        public CreateFoodCommandValidator()
        {

            RuleFor(u => u.Name).NotEmpty().WithMessage("Required");
            RuleFor(u => u.Price.Amount).GreaterThan(0).WithMessage("Food can not be free!");
            RuleFor(u => u.Description).NotEmpty().WithMessage("Required");

        }
    }
}
