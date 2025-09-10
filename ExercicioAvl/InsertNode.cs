using System;
using static ExercicioAvl.WorkNode;    
using static ExercicioAvl.RotateNode;    

namespace ExercicioAvl
{
    internal static class InsertNode
    {
        public static Node Insert(Node node, int key)
        {
            if (node == null) return new Node(key);

            if (key < node.Key)
                node.LeftSon = Insert(node.LeftSon, key);
            else if (key > node.Key)
                node.RightSon = Insert(node.RightSon, key);  
            else
                return node; 

            UpdateHeight(node);
            int bf = BalanceFactor(node);


            if (bf > 1 && key < node.LeftSon.Key)
                return RotateRight(node);

            if (bf < -1 && key > node.RightSon.Key)
                return RotateLeft(node);

            if (bf > 1 && key > node.LeftSon.Key)
            {
                node.LeftSon = RotateLeft(node.LeftSon);
                return RotateRight(node);
            }

            if (bf < -1 && key < node.RightSon.Key)
            {
                node.RightSon = RotateRight(node.RightSon);
                return RotateLeft(node);
            }

            return node;
        }
    }
}
