namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable and BinarySearch Tree");

            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
        }
    }
}