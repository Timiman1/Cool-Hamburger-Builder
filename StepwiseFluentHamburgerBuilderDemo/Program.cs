using System;

namespace StepwiseFluentHamburgerBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine(burger.ToString());

            Console.ReadKey();
        }
    }
}
