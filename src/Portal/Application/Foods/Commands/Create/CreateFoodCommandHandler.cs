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

        private static ValidationResult Validate(CreateFoodCommand createFoodCommand)
        {
            var validator = new CreateFoodCommandValidator();
            return validator.Validate(createFoodCommand);
        }
        public async Task<CreateFoodCommandResult> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {
            var check = Validate(request);
            var result = new CreateFoodCommandResult
            {
                ValidationResult = check
            };

            if (check.IsValid)
            {
                var food = _mapper.Map<CreateFoodCommand, Food>(request);
                var newFood = _db.Foods.Add(food);
                await _db.SaveChangesAsync();

                result.FoodId = newFood.Entity.Id;
            }
            return result;
        }
    }
}
