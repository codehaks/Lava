using AutoMapper;
using FluentValidation.Results;
using MediatR;
using Portal.Application.Common;
using Portal.Domain.Entities;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands
{
    public class CreateFoodCommandHandler : IRequestHandler<CreateFoodCommand, OperationResult<CreateFoodCommandResult>>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;

        public CreateFoodCommandHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<OperationResult<CreateFoodCommandResult>> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {


            var food = _mapper.Map<CreateFoodCommand, Food>(request);
            var newFood =await _db.Foods.AddAsync(food);

            //_db.SaveChangesAsync()

            var result = OperationResult<CreateFoodCommandResult>
                .BuildSuccessResult(new CreateFoodCommandResult
                {
                    FoodId = newFood.Entity.Id
                });
            await Task.CompletedTask;
            return result;
        }


    }
}
