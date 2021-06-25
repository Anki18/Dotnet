using System;

namespace PartialClass
{
    public partial class EmployeeMethods
    {
        public Employee(int Id, string name)
        {
            this.EmpId = Id;
            this.Name = name;
        }

        public int DisplayEmployeeInfo()
        {
            Console.WriteLine(this.EmpId + " " + this.FirstName + " " + this.LastName);
            return 0;
        }

        public void Save(int id, string firstName, string lastName)
        {
            Console.WriteLine("Saved!");
        }
    }
}
