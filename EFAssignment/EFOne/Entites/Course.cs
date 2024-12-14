using EFOne.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entites
{
    public class Course
    {
        //Id,Name,Duration,Discription
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        //Take relationship
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        //Classify relationship
        [ForeignKey(nameof(Topic))]
        public int? TopicId { get; set; }
        public Topic Topic { get; set; }
        //Teach relationship
        public ICollection<InstructorCourse> CoursesInstructors { get; set; } = new HashSet<InstructorCourse>();
    }
}
