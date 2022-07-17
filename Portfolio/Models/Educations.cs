namespace Portfolio.Models
{
    public class Educations : BaseAtributtes
    {
        public Educations(int iD, string instituion, DateTime startDate, DateTime endDate, bool isGoing, string direction, string grade)
            : base(iD, instituion, startDate, endDate, isGoing)
        {
            Direction = direction;
            Grade = grade;
        }

        public string Direction { get; set; }
        public string Grade { get; set; }
    }
}
