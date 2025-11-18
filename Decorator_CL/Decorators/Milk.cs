using Decorator_CL.Contracts;

namespace Decorator_CL.Decorators
{
    public class Milk: Ingredient
    {
        
        private double amount;
        private double fatness;

        public Milk(double amount, double fatness)
        {
            this.amount = amount;
            this.fatness = fatness;
            
        }
        
        public override double GetTemperature()
        {
            return drink.GetTemperature() - (amount*0.5);
        }

        public override double GetPrice()
        {
            return drink.GetPrice() + (amount * (1.5 + (fatness * 1.3)));
        }
        
        public override string GetInfo()
        {
            return drink.GetInfo();
        }
    }
}