using System;
using System.Threading;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void DoSomething(object str)
        {
            Console.WriteLine(str);
        }
        public static async Task DoAsync()
        {
            Console.WriteLine("Before await");

            await Task.Delay(TimeSpan.FromSeconds(1));

            Console.WriteLine("Between awaits");

            await Task.Delay(TimeSpan.FromSeconds(1));

            Console.WriteLine("After await");
        }
        static void Main(string[] args)
        {
            await DoAsync();
        }
    }
}