using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    //Teach relationship

    public class InstructorCourse
    {
        //InstructorId, CourseId, Evaluation
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string? Evaluation { get; set; }

    }
}
