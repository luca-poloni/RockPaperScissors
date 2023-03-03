namespace Domain.Exceptions
{
    internal sealed class InvalidHandException : Exception
    {
        private const string DEFAULT_MESSAGE = "The hand is invalid.";
        internal InvalidHandException() : base(DEFAULT_MESSAGE) { }
    }
}