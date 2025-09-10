using static ExercicioAvl.WorkNode;
using static ExercicioAvl.RotateNode;

namespace ExercicioAvl
{
    internal static class RemoveNode
    {
        public static Node Remove(Node root, int key)
        {
            if (root == null) return root;

            if (key < root.Key)
                root.LeftSon = Remove(root.LeftSon, key);
            else if (key > root.Key)
                root.RightSon = Remove(root.RightSon, key);
            else
            {
                if (root.LeftSon == null || root.RightSon == null)
                    root = root.LeftSon ?? root.RightSon;
                else
                {
                    var temp = MinValueNode(root.RightSon);
                    root.Key = temp.Key;
                    root.RightSon = Remove(root.RightSon, temp.Key);
                }
            }

            if (root == null) return root;

            UpdateHeight(root);

            int bf = BalanceFactor(root);

            if (bf > 1 && BalanceFactor(root.LeftSon) >= 0)
                return RotateRight(root);

            if (bf > 1 && BalanceFactor(root.LeftSon) < 0)
            {
                root.LeftSon = RotateLeft(root.LeftSon);
                return RotateRight(root);
            }

            if (bf < -1 && BalanceFactor(root.RightSon) <= 0)
                return RotateLeft(root);

            if (bf < -1 && BalanceFactor(root.RightSon) > 0)
            {
                root.RightSon = RotateRight(root.RightSon);
                return RotateLeft(root);
            }

            return root;
        }

        private static Node MinValueNode(Node node)
        {
            var current = node;
            while (current.LeftSon != null)
                current = current.LeftSon;
            return current;
        }
    }
}
