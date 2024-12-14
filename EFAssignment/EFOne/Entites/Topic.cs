using EF.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Topic
    { 
        //Id, Name
        public int Id { get; set; }
        public string Name { get; set; }
        //Classify relationship
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
