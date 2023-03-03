using System.ComponentModel.DataAnnotations;

namespace Application.Aggregates
{
    public sealed record PlayerAggregate
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(3, ErrorMessage = "Minimum Length for Name is 3 characters.")]
        [MaxLength(100, ErrorMessage = "Maximum Length for Name is 100 characters.")]
        public string Name { get; }

        [Required(ErrorMessage = "Hand Name is required.")]
        [MinLength(4, ErrorMessage = "Minimum Length for Hand Name is 4 characters.")]
        [MaxLength(8, ErrorMessage = "Maximum Length for Hand Name is 8 characters.")]
        public string HandName { get; }

        public PlayerAggregate(string name, string handName)
        {
            Name = name;
            HandName = handName;
        }
    }
}
