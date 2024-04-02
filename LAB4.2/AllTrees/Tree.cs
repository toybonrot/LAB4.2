using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4._2.AllTrees
{
    public class Tree
    {
        //protected string type { get; set; }
        public int age { get; set; }
        protected bool infected { get; set; }
        public Tree()
        {
            age = 0;
            infected = false;
        }
        public Tree(/*string type, */int age, bool infected)
        {
            //this.type = type;
            this.age = age;
            this.infected = infected;
        }

        public override string ToString()
        {
            return $"age = {age}, infected = {infected}";
        }
    }
}
