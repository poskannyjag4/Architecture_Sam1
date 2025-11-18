using System;
using Decorator_CL.Components;
using Decorator_CL.Contracts;
using Decorator_CL.Decorators;

namespace Architecture_Sam1
{
    internal class Program
    {

        private static void ShowInfo(Drink drink)
        {
            Console.WriteLine(drink.GetInfo());
            Console.WriteLine($"Температура: {drink.GetTemperature()}");
            Console.WriteLine($"Цена: {drink.GetPrice()}");
            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Кофе");
            Drink coffee = new Coffee("Латте", 500, 250, 65);
            ShowInfo(coffee);

            Console.WriteLine("Кофе и молоко");
            Ingredient milk = new Milk(50, 2.5);
            milk.Drink = coffee;
            ShowInfo(milk);

            Console.WriteLine("Кофе и лимон");
            Ingredient lemon = new Lemon(3);
            lemon.Drink = coffee;
            ShowInfo(lemon);

            Console.WriteLine("Кофе и сахар");
            Ingredient sugar = new Sugar(5);
            sugar.Drink = coffee;
            ShowInfo(sugar);

            Console.WriteLine();
            Console.WriteLine("Чай");

            Drink tea = new Tea("Эрл грей", 750, 150, 70);
            ShowInfo(tea);

            Console.WriteLine("чай и молоко");
            milk.Drink = tea;
            ShowInfo(milk);

            Console.WriteLine("чай и лимон");
            lemon.Drink = tea;
            ShowInfo(lemon);

            Console.WriteLine("чай и сахар");
            sugar.Drink = tea;
            ShowInfo(sugar);
        }
    }
}