namespace Portfolio.Models
{
    public class Skills
    {
        public Skills(int iD, string name, int level)
        {
            ID = iD;
            Name = name;
            Level = level;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
