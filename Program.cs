using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Delegates
{
    public static class ArrayExtensions
    {
        public static IEnumerable<T[]> Chunk<T>(this T[] source, int chunkSize)
        {
            for (int i = 0; i < source.Length; i += chunkSize)
            {
                int size = Math.Min(chunkSize, source.Length - i);
                T[] chunk = new T[size];
                Array.Copy(source, i, chunk, 0, size);
                yield return chunk;
            }
        }
    }

    public class Program
    {
        private const string Line = "******";

        // Custom delegates
        public delegate double DoCalculation(int a, int b);
        public delegate int PerformCalculation(int x, int y);

        public static void Main(string[] args)
        {
            // * Default Delegate
            // ? Delegate is a reference type (nullable)
            Delegate dd = null;

            DoCalculation del = new DoCalculation((a, b) => 5);
            try
            {
                dd.DynamicInvoke();
                // Or do this
                // dd?.DynamicInvoke();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("delegate was null");
            }

            Console.WriteLine(Line);
            // ? Basic use of Delegate
            Delegate voidParameterLess = null;
            voidParameterLess =new Action( Test);
            // Combine tow delegate to execute (Add + operation)
            voidParameterLess = Delegate.Combine(voidParameterLess, new Action(() => { Console.WriteLine(Line); }));
            var invocationList = voidParameterLess.GetInvocationList();
            Console.WriteLine(invocationList.Length);
            // Combine tow delegate to execute (Add + operation)
            voidParameterLess = Delegate.Remove(new Action(() => {Console.WriteLine(); }), voidParameterLess);
            Console.WriteLine(invocationList.Length);
            // Execute run 
            voidParameterLess.DynamicInvoke();
            Console.WriteLine(Line);

            // * Custom Delegate
            // Using lambda expressions
            DoCalculation calculation = (a, b) => a * b;
            Console.WriteLine(calculation.GetInvocationList().Length);
            calculation += (a, b) => a - b;
            Console.WriteLine(calculation.GetInvocationList().Length);
            // This will not do anything
            calculation -= (a, b) => a - b;
            Console.WriteLine(calculation.GetInvocationList().Length);
            Console.WriteLine(Line);

            // In order to remove method from invocation list we must know 
            // What is it (name or signature in delegate form)
            // Using Func
            Func<int, int, int> method1 = (a, b) => a * b;
            Func<int, int, int> method2 = (a, b) => a - b;
            Func<int, int, int> methods = method2 + method1;
            System.Console.WriteLine(methods.GetInvocationList().GetLength(0));
            System.Console.WriteLine(methods(5, 6));
            // This will work because we have the method delegate
            methods -= method1;
            System.Console.WriteLine(methods.GetInvocationList().GetLength(0));
            System.Console.WriteLine(methods(5, 6));
            Console.WriteLine(Line);

            // Using Action
            Action<int, int> action = (int a, int b) => Console.WriteLine(a + b);
            action(5, 6);
            Console.WriteLine(Line);

            // Using Predicate
            Predicate<int> isMoreThanSeven = (int a) => a > 7;
            System.Console.WriteLine("isMoreThanSeven 5? " + isMoreThanSeven(5));
            System.Console.WriteLine("isMoreThanSeven 10? " + isMoreThanSeven(10));
            Console.WriteLine(Line);

            // Create an array from 1 .. 5 (1,2,3,4,5)
            int[] array = Enumerable.Range(1, 6).ToArray();
            // Get array's sum
            int sum = array.Sum();
            // Get the sum of odd numbers
            int sumOddNumbers = array.Sum(selector: OddNumbersOnly);
            // Get the sum of even numbers
            int sumEvenNumbers = array.Sum(selector: EvenNumbersOnly);
            // Get an array of odd numbers
            int[] onlyOddNumbersArray = array.Where(i => i % 2 != 0).ToArray();
            // Divide the array into small arrays
            int[][] chunks = array.Chunk(5).ToArray();
            // Every element multiply by the next element and so ..
            int pai = array.Aggregate((temp, next) => temp * next);


            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(array));
            Console.WriteLine(sum);
            Console.WriteLine(pai);
            Console.WriteLine(sumOddNumbers);
            Console.WriteLine(sumEvenNumbers);
        }

        public static void Test() => Console.WriteLine("test");

        public static int OddNumbersOnly(int number)
        {
            if (number % 2 == 0)
            {
                return 0;
            }

            return number;
        }

        public static int EvenNumbersOnly(int number)
        {
            if (number % 2 != 0)
            {
                return 0;
            }

            return number;
        }
    }
}