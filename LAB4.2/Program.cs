using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB4._2.AllTrees;

namespace LAB4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            Cons(forest);

        }
        static void Cons(Forest forest)
        {
            while (true)
            {          
            Console.WriteLine(" 1.Show inf \n 2. Sort type \n 3. Sort age \n 4. Sort amount \n 5. Get squer of forest" +
                "\n 6. Remove old tree \n 7. Add new tree \n 8. Quit");
            string com = Console.ReadLine();
                switch (com)
                {
                    case "1": Console.Clear(); forest.Show(); break;

                    case "2": Console.Clear(); forest.SortType(); break;

                    case "3": Console.Clear(); forest.SortAge(); break;

                    case "4": Console.Clear(); forest.SortAmount(); break;

                    case "5": Console.Clear(); Console.WriteLine(forest.ForestSquer() + " meters\n"); 
                        break;

                    case "6": Console.Clear(); forest.RemoveTree(); break;

                    case "7": Console.Clear(); forest.AddTree(); break;

                    case "8": return;
                }
            }
        }
    }

    }

    
