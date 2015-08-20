using System;
using System.Collections.Generic;

namespace ImplementBinaryHeap
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var priorityQueue = new PriorityQueue<int, string>();
            priorityQueue.Enqueue(5, "john");
            priorityQueue.Enqueue(8, "lisa");
            priorityQueue.Enqueue(3, "boby");
            priorityQueue.Enqueue(17, "frank");
            priorityQueue.Enqueue(9, "bob");
            priorityQueue.Enqueue(12, "carol");
            priorityQueue.Enqueue(10, "maria");

            var priorityQueue2 = new PriorityQueue<int, string>();
            priorityQueue2.Enqueue(7, "burg");
            priorityQueue2.Enqueue(15, "salt");
            priorityQueue2.Enqueue(6, "gabe");

            var mergedPriorityQueue = PriorityQueue<int, string>.MergeQueues(
                priorityQueue, priorityQueue2);
            
            while (!mergedPriorityQueue.IsEmpty)
            {
                var element = mergedPriorityQueue.Dequeue();
                Console.WriteLine("{0} -> {1}", element.Key, element.Value);
            }
        }
    }
}
