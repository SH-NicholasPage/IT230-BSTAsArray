namespace BSTAsArray
{
    public class Program
    {
        public static void Main()
        {
            TestBSTArray();
            //You can add additional test cases here
        }

        //DO NOT MODIFY THIS METHOD
        private static void TestBSTArray()
        {
            BinarySearchTreeArray<int> bst = new BinarySearchTreeArray<int>();
            bst.Insert(50);//Root
            //Left subtree
            bst.Insert(25);
            bst.Insert(10);
            bst.Insert(33);
            bst.Insert(4);
            bst.Insert(11);
            bst.Insert(30);
            bst.Insert(40);
            //Right subtree
            bst.Insert(75);
            bst.Insert(56);
            bst.Insert(89);
            bst.Insert(52);
            bst.Insert(61);
            bst.Insert(82);
            bst.Insert(95);
            Console.WriteLine(bst);

            Console.WriteLine("Starting tree...");
            Console.WriteLine(bst);

            doDeletion(bst, 4);
            doDeletion(bst, 10);
            doDeletion(bst, 56);

            Console.WriteLine("Adding 55...");
            bst.Insert(55);
            Console.WriteLine(bst);

            doDeletion(bst, 50);
        }

        //DO NOT MODIFY THIS METHOD
        public static void doDeletion(BinarySearchTreeArray<int> bst, int value)
        {
            Console.WriteLine("\n===============================");
            bst.Delete(value);
            Console.WriteLine($"After deleting {value}...");
            Console.WriteLine(bst);
            Console.WriteLine("===============================\n");
        }
    }
}