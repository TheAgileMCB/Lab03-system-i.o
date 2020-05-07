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
                    string[] adventures = ViewAdventures(path);
                    Console.Write(adventures);
                    return true;

                case "2":
                    Console.WriteLine("Add your adventure!");
                    string newAdventure = Console.ReadLine();
                    AddAdventure(path, newAdventure);
                    return true;

                case "3":
                    Console.WriteLine("Changed your mind? Remove an adventure!");
                    string badAdventure = Console.ReadLine();
                    RemoveAdventure(path, badAdventure);
                    return true;

                case "4":
                    Console.WriteLine("Goodbye.");
                    return false;

                default:
                    return true;
            }
        }


        private static string path = "BucketList.txt";

        public static string GetPath()
        {
            return path;
        }


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


        public static void RemoveAdventure(string path, string badAdventure)
        {
            string[] adventures = File.ReadAllLines(path);

            string[] result = RemoveItemFromArray(adventures, badAdventure);

            File.WriteAllLines(path, result);
        }
        public static string[] ViewAdventures(string path)
        {
            return File.ReadAllLines(path);

        }

        public static string[] RemoveItemFromArray(string[] array, string badAdventure)
        {
            int valueCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == badAdventure) 
                {
                    valueCount++;
                }
            }
            string[] result = new string[array.Length - 1];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] != badAdventure)
                {
                    result[j++] = array[i];
                }
            }
            return result;
        }

            
    }
}
