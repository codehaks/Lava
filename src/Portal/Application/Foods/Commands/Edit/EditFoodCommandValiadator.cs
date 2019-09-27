using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands.Edit
{
    public class EditFoodCommandValiadator : AbstractValidator<CreateFoodCommand>
    {
        public EditFoodCommandValiadator()
        {
            RuleFor(u => u.Name).NotEmpty().WithMessage("Food name is Required.");
            RuleFor(u => u.Price.Amount).GreaterThan(0).WithMessage("Food can not be free.");
            RuleFor(u => u.Description).NotEmpty().WithMessage("Food description is Required.");
        }
    }
}
