using System.Collections.Generic;

namespace Day_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Dictionary
             * List
             * Queue
             * SortedList
             * Stack
             * HashSet
             * LinkedList
             */
            Console.WriteLine("===========Dictionary==============");
            Dictionary<int, string> mydict = new Dictionary<int, string>();
            mydict.Add(101,"C++");
            mydict.Add(102, "C#");
            mydict.Add(103, "C");
            mydict.Add(104, "Java");
            mydict.Add(105, "Python");
            mydict.Remove(101);
            foreach (KeyValuePair<int,string> item in mydict)
            {
                Console.WriteLine("{0} ==>{1}",item.Key,item.Value);
            }
            for (int i = 0; i < mydict.Count; i++)
            {
                Console.WriteLine("{0} ==>{1}", mydict.ElementAt(i).Key, mydict.ElementAt(i).Value);
            }

            Console.WriteLine("===========List==============");
            List<string> myList = new List<string>();
            myList.Add("C++");
            myList.Add("C#");
            myList.Add("C");
            myList.Add("Java");
            myList.Add("Python");
            myList.RemoveAt(1);
            foreach (var item in myList)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("===========Stack==============");
            Stack<string> myStack = new Stack<string>();
            myStack.Push("C++");
            myStack.Push("C#");
            myStack.Push("C");
            myStack.Push("Java");
            myStack.Push("Python");
            myStack.Pop();
            foreach (var item in myStack)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("===========Queue==============");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C++");
            myQueue.Enqueue("C#");
            myQueue.Enqueue("C");
            myQueue.Enqueue("Java");
            myQueue.Enqueue("Python");
            myQueue.Dequeue();
            foreach (var item in myQueue)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}