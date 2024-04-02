using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4._2.AllTrees
{
    public class LeavesTree : Tree
    {
        double LeaveSquer { get; set; }
        public LeavesTree(int age, bool infected, double LeaveSquer) : base(age, infected)
        {
            this.LeaveSquer = LeaveSquer;
        }
        public override string ToString()
        {
            return "Leaves tree, " + base.ToString() + $", Leaves Square = {LeaveSquer}";
        }
    }
}
