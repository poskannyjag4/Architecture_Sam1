namespace Decorator_CL.Contracts
{
    public abstract class Drink
    {
        protected string Name;
        
        protected double Temperature;
        
        protected double Price;

        public abstract double GetTemperature();
        
        public abstract double GetPrice();
        
        public abstract string GetInfo();
    }
}