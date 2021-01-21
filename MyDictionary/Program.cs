using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("book","kitab");
            dictionary.Insert(0,"table","stol");
            //dictionary.DeleteByKey("book");
            //dictionary.DeleteByValue("stol");
            //dictionary.DeleteByIndex(1);
            foreach (var dictionaryValue in dictionary.Values)
            {
                Console.WriteLine(dictionaryValue);
            }
        }
    }

    

}
