using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.KnapsackSolver
{
    /// <summary>
    /// Creates the knapsack solver form.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Contains all the items in the current instance.
        /// </summary>
        private List<KnapsackItem> _items;

        /// <summary>
        /// The weight bound for the current instance.
        /// </summary>
        private int _weightLimit;

        /// <summary>
        /// The total value of the optimal solution for the current instance.
        /// </summary>
        private int _totalValue;

        /// <summary>
        /// The total weight of the optimal solution for the current instance.
        /// </summary>
        private int _totalWeight;

        /// <summary>
        /// Cosntructor for the interface.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the input file and files the items list.
        /// </summary>
        /// <param name="filename">the name of the file to be read</param>
        /// <returns>the weight bound for the instance read</returns>
        public int ReadInput(string filename)
        {
            int bound;
            List<KnapsackItem> tmpList = new List<KnapsackItem>();
            using (StreamReader sr = new StreamReader(filename))
            {
                bound = Convert.ToInt32(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    string[] pieces = sr.ReadLine().Split(',');
                    KnapsackItem newItem = new KnapsackItem(Convert.ToInt32(pieces[0]), Convert.ToInt32(pieces[1]), Convert.ToInt32(pieces[2]));
                    tmpList.Add(newItem);
                }
                tmpList.Sort();
            }
            _items = tmpList;
            return bound;
        }

        /// <summary>
        /// A method to compute the upper bound
        /// </summary>
        /// <param name="toCompute">The candidate solution whose upper bound we wish to compute</param>
        /// <param name="foundSoFar">The best candidate solution we have found so far</param>
        /// <returns>the upper bound</returns>
        public int ComputeBounds(CandidateSolution toCompute, ref CandidateSolution best)
        {
            int i = toCompute.Index + 1;
            while ( i < _items.Count && (toCompute.Weight + _items[i].Weight) <= _weightLimit)
            {
                CandidateSolution newSolution = new CandidateSolution(_items, i, toCompute);
                toCompute = newSolution;
                i++;
            }
            if (toCompute.Value > best.Value)
            {
                best = toCompute;
            }
            if (i >= _items.Count || toCompute.Weight == _weightLimit)
            { 
                return toCompute.Value;
            }
            else
            {
                return (int)(((((long)(_weightLimit - toCompute.Weight) * (_items[i].Value)) - 1) / (_items[i].Weight)) + toCompute.Value);
            }
        }

        /// <summary>
        /// Method to find the optimal solution
        /// </summary>
        /// <param name="filename">input file</param>
        public void Solve(string filename)
        {
            _weightLimit = ReadInput(filename);
            CandidateSolution candidate = new CandidateSolution(_items, -1, null);
            CandidateSolution best = candidate;
            
            PriorityQueue<int, CandidateSolution> queue =  new PriorityQueue<int, CandidateSolution>();
            queue.Add(candidate, ComputeBounds(candidate, ref best));
            
            while (queue.Count > 0 && queue.MaximumPriority >= best.Value)
            {
                CandidateSolution root = queue.RemoveMaximumPriority();
                int k = root.Index + 1;
                for (int j = k; j < _items.Count; j++)
                {
                        CandidateSolution child = new CandidateSolution(_items, j, root);
                        if (child.Weight <= _weightLimit)
                        {
                            int childBounds = ComputeBounds(child, ref best);
                            if (childBounds > best.Value)
                            {
                                queue.Add(child, childBounds);
                            }
                        }
                }

            }
            _totalValue = best.Value;
            _totalWeight = best.Weight;
            while(best.Previous != null)
            {
                KnapsackItem tmp = _items[best.Index];
                tmp.SelectionText = "X";
                _items[best.Index] = tmp;
                best = best.Previous;
            }

        }

        /// <summary>
        /// Displays solution on the GUI
        /// </summary>
        public void ShowSolution()
        {
            uxFileName.Text = uxOpenDialog.FileName;
            uxLimit.Text = _weightLimit.ToString();
            uxTotalValue.Text = _totalValue.ToString();
            uxTotalWeight.Text = _totalWeight.ToString();
            uxSolution.Rows.Clear();
            if (uxSolution.SortedColumn != null)
            {
                uxSolution.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                uxSolution.SortedColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            uxSolution.Rows.Add(_items.Count);
            for (int i = 0; i < _items.Count; i++)
            {
                float density = _items[i].Value/(float)_items[i].Weight;
                uxSolution.Rows[i].SetValues(_items[i].Id, _items[i].Value, _items[i].Weight, density, _items[i].SelectionText);
            }

            
        }

        /// <summary>
        /// Writes the optimal solution to a file.
        /// </summary>
        /// <param name="filename">File to be saved to</param>
        public void WriteSolution(string filename)
        {
            using(StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(_weightLimit.ToString() + "," + _totalValue.ToString() + "," + _totalWeight.ToString());
                for (int i = 0; i < _items.Count; i++)
                {
                    sw.WriteLine(_items[i].Id.ToString() + "," + _items[i].Value.ToString() + "," + _items[i].Weight.ToString() + "," + _items[i].SelectionText.ToString());
                }
            }
            MessageBox.Show("File Written");
        }

        /// <summary>
        /// Event Handler for the Open File button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    Solve(uxOpenDialog.FileName);
                    uxSave.Enabled = true;
                    ShowSolution();
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Event handler for the save solution button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    WriteSolution(uxSaveDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
