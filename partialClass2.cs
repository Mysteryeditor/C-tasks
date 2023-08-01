using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{

    public partial class Task2
    {
        public partial void LinkedListTask()
        {
            Console.WriteLine("***Linked List Tasks***");
            LinkedList<string> linkedlist = new LinkedList<string>();
            linkedlist.AddLast("Srikanth");
            var a = linkedlist.AddFirst("Darshan");

            linkedlist.AddBefore(a, "Sharon");
            linkedlist.AddAfter(a, "Hemanth");
            linkedlist.RemoveFirst();
            if (linkedlist.Contains("Arun"))
            {
                Console.WriteLine("Arun is present");
            }
            else
            {
                linkedlist.AddLast("Arun");
            }

            Console.WriteLine("The Linked List Items");

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public partial void QueueTask()
        {
            Console.WriteLine();
            Console.WriteLine("***Queue Tasks***");
            Queue<char> vowels = new Queue<char>();
            vowels.Enqueue('a');
            vowels.Enqueue('e');
            vowels.Enqueue('i');
            vowels.Enqueue('o');
            vowels.Enqueue('u');

            Console.WriteLine("The first element in the queue is " + vowels.Peek());
            Console.WriteLine("The last element in the queue is " + vowels.Last());
            Console.WriteLine("The Size of the queue is " + vowels.Count());


            Console.WriteLine("Queue Items");
            foreach (var item in vowels)
            {
                Console.Write(item.ToString() + "\t");
            }
        }

        public partial void HashSetTasks()
        {
            Console.WriteLine();
            Console.WriteLine("***HashSet Tasks***");
            HashSet<int> cubes = new HashSet<int>();

            for (int i = 1; i <= 10; i++)
            {
                cubes.Add(i);
            }

            int search;
            Console.WriteLine("Enter an integer to search");
            search = Convert.ToInt32(Console.ReadLine());

            if (cubes.Add(search))
            {
                Console.WriteLine("Element was not found and was added now");
            }

            else
            {
                Console.WriteLine("Element found");
            }

            Console.WriteLine("The hash set elements are");
            foreach (int i in cubes)
            {
                Console.Write(i + "\t");
            }
        }

    }

}
