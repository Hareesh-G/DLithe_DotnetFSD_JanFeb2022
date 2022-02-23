using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightWeightInfo
{
    internal class partialclass1
    {
    }
    public partial class Student
    {
        public void Bu() { }
        public partial void InitializeStudent()
        {
            string str = "Student";
            Console.WriteLine(str);
        }
    }
    public partial class Employee
    {
        public void PrintEmployee()
        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("age:" + age);
        }
    }
}

