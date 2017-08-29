using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops - used to iterate over a collection
            string[] months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            foreach(string month in months)
            {
              
                if(month=="dec")
                {
                    Console.WriteLine(month + " is the best month!");
                }
                else
                    Console.WriteLine(month + " is okay, too");
            }
               
            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "nas", "Jarryd" };
            foreach(string band in musicians)
            {
                Console.WriteLine(band);
            }

            //Create a program that asks the user for their 3 fav food and stores them in an array
            //loop through the array and print all of the foods

            string[] favFoods = new string[3];
            Console.WriteLine("What is your first favorite food?");
            favFoods[0] = Console.ReadLine();
            Console.WriteLine("What is your second favorite food?");
            favFoods[1] = Console.ReadLine();
            Console.WriteLine("What is your third favorite food?");
            favFoods[2] = Console.ReadLine();

            Console.WriteLine("You chose the following three favorite foods: ");
            foreach(string food in favFoods)
            {
                Console.WriteLine(food);
            }


            //create an array of lucky numbers using a foreach loop  & print the following:
            //Your lucky number is: 4
            //Your lucky number is: 19
            //Your lucky number is: 7

            int[] luckyNumber = { 4, 19, 7 };
            foreach (int number in luckyNumber)
            {
                Console.WriteLine("Your lucky number is: "+ number);
            }

        }
    }
}
