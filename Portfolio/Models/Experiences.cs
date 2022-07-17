namespace Portfolio.Models
{
    public class Experiences : BaseAtributtes
    {
        public Experiences(int iD, string instituion, DateTime startDate, DateTime endDate, bool isGoing, string description, string position) : base(iD, instituion, startDate, endDate, isGoing)
        {
            Description = description;
            Position = position;
        }

        public string Description { get; set; }

        public string Position { get; set; }

    }
}
