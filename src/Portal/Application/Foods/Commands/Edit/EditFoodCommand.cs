using MediatR;
using Portal.Common.Enums;
using Portal.Common.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands.Edit
{
    public class EditFoodCommand:IRequest<EditFoodCommandResult>
    {
        public Money Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
    }
}
