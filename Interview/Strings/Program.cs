using System;
using System.Text;

namespace Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = "Hi there I am Ankit";
            StringBuilder rev = new StringBuilder();
            var splitInput = input.Split(' ');
            foreach (var sp in splitInput)
            {
                string res="";
                for (int i = sp.Length-1; i > -1; i--)
                {
                    res += sp[i];
                }
            }
        }

        static void ReverseString()
        {
            string input = "ankit";
            StringBuilder rev = new StringBuilder();
            for (int j = input.Length -1 ; j > -1; j--)
            {
                rev.Append(input[j]);
            }
            Console.WriteLine(rev);
        }
        
        public static void DuplicateUnique()
        {
            string inp = "abcdaed";
            string res = "";
            string duplicate = "";

            foreach (var a in inp)
            {
                if (res.IndexOf(a) == -1)
                {
                    res += a;
                }
                else
                {
                    duplicate += a;
                }
            }
            
            Console.WriteLine($"unique - {res}, duplicate- {duplicate}");
        }
    }
}