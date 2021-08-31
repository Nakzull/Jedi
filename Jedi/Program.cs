using System;
using System.Collections.Generic;

namespace Jedi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Andreas", 35);
            myDictionary["Mads"] = 25;
            myDictionary.Add("Hans Solo", 88);

            myDictionary.Remove("Hans Solo");
            

            foreach (KeyValuePair<string, int> items in myDictionary)
                Console.WriteLine("{0}, {1}", items.Key, items.Value);
        }
    }
}
