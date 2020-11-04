using queue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var squeue = new squeue<int>();
            squeue.Enqueue(3);
            squeue.Enqueue(9);
            squeue.Enqueue(4);
            squeue.Enqueue(6);
            squeue.Enqueue(1);

            Console.WriteLine(squeue.Dequeue());
            Console.WriteLine(squeue.Peek());
            Console.WriteLine(squeue.Dequeue());

            Console.ReadLine();
        }
    }
}
