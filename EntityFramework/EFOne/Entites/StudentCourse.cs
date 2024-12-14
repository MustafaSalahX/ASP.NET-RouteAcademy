using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    //Take relationship
    public class StudentCourse
    {
        //StudentId, CourseId, Grade
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
    }
}
