using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim
{
    public class Program
    {
        private readonly ClaimRepository _claimRepo = new ClaimRepository();
        static void Main()
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
            //SeedContent();
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Options:\n" +
                    "1. Display Claim Directory\n" +
                    "2. Take Care Of Next Claim\n" +
                    "3. Add A Claim\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Trim();

                switch (userInput)
                {
                    case "1":
                        DisplayDirectoryInterface();
                        break;
                    case "2":
                        DisplayNextClaimInterface();
                        break;
                    case "3":
                        AddNewClaimInterface();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void DisplayDirectoryInterface()
        {
            Console.Clear();

            List<Claim> directory = _claimRepo.DisplayDirectory();

            foreach (Claim claim in directory)
            {
                Console.WriteLine($"Claim ID: {claim.ClaimID}\n" +
                    $"Claim Type: {claim.ClaimType}\n" +
                    $"Description: {claim.Description}\n" +
                    $"Date Of Incident: {claim.DateOfIncident}\n" +
                    $"Date Of Claim: {claim.DateOfClaim}\n" +
                    $"Valid: {claim.IsValid}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void AddNewClaimInterface()
        {
            Claim claim = new Claim();
            Console.WriteLine("Hello, please enter a claim ID number");
            claim.ClaimID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a claim type (ex. Car, Home, Theft)");
            claim.ClaimType = Console.ReadLine();
            Console.WriteLine("please enter the Date of the claim");
            claim.DateOfClaim = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("please enter the Date of the incident");
            claim.DateOfIncident = DateTime.Parse(Console.ReadLine());

            _claimRepo.AddNewClaim(claim);
        }
        private void DisplayNextClaimInterface()
        {

            Console.WriteLine($"{_claimRepo.GetFirstListItem()}");
            Console.WriteLine("Would You Like To Deal With This Claim Now? y or n?");
            string userInput = Console.ReadLine();
            userInput = userInput.Trim();
            if (userInput == "y")
            {
                _claimRepo.RemoveFromDirectory();
                Console.WriteLine("Item Removed");
            }
            else
            {
                Console.WriteLine("Press Enter To Continue");
            }
            Console.ReadKey();
        }
        private void SeedContent()
        {
           // Claim seedOne = new Claim( 1, "Car", "Zebra Attack", "1967, 12, 1, 0, 0", )
        }
    }
}