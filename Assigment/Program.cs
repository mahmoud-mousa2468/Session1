using System.Collections;

namespace Assigment
{

    internal class Program
    {
        #region Q3
        public static void ReverseFun(ArrayList AL)
        {

            int j = AL.Count - 1;
            for (int i = 0; i < AL.Count / 2; i++)
            {
                var Temp = AL[i];
                AL[i] = AL[j];
                AL[j] = Temp;
                j--;
            }
        }
        #endregion

        #region Q4
        public static List<int> EvenNums(List<int> Numbers)
        {
            List<int> EvenNums = new List<int>();
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] % 2 == 0)
                    EvenNums.Add(Numbers[i]);

            }
            return EvenNums;
        }
        #endregion

        #region Q6
        static void NonRepeated(string statement)
        {
            int find;
            for (int i = 0; i < statement.Length; i++)
            {
                find = 0;
                for (int j = 0; j < statement.Length; j++)
                {
                    if (statement[i] == statement[j])
                        find++;
                }
                if (find == 1)
                {
                    Console.WriteLine($"The NonRepeated Char is {statement[i]} & It's Index Is {i + 1}");
                    break;
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //1.The Bubble Sort algorithm has a time complexity of O(n ^ 2)
            //in its worst and average cases, which makes it inefficient for large datasets.
            //How we can optimise the Bubble Sort algorithm And implement the code
            //of this optimised bubble sort algorithm

            //Solution
            // best case: If no swaps occur, we terminate the sorting process early
            // saving unnecessary passes 

            //int[] Numbers = { 10, 5, 2, 4, 1, 9 };
            //Helper.PrintArr(ref Numbers);
            //Console.WriteLine();
            //Console.WriteLine("After BubbleSort");
            //Helper.EfficienceBubbleSort(ref Numbers);
            //Helper.PrintArr(ref Numbers);

            #endregion

            #region Q2
            //2.create a generic Range < T > class that represents a range of values
            //from a minimum value to a maximum value.The range should support basic operations
            //such as checking if a value is within the range and determining
            //the length of the range.
            //Requirements:
            //1.Create a generic class named Range<T> where T represents the type of values.
            //2.Implement a constructor that takes the minimum and maximum values to define
            //  the range.
            //3.Implement a method IsInRange(T value) that returns true if the given value
            //  is within the range, otherwise false.
            //4.Implement a method Length() that returns the length of the range
            //  (the difference between the maximum and minimum values).
            //5.Note: You can assume that the type T used in the Range<T> class implements
            //  the IComparable<T> interface to allow for comparisons.


            //Range<int> R01 = new Range<int>(1, 10);
            //Console.WriteLine(R01.IsInRange(2));
            //Console.WriteLine(R01.Length());


            #endregion

            #region Q3
            //3.You are given an ArrayList containing a sequence of elements.
            //try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            //without using the built-in Reverse.Implement a function that takes the ArrayList as input
            //and modifies it to have the reversed order of elements.
            //ArrayList Numbers = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ArrayList Words = new ArrayList { "Mo", "Do", "Bo", "Co", "Ho" };
            //foreach (var item in Words)
            //{
            //    Console.Write($"{item} ");
            //}
            //ReverseFun(Words);
            //Console.WriteLine();
            //foreach (var item in Words)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Q4
            //4.You are given a list of integers. Your task is to find and return a new list containing
            //only the even numbers from the given list.


            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var item in EvenNums(Numbers))
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Q5
            //5.implement a custom list called FixedSizeList<T> with a predetermined capacity.
            //This list should not allow more elements than its capacity and should provide clear messages
            //if one tries to exceed it or access invalid indices.
            //Requirements:
            //1.Create a generic class named FixedSizeList<T>.
            //2.Implement a constructor that takes the fixed capacity of the list as aparameter.
            //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //4.Implement a Get method that retrieves an element at a specific index in the list but
            //throws an exception for invalid indices.

            //FixedSizeList<int> Numbers = new FixedSizeList<int>(5);
            //Numbers.AddFun(5);
            //Numbers.AddFun(5);
            //Numbers.AddFun(5);
            //Numbers.AddFun(5);
            //Numbers.AddFun(5);
            //Numbers.AddFun(5);
            //Numbers.GetFun(10);
            #endregion

            #region Q6
            //6.Given a string, find the first non - repeated character in it and return its index.
            //If there is no such character, return -1.Hint you can use dictionary

            //string S01 = "ahmed mousa";
            //NonRepeated(S01);
            #endregion
        }
    }
}
