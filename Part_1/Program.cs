namespace Part_1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    }

    public static void Log(int[] numbers)
    {
        // O(1) => Constant time
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[0]);
    }

    // public void Log2(int[] numbers)
    // {
    //     //---> O(1 + n + 1) = O(2 + n) ===> O(n)
    //     Console.WriteLine(); //O(1)

    //     for (int i = 0; i < numbers.Length; i++)  // O(n)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }
    //     Console.WriteLine(); //O(1)

    // }

    // public void Log3(int[] numbers)
    // {
    //     //---> O(n+ n) = O(2n) ===> O(n) N.B n or 2n still represents a Linear growth

    //     for (int i = 0; i < numbers.Length; i++)  // O(n)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }
    //     for (int i = 0; i < numbers.Length; i++)  // O(n)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }
    // }
    // public void Log4(int[] numbers, string[] names)
    // {
    //     //---> O(n+ m)  ===> O(n) N.B This still represents a Linear growth

    //     for (int i = 0; i < numbers.Length; i++)  // O(n)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }
    //     for (int i = 0; i < names.Length; i++)  // O(m)
    //     {
    //         Console.WriteLine(names[i]);
    //     }
    // }
}
