using Decorator_CL.Contracts;

namespace Decorator_CL.Decorators
{
    public class Lemon: Ingredient
    {
        private int amount;

        public Lemon(int amount)
        {
            this.amount = amount;
        }
        
        public override double GetTemperature()
        {
            return drink.GetTemperature();
        }

        public override double GetPrice()
        {
            return drink.GetPrice() + (amount * 7);
        }

        public override string GetInfo()
        {
            return drink.GetInfo();
        }
    }
}