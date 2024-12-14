using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Department
    {
        public int DepId {  get; set; }
        public string DepName { get; set; }
        List<Employee> Staff;
        public Department()
        {
            Staff = new List<Employee>();
        }
        public void AddStaff(Employee emp)
        {
            if(emp is not null && !Staff.Contains(emp))
            {
                Staff.Add(emp);
                emp.EmployeeLayOff += this.RemoveStaff;
            }
        }
        public void RemoveStaff(object sender , EmployeeLayOffEventArgs e)
        {
            if(sender is Employee E && Staff.Contains(E))
            {
                Staff.Remove(E);
                Console.WriteLine($"The Employee with ID -> {E.EmployeeID} was removed from department beacuse -> {e.Cause}");
            }
        }

    }
}
