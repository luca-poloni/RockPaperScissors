namespace Domain.Exceptions
{
    public sealed class InvalidHandException : Exception
    {
        private const string DEFAULT_MESSAGE = "The hand is invalid.";
        public InvalidHandException() : base(DEFAULT_MESSAGE) { }
    }
}