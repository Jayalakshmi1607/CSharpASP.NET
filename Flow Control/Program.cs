using System;

namespace Flow_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int n = r.Next(-5, 5);
            Console.WriteLine(n);
            if(n>0)
            {
                Console.WriteLine("It is a positive number");
            }
            else if(n==0)
            {
                Console.WriteLine("It is zero");
            }
            else
            {
                Console.WriteLine("it is a negative number");
            }
            Console.WriteLine("enter ur country");
            string country;
            country = Console.ReadLine();
            country = country.Trim().ToLower();
            string result = country switch
            {
                "india" => "India",
                "us" => "United States",
                "de" => "Germany",
                "sk" => "Slovakiya",
                _ => "Unknown"
            };
            Console.WriteLine(result);
            Console.WriteLine("Enter ur age");
            var Age = Console.ReadLine();
            var age = Int32.Parse(Age.Trim());
            switch(age)
            {
                case var myAge when age < 18:
                    {
                        Console.WriteLine("Your aren't eligible to vote");
                        break;
                    }
                case var myAge when age >= 18:
                    {
                        Console.WriteLine("You are eligible to vote");
                        break;
                    }
            }
            int x = 0;
            while(x<20)
            {
                x++;
                if(x%5==0)
                {
                    continue;
                }
                else if(x==18)
                {
                    break;
                }
                Console.WriteLine(x);
            }
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            Console.WriteLine("Planets of solar system");
            foreach(string planet in planets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
