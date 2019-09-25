using FluentValidation;
using Portal.Application.Foods.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods
{
    public class FoodAddValidator: AbstractValidator<FoodAddInfo>
    {
        public FoodAddValidator()
        {
            RuleFor(u => u.Name).NotEmpty().WithMessage("Required");
            RuleFor(u => u.Description).NotEmpty().WithMessage("Required");

        }
    }
}
