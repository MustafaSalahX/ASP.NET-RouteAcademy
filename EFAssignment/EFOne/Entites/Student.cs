using EF.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Student
    {
        //Id, FName, LName, Address, Age
        public int Id { get; set; }
        public string FName { get; set; }
        public  string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        //Take relationship
        public ICollection<StudentCourse> StudentCourses = new HashSet<StudentCourse>();
        //Located relationship
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
