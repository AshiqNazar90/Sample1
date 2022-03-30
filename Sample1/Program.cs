using Sample1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var StudentList = new List<Student>()
            {
                new Student(){Email="ashiq.com",Name="Ashiq",Password="345"},
                 new Student(){Email="Rinshad.com",Name="rinshad",Password="345"},
                  new Student(){Email="Sanil.com",Name="Sanil",Password="345"},
                  new Student(){Email="Athira.com",Name="Athira",Password="345"}
            };

            var student = StudentList.Single(x => x.Email == "ashiq.com" && x.Password == "345");
            Console.WriteLine(student.Name);
            var student1 = StudentList.FindAll(x => x.Password == "345");

            foreach( var item in student1)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.Password);

            }

            Console.ReadKey();
        }
    }
}
