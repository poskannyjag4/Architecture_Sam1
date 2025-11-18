using System;
using System.Collections.Generic;
using System.Text;
using Composite_CL.Contracts;

namespace Composite_CL
{
    public class Directory: Component
    {
        public List<Component> children = new List<Component>();
        
        public Directory(string name) : base(name)
        {
        }

        public override string Display()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(name + '\n');

            foreach (var child in children)
            {
                result.AppendLine(child.Display());
            }
            return result.ToString();
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}