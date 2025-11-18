using Decorator_CL.Contracts;

namespace Decorator_CL.Components
{
    public class Tea: Drink
    {
        private string type;

        private double amount;

        public Tea(string type, double amount, double price, double temperature)
        {
            base.Price = price;
            base.Temperature = temperature;
            this.type = type;
            this.amount = amount;
        }
        
        public override double GetTemperature()
        {
            return Temperature;
        }

        public override double GetPrice()
        {
            return Price;
        }
        
        public override string GetInfo()
        {
            return $"Чай {type} в количестве {amount}мл";
        }
    }
}