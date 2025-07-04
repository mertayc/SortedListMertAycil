using SortedListMertAycil.Business;

internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("How many numbers should be created (default 10): ");
            int size = int.TryParse(Console.ReadLine(), out int parsedSize) ? parsedSize : 10;

            Console.Write("Minimum value (default 0): ");
            int min = int.TryParse(Console.ReadLine(), out int parsedMin) ? parsedMin : 0;

            Console.Write("Maximum value (default 100): ");
            int max = int.TryParse(Console.ReadLine(), out int parsedMax) ? parsedMax : 100;

            Console.WriteLine("\nUnsorted list:\n");

            var unsortedList = ListProcess.GenerateRandomList(size, min, max);

            foreach (var item in unsortedList)
                Console.Write($"{item} ");

            Console.WriteLine("\n\nSorting the list using Merge Sort algorithm...\n");
            var sortedList = MergeSortAlgoritm.MergeSort(unsortedList);

            foreach (var item in sortedList)
                Console.Write($"{item} ");

            Console.WriteLine("\n\nEnter a number to check if it exists in the sorted list: ");
            string numberToCheck = Console.ReadLine();
            var checkResult = ListProcess.CheckNumberInList(numberToCheck, sortedList);
            Console.WriteLine(checkResult);

            Console.WriteLine("\n\nPress any key to run again or 'q' to quit.");

            var key = Console.ReadKey();
            if (key.KeyChar == 'q' || key.KeyChar == 'Q')
                break;
        }
    }
}