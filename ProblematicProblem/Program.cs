using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
    
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? Yes/No: ");
            var userInput = Console.ReadLine();
            bool cont;
            if (userInput.ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            var userInput2 = Console.ReadLine();
            bool seeList;
            if (userInput2.ToLower() == "sure")
            {
                seeList = true;
            }
            else
            {
                seeList = false;
            }


            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                var userInput3 = Console.ReadLine();
                bool addToList;
                if (userInput3.ToLower() == "yes")
                {
                    addToList = true;
                }
                else
                {
                    addToList = false;
                }

                Console.WriteLine();

                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    var userInput4 = Console.ReadLine();
                    bool listAddition;
                    if (userInput4.ToLower() == "yes")
                    {
                        listAddition = true;
                    }
                    else
                    {
                        listAddition = false;
                    }
                    if (listAddition == false)
                    {
                        break;
                    }
                }
            }
            
            while (cont)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);

                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    int number = rng.Next(activities.Count);
                    string activity = activities[randomNumber];
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    

                    
                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                var userInput5 = Console.ReadLine();
                if (userInput5.ToLower() == "keep")
                {
                    cont = false;
                }
                else
                {
                    cont = true;
                }
               
            }
        }
    }
}
