using Domain.Exceptions;
using Domain.Interfaces;
using Domain.Implementations;

namespace Domain.Factories
{
    public static class HandFactory
    {
        public static IHand Create(string name)
        {
            switch (name.ToUpper())
            {
                case "ROCK":
                    return new Rock();
                case "PAPER":
                    return new Paper();
                case "SCISSORS":
                    return new Scissors();
                default:
                    throw new InvalidHandException();
            }
        }
    }
}
