using System;

namespace ruz_AI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello i am luke");

            method1();
        }


        private static void method1()
        {
            Console.WriteLine("Enter Your Name.");
            string name1 = Console.ReadLine();

            Console.WriteLine($"Hello {name1}.");
            Console.WriteLine($"What game do you play?\n{name1}!");

            String gamename = Console.ReadLine();
            Console.WriteLine($"What's your level in {gamename}");
            string gamelvl = Console.ReadLine();
            int gamelevel = Convert.ToInt32(gamelvl);
            if (gamelevel < 15)
            {
                Console.WriteLine("Ha! Ha!..");
            }

            else if (gamelevel < 40)
            {
                Console.WriteLine("noobs..");
            }
            else if (gamelevel > 60)
            {
                Console.WriteLine("Superb........");
            }

            else 
            {
                Console.WriteLine("Good.");
            }

        }







        private static void methodt()
        {
            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            if (age < 3)
            {
                Console.WriteLine("you are just born");
            }
            else if (age > 60)
            {
                Console.WriteLine("you have to be below 45 years old.\nTo transact.");
            }
            else if (age < 18)
            {
                Console.WriteLine("your age is below 18 years old. \nyou can't transact.");
            }
            else if (age < 16)
            {
                Console.WriteLine("complete your high school.");
            }

            else
            {
                Console.WriteLine("please continue.");
            }
        }


    }
}
