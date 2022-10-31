namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frequency Counter using Hash Table ");

            FrequencyInLargeParagraph paragraph = new FrequencyInLargeParagraph();
            paragraph.frequency();
        }
    }
}
