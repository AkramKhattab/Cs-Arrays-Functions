using static System.Formats.Asn1.AsnWriter;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Xml.Linq;

namespace C42_G04_CS04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region One-Dimensional Array
        // Declaring and initializing a one-dimensional array
        int[] oneDArray = { 1, 2, 3, 4, 5 };
        // Accessing elements in the array
        Console.WriteLine("One-Dimensional Array:");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.WriteLine(oneDArray[i]);
        }
        #endregion

        #region Two-Dimensional Array (Rectangular Array)
        // Declaring and initializing a rectangular two-dimensional array
        int[,] rectArray = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        // Accessing elements in the array
        Console.WriteLine("\nTwo-Dimensional Rectangular Array:");
        for (int i = 0; i < rectArray.GetLength(0); i++)
        {
            for (int j = 0; j < rectArray.GetLength(1); j++)
            {
                Console.Write(rectArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Two-Dimensional Array (Jagged Array)
        // Declaring and initializing a jagged array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        // Accessing elements in the array
        Console.WriteLine("\nTwo-Dimensional Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Functions Prototype and Calling
        // Function prototype
        int Add(int a, int b);
        // Function calling
        int result = Add(3, 4);
        Console.WriteLine("\nFunction Prototype and Calling:");
        Console.WriteLine("Sum: " + result);

        int Add(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region Functions - ValueType Parameters
        // Function with value type parameters
        void Square(int number)
        {
            number *= 2;
            Console.WriteLine("Squared Value: " + number);
        }

        int value = 5;
        Square(value);
        Console.WriteLine("Original Value: " + value);
        #endregion

        #region Functions - ReferenceType Parameters
        // Function with reference type parameters
        void ChangeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
        }

        int[] array = { 1, 2, 3, 4, 5 };
        ChangeArray(array);
        Console.WriteLine("\nReference Type Parameters:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
        #endregion

        #region Function - Passing By Out
        // Function with out parameters
        void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        int num1 = 10, num2 = 3;
        Divide(num1, num2, out int q, out int r);
        Console.WriteLine("\nPassing By Out:");
        Console.WriteLine($"Quotient: {q}, Remainder: {r}");
        #endregion

        #region Functions - Params
        // Function with params
        int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine("\nFunctions - Params:");
        Console.WriteLine("Sum: " + total);
        #endregion
            
        }
    }
}
