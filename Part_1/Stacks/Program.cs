namespace Stacks;

public class Program
{
    public static void Main(string[] args)
    {
        // var stack = new Stack<int>();
        // stack.Push(10);
        // stack.Push(20);
        // stack.Push(30);
        // Console.WriteLine(stack);
        // stack.Pop();
        // Console.WriteLine(stack);
        // Console.WriteLine(string.Join(", ", stack));
        string str = "abcd";
        StringReversal reverser = new();
        var result = reverser.Reverse(str);
        Console.WriteLine(result);
    }

}
