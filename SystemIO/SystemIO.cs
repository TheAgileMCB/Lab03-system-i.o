using System;
using System.IO;
using System.Linq;

namespace SystemIO
{
    public class SystemIO
    {
        public static void Main(string[] args)
        {
            BeginBucketList(path);
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
                    ViewAdventures(path);
                    return true;

                case "2":
                    Console.WriteLine("Add your adventure!");
                    string newAdventure = Console.ReadLine();
                    AddAdventure(path, newAdventure);
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


        public static string path = "BucketList.txt";


        public static void BeginBucketList(string path)
        {
            string[] heading = new[] { "Welcome to THE Bucket List. Your desires await you." };
            File.WriteAllLines(path, heading);
        }


        public static void AddAdventure(string path, string newAdventure)
        {
            string[] content = new[] { newAdventure };
            File.AppendAllLines(path, content);
            Console.WriteLine("Awesome idea! Your rad adventure has been added!");
           
        }


        public static string RemoveAdventure()
        {
            return "remove";
        }
        public static string[] ViewAdventures(string path)
        {
            return File.ReadAllLines(path);

        }

    }
}
