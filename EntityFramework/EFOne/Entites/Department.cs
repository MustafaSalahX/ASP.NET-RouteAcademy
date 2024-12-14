using EFOne.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entites
{
    public class Department
    {
        //Id,Name,HiringDate
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly HiringDate { get; set; }
        //Located relationship
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        //Manage relationship
        [ForeignKey(nameof(Manger))]
        public int? MangerId { get; set; }
        [InverseProperty(nameof(Instructor.ManageDepartment))]
        public Instructor Manger { get; set; }
        //Contain relationship
        [InverseProperty(nameof(Instructor.WorkDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
