Arrays and Functions

This repository contains examples and notes from a C# session covering various topics such as one-dimensional arrays, two-dimensional arrays (both rectangular and jagged), and functions (including prototypes, value type parameters, reference type parameters, passing by out, and the `params` keyword).

## Table of Contents

- [Notes](#notes)
  - [One-Dimensional Array](#one-dimensional-array)
  - [Two-Dimensional Array (Rectangular Array)](#two-dimensional-array-rectangular-array)
  - [Two-Dimensional Array (Jagged Array)](#two-dimensional-array-jagged-array)
  - [Functions Prototype and Calling](#functions-prototype-and-calling)
  - [Functions - ValueType Parameters](#functions---valuetype-parameters)
  - [Functions - ReferenceType Parameters](#functions---referencetype-parameters)
  - [Function - Passing By Out](#function---passing-by-out)
  - [Functions - Params](#functions---params)
- [Examples](#examples)
  - [One-Dimensional Array](#one-dimensional-array-1)
  - [Two-Dimensional Array (Rectangular Array)](#two-dimensional-array-rectangular-array-1)
  - [Two-Dimensional Array (Jagged Array)](#two-dimensional-array-jagged-array-1)
  - [Functions Prototype and Calling](#functions-prototype-and-calling-1)
  - [Functions - ValueType Parameters](#functions---valuetype-parameters-1)
  - [Functions - ReferenceType Parameters](#functions---referencetype-parameters-1)
  - [Function - Passing By Out](#function---passing-by-out-1)
  - [Functions - Params](#functions---params-1)

## Notes

### One-Dimensional Array

- A one-dimensional array is a linear collection of elements of the same type.
- Arrays in C# are zero-indexed, meaning the index of the first element is 0.

### Two-Dimensional Array (Rectangular Array)

- A rectangular array is a two-dimensional array where each row has the same number of columns.
- It's like a matrix with rows and columns.

### Two-Dimensional Array (Jagged Array)

- A jagged array is an array of arrays, where each inner array can have a different length.
- It's useful when you need a 2D structure but with varying row lengths.

### Functions Prototype and Calling

- Functions are blocks of code designed to perform specific tasks.
- Prototypes define the function's name, return type, and parameters but do not include the body.

### Functions - ValueType Parameters

- When value types are passed to functions, a copy of the value is passed.
- Modifying the parameter inside the function does not affect the original value.

### Functions - ReferenceType Parameters

- When reference types are passed to functions, the reference (or address) is passed.
- Modifying the parameter inside the function affects the original object.

### Function - Passing By Out

- The `out` keyword allows a function to return multiple values.
- The out parameter must be assigned a value before the function exits.

### Functions - Params

- The `params` keyword allows a function to accept a variable number of arguments.
- It's useful when the exact number of parameters is unknown.

## Examples

### One-Dimensional Array

```csharp
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

Two-Dimensional Array (Rectangular Array)

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

Two-Dimensional Array (Jagged Array)

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


Functions Prototype and Calling

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


Functions - ValueType Parameters

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


Functions - ReferenceType Parameters

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

Function - Passing By Out
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

Functions - Params

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



