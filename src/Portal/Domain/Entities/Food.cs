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

        public Food(int id,string name, Money price, FoodType type)
        {
            Name = name;
            Price = price;
            FoodType = type;
            Description = string.Empty;
            Id = id;
        }

        public int Id { get; private set; }

        public Money Price { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public FoodType FoodType { get; private set; }

        public void AddDescription(string description)
        {
            if (description.Length < 500)
            {
                Description = description;
            }
            else
            {
                throw new System.Exception("Description is too long!");
            }

        }

        public void WithType(FoodType type)
        {
            FoodType = type;
        }

        public void WithPrice(Money price)
        {
            Price = price;
        }
    }
}
