using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public enum LayOffCause
    {
       VactionStock = 1,
       Age = 2,
       TargetNotAchieved = 3 ,
       Resign = 4
    }

    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke (this, e);
        }
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        DateTime birthDate;
        public DateTime BirthDate 
        {
            get => birthDate;
            set
            {
                if (DateTime.Now.Year - value.Year >= 60)
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age });
              
                birthDate = value;
            }
        }
        int vactionStock;
        public virtual int VacationStock 
        { 
            get => vactionStock;
            set
            {
                if(value < 0)
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VactionStock });
                vactionStock = value;
            }
        }
        public override string ToString()
        {
            return $"EmployeeId -> {EmployeeID} , EmployeeName -> {Name}";
        }
        public bool  RequestVacation(DateTime from , DateTime to)
        {
            if(to.Day - from.Day > vactionStock)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VactionStock });
                return false;
            }
            vactionStock -= (to.Day - from.Day);
            return true;
        }
        public void EndOfYearOperation()
        {
            if(DateTime.Now.Year - birthDate.Year >= 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age });
                Console.WriteLine($"Employee with ID : {EmployeeID} , {Name} has been LayedOFF");
            }
            else
            {
                Console.WriteLine($"Employee with ID : {EmployeeID} , {Name} still working");

            }
        }
    }
}
