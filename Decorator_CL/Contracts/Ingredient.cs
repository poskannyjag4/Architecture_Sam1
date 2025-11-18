namespace Decorator_CL.Contracts
{
    public abstract class Ingredient: Drink
    {
        protected Drink drink;

        public Drink Drink
        {
            set => drink = value;
        }
    }
}