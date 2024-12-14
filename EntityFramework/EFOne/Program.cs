using EF.Data;
using EFOne.Entites;

namespace EFOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Steps
            //1- Install packages (EFCore.SqlSServer -- EFCore.Tools)
            //2- Add dbContext class with connection string
            //3- Add entites without relationships
            //4- Add relationships between entities
            //5- Add dbSets in dbContext
            //6- Add configuration class for each entity 
            //7- Apply configurations in OnModelCreating in dbContext
            //8- Add migration 
            //9- Update database
            //10- Do CRUD operations for each entity
            #endregion

            #region RelationShips
            //1- Take relationship (Student -- Course)
            //2- Located relationship (Student -- Department)
            //3- Classify relationship (Course -- Topic)
            //4- Teach relationship (Course -- Instructor)
            //5- Manage relationship (Instructor -- Department)
            //6- Contain relationship  (Instructor -- Department)
            #endregion

            #region CRUD Operations
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            #region Instructors
            #region Insert
            //Instructor instructor1 = new Instructor() { Name = "Mariam", Address = "Cairo", Salary = 3000m, Bonus = 100m, HourRate = 50m };
            //Instructor instructor2 = new Instructor() { Name = "Mohamed", Address = "Alex", Salary = 5000m, Bonus = 200m, HourRate = 80m };
            //Console.WriteLine($"Before Adding --> {dbContext.Entry(instructor1).State}"); //Deatched
            //dbContext.Add(instructor1);
            //dbContext.Add(instructor2);
            //Console.WriteLine($"After Adding --> {dbContext.Entry(instructor1).State}"); //Added
            //dbContext.SaveChanges();
            #endregion

            #region Select
            //var myInstructor = (from Instructor in dbContext.Instructors
            //                    where Instructor.Id == 1
            //                    select Instructor).FirstOrDefault();
            //Console.WriteLine($"Name --> {myInstructor.Name} --- Salary --> {myInstructor.Salary}");
            #endregion
            #region Update
            //Console.WriteLine($"Before update --> {dbContext.Entry(myInstructor).State}"); //UnChanged
            //myInstructor.Name = "Omnia";
            //Console.WriteLine($"After update --> {dbContext.Entry(myInstructor).State}"); //Modified
            //Console.WriteLine($"Name --> {myInstructor.Name} --- Salary --> {myInstructor.Salary}");
            //dbContext.SaveChanges();
            #endregion
            #region Delete
            //Console.WriteLine($"Before Delete --> {dbContext.Entry(myInstructor).State}"); //UnChanged
            //dbContext.Remove(myInstructor);
            //Console.WriteLine($"Afer Delete --> {dbContext.Entry(myInstructor).State}"); //Deleted
            //dbContext.SaveChanges();
            //Console.WriteLine($"Afer Saving --> {dbContext.Entry(myInstructor).State}"); //Detached

            #endregion

            #endregion

            #region Topics
            #region Insert
            //Topic topic1 = new Topic() { Name = "CSharp" };
            //Topic topic2 = new Topic() { Name = "C++" };
            //Console.WriteLine($"Before Adding --> {dbContext.Entry(topic1).State}"); //Deatched
            //dbContext.Add(topic1);
            //dbContext.Add(topic2);
            //Console.WriteLine($"After Adding --> {dbContext.Entry(topic1).State}"); //Added
            //dbContext.SaveChanges();
            //Console.WriteLine($"After Saving --> {dbContext.Entry(topic1).State}"); //UnChanged
            #region Select
            //var myTopic = (from topic in dbContext.Topics
            //               where topic.Id == 2
            //               select topic).FirstOrDefault();
            //Console.WriteLine($"Topic Name --> {myTopic.Name}");
            #endregion
            #region Update
            //Console.WriteLine($"Before Updating --> {dbContext.Entry(myTopic).State}"); //UnChanged
            //myTopic.Name = "Python";
            //Console.WriteLine($"Topic Name --> {myTopic.Name}");
            //Console.WriteLine($"After Updating --> {dbContext.Entry(myTopic).State}"); //Modified
            //dbContext.SaveChanges();
            //Console.WriteLine($"After Saving --> {dbContext.Entry(myTopic).State}"); //UnChanged

            #endregion
            #region Delete
            //Console.WriteLine($"Before deleting --> {dbContext.Entry(myTopic).State}"); //UnChanged
            //dbContext.Remove(myTopic);
            //Console.WriteLine($"After deleting --> {dbContext.Entry(myTopic).State}"); //Deleted
            //dbContext.SaveChanges();
            //Console.WriteLine($"After Saving --> {dbContext.Entry(myTopic).State}"); //Detached

            #endregion
            #endregion
            #endregion
           
            #endregion
        }
    }
}
