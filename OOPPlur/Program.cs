using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlur
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee em1 = new Employee("Medo","Mahgoub","e@e.com", new DateTime(1995, 1, 20),25,EmployeeType.Manager);
            WorkTask task;
            task.description = "Bake a delicious pies";
            task.hours = 3;
            task.performWorkTask();
            //Console.WriteLine("Create An Employee");
            //Console.WriteLine("----------------------");
            //em1.DisplayEmployeeDetails();
            //em1.PerformWork();
            //Employee emp = new Employee();
            //emp.firstName = "Medo";
            //emp.lastName = "Mahgoub";
            //emp.email = "m@m.com";
            //emp.BirthDay = new DateTime(1995, 1, 20);
            //string empJson = emp.ConvertToJson();
            //Console.WriteLine(empJson);
            //int minBouns = 100;
            //em1.numberOfHoursWorked = 20;
            //int receiveBouns = em1.calculateBouns(minBouns); // 200
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.AppendLine("Medo");
            //Console.WriteLine(sb.ToString());
            
            //string a = "Hello";
            //string b = a;
            //b += "World";
            //Console.WriteLine(b); // hello world
            //Employee em1 = new Employee();
            //em1.email = "Medo@medo.com";
            //Employee em2 = em1;
            //Console.WriteLine(em1.email);
            //Console.WriteLine(em2.email);
            //em2.email = "sedo@sedo.com";
            //Console.WriteLine(em1.email);
            //Console.WriteLine(em2.email);



            Console.ReadLine();
        }
    }
}
