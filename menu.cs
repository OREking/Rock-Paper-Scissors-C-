using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What option would u like:");
            Console.WriteLine("1. linear search");
            Console.WriteLine("2. code count Occurances ");
            Console.WriteLine("3. Rock Paper Scissors");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Linearsearch();
            }
            if (choice == 2 )
            {
                CCO();
            }
            if (choice == 3)
            {
                RPS();
            }
            
        }
        public static void CCO()
        {
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("Linear search");
            Console.WriteLine("well u dont have a choice");
            int[] myArray = { 10, 45, 23, 10, 10, 11, 89, 10 };
            int searchvalue = 10;
            int count = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] == searchvalue)
                {
                    count = count + 1;
                }

            }
            if (count > 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("There is no count");
            }
        }
        public static void Linearsearch()
        {
            int[] mynumber = { 13, 48, 7, 4, 15, 25, 11 };
            Console.WriteLine("Enter the value to be searched");
            int value = Convert.ToInt32(Console.ReadLine());
            Boolean found = false;
            int i = 0;
            while (found == false && i<= mynumber.Length -1)
            {
                if (value == mynumber[i])
                {
                    found = true;
                    break;
                }
                i = i + 1;
            }
            if (found = true)
            {
                Console.WriteLine("The item is in the list at position"+ i);
            }
            else
            {
                Console.WriteLine("Item is not in the list");
            }
        }
        public static void RPS()
        {
            Console.WriteLine("Do you choose rock,paper or scissors");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("It is a tie ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("It is a tie ");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose,paper beat rock");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,scissors beat paper ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose,rock beats scissors");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,rock beats scissors");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,paper beats rock");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors beat paper");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            Console.ReadLine();
        }
    }
}

    

