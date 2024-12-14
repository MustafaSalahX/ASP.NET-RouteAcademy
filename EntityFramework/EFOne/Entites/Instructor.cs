using EF.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Instructor
    {
        //Id,Name,Bonus,Salary,Address,HoureRate
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        //Teach relationship
        public ICollection<InstructorCourse>InstructorCourses {  get; set; } = new HashSet<InstructorCourse>();
        //Manage relationship
        [InverseProperty(nameof(Department.Manger))]
        public Department ManageDepartment { get; set; }
        //Contain relationship
        [InverseProperty(nameof(Department.Instructors))]
        public Department WorkDepartment { get; set; }
        public int? DepartmentId { get; set; }

    }
}
