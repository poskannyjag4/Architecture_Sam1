using System;
using Composite_CL;
using Composite_CL.Contracts;

namespace Composite_CA
{
    internal class Program
    {

        public static void Show(Component component)
        {
            Console.WriteLine();
            if (component.GetType() == typeof(Directory))
            {
                Directory dir = (Directory)component;
                for (int i = 0; i<dir.children.Count; i++)
                {
                    Console.WriteLine($"{i} - {dir.children[i].GetType().Name} {dir.children[i].name}");
                }
            }
            else
            {
                Console.WriteLine($"{component.GetType().Name} - {component.name}");
            }
        }

        public static Component Move(Component component, int index)
        {
            
            if (component.GetType() == typeof(Directory))
            {
                Directory comp = (Directory)component;
                if (index >= comp.children.Count || index < 0)
                {
                    return comp;
                }
                else
                {
                    return comp.children[index];
                }
            }
            else
            {
                return component;
            }
        }
        
        public static void Main(string[] args)
        {
            Component tree = new Directory("root");
            
            Component file1 = new File("file1");
            tree.Add(file1);
            
            Component dir1 = new Directory("dir1");
            
            Component file2 = new File("file2");
            Component file3 = new File("file3");
            dir1.Add(file2);
            dir1.Add(file3);
            
            tree.Add(dir1);

            Component dir2 = new Directory("dir2");
            Component dir3 = new Directory("dir3");
            dir2.Add(dir3);
            Component file4 = new File("file4");
            dir2.Add(file4);
            Component file5 = new File("file5");
            Component file6 = new File("file6");
            Component file7 = new File("file7");
            dir3.Add(file7);
            dir3.Add(file6);
            dir3.Add(file5);
            tree.Add(dir2);
            
            Component curComp = tree;
            
            while (true)
            {
                Show(curComp);
                int index = int.Parse(Console.ReadLine());
                
                curComp = Move(curComp, index);
                
            }
        }
    }
}