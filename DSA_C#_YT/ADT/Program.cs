// using System.Collections;
// using ADT;
// Stack stack = new Stack();
// Pokemon squirtle = new Pokemon();

/**Arrays*/
// Array Insertions & Deletions

// Insert at end of array O(1) - Constant

int[] intArray = new int[10];

// We made a variable to keep the track of length because  .Length is based off capacity and does track the actual index
int length = 0;

for (int i = 0; i < 8; i++)
{
    intArray[length] = 1;
    length++;
}
intArray[length] = 8;
length++;

// Insert at start of array O(1) - Constant
// for (int i = 3; i >= 0; i--)
// {
//     // This is  moving over all the values e.g 5th value becomes 4th value
//     intArray[i + 1] = intArray[3];
// }
// intArray[0] = 20;
// int value = 0;

// Insert anywhere in an array; For example 5th value
for (int i = 4; i >= 2; i--)
{
    // Shift each element one position to the right
    intArray[i + 1] = intArray[i + 2];
}
intArray[2] = 8;
