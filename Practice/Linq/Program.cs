using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            class A = new C();
            A.Print();
        }
    }

    public class A
    {
        public virtual string Print()
        {
            Console.WriteLine("Print A");
        }

    }

    public class B: A
    {
        public override string Print()
        {
            Console.WriteLine("Print B");
        }
    }

    public class C: B
    {
        public new string Print()
        {
            Console.WriteLine("Print C");
        }

    }
    
}
