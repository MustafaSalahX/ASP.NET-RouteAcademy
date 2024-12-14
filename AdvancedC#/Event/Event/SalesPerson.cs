using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class SalesPerson : Employee
    {
        public override int VacationStock {  get; set; }
        public int AchievedTarget { get; set; }
        public bool CheckTarget (int Quota)
        {
            if (Quota >= AchievedTarget) return true;
            else
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.TargetNotAchieved });
                return true;
            }
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if(e.Cause != LayOffCause.VactionStock)
               base.OnEmployeeLayOff(e);
        }
    }
}
