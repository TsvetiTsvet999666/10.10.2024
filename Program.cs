using System.Threading.Tasks.Dataflow;

namespace InsertionSort_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { -3, 5, 1, 9, -12, 4, 6, -2, 0 };
            Console.WriteLine("Original list:");
            DisplayList(numbers);
            SortList(numbers);
            Console.WriteLine("Sort list:");
            DisplayList(numbers);
            List<int> filteredList = FilterList(numbers);
            Console.WriteLine("List after remove negative odd values:");
            DisplayList(filteredList);
        }

        static void SortList(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }

        static List<int> FilterList(List<int> list)
        {
            return list.Where(n => !(n < 0 && n % 8 != 0)).ToList();
        }

        static void DisplayList(List<int> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
