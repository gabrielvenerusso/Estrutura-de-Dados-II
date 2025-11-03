using System;
using ExercicioAvl;

namespace ExercicioAvl
{
    public class WorkNode
    {
        public Node Root;

        public void Insert(int key) => Root = InsertNode.Insert(Root, key);

        public static int HeightOf(Node no) => no?.Height ?? 0;

        public static int BalanceFactor(Node no) =>
            no == null ? 0 : HeightOf(no.LeftSon) - HeightOf(no.RightSon);

        public static void UpdateHeight(Node no) =>
            no.Height = 1 + Math.Max(HeightOf(no.LeftSon), HeightOf(no.RightSon));

        public void Remove(int key) => Root = RemoveNode.Remove(Root, key);

    }
}
