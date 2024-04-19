namespace Arrays
{
    public class ArrayClass
    {
        private int[]? items;
        private int count;

        public ArrayClass(int length)
        {
            items = new int[length];

        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items?[i]);
            }
        }

        public void Insert(int item)
        {
            //if full we need to resize it
            if (items?.Length == count)
            {
                // Create a new Array(twice as large)
                int[] newItems = new int[count * 2];
                //Copy all the existing items
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                // Set "items to this new array
                items = newItems;
            }
            items![count] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            // Validate the index
            if (index < 0 || index >= count)
            {
                throw new ArgumentException("Illegal Argument");
            }
            // Shift items to the left to fill the hole
            // [10, 20, 30, 40]
            // [10, 30, 40]
            // index: 1
            // 1 <-2
            // 2 <- 3
            for (int i = index; i < count; i++)
            {
                items![i] = items[i + 1];
            }
            count--;

        }

        public int IndexOf(int item)
        {
            // If we find it, return index
            for (int i = 0; i < count; i++)
            {
                // Otherwise , return -1 
                if (items![i] == item)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}