using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_exercises
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            /*
                Start with a collection that is of type IEnumerable, which
                List is and initialize it with some values. This is the
                class sizes for a selection of NSS cohorts.
            */
            List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };

            bool isiteleven = cohortStudentCount.All(number => number == 11);
            Console.WriteLine($"{isiteleven} +  isiteleven? ");

            /*
                Now we need to determine which cohorts fell within the range
                of acceptable size - between 20 and 26 students. Also, sort
                the new enumerable collection in ascending order.
            */
            IEnumerable<int> idealSizes = from count in cohortStudentCount
                                          where count < 27 && count > 19
                                          orderby count ascending
                                          select count;

            // Display each number that was the acceptable size
            foreach (int c in idealSizes)
            {
                Console.WriteLine($"{c}");
            }


            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit[0] == 'L'
                                          select fruit;
            Console.WriteLine("Fruits That Begin With 'L':");
            Console.WriteLine("----------");
            foreach (string f in LFruits)
            {
                Console.WriteLine(f);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers
            .Where(number => number % 4 == 0 && number % 6 == 0);

            foreach (int x in fourSixMultiples)
            {
                Console.WriteLine(x);
            }



            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names
                .OrderByDescending(s => s).ToList();


            foreach (string i in descend)
            { Console.WriteLine(i); }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> sortedAscending = numbers2
            .OrderBy(number => number).ToList();

            foreach (int z in sortedAscending)
            { Console.WriteLine(z); }


            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine($"There are {numbers3.Count} numbers in the list");

            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };
            Console.WriteLine($"How much money have we made? {purchases.Sum()};");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine($"Our most expensive product: {prices.Max()}");
            Console.WriteLine($"");

            /*
                Store each number in the following List until a perfect square
                is detected.
                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = (new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            }).TakeWhile(num => (Math.Sqrt(num)) % 1 != 0)
            .ToList();

            foreach (int z in wheresSquaredo)
            { Console.WriteLine(z); };



            //using custom types
            // Build a collection of customers who are millionaires


                List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            // Given the same customer set, display how many millionaires per bank.
        // Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

        // Example Output:
        // WF 2
        // BOA 1
        // FTB 1
        // CITI 1

    }
}
}
