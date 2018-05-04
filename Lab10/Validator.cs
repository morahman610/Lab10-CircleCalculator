using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validator
    {
        public static double Validate(string Input)
        {
            while (true)
            {


                if (!(double.TryParse(Input, out double radius)))
                {
                    Console.WriteLine("That was not an integer. Please try again");
                }
                else
                {
                    return radius;
                }

                Input = Console.ReadLine();
            }
        }
    }
}
