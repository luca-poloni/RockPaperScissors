namespace Application.ValueObjects
{
    public sealed record PlayerVO
    {
        public string Name { get; }
        public string HandName { get; }

        public PlayerVO(string name, string handName)
        {
            Name = name;
            HandName = handName;
        }
    }
}
