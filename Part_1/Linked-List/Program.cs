
namespace Linked_List;


class Program
{

    public static void Main(string[] args)
    {
        var list = new LinkedList();
        Console.WriteLine(list.Size());
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        Console.WriteLine(list.IndexOf(10));
        list.RemoveFirst();
        Console.WriteLine(list.Size());
        Console.WriteLine(list.Contains(30));
        Console.WriteLine(list.Contains(40));
        var array = list.ToArray().ToString();




        // LinkedList<int> linkedList = new();

        // linkedList.AddLast(1);
        // linkedList.AddLast(2);
        // linkedList.AddLast(3);
        // linkedList.AddLast(4);
        // linkedList.AddLast(5);

        // Console.WriteLine(string.Join(", ", linkedList));
        // Console.WriteLine(linkedList.Contains(2));
        // Console.WriteLine(linkedList.Count);
        // Console.WriteLine(linkedList.ToArray());
    }

}