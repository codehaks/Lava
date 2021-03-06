﻿using Portal.Common.Enums;
using Portal.Common.Values;

namespace Portal.Application.Foods.Models
{
    public class FoodEditInfo
    {
        public int Id { get; set; }
        public Money Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
    }
}
