using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        private double circumference;
        private double Area;

        public double CalculateCircumference(double Formattedcircumference)
        {
            circumference = double.Parse(CalculateFormattedCircumference(Formattedcircumference));
            return circumference;

        }

        public string CalculateFormattedCircumference (double radius)
        {
            double FormattedCircumference = Math.Round(2 * Math.PI * radius, 2);
            return FormattedCircumference.ToString();
        }

        public double CalculateArea(double FormattedArea)
        {
            Area = double.Parse(CalculateFormattedArea(FormattedArea));
            return Area;
        }

        public string CalculateFormattedArea (double radius)
        {
            double FormattedArea = Math.Round(Math.PI * radius * radius, 2);
            return FormattedArea.ToString();
        }

    }
}
