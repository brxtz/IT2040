using System;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            if(sample1 == sample2)
            {
                Console.WriteLine("\nThe samples are equal.");
            }
            else
            {
                Console.WriteLine("\nThe samples are not equal.");   
            }
            

            int heartRate = 85;
            if(heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("\nHeart rate is normal.");
            }
            else
            {
                Console.WriteLine("\nHeart rate is not normal.");
            }

            double deposits = 135002796;
            if(deposits >= 100000000)
            {
                Console.WriteLine("\nYou are exccedingly wealthy.\n");
            }
            else
            {
                Console.WriteLine("\nSorry you are so poor.\n");
            }


            const float acceleration = 9.800F;
            float mass = 14.6F;

            float force = acceleration * mass;
            Console.WriteLine($"force = {force}\n");


            double distance = 129.763001;
            Console.WriteLine($"{distance} is the distance.\n");
            

            bool lost = true;
            bool expensive = true;
            if(lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if(lost != true && expensive != true)
            {
                Console.WriteLine("Here is your 10% off.");
            }

            int choice = 2;
            switch (choice)
            {
                case 1:
                Console.WriteLine("\nYou chose 1.");
                break;

                case 2:
                Console.WriteLine("\nYou chose 2.");
                break;

                case 3:
                Console.WriteLine("\nYou chose 3.");
                break;
                
                default:
                Console.WriteLine("\nYou made an unknown choice.");
                break;
            }


            const char integral = '\u222B';
            Console.WriteLine($"\n{integral} is an integral.\n");


            for(int i = 5; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine("\n");
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine($"age = {age}");
                age++;

            }

            Console.WriteLine("\n");
            const string greeting = "Hello";
            string name = "Karen";     
            Console.WriteLine($"{greeting} {name}\n");


        }
    }
}
