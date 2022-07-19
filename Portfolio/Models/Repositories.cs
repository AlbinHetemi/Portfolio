namespace Portfolio.Models
{
    public class Repositories
    {
        public Repositories(int iD, string name, string description, bool isActive)
        {
            ID = iD;
            Name = name;
            Description = description;
            IsActive = isActive;
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Languages Languages { get; set; }

        public bool IsActive { get; set; }  


       
    }
}
