
namespace Stacks;
public class Stack
{
    private int[] items = new int[5];
    private int count;

    public void Push(int item)
    {
        items[count] = item;
        count++;
    }

}
