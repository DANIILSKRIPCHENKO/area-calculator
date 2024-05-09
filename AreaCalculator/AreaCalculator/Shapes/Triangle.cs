using AreaCalculator.Abstractions;
using AreaCalculator.Erros;

namespace AreaCalculator.Shapes
{
    public class Triangle : Shape
    {
        private Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        public override double GetArea()
        {
            var semiPerimeter = (A + B + C) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        /// <summary>
        /// Ruturns true if one of the angles is 90 degrees
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            var sides = new List<double>
            {
                A, B, C,
            };

            var sortedSides = sides.OrderBy(side => side).ToList();

            return Math.Pow(sortedSides[2], 2) == Math.Pow(sortedSides[1], 2) + Math.Pow(sortedSides[0], 2);
        }

        /// <summary>
        /// Creates a new instance of class <see cref="Triangle" />
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="InvalidInputException"></exception>
        public static Triangle Create(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new InvalidInputException($"Triangle sides should be positive numbers");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new InvalidInputException("Each triangle side lenght should be less then sum of the others side lengths");

            return new Triangle(a, b, c);
        }
    }
}
