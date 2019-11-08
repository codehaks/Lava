using FluentValidation.Results;
using MediatR;
using Portal.Application.Common;
using Portal.Common.Enums;
using Portal.Common.Values;
using Portal.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands
{
    public class CreateFoodCommand:IRequest<OperationResult<CreateFoodCommandResult>>
    {
        public Money Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }

    }
}
