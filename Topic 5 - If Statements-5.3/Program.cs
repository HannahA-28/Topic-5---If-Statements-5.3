namespace Topic_5___If_Statements_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //Console.WriteLine("What is your age?");
            //int.TryParse(Console.ReadLine(), out age);
            //{
            //    if (age >= 13 && age <= 19)
            //        Console.WriteLine("They are a teenager!");
            //    else
            //        Console.WriteLine("They are not a teenager!");
            //}

            //int money;
            //string working;
            //Console.WriteLine("How much money do you have?");
            //int.TryParse(Console.ReadLine(), out money);
            //Console.WriteLine("Are you working?");
            //working = Console.ReadLine();
            //if (working == "no"&& money >= 20)
            //    Console.WriteLine("You can go to the movies!");
            //else
            //    Console.WriteLine("You can't go to the movies!");

            //string password;
            //int guesses;
            //Console.WriteLine("What is the password? You have 5 guesses.");
            //int.TryParse(Console.ReadLine(), out guesses);
            //password = Console.ReadLine();
            //if (password == santa&& guesses <= 5)
            //    Console.WriteLine("Open Sesame.");
            //else
            //    Console.WriteLine("Access Denied.");

            string topping;
            Console.WriteLine("What are your favourite pizza toppings?");
            topping = Console.ReadLine();
            if (topping == pepperoni || topping == bacon)
                Console.WriteLine("Yum!");
            else
                Console.WriteLine("Yuck!");
            

        }
    }
}
