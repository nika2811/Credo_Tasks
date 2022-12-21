namespace Branch_sums
{
    public class Program
    {
        public class BinaryTreeNode
        {
            public BinaryTreeNode? Left;
            public BinaryTreeNode? Right;
            public int Value;

            public BinaryTreeNode(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
        private static List<int> BranchSums(BinaryTreeNode root, int runningSum = 0)
        {
            if (root == null) return new List<int>();

            runningSum += root.Value;
            var sums = new List<int>();

            if (root.Left == null && root.Right == null)
            {
                sums.Add(runningSum);
                return sums;
            }

            sums.AddRange(BranchSums(root.Left, runningSum));
            sums.AddRange(BranchSums(root.Right, runningSum));

            return sums;
        }


        public static void Main()
        {
            var root = new BinaryTreeNode(1);

            root.Left = new BinaryTreeNode(2);
            root.Right = new BinaryTreeNode(3);

            root.Left.Left = new BinaryTreeNode(4);
            root.Left.Right = new BinaryTreeNode(5);
            root.Right.Left = new BinaryTreeNode(6);
            root.Right.Right = new BinaryTreeNode(7);

            root.Left.Left.Left = new BinaryTreeNode(8);
            root.Left.Left.Right = new BinaryTreeNode(9);

            root.Left.Right.Left = new BinaryTreeNode(10);

            var sums = BranchSums(root);
            Console.WriteLine(string.Join(", ", sums)); // უნდა გამოიტანოს 15, 16, 18, 10, 11
        }
    }
}