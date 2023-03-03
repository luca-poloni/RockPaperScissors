namespace Domain.Exceptions
{
    internal sealed class EqualsHandsException : Exception
    {
        private const string DEFAULT_MESSAGE = "The hands are equals.";
        internal EqualsHandsException() : base(DEFAULT_MESSAGE) { }
    }
}
