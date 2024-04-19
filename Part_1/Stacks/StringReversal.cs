using System.Text;

namespace Stacks;

public class StringReversal
{
    public string Reverse(string input)
    {
        if (input == null) throw new InvalidDataException();
        var stack = new Stack<char>();

        foreach (var ch in input.ToCharArray())
        {
            stack.Push(ch);
        }

        // Not efficient using normal string concatenation
        // string reversed = "";
        // while (!(stack.Count == 0))
        // {
        //     reversed += stack.Pop();
        // }
        StringBuilder reversed = new();
        while (!(stack.Count == 0))
        {
            reversed.Append(stack.Pop());
        }
        return reversed.ToString();



    }

}
