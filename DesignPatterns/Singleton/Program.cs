using System;

namespace Singleton
{
    public class Policy
    {
        private static Policy _instance;

        public static Policy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Policy();
                }

                return _instance;
            }
        }

//        public static Policy Instance
//        {
//            get { return new Policy(); }
//        }

        public Policy()
        {
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var inst = Policy.Instance;
            var inst2 = Policy.Instance;
            if (inst == inst2)
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("Not equals");
            }
        }
    }
}