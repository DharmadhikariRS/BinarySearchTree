namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeOperations<int> binarySearchTreeOperations = new BinarySearchTreeOperations<int>();
            Console.WriteLine("Enter 1 to Create Binary Search Tree");

            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                case 1:
                    binarySearchTreeOperations.AddElement(56);
                    binarySearchTreeOperations.AddElement(30);
                    binarySearchTreeOperations.AddElement(70);
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
        }
    }
}