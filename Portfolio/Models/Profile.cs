namespace Portfolio.Models
{
    public class Profile 
    {
        public Profile(int iD, string name, string surname, string description, List<Educations> educations, List<Experiences> experiences, List<Languages> languages, List<Skills> skills,List<Repositories> repositories)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Description = description;
            Educations = educations;
            Experiences = experiences;
            Languages = languages;
            Skills = skills;
            Repositories = repositories;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }

        public List<Educations> Educations { get; set; }
        public List<Experiences> Experiences { get; set; }

        public List<Languages> Languages { get; set; }
        
        public List<Skills> Skills { get; set; }

        public List<Repositories> Repositories { get; set; }

    }
}
