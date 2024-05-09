namespace AreaCalculator.Erros
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message): base(message) 
        { 
        }
    }
}
