using System;
using System.Collections;
namespace HashTables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("A", "Ank");
            hashTable.Add(1, new
            {
                name = "Ank"
            });

            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}