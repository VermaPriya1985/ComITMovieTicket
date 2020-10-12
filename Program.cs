using System;

namespace comITMovieTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to comIT Movie Theatre");
            Console.WriteLine("Please enter you age");
            string userInput = Console.ReadLine();
            // int age = 15;   
            int age = Convert.ToInt32(userInput);
            if(age< 0 || age > 130)
            {
                Console.WriteLine("Invalid age, please try again");
                return;
            
            }
            double price = 0.0;
            if (age<=5)
            {
                price = 0.0;
            }   
            else if (age>=6 && age<=14)
            {

                price = 7.99;
            }
            else if (age>=15 && age<= 64)
            {
                price = 11.99;
            }
            else
            {
                price = 9.99;
            }
            // If day is tuesday, then price cut half off
        DateTime currentdate = DateTime.Now;
        Console.WriteLine(currentdate.DayOfWeek);
        if(currentdate.DayOfWeek==DayOfWeek.Monday)
        {
            price /= 2;
        }
        double roundprice = Math.Round(price,2);
        Console.WriteLine(roundprice);
        }
    }
}
