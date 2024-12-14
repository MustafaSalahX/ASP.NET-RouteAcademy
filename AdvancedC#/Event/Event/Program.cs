namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Name = "Mariam",
                EmployeeID = 1,
                BirthDate = new DateTime(2003, 11, 20),
                VacationStock = 10
            };
            Employee emp2 = new Employee()
            {
                Name = "Amira",
                EmployeeID = 2,
                BirthDate = new DateTime(1999, 11, 20),
                VacationStock = 1
            };
            SalesPerson sp = new SalesPerson()
            {
                Name = "Mohamed",
                EmployeeID = 3,
                BirthDate = new DateTime(1998, 3, 30),
                VacationStock = 20,
                AchievedTarget = 3000
            };
            BoardMember bm = new BoardMember()
            {
                Name = "Ahmed",
                EmployeeID = 4,
                BirthDate = new DateTime(1997, 11, 3),
                VacationStock = 20
            };
            Department dep = new Department()
            {
                DepName = "CS",
                DepId = 1
            };
            Club clb = new Club()
            {
                ClubID = 1,
                ClubName = "Barca"
            };
            dep.AddStaff(emp);
            clb.AddMember(emp);
            dep.AddStaff(emp2);
            clb.AddMember(emp2);
            dep.AddStaff(sp);
            clb.AddMember(sp);
            dep.AddStaff(bm);
            clb.AddMember(bm);
            Console.WriteLine("Employee LayedOff --> vacation stock ");
            emp.VacationStock -= 20;
            Console.WriteLine("**********************************");
            Console.WriteLine("Employee LayedOff --> age > 60 ");
            emp2.BirthDate = new DateTime(1960, 11, 20);
            Console.WriteLine("**********************************");
            Console.WriteLine("SalesPerson LayedOff --> target not achieved ");
            sp.CheckTarget(1000);
            Console.WriteLine("**********************************");
            Console.WriteLine("BoardMember LayedOff --> resigned ");
            bm.Resign();
            Console.WriteLine("**********************************");
        }
    }
}
