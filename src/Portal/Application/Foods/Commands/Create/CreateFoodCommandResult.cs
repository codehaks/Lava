using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands
{
    public class CreateFoodCommandResult
    {
        public ValidationResult ValidationResult { get; set; }
        public int FoodId { get; set; }
    }
}
