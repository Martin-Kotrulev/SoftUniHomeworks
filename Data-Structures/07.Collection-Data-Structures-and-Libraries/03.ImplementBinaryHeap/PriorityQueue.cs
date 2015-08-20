using System;
using System.Collections.Generic;

namespace ImplementBinaryHeap
{
    public class PriorityQueue<TPriority, TValue>
    {
        public static PriorityQueue<TPriority, TValue> MergeQueues
        (PriorityQueue<TPriority, TValue> pq1,
            PriorityQueue<TPriority, TValue> pq2)
        {
            if (pq1 == null || pq2 == null)
                throw new ArgumentNullException();
            // merge data
            PriorityQueue<TPriority, TValue> result = 
                new PriorityQueue<TPriority, TValue>();
            result._baseHeap.AddRange(pq1._baseHeap);
            result._baseHeap.AddRange(pq2._baseHeap);
            // heapify data
            for (int pos = result._baseHeap.Count / 2 - 1; pos >= 0; pos--)
                result.HeapifyFromRootToEnd();

            return result;
        }  

        // Simple imlpementation of heap with list
        private List<KeyValuePair<TPriority, TValue>> _baseHeap;
        // Comparer for the priorities
        private IComparer<TPriority> _comparer;

        public PriorityQueue()
            : this(Comparer<TPriority>.Default)
        {
        }

        public PriorityQueue(IComparer<TPriority> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException();
            }

            _baseHeap = new List<KeyValuePair<TPriority, TValue>>();
            _comparer = comparer;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is empty.
        /// </summary>
        /// <value><c>true</c> if this instance is empty; otherwise, <c>false</c>.</value>
        public bool IsEmpty
        {
            get { return _baseHeap.Count == 0; }
        }

        /// <summary>
        /// Gets the count of the elements in the queue.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get { return _baseHeap.Count; }
        }

        private void ExchangeElements(int firstPos, int secPos)
        {
            KeyValuePair<TPriority, TValue> swap = _baseHeap[firstPos];
            _baseHeap[firstPos] = _baseHeap[secPos];
            _baseHeap[secPos] = swap;
        }

        /// <summary>
        /// Heapifies the _baseHeap from end to beginning
        /// </summary>
        private void HeapifyBackwards()
        {
            // Parent is based on the formula:
            // heap[i] has parent heap[(i - 1) / 2]

            int index = _baseHeap.Count - 1;
            while (index > 0)
            {
                int parentPos = (index - 1) / 2;
                if (_comparer.Compare(
                    _baseHeap[parentPos].Key, _baseHeap[index].Key) > 0)
                {
                    // Every child chould be greater or equal to its parent
                    ExchangeElements(parentPos, index);
                    index = parentPos;
                }
                else
                    break;
            }
        }

        /// <summary>
        /// Insert the specified priority and value.
        /// </summary>
        /// <param name="priority">Priority.</param>
        /// <param name="value">Value.</param>
        public void Insert(TPriority priority, TValue value)
        {
            var entry = new KeyValuePair<TPriority, TValue>(priority, value);
            _baseHeap.Add(entry);
            HeapifyBackwards();
        }

        /// <summary>
        /// Enqueue the specified priority and value.
        /// </summary>
        /// <param name="priority">Priority.</param>
        /// <param name="value">Value.</param>
        public void Enqueue(TPriority priority, TValue value)
        {
            Insert(priority, value);
        }

        private void HeapifyFromRootToEnd()
        {
            // Children are based on the formula:
            // heap[i] has children heap[2*i + 1] and heap[2*i + 2]
            int index = 0;
            while (true)
            {
                // On each iteration exchange the element with a smaller children
                int smallest = index;
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
               
                if (leftChildIndex < _baseHeap.Count && 
                    _comparer.Compare(_baseHeap[smallest].Key, _baseHeap[leftChildIndex].Key) > 0)
                {
                    smallest = leftChildIndex;
                }
                if (rightChildIndex < _baseHeap.Count && 
                    _comparer.Compare(_baseHeap[smallest].Key, _baseHeap[rightChildIndex].Key) > 0)
                {
                    smallest = rightChildIndex;
                }

                if (smallest != index)
                {
                    ExchangeElements(smallest, index);
                    index = smallest;
                }
                else
                    break;
            }
        }

        private void DeleteRoot()
        {
            if (_baseHeap.Count <= 1)
            {
                _baseHeap.Clear();
                return;
            }

            // takes the last element and put it as the new root
            _baseHeap[0] = _baseHeap[_baseHeap.Count - 1];
            _baseHeap.RemoveAt(_baseHeap.Count - 1);

            HeapifyFromRootToEnd();
        }

        /// <summary>
        /// Returns the priority element.
        /// </summary>
        public KeyValuePair<TPriority, TValue> Dequeue()
        {
            if (!this.IsEmpty)
            {
                KeyValuePair<TPriority, TValue> result = _baseHeap[0];
                DeleteRoot();
                return result;
            }
            else
                throw new InvalidOperationException("Priority Queue is empty");
        }

        /// <summary>
        /// Dequeues the priority element.
        /// </summary>
        /// <returns>The value.</returns>
        public TValue DequeueValue()
        {
            return this.Dequeue().Value; 
        }

        /// <summary>
        /// Gets the priority element.
        /// </summary>
        public KeyValuePair<TPriority, TValue> Peek()
        {
            if (!IsEmpty)
                return _baseHeap[0];
            else
                throw new InvalidOperationException("Priority queue is empty");
        }

        /// <summary>
        /// Gets the priority element value.
        /// </summary>
        /// <returns>The value.</returns>
        public TValue PeekValue()
        {
            return this.Peek().Value;
        }
    }
}
