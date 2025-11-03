using static ExercicioAvl.WorkNode;

namespace ExercicioAvl
{
    internal static class RotateNode
    {
        public static Node RotateRight(Node y)
        {
            var x = y.LeftSon;
            var t2 = x.RightSon;

            x.RightSon = y;
            y.LeftSon = t2;

            UpdateHeight(y);
            UpdateHeight(x);
            return x;
        }

        public static Node RotateLeft(Node x)
        {
            var y = x.RightSon;
            var t2 = y.LeftSon;

            y.LeftSon = x;
            x.RightSon = t2;

            UpdateHeight(x);
            UpdateHeight(y);
            return y;
        }
    }
}
