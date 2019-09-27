using MediatR;
using Microsoft.EntityFrameworkCore;
using Portal.Domain.Entities;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands.Edit
{
    public class EditFoodCommandHandler : IRequestHandler<EditFoodCommand, EditFoodCommandResult>
    {
        private readonly PortalDbContext _db;

        public EditFoodCommandHandler(PortalDbContext db)
        {
            _db = db;
        }

        public async Task<EditFoodCommandResult> Handle(EditFoodCommand request, CancellationToken cancellationToken)
        {
            var food = new Food(request.Id, request.Name, request.Description, request.Price, request.FoodType);

            //_db.Entry(food.Price).State = EntityState.Modified;
            //_db.Entry(food).State = EntityState.Modified;

            _db.Update(food);

            await Task.CompletedTask;

            return new EditFoodCommandResult
            {
                ValidationResult = null
            };
        }
    }
}
