using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    //Enum for Months
    public enum Months {Jan, Feb, March, April, May, June, July, August, Sept, Oct, Nov, Dec }
    class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            int userMonth;

            //Asks user for Month
            Console.WriteLine("Please enter the number for this month: ");
            userInput = Console.ReadLine();
            userMonth = Convert.ToInt32(userInput);

            //If statement to make sure user enter legal number
            if (userMonth < 1 || userMonth> 12)
            {
                Console.WriteLine("Invalid choice");
            }
            else{
                // Call enum and find the right value
                Months answer = (Months)userMonth - 1;

                //Display answer
                Console.WriteLine(answer);
            }
        }
    }
}
