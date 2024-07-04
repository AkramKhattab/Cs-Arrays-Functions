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
    //class MyClass
    //{
    //    public int Value { get; set; }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string originalString = "Hello, world!";
            //    int position = 7; // Replace the character at position 7 (zero-based)
            //    char newChar = 'W'; // Replace with the letter 'W'
            //    string modifiedString = ChangeChar(originalString, position, newChar);
            //    Console.WriteLine(modifiedString); // Output: Hello, World!}}}

            //================================================================================//
            // You can call the MinMaxArray function here with your desired array and variables to store min and max values.

            /*int[] numbers = { 5, 3, 9, 1, 4, 8, 7, 2, 6 };
            int minValue = 0;
            int maxValue = 0;
            MinMaxArray(numbers, ref minValue, ref maxValue);
            Console.WriteLine($"Minimum value: {minValue}");
            Console.WriteLine($"Maximum value: {maxValue}");*/
            //==============================================================================//

            #region Q1.Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.

            //            int a = 10;
            //            int b = 10;

            //            Console.WriteLine($"Before pass by value: {a}");
            //            PassByValue(a);
            //            Console.WriteLine($"After pass by value: {a}");

            //            Console.WriteLine($"Before pass by reference: {b}");
            //            PassByReference(ref b);
            //            Console.WriteLine($"After pass by reference: {b}");

            //            static void PassByValue(int x)
            //            {
            //                x = 20;
            //            }

            //            static void PassByReference(ref int x)
            //            {
            //                x = 20;
            //            }
            //        }
            //    }
            //}

            #endregion


            #region  Q2.Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.

            //            MyClass obj1 = new MyClass { Value = 10 };
            //            MyClass obj2 = new MyClass { Value = 10 };

            //            Console.WriteLine($"Before pass by value: {obj1.Value}");
            //            PassByValue(obj1);
            //            Console.WriteLine($"After pass by value: {obj1.Value}");

            //            Console.WriteLine($"Before pass by reference: {obj2.Value}");
            //            PassByReference(ref obj2);
            //            Console.WriteLine($"After pass by reference: {obj2.Value}");
            //        }

            //        static void PassByValue(MyClass obj)
            //        {
            //            // Modifying the object itself; this will reflect outside the method
            //            obj.Value = 20;

            //            // Assigning a new object; this will NOT reflect outside the method
            //            obj = new MyClass { Value = 30 };
            //        }

            //        static void PassByReference(ref MyClass obj)
            //        {
            //            // Modifying the object itself; this will reflect outside the method
            //            obj.Value = 20;

            //            // Assigning a new object; this will also reflect outside the method
            //            obj = new MyClass { Value = 30 };
            //        }
            //    }
            //}


            #endregion


            #region Q3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //            Console.WriteLine("Enter four numbers:");

            //            Console.Write("Enter first number: ");
            //            int num1 = int.Parse(Console.ReadLine());

            //            Console.Write("Enter second number: ");
            //            int num2 = int.Parse(Console.ReadLine());

            //            Console.Write("Enter third number: ");
            //            int num3 = int.Parse(Console.ReadLine());

            //            Console.Write("Enter fourth number: ");
            //            int num4 = int.Parse(Console.ReadLine());

            //            (int sumResult, int subResult) = SumAndSubtract(num1, num2, num3, num4);

            //            Console.WriteLine($"Sum of {num1} and {num2} is: {sumResult}");
            //            Console.WriteLine($"Subtraction of {num3} from {num4} is: {subResult}");
            //        }

            //        static (int, int) SumAndSubtract(int num1, int num2, int num3, int num4)
            //        {
            //            int sum = num1 + num2;
            //            int difference = num4 - num3;
            //            return (sum, difference);
            //        }
            //    }
            //}

            #endregion


            #region Q4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            /*Output should be like
            Enter a number: 25
            The sum of the digits of the number 25 is: 7*/
            //----------------------------------------------//

            //                Console.Write("Enter a number: ");
            //            int number = int.Parse(Console.ReadLine());

            //            int sumOfDigits = CalculateSumOfDigits(number);

            //            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
            //        }

            //        static int CalculateSumOfDigits(int number)
            //        {
            //            int sum = 0;
            //            while (number != 0)
            //            {
            //                sum += number % 10;
            //                number /= 10;
            //            }
            //            return sum;
            //        }
            //    }
            //}

            #endregion


            #region Q5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //            Console.Write("Enter a number: ");
            //            int number = int.Parse(Console.ReadLine());

            //            bool isPrime = IsPrime(number);

            //            if (isPrime)
            //            {
            //                Console.WriteLine($"{number} is a prime number.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{number} is not a prime number.");
            //            }
            //        }

            //        static bool IsPrime(int number)
            //        {
            //            if (number <= 1)
            //            {
            //                return false;
            //            }

            //            for (int i = 2; i <= Math.Sqrt(number); i++)
            //            {
            //                if (number % i == 0)
            //                {
            //                    return false;
            //                }
            //            }
            //            return true;
            //        }
            //    }
            //}

            #endregion


            #region Q6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //            static void MinMaxArray(int[] array, ref int min, ref int max)
            //            {
            //                if (array == null || array.Length == 0)
            //                {
            //                    throw new ArgumentException("The array cannot be null or empty.");
            //                }

            //                // Initialize min and max with the first element of the array
            //                min = array[0];
            //                max = array[0];

            //                // Iterate through the array to find the min and max values
            //                foreach (int number in array)
            //                {
            //                    if (number < min)
            //                    {
            //                        min = number;
            //                    }
            //                    if (number > max)
            //                    {
            //                        max = number;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion


            #region Q7.Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter

            // Example usage:
            //            int number = 5;
            //            long factorialResult = CalculateFactorial(number);
            //            Console.WriteLine($"The factorial of {number} is {factorialResult}");
            //        }

            //        // Iterative function to calculate factorial
            //        static long CalculateFactorial(int n)
            //        {
            //            long result = 1;
            //            for (int i = 1; i <= n; i++)
            //            {
            //                result *= i;
            //            }
            //            return result;
            //        }
            //    }
            //}
            #endregion


            #region Q8.Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter

            //            public static string ChangeChar(string inputString, int position, char newChar)
            //            {
            //                if (position < 0 || position >= inputString.Length)
            //                {
            //                    // Invalid position, return the original string unchanged
            //                    return inputString;
            //                }

            //                char[] charArray = inputString.ToCharArray();
            //                charArray[position] = newChar;

            //                return new string(charArray);
            //            }
            //        }
            //    }
            //}
            #endregion

            #region Q9.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //            Console.WriteLine("Enter the size of the identity matrix:");
            //            int n = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Identity Matrix:");

            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n; j++)
            //                {
            //                    if (i == j)
            //                    {
            //                        Console.Write("1 ");
            //                    }
            //                    else
            //                    {
            //                        Console.Write("0 ");
            //                    }
            //                }

            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //}
            #endregion


            #region Q10.Write a program in C# Sharp to find the sum of all elements of the array.

            //            int[] array = { 1, 2, 3, 4, 5 };

            //            int sum = 0;

            //            foreach (int element in array)
            //            {
            //                sum += element;
            //            }

            //            Console.WriteLine("Sum of all elements in the array: " + sum);
            //        }
            //    }
            //}
            #endregion


            #region Q11.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //            int[] array1 = { 1, 3, 5, 7, 9 };
            //            int[] array2 = { 2, 4, 6, 8, 10 };

            //            int[] mergedArray = new int[array1.Length + array2.Length];

            //            int i = 0, j = 0, k = 0;

            //            while (i < array1.Length && j < array2.Length)
            //            {
            //                if (array1[i] < array2[j])
            //                {
            //                    mergedArray[k] = array1[i];
            //                    i++;
            //                }
            //                else
            //                {
            //                    mergedArray[k] = array2[j];
            //                    j++;
            //                }

            //                k++;
            //            }

            //            while (i < array1.Length)
            //            {
            //                mergedArray[k] = array1[i];
            //                i++;
            //                k++;
            //            }

            //            while (j < array2.Length)
            //            {
            //                mergedArray[k] = array2[j];
            //                j++;
            //                k++;
            //            }

            //            Console.WriteLine("Merged Array:");
            //            foreach (int element in mergedArray)
            //            {
            //                Console.Write(element + " ");
            //            }
            //        }
            //    }
            //}
            #endregion


            #region Q12.Write a program in C# Sharp to count the frequency of each element of an array.

            //            int[] array = { 1, 2, 3, 2, 4, 1, 5, 2, 5, 3 };

            //            Dictionary<int, int> frequencyCount = new Dictionary<int, int>();

            //            foreach (int element in array)
            //            {
            //                if (frequencyCount.ContainsKey(element))
            //                {
            //                    frequencyCount[element]++;
            //                }
            //                else
            //                {
            //                    frequencyCount[element] = 1;
            //                }
            //            }

            //            Console.WriteLine("Frequency of each element:");

            //            foreach (KeyValuePair<int, int> kvp in frequencyCount)
            //            {
            //                Console.WriteLine("Element: " + kvp.Key + ", Frequency: " + kvp.Value);
            //            }
            //        }
            //    }
            //}
            #endregion


            #region Q13.Write a program in C# Sharp to find maximum and minimum element in an array

            //            int[] array = { 5, 3, 9, 1, 7, 2, 6 };

            //            int min = array[0]; // Assume the first element as the minimum
            //            int max = array[0]; // Assume the first element as the maximum

            //            for (int i = 1; i < array.Length; i++)
            //            {
            //                if (array[i] < min)
            //                {
            //                    min = array[i];
            //                }

            //                if (array[i] > max)
            //                {
            //                    max = array[i];
            //                }
            //            }

            //            Console.WriteLine("Minimum element: " + min);
            //            Console.WriteLine("Maximum element: " + max);
            //        }
            //    }
            //}
            #endregion


            #region Q14.Write a program in C# Sharp to find the second largest element in an array.

            //int[] array = { 5, 3, 9, 1, 7, 2, 6 };

            //int max = int.MinValue; // Assume the maximum as the smallest possible value
            //int secondMax = int.MinValue; // Assume the second maximum as the smallest possible value

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        secondMax = max;
            //        max = array[i];
            //    }
            //    else if (array[i] > secondMax && array[i] != max)
            //    {
            //        secondMax = array[i];
            //    }
            //}

            //if (secondMax == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element in the array.");
            //}
            //else
            //{
            //    Console.WriteLine("Second largest element: " + secondMax);
            //}

            #endregion


            #region Q15.Find the Longest Distance Between Two Equal Cells

            //int[] array = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int maxDistance = 0;
            //Dictionary<int, int> firstOccurrences = new Dictionary<int, int>();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (!firstOccurrences.ContainsKey(array[i]))
            //    {
            //        firstOccurrences[array[i]] = i;
            //    }
            //    else
            //    {
            //        int distance = i - firstOccurrences[array[i]];
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //        }
            //    }
            //}

            //Console.WriteLine("Longest distance between two equal cells: " + maxDistance);

            #endregion


            #region Q16.Given a list of space separated words, reverse the order of the words.

            /*Input: this is a test            Output: test a is this
              Input: all your base               Output: base your all
              Input: Word                        Output: Word
              Note : 
              Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement*/

            //            Console.WriteLine("Enter a space-separated list of words:");
            //            string input = Console.ReadLine();
            //            string[] words = input.Split(' ');
            //            Array.Reverse(words);
            //            string output = string.Join(' ', words);
            //            Console.WriteLine("Reversed words: " + output);
            //        }
            //    }
            //}

            #endregion


            #region Q17.Write a program to create two multidimensional arrays of same size.Accept value from user and store them in first array.Now copy all the elements of first array on second array and print second array.

            //            int rows = 3; // Example size
            //            int cols = 3; // Example size

            //            int[,] firstArray = new int[rows, cols];
            //            int[,] secondArray = new int[rows, cols];

            //            // Accept values from user for the first array
            //            Console.WriteLine("Enter values for the first array:");
            //            for (int i = 0; i < rows; i++)
            //            {
            //                for (int j = 0; j < cols; j++)
            //                {
            //                    Console.Write($"Element [{i},{j}]: ");
            //                    firstArray[i, j] = int.Parse(Console.ReadLine());
            //                }
            //            }

            //            // Copy elements from first array to second array
            //            for (int i = 0; i < rows; i++)
            //            {
            //                for (int j = 0; j < cols; j++)
            //                {
            //                    secondArray[i, j] = firstArray[i, j];
            //                }
            //            }

            //            // Print the second array
            //            Console.WriteLine("Second array:");
            //            for (int i = 0; i < rows; i++)
            //            {
            //                for (int j = 0; j < cols; j++)
            //                {
            //                    Console.Write(secondArray[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //}
            #endregion


            #region Q18.Write a Program to Print One Dimensional Array in Reverse Order

            //            int[] array = { 1, 2, 3, 4, 5 }; // Example array

            //            Console.WriteLine("Array in reverse order:");
            //            for (int i = array.Length - 1; i >= 0; i--)
            //            {
            //                Console.WriteLine(array[i]);
            //            }
            //        }
            //    }
            //}
            #endregion
        }
    }
}