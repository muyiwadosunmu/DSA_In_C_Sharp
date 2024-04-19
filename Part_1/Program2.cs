// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Hello from O(n*n)");

//     }
//     public void Log(int[] numbers)
//     {
//         //---> O(n * n) => O(n^2)

//         for (int i = 0; i < numbers.Length; i++)  // O(n)
//         {
//             for (int j = 0; j < numbers.Length; i++)  // O(n)
//             {
//                 Console.WriteLine(numbers[i]);
//             }
//         }

//     }

//     public void Log1(int[] numbers)
//     {
//         //---> O(n +  n* n) => O(n^2) ==== Quadratic
//         for (int j = 0; j < numbers.Length; i++)  // O(n)
//         {
//             Console.WriteLine(numbers[i]);
//         }
//         for (int i = 0; i < numbers.Length; i++)  // O(n)
//         {
//             for (int j = 0; j < numbers.Length; i++)  // O(n)
//             {
//                 Console.WriteLine(numbers[i]);
//             }
//         }

//     }

//     public void Log1(int[] numbers)
//     {
//         //---> O(n +  n* n) => O(n^2)

//         for (int i = 0; i < numbers.Length; i++)  // O(n)
//         {
//             for (int j = 0; j < numbers.Length; j++)  // O(n)
//             {
//                 for (int k = 0; k < numbers.Length; k++)  // O(n)
//                 {
//                     Console.WriteLine(numbers[j]);
//                 }
//             }
//         }

//     }
// }