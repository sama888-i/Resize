using System.Globalization;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 17, 8, 88 };
            InsertArray(ref numbers, 9);

        }
        static void InsertArray(ref int[] arr, params int[] numbers)
        {
            int newLength = arr.Length + numbers.Length;
            int[] newarray = new int[newLength];

            for (int i = 0; i < arr.Length; i++)
            {
                newarray[i] = arr[i];


            }

            arr = newarray;
            Console.Write(arr.Length);


        }
    }
}
