namespace Part_1;

public class Space
{
    // public void Greet(string[] names)
    // {
    //     // 0(1) space
    //     for (int i = 0; i < names.Length; i++)
    //     {
    //         Console.WriteLine("Hi" + names[i]);
    //     }
    // }

    public static void Greet(string[] names)
    {
        // 0(n)
        string[] copy = new string[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Hi" + names[i]);
        }
    }
}
