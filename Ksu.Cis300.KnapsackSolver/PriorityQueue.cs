/* MinPriorityQueue.cs
 * Author: Rod Howell 
 * Modified By: Levi Mann
 * Completetion Code: 04 19 09 93
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.KnapsackSolver
{
    /// <summary>
    /// A generic priority queue.
    /// </summary>
    /// <typeparam name="TPriority">The type of the priorities.</typeparam>
    /// <typeparam name="TValue">The type of the elements.</typeparam>
    public class PriorityQueue<TPriority, TValue> where TPriority : IComparable<TPriority>
    {
        /// <summary>
        /// The heap storing the elements with their priorities.
        /// </summary>
        private LeftistTree<KeyValuePair<TPriority, TValue>> _elements = null;

        /// <summary>
        /// The number of elements in the PriorityQueue.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements in the PriorityQueue.
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }

        /// <summary>
        /// Gets the Maximum priority in the PriorityQueue.
        /// </summary>
        public TPriority MaximumPriority
        {
            get
            {
                if (_elements == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return _elements.Data.Key;
                }
            }
        }

        /// <summary>
        /// Gets a drawing of the heap.
        /// </summary>
        public TreeForm HeapDrawing
        {
            get
            {
                return new TreeForm(_elements, 100);
            }
        }

        /// <summary>
        /// Merges the given heaps into one.
        /// </summary>
        /// <param name="h1">One heap.</param>
        /// <param name="h2">The other heap.</param>
        /// <returns></returns>
        private static LeftistTree<KeyValuePair<TPriority, TValue>> Merge(LeftistTree<KeyValuePair<TPriority, TValue>> h1, 
            LeftistTree<KeyValuePair<TPriority, TValue>> h2)
        {
            if  (h1 == null)
            {
                return h2;
            }
            else if (h2 == null)
            {
                return h1;
            }
            else
            {
                int compare = h1.Data.Key.CompareTo(h2.Data.Key);
                if (compare > 0)
                {
                    return new LeftistTree<KeyValuePair<TPriority, TValue>>(h1.Data, h1.LeftChild, Merge(h1.RightChild, h2));
                }
                else
                {
                    return new LeftistTree<KeyValuePair<TPriority, TValue>>(h2.Data, h2.LeftChild, Merge(h2.RightChild, h1));
                }
            }
        }

        /// <summary>
        /// Adds the given element with the given priority.
        /// </summary>
        /// <param name="x">The element to add.</param>
        /// <param name="p">The priority of the element.</param>
        public void Add(TValue x, TPriority p)
        {
            LeftistTree<KeyValuePair<TPriority, TValue>> node = 
                new LeftistTree<KeyValuePair<TPriority, TValue>>(new KeyValuePair<TPriority, TValue>(p, x), null, null);
            _elements = Merge(_elements, node);
            _count++;
        }

        /// <summary>
        /// Removes an element with maximum priority.
        /// </summary>
        /// <returns>The element removed.</returns>
        public TValue RemoveMaximumPriority()
        {
            if (_elements == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                TValue tempValue = _elements.Data.Value;
                _count--;
                _elements = Merge(_elements.LeftChild, _elements.RightChild);
                return tempValue;
            }
        }
    }
}
