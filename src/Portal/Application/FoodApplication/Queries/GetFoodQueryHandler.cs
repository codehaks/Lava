using MediatR;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Queries
{
    public class GetFoodQueryHandler : IRequestHandler<GetFoodQuery, GetFoodQueryResult>
    {
        private readonly PortalDbContext _db;

        public GetFoodQueryHandler(PortalDbContext db)
        {
            _db = db;
        }

        public async Task<GetFoodQueryResult> Handle(GetFoodQuery request, CancellationToken cancellationToken)
        {
            var food = await _db.Foods.FindAsync(request.FoodId);
            return new GetFoodQueryResult
            {
                Food = new Models.FoodInfo
                {
                    Id = food.Id,
                    Description = food.Description,
                    FoodType = food.FoodType,
                    Name = food.Name,
                    Price = food.Price
                }
            };
        }
    }
}
