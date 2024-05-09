using AreaCalculator.Abstractions;
using AreaCalculator.Erros;
using AreaCalculator.Shapes;
using FluentAssertions;
using Xunit;

namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Create_ZeroR_ShouldThrowException()
        {
            var r = 0;

            Action act = () => Circle.Create(r);

            act.Should().Throw<InvalidInputException>();
        }

        [Fact]
        public void Create_NegativeR_ShouldThrowException()
        {
            var r = -10;

            Action act = () => Circle.Create(r);

            act.Should().Throw<InvalidInputException>();
        }

        [Fact]
        public void Create_ValidR_ShouldNotThrow()
        {
            var r = 10;

            Action act = () => Circle.Create(r);

            act.Should().NotThrow();
        }

        [Fact]
        public void GetArea_ShouldReturnCorrect()
        {
            var r = 10;

            var circle = Circle.Create(r);

            var area = circle.GetArea();

            area.Should().Be(Math.PI * Math.Pow(r,2));
        }
    }
}