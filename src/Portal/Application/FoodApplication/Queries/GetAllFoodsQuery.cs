using MediatR;
using Portal.Application.Foods.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Queries
{
    public class GetAllFoodsQuery:IRequest<IList<FoodInfo>>
    {
    }
}
