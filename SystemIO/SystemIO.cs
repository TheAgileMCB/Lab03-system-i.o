using System;

namespace SystemIO
{
    public class SystemIO
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            Console.WriteLine("THE Bucket List");
            Console.Write("\nMain Menu \n\n1. View your adventures \n2. Add an adventure \n3. Remove an adventure \n4. Exit \n\n");
            Console.WriteLine("Type the corresponding number to the option you'd like to choose:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ViewAdventures();
                    return true;

                case "2":
                    AddAdventure();
                    return true;

                case "3":
                    RemoveAdventure();
                    return true;

                case "4":
                    Console.WriteLine("Goodbye.");
                    return false;

                default:
                    return true;
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
