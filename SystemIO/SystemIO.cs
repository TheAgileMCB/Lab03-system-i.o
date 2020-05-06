using System;
using System.IO;
using System.Linq;

namespace SystemIO
{
    public class SystemIO
    {
        public static void Main(string[] args)
        {
            OpenDocument(path);
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
                    AddAdventure(path);
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

        private static string path = "BucketList.txt";

        public static void OpenDocument(string path)
        {
        string[] heading = new[] { "Welcome to THE Bucket List. Your desires await you." };
        File.WriteAllLines(path, heading);
        }

        public static string AddAdventure(string path)
        {
            // Console.WriteLine(path);
            //string path = "BucketList.txt";

            Console.WriteLine("Add your adventure!");

            string[] content = new[] { Console.ReadLine() };
            File.AppendAllLines(path, content);
            return path;
        }
        public static string RemoveAdventure()
        {
            return "remove";
        }
        public static string ViewAdventures(string path)
        {
            //if (path == false)
            //{
            //    Console.WriteLine("Please add an adventure!");
            //}
            //else
            //{
            //    File.WriteAllLines(path);
            //}

            return "view";
        }

    }
}
