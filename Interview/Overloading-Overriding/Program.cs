using System;

namespace Overloading_Overriding
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
//            ClassA B = new ClassB();
//            ClassB b = B as ClassB;
//            b.Method2();
               Overloading o = new Overloading();
               Console.WriteLine(o.Sum(1, 2.2));
        }
    }

    public class Overloading
    {
        public int Sum(int x, double y)
        {
            return (int)(x + y);
        }
        public int Sum(double x, int y)
        {
            return (int)(x + y);
        }
    }
    class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("base ctor");
        }
        public virtual void Method1()
        {
            Console.WriteLine("base class");
        }
    }
    class ClassB: ClassA
    {
        public ClassB()
        {
            Console.WriteLine("child ctor");
        }
        public override  void Method1()
        {
            Console.WriteLine("child class");
        }
        public void Method2()
        {
            Console.WriteLine("child class Met 2");
        }
    }
}