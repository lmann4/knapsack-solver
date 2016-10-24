using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.KnapsackSolver
{
    /// <summary>
    /// Class for storing an immutable canadate solution.
    /// </summary>
    public class CandidateSolution
    {
        /// <summary>
        ///  Index (into a List<KnapsackItem>)to the last item added to this candidate solution
        /// </summary>
        private int _index;

        /// <summary>
        ///  Total value of this candidate solution.
        /// </summary>
        private int _value = 0;

        /// <summary>
        /// Total weight of this candidate solution.
        /// </summary>
        private int _weight = 0;

        /// <summary>
        /// The CandidateSolution containing the remaining items.
        /// </summary>
        private CandidateSolution _previous;

        /// <summary>
        /// Gets the index of the last item added to this candidate solution.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
        }

        /// <summary>
        /// Gets the total value of this candidate solution
        /// </summary>
        public int Value
        {
            get
            {
                return _value;
            }
        }

        /// <summary>
        /// Gets the total weight of the candidate solution.
        /// </summary>
        public int Weight
        {
            get
            {
                return _weight;
            }
        }

        /// <summary>
        /// Gets candidate solution containing the remaining items.
        /// </summary>
        public CandidateSolution Previous
        {
            get
            {
                return _previous;
            }
        }

        /// <summary>
        /// Constructor for a candidate solution.
        /// </summary>
        /// <param name="items">List of all the items</param>
        /// <param name="index">index (into the above list) of the last item to be added to this candidate solution</param>
        /// <param name="previous">the remaining items</param>
        public CandidateSolution(List<KnapsackItem> items, int index, CandidateSolution previous)
        {
            if (index == -1)
            {
                _index = index;
                _value = 0;
                _weight = 0;
                _previous = null;
            }
            else
            {
                _index = index;
                _value = previous.Value + items[index].Value;
                _weight = previous.Weight + items[index].Weight;
                _previous = previous;
            }
        }

    }
}
