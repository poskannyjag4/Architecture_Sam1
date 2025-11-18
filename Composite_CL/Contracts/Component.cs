namespace Composite_CL.Contracts
{
    public abstract class Component
    {
        public string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract string Display();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);

    }
}