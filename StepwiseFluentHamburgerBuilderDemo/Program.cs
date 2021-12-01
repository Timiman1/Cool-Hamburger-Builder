using System;

namespace StepwiseFluentHamburgerBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Builder Pattern Demo***");
            var burger = HamburgerBuilder.Create().
                OfType(HamburgerType.Vegan).
                WithBun(ServingSize.Medium).
                WithLettuce(ServingSize.Medium).
                WithCheese(ServingSize.Extra).
                WithOnion(ServingSize.Extra).
                WithPatty(ServingSize.Medium).
                WithKetchup(ServingSize.None).
                WithCucumber(ServingSize.Medium).
                WithTomato(ServingSize.Extra).
                Build();

            Console.WriteLine("Hamburger was assembled!");
            Console.WriteLine(burger.ToString());
            Console.WriteLine("The ingredients are hardcoded, change the serving sizes in Program.cs to style your own awesome burger :)");

            Console.ReadKey();
        }
    }
}
