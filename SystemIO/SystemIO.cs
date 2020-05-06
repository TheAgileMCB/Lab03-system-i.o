using System;

namespace SystemIO
{
    public class SystemIO
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("THE Bucket List");
            Console.Write("1. Add an adventure \n2. Remove an adventure \n3. View your adventures \n4. Exit \n\n");
            Console.WriteLine("Type the corresponding number to the option you'd like to choose:");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                AddAdventure();
            }
            else if (userInput == "2")
            {
                RemoveAdventure();
            }
            else if (userInput == "3")
            {
                ViewAdventures();
            }
            else
            {
               
            }
        }

        public static string AddAdventure()
        {
            return "add";
        }
        public static string RemoveAdventure()
        {
            return "remove";
        }
        public static string ViewAdventures()
        {
            return "view";
        }

    }
}
