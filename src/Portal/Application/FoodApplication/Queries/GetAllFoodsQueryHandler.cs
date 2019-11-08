using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portal.Application.Foods.Models;
using Portal.Domain.Entities;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Queries
{
    class GetAllFoodsQueryHandler : IRequestHandler<GetAllFoodsQuery, IList<FoodInfo>>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public GetAllFoodsQueryHandler(PortalDbContext db, IMapper mapper, ILogger<FoodService> logger)
        {
            _db = db;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<FoodInfo>> Handle(GetAllFoodsQuery request, CancellationToken cancellationToken)
        {
            var foods = await _db.Foods.ToListAsync();
            var model = foods.Select(_mapper.Map<Food, FoodInfo>);
            return model.ToList();
        }
    }
}
