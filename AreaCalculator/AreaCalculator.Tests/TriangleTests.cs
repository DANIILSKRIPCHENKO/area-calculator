using AreaCalculator.Erros;
using AreaCalculator.Shapes;
using FluentAssertions;
using Xunit;

namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Create_ZeroSide_ShouldThrowException()
        {
            var a = 5;
            var b = 4;
            var c = 0;

            Action act = () => Triangle.Create(a, b, c);

            act.Should().Throw<InvalidInputException>();
        }

        [Fact]
        public void Create_NegativeSide_ShouldThrowException()
        {
            var a = 5;
            var b = 4;
            var c = -1;

            Action act = () => Triangle.Create(a, b, c);

            act.Should().Throw<InvalidInputException>();
        }

        [Fact]
        public void Create_InvalidSides_ShouldThrowException()
        {
            var a = 3;
            var b = 4;
            var c = 100;

            Action act = () => Triangle.Create(a, b, c);

            act.Should().Throw<InvalidInputException>();
        }

        [Fact]
        public void Create_ValidSides_ShouldNotThrow()
        {
            var a = 8;
            var b = 9;
            var c = 10;

            Action act = () => Triangle.Create(a, b, c);

            act.Should().NotThrow();
        }

        [Fact]
        public void GetArea_ShouldReturnCorrect()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var triangle = Triangle.Create(a, b, c);

            var area = triangle.GetArea();

            area.Should().Be(6);
        }

        [Fact]
        public void IsRight_Right_ShouldReturnTrue()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var triangle = Triangle.Create(a, b, c);

            var isRight = triangle.IsRight();

            isRight.Should().Be(true);
        }
        
        [Fact]
        public void IsRight_NotRight_ShouldReturnFalse()
        {
            var a = 10;
            var b = 11;
            var c = 12;

            var triangle = Triangle.Create(a, b, c);

            var isRight = triangle.IsRight();

            isRight.Should().Be(false);
        }
    }
}
