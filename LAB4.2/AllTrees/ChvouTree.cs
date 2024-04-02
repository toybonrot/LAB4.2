using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4._2.AllTrees
{
    public class ChvouTree : Tree
    {
        double spikeLength { get; set; }
        public ChvouTree(int age, bool infected, double spikeLength) : base(age, infected)
        {
            this.spikeLength = spikeLength;
        }
        public override string ToString()
        {
            return $"Chvoi tree, " + base.ToString() + $", spike Length = {spikeLength}";
        }
    }
}
