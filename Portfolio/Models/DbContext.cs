using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class DbContext
    {
        public Profile profile = new Profile(1, "Albin", "Hetemi", "I'm a Programmer, hard working man and ready to learn new things!",
            new List<Educations>
            {
                  new Educations(1,"Universiteti i Prishtines",Convert.ToDateTime("2018-10-1"),Convert.ToDateTime("2021-09-20"),false,"AgroEconomics","Bachelor"),
                  new Educations(2,"Cacttus Education",Convert.ToDateTime("2021-10-25"),Convert.ToDateTime("2023-06-01"),true,"Development of web and mobile applications","Proffesional School")
            }, new List<Experiences>
            {
                 new Experiences(1,"SHPK Besiana",Convert.ToDateTime("2020-06-01"),Convert.ToDateTime("2021-10-01"),false,"Started working in Spare Parts Industry, where I have reponsibilities for selling and buying for missing products as well as new products which are sought by buyers","Sales Manager")
            }, new List<Languages>()
        {
            new Languages(1,"Java",6),
            new Languages(2,"C#",7),
            new Languages(3,"JavaScript",4),
            new Languages(4,"Microsoft Sql Server",7),
            new Languages(5,"Html-5",7),
            new Languages(6,"Css",6),
            new Languages(7,"ReactJS",4)
        }, new List<Skills>
        {
            new Skills(1,"Java",6),
            new Skills(2,"C#",7),
            new Skills(3,"JavaScript",4),
            new Skills(4,"Microsoft Sql Server",7),
            new Skills(5,"Html-5",7),
            new Skills(6,"Css",6),
            new Skills(7,"ReactJS",4),
            new Skills(8,".Net Core",7),
            new Skills(9,".Net Core MVC",7),
            new Skills(10,".Net Core Api",7),
            new Skills(11,"BootStrap",6),
            new Skills(12,".Net Windows Forms",8),
            new Skills(13,"JavaFx",4),
            new Skills(14,"Asp .Net",7)
        });
       
    }
}
