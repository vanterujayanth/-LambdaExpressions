using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {
           
        }

        public void studentDisplay()
        {

            List<Student> details = new List<Student>() {
                    new Student{ Id = 1, Name = "Liza" },
                    new Student{ Id = 2, Name = "Stewart" },
                    new Student{ Id = 3, Name = "Tina" },
                    new Student{ Id = 4, Name = "Stefani" },
                    new Student{Id = 5, Name = "Trish" }
            };
            var newdetails = details.OrderBy(x => x.Name).ToList(); // to sort list of values on the base of name in assending order 
            foreach (var item in newdetails)
            {
                Console.WriteLine(item.Id + "  " + item.Name);
            }

        }

    }
}



