using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    public class Program
    {
        private readonly BadgeRepository _badgeRepo = new BadgeRepository();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        private void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Options:\n" +
                    "1. Create New Badge\n" +
                    "2. Update Doors On A Badge\n" +
                    "3. Delete All Doors On A Badge\n" +
                    "4. Show All Badges\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Trim();

                switch (userInput)
                {
                    case "1":
                        CreateNewBadgeInterface();
                        break;
                    case "2":
                        UpdateDoorsOnBadgeInterface();
                        break;
                    case "3":
                        DeleteDoorsOnBadgeInterface();
                        break;
                    case "4":
                        DisplayAllBadgesInterface();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void CreateNewBadgeInterface()
        {
            Badge badge = new Badge();
            Console.Clear();
            Console.WriteLine("Please enter an ID number for the new badge");
            badge.BadgeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a door name to be added to the badge's access list");
            badge.DoorAccessList.Add(Console.ReadLine());
            Console.WriteLine("Would you like to enter another door to the badge's access list?");

            string userInput = Console.ReadLine();
            do
            {
                Console.WriteLine("Please enter a door name to be added to the badge's access list");
                badge.DoorAccessList.Add(Console.ReadLine());
            }
            while (userInput == "y");

            _badgeRepo.CreateNewBadge(badge);
        }
        private void UpdateDoorsOnBadgeInterface()
        {
            Console.WriteLine("Please enter the ID of the badge you'd like to update");

            Console.WriteLine("Please enter the new list of doors");
        }
        private void DeleteDoorsOnBadgeInterface()
        {
            Console.WriteLine("Please enter the id of the badge you'd like to delete");
            string userInput = Console.ReadLine();
            //if (userInput == _badgeRepo.)
            {

            }
        }
        private Dictionary<int, List<string>> DisplayAllBadgesInterface()
        {
            return _badgeRepo.ShowAllBadges();
        }
    }
}

