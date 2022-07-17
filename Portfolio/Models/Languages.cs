namespace Portfolio.Models
{
    public class Languages
    {
        public Languages(int id, string name, int level)
        {
            Id = id;
            Name = name;
            Level = level;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

    }
}
