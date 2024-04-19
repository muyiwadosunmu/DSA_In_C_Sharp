using System.Collections;

namespace Arrays
{
    public class Program
    {

        // public static void Main(string[] args)
        // {
        //     ArrayClass numbers = new(5);
        //     numbers.Insert(10);
        //     numbers.Insert(20);
        //     numbers.Insert(30);
        //     numbers.Insert(40);
        //     Console.WriteLine(numbers.IndexOf(20));
        //     numbers.RemoveAt(0);
        //     numbers.IndexOf(20);
        //     numbers.Print();

        // }

        // ArrayList
        public static void Main(string[] args)
        {
            ArrayList arrayList = new()
            {
                10,
                20,
                30
            };

            arrayList.Remove(0);
            arrayList.IndexOf(2);
            arrayList.Contains(20);


            Console.WriteLine("ArrayList elements:");
            foreach (int num in arrayList)
            {
                Console.WriteLine(num);
            }

        }

        // public static void Main(string[] args)
        // {
        //     List<string> strings = new() {
        //         "Mayor", "Mosh","Joshua"
        //     };
        //     Console.WriteLine(strings[0]);
        //     strings.Add("Boy");
        //     Console.WriteLine(strings.Count);

        //     foreach (var item in strings)
        //     {
        //         Console.WriteLine(item);
        //     }

        // }
        // public static void Main(string[] args)
        // {
        //     int[] numbers = new int[4];
        //     int[] numbers2 = { 10, 20, 30, 40 };
        //     // Console.WriteLine(numbers.ToString());
        //     // Console.WriteLine(Array.AsReadOnly(numbers));
        //     Console.WriteLine(string.Join(", ", numbers2));
        //     Console.WriteLine(numbers2.Length);

        // }

    }

}