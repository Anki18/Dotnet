using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "John");
            emp.DisplayEmployeeInfo();
            Console.WriteLine("Hello World!");
        }
    }
}
