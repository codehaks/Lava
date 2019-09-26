using Portal.Common.Enums;
using Portal.Common.Values;

namespace Portal.Domain.Entities
{
    public class Food
    {
        protected Food()
        {
            Price = new Money(0);
            Name = string.Empty;
            Description = string.Empty;
        }

        public Food(int id, string name, string description, Money price, FoodType type)
        {
            Name = name;
            Description = description;
            Price = price;
            FoodType = type;
            Id = id;
        }

        public int Id { get; private set; }

        public Money Price { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public FoodType FoodType { get; private set; }

        public Food WithType(FoodType type)
        {
            return new Food(this.Id, this.Name, this.Description, this.Price, type);

        }

        public Food WithPrice(Money price)
        {
            return new Food(this.Id, this.Name, this.Description, price, this.FoodType);

        }
    }
}
