using FluentValidation.Results;
using Portal.Application.Common;
using Portal.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands
{
    public class CreateFoodCommandResult
    {
        public int FoodId { get; set; }
    }
}
