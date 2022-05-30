using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Party Guest  Book");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            Console.Write("Please enter your party/group name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;
            do
            {
                Console.Write("How many people are in your party? ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output); 

            } while (isValidNumber == false);

            return output;

        }

        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guests = new();
            do
            {
                guests.Add(GetPartyName());

                totalGuests += GetPartySize();
            } while (AskToContinue());

            return (guests, totalGuests);   
        }

        public static bool AskToContinue()
        {
            Console.Write("Are there more guests coming? (yes/no) ");
            string continueLooping = Console.ReadLine();

            bool output = (continueLooping.ToLower() == "yes");

            return output;
        }

        public static void DisplayGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.Write(guest);
            }
        }

        public static void DisplayGuestCount(int totalGuests)
        {
            Console.WriteLine("Thank you for everyone who attended.");

            Console.WriteLine($"The total guests count for the evening was {totalGuests}.");
        }
        

    }

}
