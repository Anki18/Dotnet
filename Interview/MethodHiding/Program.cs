using System;

namespace MethodHiding
{

    class A
    {
        public virtual void Method1()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public override void Method1()
        {
            Console.WriteLine("B");
        }
    }
    class C : B
    {
        public new void Method1()
        {
            Console.WriteLine("C");
        }
    }
    class D : C
    {
        public new void Method1()
        {
            Console.WriteLine("D");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            C a = new D();
            a.Method1();
        }
    }
}