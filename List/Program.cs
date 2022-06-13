using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _List<int> _list = new _List<int>();
            _list.Add(59);
            _list.Add(19);
            _list.Add(71);
            _list.Add(717);
            _list.Add(7);
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            _list[0] = 77;
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(_list.Capacity);
            Console.WriteLine(_list.Count);
            _list.Clear();
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 5);
            }
            _List<int> _list2 = new _List<int>(arr);
            foreach (var item in _list2)
            {
                Console.WriteLine(item);
            }
            _List<int> _list3 = new _List<int>();
            _list3.Add(71);
            _list3.Add(717);
            _list3.Insert(1, 17);
            foreach (var item in _list3)
            {
                Console.WriteLine(item);
            }
            _List<string> list4 = new _List<string>();
            list4.Add("Hello");
            list4.Add("World");
            list4.Add("77");
            foreach(var item in list4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('_' , 50));
            list4[2] = "717";
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }
            list4.InsertRange(3,new string[]{ "good","morning"});
            Console.WriteLine(new string('_', 50));
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }
        }
    }
}
