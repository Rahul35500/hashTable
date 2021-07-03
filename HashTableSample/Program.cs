using System;
using System.Collections;
namespace HashTableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable primeNumber=new Hashtable();
            // primeNumber.Add(0,2);
            primeNumber.Add(1,4);
            primeNumber.Add(2,6);
            primeNumber.Add(3,8);
            primeNumber.Add(0,10);
            primeNumber.Add(5,16);
            primeNumber.Add(6,12);
            primeNumber.Add(4,2);
             primeNumber.ContainsKey(2);
            
            foreach(var key in primeNumber.Keys)
            {
                System.Console.WriteLine(primeNumber[key]);
            }


            foreach(DictionaryEntry i in primeNumber)
            {
                System.Console.WriteLine($"{i.Key}={i.Value}");
            }
            


        }
    }
}
