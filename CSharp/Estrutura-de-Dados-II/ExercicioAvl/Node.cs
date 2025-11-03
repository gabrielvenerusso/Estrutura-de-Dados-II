namespace ExercicioAvl
{
    public class Node
    {
        public int Key;
        public Node LeftSon, RightSon;
        public int Height = 1;

        public Node(int key) { Key = key; }
    }
}
