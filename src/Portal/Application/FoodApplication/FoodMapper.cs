using AutoMapper;
using Portal.Application.Foods.Commands;
using Portal.Application.Foods.Models;
using Portal.Domain.Entities;

namespace Portal.Application.Products
{
    public class FoodMapper : Profile
    {
        public FoodMapper()
        {
            CreateMap<FoodAddInfo, Food>();
            CreateMap<Food,FoodInfo>();
            CreateMap<CreateFoodCommand, Food>();
        }
    }
}