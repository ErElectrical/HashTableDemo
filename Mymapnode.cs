using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTable
{
    class MyMapNode<K, V>
        // Mymapnode is a genric class k,v represents a hashtable type
        // which is having key , value pair.
    {
        // varible for size 
        private readonly int _size;
        //linkedlist varible for hashtable.
        private readonly LinkedList<KeyValue<K, V>>[] items;

        // creating constructor for our class so that 
        // we can preinitialize it.
        public MyMapNode(int size)
        {
            this._size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % _size;
            // GetHashCode is use for getting the position of that particular key
            // behind the scene hashcode returns datatype is integer value.
            // hashcode of those objects which are defined equal by (==) is same.
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        // method to add values in Hashtable.

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }

        // method to get particular position from linkedlist hashtable
        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        public int GetFrequencyOfWords(V value)
        {
            int count = 0;
            if (items == null)
            {
                Console.WriteLine("Hash Table is Empty!");
                return 0;
            }
            for (int i = 0; i < items.Length; i++)
            {
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(i);
                foreach (KeyValue<K, V> item in linkedList)
                {
                    if (item.value.Equals(value))
                        count++;
                }
            }
            return count;
        }


        // struct is a keyword that is use for declaring a user defind datatype
        // as here A structure creates a data type that can be used
        // to group items of possibly different types into a single type.
        public struct KeyValue<Ke, Va>
        {
            public Ke key { get; set; }
            public Va value { get; set; }
        }
    }
}
