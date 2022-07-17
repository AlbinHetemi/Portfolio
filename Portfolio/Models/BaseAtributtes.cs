namespace Portfolio.Models
{
    public abstract class BaseAtributtes
    {
        protected BaseAtributtes(int iD, string instituion, DateTime startDate, DateTime endDate, bool isGoing)
        {
            ID = iD;
            Instituion = instituion;
            StartDate = startDate;
            EndDate = endDate;
            IsGoing = isGoing;
        }

        public int ID { get; set; }
        public string Instituion { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsGoing { get; set; }

    }
}
