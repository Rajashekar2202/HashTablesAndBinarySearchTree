namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frequency Counter using Hash Table ");
            FrequencyInLine line = new FrequencyInLine();
            line.freqPerWord();
        }
    }
}
