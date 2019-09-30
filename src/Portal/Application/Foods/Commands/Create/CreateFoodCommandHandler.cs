using AutoMapper;
using FluentValidation.Results;
using MediatR;
using Portal.Domain.Entities;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands
{
    public class CreateFoodCommandHandler : IRequestHandler<CreateFoodCommand, CreateFoodCommandResult>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;

        public CreateFoodCommandHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CreateFoodCommandResult> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {

            var result = new CreateFoodCommandResult();
            var food = _mapper.Map<CreateFoodCommand, Food>(request);
            var newFood = _db.Foods.Add(food);

            result.FoodId = newFood.Entity.Id;

            await Task.CompletedTask;
            return result;
        }


    }
}
