using LAB4._2.AllTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4._2
{
    public class Forest
    {
        List<Tree> trees;
        public Forest()
        {
            trees = new List<Tree>();
        }
        public void Show()
        {
            foreach (Tree tree in trees)
            {
                Console.WriteLine(tree.ToString());
            }
            Console.WriteLine();
        }
        public double ForestSquer()
        {
            return trees.Count;
        }
        public void SortType()
        {
            trees.Sort((a, b) => a.GetType().Name.CompareTo(b.GetType().Name));
            Show();
        }
        public void SortAmount()
        {
            var groupedTrees = trees.GroupBy(t => t.GetType()).OrderByDescending(g => g.Count());
            List<Tree> sortedTrees = new List<Tree>();
            foreach (var group in groupedTrees)
            {
                sortedTrees.AddRange(group);
            }
            trees = sortedTrees;
            Show();
        }
        public void SortAge()
        {
            trees.Sort((x, y) => x.age.CompareTo(y.age));
            Show();
        }
        public void RemoveTree()
        {
            Show();
            Console.WriteLine("Яке за номером видалити?");
            int input = int.Parse(Console.ReadLine());
            if (input > trees.Count)
            {
                Console.WriteLine("Такого за номером немає");
            }
            else
            {
                trees.RemoveAt(input - 1);
            }
            Console.Clear();
            Show();
        }
        private int QAge()
        {
            Console.WriteLine("Вік: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }
        private bool QInf()
        {
            while (true)
            {
                Console.WriteLine("Є шкідники?(Так/+ чи Ні/-): ");
                string input = Console.ReadLine();
                if (input == "Так" || input == "так" || input == "+")
                {
                    return true;
                }
                else if (input == "Ні" || input == "ні" || input == "-")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Не зрозуміла відповідь");
                }
            }
        }
        public void AddTree()
        {
            Console.WriteLine("Тип дерева: ");
            string type = Console.ReadLine();
            if (type == "")
            {
                int age = QAge();
                bool infected = QInf();
                trees.Add(new Tree(age, infected));
            }
            else if (type == "Chvou tree")
            {
                int age = QAge();
                bool infected = QInf();
                Console.WriteLine("Розмір гілок: ");
                double spikeLength = double.Parse(Console.ReadLine());
                trees.Add(new ChvouTree(age, infected, spikeLength));
            }
            else if (type == "Leaves tree")
            {
                int age = QAge();
                bool infected = QInf();
                Console.WriteLine("Розмір листків: ");
                double LeavesSquer = double.Parse(Console.ReadLine());
                trees.Add(new LeavesTree(age, infected, LeavesSquer));
            }
            else
            {
                Console.WriteLine("Такого типу не існує");
            }
        }
        public void AddTree/*(string type, */(int age, bool infected)
        {
            trees.Add(new Tree(age, infected));
        }

    }
}
