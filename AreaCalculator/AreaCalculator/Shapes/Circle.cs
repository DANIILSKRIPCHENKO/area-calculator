using AreaCalculator.Abstractions;
using AreaCalculator.Erros;

namespace AreaCalculator.Shapes
{
    public class Circle : Shape
    {
        private Circle(double r)
        {
            R = r;
        }

        public double R { get; private set; }

        public override double GetArea() => Math.PI * Math.Pow(R, 2);

        /// <summary>
        /// Creates a new instance of class <see cref="Circle" />
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        /// <exception cref="InvalidInputException">Inavlid input params</exception>
        public static Circle Create(double r)
        {
            if (r <= 0) throw new InvalidInputException($"R should be positive number");
            
            return new Circle(r);
        }
    }
}
