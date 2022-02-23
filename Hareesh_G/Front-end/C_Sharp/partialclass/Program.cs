using System;

namespace HeightWeightInfo
{
    class Company
    {
    }
    public partial class Employee
    {
        private int salary;
        private int age;
        public Employee(int salary, int age)
        {
            this.salary = salary;
            this.age = age;
        }
    }
    public partial class Student
    {
        public partial void InitializeStudent();
        public void Height() { }
        public void Weight() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee(300000, 25);
            myEmployee.PrintEmployee();
            Student c = new Student();
            c.InitializeStudent();
            Console.ReadLine();
        }
    }
}
