namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeOperations<int> binarySearchTreeOperations = new BinarySearchTreeOperations<int>();
            Console.WriteLine("Enter 1 to Create Binary Search Tree");
            Console.WriteLine("Enter 2 to Add elements in Binary Search Tree");
            Console.WriteLine("Enter 3 to Search element in Binary Search Tree");
            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                case 1:
                    binarySearchTreeOperations.AddElement(56);
                    binarySearchTreeOperations.AddElement(30);
                    binarySearchTreeOperations.AddElement(70);
                    break;
                case 2:
                    binarySearchTreeOperations.AddElement(56);
                    binarySearchTreeOperations.AddElement(30);
                    binarySearchTreeOperations.AddElement(22);
                    binarySearchTreeOperations.AddElement(40);
                    binarySearchTreeOperations.AddElement(11);
                    binarySearchTreeOperations.AddElement(3);
                    binarySearchTreeOperations.AddElement(16);
                    binarySearchTreeOperations.AddElement(70);
                    binarySearchTreeOperations.AddElement(60);
                    binarySearchTreeOperations.AddElement(95);
                    binarySearchTreeOperations.AddElement(65);
                    binarySearchTreeOperations.AddElement(63);
                    binarySearchTreeOperations.AddElement(67);
                    break;
                case 3:
                    binarySearchTreeOperations.AddElement(56);
                    binarySearchTreeOperations.AddElement(30);
                    binarySearchTreeOperations.AddElement(22);
                    binarySearchTreeOperations.AddElement(40);
                    binarySearchTreeOperations.AddElement(11);
                    binarySearchTreeOperations.AddElement(3);
                    binarySearchTreeOperations.AddElement(16);
                    binarySearchTreeOperations.AddElement(70);
                    binarySearchTreeOperations.AddElement(60);
                    binarySearchTreeOperations.AddElement(95);
                    binarySearchTreeOperations.AddElement(65);
                    binarySearchTreeOperations.AddElement(63);
                    binarySearchTreeOperations.AddElement(67);
                    Console.WriteLine("Searching 63 in binary search tree");
                    binarySearchTreeOperations.SearchElement(63);
                    break;

                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
        }
    }
}