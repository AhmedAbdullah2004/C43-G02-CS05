using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session03
{
    internal class Program
    {
        //(1)
        //static void ModifyByValue(int num)
        //{
        //    num = 100;
        //}
        //static void ModifyByReference(ref int num)
        //{
        //    num = 100;
        //}

        //(2)
        //static void ModifyByValue(int value)
        //{
        //    value += 1;
        //    Console.WriteLine($" Modify V: {value}");
        //}

        //static void ModifyByReference(ref int value)
        //{
        //    value += 1;
        //    Console.WriteLine($" Modify R: {value}");
        //}
        //(3)
        //static (int sum, int modify) Calculate(int num1, int num2, int num3, int num4)
        //{
        //    int sum = num1 + num2; 
        //    int modify = num3 - num4;
        //    return (sum, modify);
        //}
        //static void Main()
        //{
        //(4)
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10; 
        //        number /= 10;     
        //    }
        //    return sum;
        //}
        //(5)
        //    static bool IsPrime(int number)
        //    {
        //        if (number <= 1)
        //            return false;

        //        for (int i = 2; i <= Math.Sqrt(number); i++)
        //        {
        //            if (number % i == 0)
        //                return false; 
        //        }

        //        return true; 
        //    }
        //}
        //(6)
        //static void MinMaxArray(int[] arr, out int minVal, out int maxVal)
        //{
        //    minVal = arr[0];
        //    maxVal = arr[0];

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < minVal)
        //        {
        //            minVal = arr[i];
        //        }
        //        if (arr[i] > maxVal)
        //        {
        //            maxVal = arr[i];
        //        }
        //    }
        //}
        //(7)
        //static int Factorial(int n)
        //{
        //    int result = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}
        //(8)
        //static int Factorial(int n)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}
        static void Main(string[] args)
        {
            #region Q1 -Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example. 

            //int valueType = 10;
            //Console.WriteLine($"Before V : {valueType}");
            //ModifyByValue(valueType);
            //Console.WriteLine($"After V: {valueType}");

            //int referenceType = 10;
            //Console.WriteLine($"Before R: {referenceType}");
            //ModifyByReference(ref referenceType);
            //Console.WriteLine($"After R: {referenceType}");
            #endregion

            #region Q2 -Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int number = 3;

            //Console.WriteLine($"Before V: {number}");
            //ModifyByValue(number);
            //Console.WriteLine($"After V: {number}");

            //Console.WriteLine($"Before R: {number}");
            //ModifyByReference(ref number);
            //Console.WriteLine($"After R: {number}");
            #endregion

            #region Q3 -Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.Write("Enter the num1: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the num2: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the num3: ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the num4: ");
            //int num4 = int.Parse(Console.ReadLine());

            //var (sum, modify) = Calculate(num1, num2, num3, num4);

            //Console.WriteLine($"The sum: {sum}");
            //Console.WriteLine($"The modify: {modify}");
            #endregion

            #region Q4 -Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7
            //Console.Write("Enter a num: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");

            #endregion

            #region Q5 -Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter a num: ");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{

            //    bool result = IsPrime(number);
            //Console.WriteLine(result? $"{number} is a prime number." : $"{number} is not num.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            #endregion

            #region Q6 -Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 3, 5, 1, 9, 7, 2 };
            //int minVal, maxVal;
            //MinMaxArray(arr, out minVal, out maxVal);

            //Console.WriteLine("Minimum : " + min);
            //Console.WriteLine("Maximum : " + max);

            #endregion

            #region Q7 -Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int number = 5;
            //int factorial = Factorial(number);
            //Console.WriteLine($"The factorial of {number} is {factorial}");

            #endregion

            #region Q8 -Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //int num = 5;

            //int factorial = Factorial(num);

            //Console.WriteLine($"The factorial of {num} is {factorial}");
            #endregion
        }
    }
}

