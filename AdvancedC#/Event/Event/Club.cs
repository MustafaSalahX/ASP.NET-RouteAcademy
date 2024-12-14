using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        List<Employee> Members;
        public Club()
        {
            Members = new List<Employee>();
        }
        public void AddMember(Employee emp)
        {
            if(emp is not null && !Members.Contains(emp))
            {
                emp.EmployeeLayOff += this.RemoveMember;
                Members.Add(emp);
            }
        }
        public void RemoveMember(object sender , EmployeeLayOffEventArgs e)
        {
            if(sender is Employee E && Members.Contains(E) && e.Cause == LayOffCause.VactionStock)
            {
                Console.WriteLine($"The Employee with ID -> {E.EmployeeID} was removed from club beacuse vaction stock");
                Members.Remove(E);
            }
        }
    }
}
