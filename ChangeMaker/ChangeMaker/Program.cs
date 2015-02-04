using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function ChangeAmount 
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);

            //keep console open
            Console.ReadKey();
        }

        /// <summary>
        /// Calculate number of dollars and coins to produce same amount entered and print results.
        /// </summary>
        /// <param name="amount">amount in decimal format (number followed by an 'm')</param>
        /// <returns>Change object for testing</returns>
        public static Change ChangeAmount(decimal amount) 
        {
            //print original total amount before "amount" is brought to 0 with following code, with empty line space following
            Console.WriteLine("AMOUNT: " + "$" + amount);
    //*****HE SHOWS A BETTER WAY TO PRINT CURRENCIES**************
            Console.WriteLine();
            
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();


    //
    //***** LOOK IN DUSTIN'S CODE ON HOW HE TURNED THIS INTO A FUNCTION *********
    //


            //subtract as many quarters ($0.25) from "amount" until under 0.25 remaining, the repeat process with dimes, nickels, and pennies
            while (amount >= 100.00m)
            {
                amount -= 100.00m;
                amountAsChange.Hundreds++;
            }
            while (amount >= 50.00m)
            {
                amount -= 50.00m;
                amountAsChange.Fifties++;
            }
            while (amount >= 20.00m)
            {
                amount -= 20.00m;
                amountAsChange.Twenties++;
            }
            while (amount >= 10.00m)
            {
                amount -= 10.00m;
                amountAsChange.Tens++;
            }
            while (amount >= 5.00m)
            {
                amount -= 5.00m;
                amountAsChange.Fives++;
            }
            while (amount >= 1.00m)
            {
                amount -= 1.00m;
                amountAsChange.Singles++;
            }
            while (amount >= 0.25m)
            {
                amount -= 0.25m;
                amountAsChange.Quarters++;
            }
            while (amount >= 0.10m)
            {
                amount -= 0.10m;
                amountAsChange.Dimes++;
            }
            while (amount >= 0.05m)
            {
                amount -= 0.05m;
                amountAsChange.Nickels++;
            }
            while (amount > 0)
            {
                amount -= 0.01m;
                amountAsChange.Pennies++;
            }

            //outputting to the console
            Console.WriteLine("HUNDREDS: " + amountAsChange.Hundreds);
            Console.WriteLine("FIFTIES: " + amountAsChange.Fifties);
            Console.WriteLine("TWENTIES: " + amountAsChange.Twenties);
            Console.WriteLine("TENS: " + amountAsChange.Tens);
            Console.WriteLine("FIVES: " + amountAsChange.Fives);
            Console.WriteLine("SINGLES: " + amountAsChange.Singles);
            Console.WriteLine("QUARTERS: " + amountAsChange.Quarters);
            Console.WriteLine("DIMES: " + amountAsChange.Dimes);
            Console.WriteLine("NICKELS: " + amountAsChange.Nickels);
            Console.WriteLine("PENNIES: " + amountAsChange.Pennies);

            //two lines spaces added for readability of next ChangeAmount call
            Console.WriteLine();
            Console.WriteLine();

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }
    /// <summary>
    /// Class "Change" to hold properties of Hundreds, Fifties, Twenties, Tens, Five, Singles Quarter, Dimes, Nickels, and Pennies when working with ChangeAmount function
    /// </summary>
    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Hundreds { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Fifties { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Twenties { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Tens { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Fives { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Singles { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickels { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Hundreds = 0;
            this.Fifties = 0;
            this.Twenties = 0;
            this.Tens = 0;
            this.Fives = 0;
            this.Singles = 0;
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickels = 0;
            this.Pennies = 0;
        }
    }
}
