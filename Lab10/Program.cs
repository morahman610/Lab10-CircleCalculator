using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool KeepAsking = true;
            int counter = 0;

            Console.WriteLine("Welcome to 360 Calculator.");

            while (KeepAsking)
            {
                Console.WriteLine("Please enter the radius of a circle.");

                string UserInput = Console.ReadLine();
                Circle ThreeSixty = new Circle
                {
                    Radius = ValidateInteger(UserInput)
                };

                Console.WriteLine($"The circumference of the circle is: \n{ThreeSixty.CalculateCircumference(ThreeSixty.Radius)}");
                Console.WriteLine($"The area of the circule is: \n{ThreeSixty.CalculateArea(ThreeSixty.Radius)}");


                counter++;

                KeepAsking = AskToContinue();
            }

            Console.WriteLine($"Thank You for using 360 Calculator! You created {counter} Circle object(s).");
        }

        static double ValidateInteger(string Input)
        {

            return Validator.Validate(Input);


        }

        static bool AskToContinue()
        {
            Console.WriteLine("Enter Y to continue or enter any other key to quit.");
            string UsersAnswer = Console.ReadLine();
            string UsersAnswerLower = UsersAnswer.ToLower();
            if (UsersAnswer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
