using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    public partial class Task1
    {
        public partial void hashTableTask();
    }

    public partial class Task2
    {
        public partial void LinkedListTask();
        public partial void QueueTask();

        public partial void HashSetTasks();

    }


    partial struct Task3 {
        public Task3()
        {
        }

        public partial void AttendaceCalculation();
    }
    partial class Task4 { }

    internal class executionClass
    {
        static void Main(string[] args)
        {
            Task1 task1Obj = new Task1();
            task1Obj.hashTableTask();

            Task2 task2obj = new Task2();
            task2obj.LinkedListTask();
            task2obj.QueueTask();
            task2obj.HashSetTasks();

            Task3 structobj= new Task3();
            structobj.AttendaceCalculation();

            Console.ReadLine();

        }

    }


}
