using System;
namespace AccessSpecifierDemo
{
    public class Employee
    {
        protected int ID = 102;
        public void PrintID()
        {
            Console.WriteLine(this.ID);
        }
    }
    public class Suresh : Employee
    {
        public void PrintEmployeeID()
        {
            Suresh a = new Suresh();
            Console.WriteLine(a.ID);
            
            
        }
    }
    public class Customer
    {
        public static void Main()
        {
            Employee c = new Employee();
            c.PrintID();
           
            Suresh cc = new Suresh();
            cc.PrintEmployeeID();
        }
        
    }
}
