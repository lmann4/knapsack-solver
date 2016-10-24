using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.KnapsackSolver
{
    /// <summary>
    /// 
    /// </summary>
    public struct KnapsackItem : IComparable<KnapsackItem>
    {
        /// <summary>
        /// The item's id
        /// </summary>
        private int _id;

        /// <summary>
        /// The items value
        /// </summary>
        private int _value;

        /// <summary>
        /// The items weight
        /// </summary>
        private int _weight;
        
        /// <summary>
        /// The text to be displayed indicating whether this item is in the solution (i.e., "x" or "")
        /// </summary>
        private string _selectionText;

        /// <summary>
        /// Gets the item's id
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Gets the item's value
        /// </summary>
        public int Value
        {
            get
            {
                return _value;
            }
        }

        /// <summary>
        /// Gets the item's value
        /// </summary>
        public int Weight
        {
            get
            {
                return _weight;
            }
        }

        /// <summary>
        /// Gets or sets the selection indicator text for an item.
        /// </summary>
        public string SelectionText
        {
            get
            {
                return _selectionText;
            }
            set
            {
                _selectionText = value;
            }
        }

        /// <summary>
        /// A constructor for a KnapsackItem
        /// </summary>
        /// <param name="id">item id</param>
        /// <param name="value">item value</param>
        /// <param name="weight">item weight</param>
        public KnapsackItem(int id, int value, int weight)
        {
            if (value <= 0 || weight <= 0)
            {
                throw new ArgumentException("Each value and weight must be positive.");
            }
            else
            {
                _id = id;
                _value = value;
                _weight = weight;
                _selectionText = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=item>The item being compared</param>
        /// <returns>an int indicating the equality, x greater than 0 if greater, x less than 0 if less, x = 0 if equal</returns>
        public int CompareTo(KnapsackItem item)
        {
            long side1 = (long)this.Value * item.Weight;
            long side2 = (long)item.Value * this.Weight;
            if (side1 == side2)
            {
                if (this.Value < item.Value || this.Weight < item.Weight)
                {
                    return -1;
                }
                else if (this.Value > item.Value || this.Weight > item.Weight)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if(side1 > side2)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
