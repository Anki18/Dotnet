using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new C();
            a.Print();
        }
    }
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Print A");
        }

    }

    public class B: A
    {
        //method overriding
        public override void Print()
        {
            Console.WriteLine("Print B");
        }
    }

    public class C: B
    {
        //method hiding
        public new void Print()
        {
            Console.WriteLine("Print C");
        }

    }
}