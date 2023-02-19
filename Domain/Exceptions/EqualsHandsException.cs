namespace Domain.Exceptions
{
    public class EqualsHandsException : Exception
    {
        private const string DEFAULT_MESSAGE = "The hands are equals.";
        public EqualsHandsException() : base(DEFAULT_MESSAGE) { }
    }
}
