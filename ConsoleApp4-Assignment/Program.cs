namespace ConsoleApp4_Assignment
{
    using System;
    using System.Linq;

    class Assignment04
    {
        static void Main(string[] args)
        {
            // Call each method for demonstration
            #region Q1 Pass by Value vs Reference
            PassByValueVsReference();
            #endregion

            #region Q2 Reference Type by Value vs Reference
            ReferenceTypeByValueVsReference();
            #endregion

            #region Q3 Sum and Subtract
            Console.WriteLine("Sum and Subtract: " + SumAndSubtract(10, 5, out int subtract));
            Console.WriteLine("Subtraction Result: " + subtract);
            #endregion

            #region Q4 Sum of Digits
            Console.WriteLine("Sum of Digits: " + SumOfDigits(25));
            #endregion

            #region Q5 Prime Check
            Console.WriteLine("Is 11 Prime? " + IsPrime(11));
            #endregion

            #region Q6 Min and Max in Array
            int[] array = { 1, 2, 3, 4, 5 };
            MinMaxArray(array, out int min, out int max);
            Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion

            #region Q7 Factorial
            Console.WriteLine("Factorial of 5: " + Factorial(5));
            #endregion

            #region Q8 Change Character in String
            Console.WriteLine("ChangeChar: " + ChangeChar("hello", 1, 'a'));
            #endregion

            #region Q9 Identity Matrix
            PrintIdentityMatrix(3);
            #endregion

            #region Q10 Sum of Array Elements
            Console.WriteLine("Array Sum: " + SumArray(array));
            #endregion

            #region Q11 Merge and Sort Arrays
            MergeAndSortArrays();
            #endregion

            #region Q12 Count Element Frequency
            CountElementFrequency(array);
            #endregion

            #region Q13 Max and Min in Array
            FindMaxAndMin(array);
            #endregion

            #region Q14 Second Largest Element
            FindSecondLargest(array);
            #endregion

            #region Q15 Longest Distance Between Equal Elements
            FindLongestDistance();
            #endregion

            #region Q16 Reverse Words
            ReverseWords();
            #endregion

            #region Q17 Copy MultiDimensional Array
            CopyAndPrintMultiDimensionalArray();
            #endregion

            #region Q18 Reverse One Dimensional Array
            ReverseArray();
            #endregion
        }

        #region Q1 Pass by Value vs Reference
        /*
        Pass by Value: A copy of the variable is passed, and modifications do not affect the original variable.
        Pass by Reference: A reference to the original variable is passed, and modifications affect the original variable.
        */
        static void PassByValueVsReference()
        {
            int x = 10;
            PassByValue(x);
            Console.WriteLine("Pass by Value: " + x);
            PassByReference(ref x);
            Console.WriteLine("Pass by Reference: " + x);
        }

        static void PassByValue(int value) => value = 20;

        static void PassByReference(ref int value) => value = 20;
        #endregion

        #region Q2 Reference Type by Value vs Reference
        /*
        Passing Reference Type by Value: A copy of the reference is passed. Modifications affect the original data since both point to the same memory location.
        Passing Reference Type by Reference: The reference itself is passed. Any changes to the reference affect the original object.
        */
        static void ReferenceTypeByValueVsReference()
        {
            int[] array = { 1, 2, 3 };
            ModifyArrayByValue(array);
            Console.WriteLine("By Value: " + string.Join(", ", array));
            ModifyArrayByReference(ref array);
            Console.WriteLine("By Reference: " + string.Join(", ", array));
        }

        static void ModifyArrayByValue(int[] arr) => arr[0] = 10;

        static void ModifyArrayByReference(ref int[] arr) => arr[0] = 20;
        #endregion

        #region Q3 Sum and Subtract
        static int SumAndSubtract(int a, int b, out int subtract)
        {
            subtract = a - b;
            return a + b;
        }
        #endregion

        #region Q4 Sum of Digits
        static int SumOfDigits(int number) => number.ToString().Sum(c => c - '0');
        #endregion

        #region Q5 Prime Check
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }
        #endregion

        #region Q6 Min and Max in Array
        static void MinMaxArray(int[] array, out int min, out int max)
        {
            min = array.Min();
            max = array.Max();
        }
        #endregion

        #region Q7 Factorial
        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++) result *= i;
            return result;
        }
        #endregion

        #region Q8 Change Character in String
        static string ChangeChar(string str, int index, char newChar)
        {
            char[] chars = str.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
        #endregion

        #region Q9 Identity Matrix
        static void PrintIdentityMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(i == j ? "1 " : "0 ");
                Console.WriteLine();
            }
        }
        #endregion

        #region Q10 Sum of Array Elements
        static int SumArray(int[] array) => array.Sum();
        #endregion

        #region Q11 Merge and Sort Arrays
        static void MergeAndSortArrays()
        {
            int[] array1 = { 1, 3, 5 };
            int[] array2 = { 2, 4, 6 };
            int[] merged = array1.Concat(array2).OrderBy(x => x).ToArray();
            Console.WriteLine("Merged and Sorted: " + string.Join(", ", merged));
        }
        #endregion

        #region Q12 Count Element Frequency
        static void CountElementFrequency(int[] array)
        {
            var frequency = array.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            foreach (var kvp in frequency)
                Console.WriteLine($"Element: {kvp.Key}, Frequency: {kvp.Value}");
        }
        #endregion

        #region Q13 Max and Min in Array
        static void FindMaxAndMin(int[] array) => Console.WriteLine($"Max: {array.Max()}, Min: {array.Min()}");
        #endregion

        #region Q14 Second Largest Element
        static void FindSecondLargest(int[] array)
        {
            int secondLargest = array.OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();
            Console.WriteLine("Second Largest: " + secondLargest);
        }
        #endregion

        #region Q15 Longest Distance Between Equal Elements
        static void FindLongestDistance()
        {
            Console.Write("Enter array elements: ");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var positions = array.Select((value, index) => new { value, index })
                                 .GroupBy(x => x.value)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Last().index - g.First().index);
            Console.WriteLine("Longest Distance: " + (positions.Any() ? positions.Max() : 0));
        }
        #endregion

        #region Q16 Reverse Words
        static void ReverseWords()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Reversed: " + string.Join(" ", sentence.Split().Reverse()));
        }
        #endregion

        #region Q17 Copy MultiDimensional Array
        static void CopyAndPrintMultiDimensionalArray()
        {
            int[,] array1 = new int[2, 2];
            Console.WriteLine("Enter elements for 2x2 array:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    array1[i, j] = int.Parse(Console.ReadLine());

            int[,] array2 = (int[,])array1.Clone();
            Console.WriteLine("Copied Array:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(array2[i, j] + " ");
            Console.WriteLine();
        }
        #endregion

        #region Q18 Reverse One Dimensional Array
        static void ReverseArray()
        {
            Console.Write("Enter array elements: ");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Reversed Array: " + string.Join(", ", array.Reverse()));
        }
        #endregion
    }

}
