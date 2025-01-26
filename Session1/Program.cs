using Demo;

namespace Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics :
            // C# Feature 2005 C# 2.0
            // Before 2005 there was Object
            #region Ex01 : SWAp
            #region Generic
            // Generic Swap
            //int A = 4, B = 5;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("========== After Swap ============");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //double A = 4.5, B = 5.9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("========== After Swap ============");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            // ponit : X,Y

            //Point P01 = new Point(4, 8);
            //Point P02 = new Point(10, 50);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);
            //Console.WriteLine("========== After Swap ============");
            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);
            #endregion

            #region Non-Generic
            // Swap
            //int A = 4, B = 5;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("========== After Swap ============");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //double A = 4.5, B = 5.9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("========== After Swap ============");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            // ponit : X,Y

            //Point P01 = new Point(4, 8);
            //Point P02 = new Point(10, 50);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);
            //Console.WriteLine("========== After Swap ============");
            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02); 
            #endregion
            #endregion

            // Linear Search

            // 4 7 8 9 10 1 2 3 5 12 -1 -13 31
            // Index
            #region E02 : Linear Search
            //int[] Numbers = { 8, 7, 6, 1, 2, 3, 4, 5, 6, 12, -1, 13, 9 };
            //int index = Helper.LinearSearch(Numbers, 4);
            //Console.WriteLine($"index : {index}");

            //Employee E01 = new Employee(10, 30, "Ahmed", 300000);
            //Employee E02 = new Employee(20, 30, "medo", 300000);
            //Employee E03 = new Employee(30, 30, "Ali", 300000);
            //Employee E04 = new Employee(40, 30, "Essam", 300000);
            //int Index = Helper.LinearSearch([E01, E02, E03, E04], E02);
            //Console.WriteLine($"Index {Index}");
            #endregion

            #region Equality in Class or struct 
            // Equality in Class or struct 
            // Equals
            // Class has equal fun Which inherited From Object Class --> Compare Reference
            // Struct has equal fun Which inherited From Object Class --> Compare Data
            // Note: Struct Don't Have Implementation  For The == Operator so we overload it

            //Employee E01 = new Employee(10, 30, "Ahmed", 300000);
            //Employee E02 = new Employee(20, 30, "medo", 300000);
            //Console.WriteLine($" E01: {E01.GetHashCode()}");
            //Console.WriteLine($" E01: {E02.GetHashCode()}");
            //if (E01.Equals(E02))
            //    Console.WriteLine("E01==E02");
            //else
            //    Console.WriteLine("E01!=E02");

            //if (E01==E02)
            //    Console.WriteLine("E01==E02");
            //else
            //    Console.WriteLine("E01!=E02"); 
            #endregion
            //BubbleSort == Array.Sort()
            #region BubbleSort
            //int[] Number = [1, 5, 2, 9, 10, 7, 4, 3];
            //Helper.PrintArray(Number);
            //Console.WriteLine();
            //Helper.BubbleSort(Number);
            //Helper.PrintArray(Number);

            //Point[] points =
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(3,3),
            //    new Point(5,5),
            //    new Point(1,1),
            //    new Point(4,4),
            //};
            //Helper.PrintArray(points);
            //Helper.BubbleSort(points);
            //Console.WriteLine();
            //Helper.PrintArray(points);

            // ICompareable : CompareTo
            // Int
            // + : Caller > Parameter
            // -: Caller < Parameter
            // 0: Caller = Parameter



            //Employee E01 = new Employee(10, 30, "Ahmed", 300000);
            //Employee E02 = new Employee(20, 29, "medo", 300000);
            //Employee E03 = new Employee(30, 20, "Ali", 300000);
            //Employee E04 = new Employee(40, 40, "Essam", 300000);
            //Employee[] employees = { E01, E02, E03, E04 };
            //Helper.PrintArray(employees);
            //Helper.BubbleSort(employees);
            //Console.WriteLine();
            //Helper.PrintArray(employees);
            #endregion
        }


    }
}
