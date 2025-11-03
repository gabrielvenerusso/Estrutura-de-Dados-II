using System;
using static ExercicioAvl.WorkNode;

namespace ExercicioAvl
{
    public static class PrintNode
    {
        public static void Print(WorkNode tree)
        {
            if (tree?.Root == null)
            {
                Console.WriteLine("A árvore está vazia.");
                return;
            }

            Print(tree.Root, "", false);
        }

        public static void Print(Node node, string prefix = "", bool isLeft = false)
        {
            if (node == null) return;

            Print(node.RightSon, prefix + (isLeft ? "│   " : "    "), false);

            int bf = BalanceFactor(node);
            Console.WriteLine($"{prefix}{(isLeft ? "└──" : "┌──")} {node.Key} (bf={bf})");

            Print(node.LeftSon, prefix + (isLeft ? "    " : "│   "), true);
        }
    }
}
