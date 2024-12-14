using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class BoardMember : Employee
    {
        public override int VacationStock { get; set; }
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Resign });
            Console.WriteLine($"{this} has resigned");
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Resign)
                base.OnEmployeeLayOff(e);
        }
    }
}
