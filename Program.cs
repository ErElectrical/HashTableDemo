using System;
using System.Collections.Generic;
namespace HashtableDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to HashTable Demo");
            //The Hashtable is a non-generic collection that stores key-value pairs,
            //similar to generic Dictionary<TKey, TValue> collection.
            //It optimizes lookups by computing the hash code of each key and stores it
            //in a different bucket internally and then matches the hash code
            //of the specified key at the time of accessing values.

            //   Hashtable Characteristics

            //Hashtable stores key - value pairs.
            //Comes under System.Collection namespace.
            //Implements IDictionary interface.
            //Keys must be unique and cannot be null.
            //Values can be null or duplicate.
            //Values can be accessed by passing associated key in the indexer e.g.myHashtable[key]
            //Elements are stored as DictionaryEntry objects.
        }
    }
}
