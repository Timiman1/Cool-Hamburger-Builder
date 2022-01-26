using System;

namespace StepwiseFluentHamburgerBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("***Build a Hamburger!***\n");

            var burger = HamburgerBuilder.Create().
                OfType(GetHamburgerTypeFromUserSelection()).
                WithBun(GetServingSizeFromUserSelectionOfItem("bun")).
                WithLettuce(GetServingSizeFromUserSelectionOfItem("lettuce")).
                WithCheese(GetServingSizeFromUserSelectionOfItem("cheese")).
                WithOnion(GetServingSizeFromUserSelectionOfItem("onion")).
                WithPatty(GetServingSizeFromUserSelectionOfItem("patty")).
                WithKetchup(GetServingSizeFromUserSelectionOfItem("ketchup")).
                WithCucumber(GetServingSizeFromUserSelectionOfItem("cucumber")).
                WithTomato(GetServingSizeFromUserSelectionOfItem("tomato")).
                Build();

            Console.WriteLine("Your Hamburger is finished and ready to serve!");
            Console.WriteLine(burger.ToString());
            Console.ReadKey();
        }

        private static HamburgerType GetHamburgerTypeFromUserSelection()
        {
            Console.WriteLine("Select a hamburger type:");
            return (HamburgerType)GetUserSelectionOfType(typeof(HamburgerType));

        }

        private static ServingSize GetServingSizeFromUserSelectionOfItem(string itemName)
        {
            Console.WriteLine($"Select serving size of {itemName}:");
            return (ServingSize)GetUserSelectionOfType(typeof(ServingSize));
        }

        private static int GetUserSelectionOfType(Type type)
        {
            foreach (int i in Enum.GetValues(type))
            {
                string name = Enum.GetName(type, i);
                Console.WriteLine($"{i}. {name}");
            }
            int input;
            while (true)
            {
                input = Console.ReadKey().KeyChar - '0';
                if (input >= 0 && input <= 2)
                    break;
                Console.CursorLeft = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bad input");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\n");
            return input;
        }
    }
}
