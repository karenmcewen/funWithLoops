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
            ////foreach loops - used to iterate over a collection
            //string[] months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            //foreach(string month in months)
            //{

            //    if(month=="dec")
            //    {
            //        Console.WriteLine(month + " is the best month!");
            //    }
            //    else
            //        Console.WriteLine(month + " is okay, too");
            //}

            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "nas", "Jarryd" };
            //foreach(string band in musicians)
            //{
            //    Console.WriteLine(band);
            //}

            ////Create a program that asks the user for their 3 fav food and stores them in an array
            ////loop through the array and print all of the foods

            //string[] favFoods = new string[3];
            //Console.WriteLine("What is your first favorite food?");
            //favFoods[0] = Console.ReadLine();
            //Console.WriteLine("What is your second favorite food?");
            //favFoods[1] = Console.ReadLine();
            //Console.WriteLine("What is your third favorite food?");
            //favFoods[2] = Console.ReadLine();

            //Console.WriteLine("You chose the following three favorite foods: ");
            //foreach(string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}


            ////create an array of lucky numbers using a foreach loop  & print the following:
            ////Your lucky number is: 4
            ////Your lucky number is: 19
            ////Your lucky number is: 7

            //int[] luckyNumber = { 4, 19, 7 };
            //foreach (int number in luckyNumber)
            //{
            //    Console.WriteLine("Your lucky number is: "+ number);
            //}

            ////create a string array then make them each lowercase
            //string[] names = { "Jordan", "Max", "Peter" };
            ////foreach(string name in names) //name is a temporary variable that doesn't exist outside the foreach loop
            //{
            //    //name = name.ToLower; this won't work because 'name' doesn't exist outside the loop
            //    //need to use a 'for' loop instead
            //}
            //for (int i=0; i< names.Length; i++) //"i" is a temporary variable used to update; i++ increments by 1
            //{
            //    names[i] = names[i].ToLower(); //makes each entry lowercase and puts back in original array
            //    Console.WriteLine(names[i]);

            //}

            ////print out 1 to 10/odd numbers/50 to 100
            //for (int counter = 50; counter <= 100; counter++) //could use counter +=2 to get every other number
            //{
            //    Console.WriteLine(counter);
            //}


            //use FOREACH loop to print out contents of strings - shows that strings are character arrays!
            //string words = "I like cake";
            //foreach(char letter in words)
            //{
            //    Console.WriteLine(letter);
            //}

            //string greetings = "My name is Jordan";
            //string[] words = greetings.Split();
            //for(int i = 0; i<words.Length; i++) //remember that array indices start at 0 not at 1
            //{
            //    Console.WriteLine(words[i]);
            //    if(words[i] == "Jordan")
            //    {
            //        words[i] = "Max"; //for loop allows us to change the array
            //    }
            //}
            //Console.WriteLine(words[words.Length - 1]);

            //create an array called days with the elements monday tuesday etc...
            //use a FOR loop to print the elememts to the console

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i<days.Length;i++)
            {
            //    Console.WriteLine(days[i]);
            //}
           
            ////create an int array size 25 using NEW, then put the numbers 1 to 25 into the array and print to console

            //int[] numbers = new int[25];
            //for (int i = 0; i<numbers.Length;i++)
            //{
            //    numbers[i] = i+1;
            //    Console.WriteLine(numbers[i]);
            //}//numbers[0]=1;...numbers[24]=25

            
            ////start with the string 'once upon a time' and create an array called storywords using the split method 
            ////reverse the order of the elements in the array
            ////and using a for loop, print each word.

            //string story = "Once upon a time";
            //string[] storyWords = story.Split();//default for 'split' is to break at the white space
            //Array.Reverse(storyWords, 0, storyWords.Length);//reverses the array
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            }

            //WHILE loops - only execute if the condition is TRUE and breaks when the condition becomes FALSE
            //danger! there is the possibility of creating an infinite loop where the condition never becomes FALSE

            //Console.WriteLine("Do you want to play a game (yes/no): ");
            //string playAgain = Console.ReadLine();
            //while (playAgain.ToLower() == "yes")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("And another???");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("What is your favorite ROYGBIV color?");
            //string userColor = Console.ReadLine();
            ////bool isRoygbiv = false; //initial value - for BOOL type often name the variable isWhatever
            //while(userColor != "red"  && userColor != "orange" &&  userColor != "blue" && userColor != "indigo" && userColor != "yellow" && userColor != "green" && userColor != "violet")
            //{
            //    Console.WriteLine("Sorry, that is not an acceptable color. Please input color again.");
            //    userColor = Console.ReadLine();
            //}


            ////DO WHILE loops - the body runs first before checking the condition - so it will run at least one time
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snow person?(yes/no)");
            //    playAgain = Console.ReadLine();
            //    Console.WriteLine("That was fun!");
            //}
            //while (playAgain.ToLower() == "yes");
            //Console.WriteLine("Thanks for building with me today!");

            //BREAK - breaks out of the loop immediately - rare to use it
            //often used when there is an error occurring - generally if you write your code well, you won't need this
            //break decreases the readability of code
            //CONTINUE skips over an iteration - might use to keep from dividing by zero!
            for (int i = 0; i < 10; i++)
            {
              
                if (i%2 == 0)
                {
                    continue; // this will skip the even numbers and goes to the next iteration immediately
                }
                Console.WriteLine(i); //if i is even, this will not print
            }


            //---------------------------------------------------------------------------
        }
    }
}
