using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Queries
{
    public class GetFoodQuery : IRequest<GetFoodQueryResult>
    {
        public int FoodId { get; set; }
    }
}
