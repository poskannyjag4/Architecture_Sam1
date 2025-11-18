using Decorator_CL.Contracts;

namespace Decorator_CL.Components
{
    public class Coffee: Drink
    {
        private string type;
        
        private double amount;

        public Coffee(string type, double amount, double price, double temperature)
        {
            this.type = type;
            this.amount = amount;
            Price = price;
            Temperature = temperature;
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
            return $"Кофе {type} в количестве {amount}мл";
        }
    }
}