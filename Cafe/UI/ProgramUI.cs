using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.UI
{
    public class ProgramUI
    {
        private readonly MenuRepository _menuRepo = new MenuRepository();
        
        static void Main()
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
        private void Run()
        {
            RunMenu();

        }
        private void RunMenu()
        {
            SeedContent();
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Options:\n" +
                    "1. Display Menu\n" +
                    "2. Add Menu Item\n" +
                    "3. Delete Menu Item\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Trim();

                switch (userInput)
                {
                    case "1":
                        DisplayMenuInterface();
                        break;
                    case "2":
                        AddToMenuInterface();
                        break;
                    case "3":
                        DeleteFromMenuInterface();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void DisplayMenuInterface()
        {
            Console.Clear();

            List<MenuItem> menu = _menuRepo.DisplayMenu();


            foreach (MenuItem item in menu)
            {
                Console.WriteLine($"Menu Number: {item.MealNumber}\n" +
                    $"Meal Name: {item.MealName}\n" +
                    $"Description: {item.Description}\n" +
                    $"Ingredients: {item.Ingredients}\n" +
                    $"Price: {item.Price}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void AddToMenuInterface()
        {
            MenuItem menuItem = new MenuItem();
            Console.WriteLine("Hello, please enter the menu number for the new menu item");
            menuItem.MealNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a name for the item");
            menuItem.MealName = Console.ReadLine();

            Console.WriteLine("please enter a description for the item");
            menuItem.Description = Console.ReadLine();

            Console.WriteLine("please list the ingredients");
            menuItem.Ingredients = Console.ReadLine();

            Console.WriteLine("Please enter the price");
            menuItem.Price = Convert.ToInt32(Console.ReadLine());

            _menuRepo.AddToMenu(menuItem);
        }
        private void DeleteFromMenuInterface()
        {
            Console.WriteLine("Please enter a meal name to be deleted");
            string userInput = Console.ReadLine();
            _menuRepo.DeleteMenuItem(userInput);
        }
        private void SeedContent()
        {
            MenuItem pizza = new MenuItem(11, "pizza", "large pie", "pepperoni, cheese, sausage", 5);
            _menuRepo.AddToMenu(pizza);
        }
    }
}

