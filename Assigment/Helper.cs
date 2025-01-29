namespace Assigment
{
    internal static class Helper
    {
        public static void EfficienceBubbleSort<T>(ref T[] Arr) where T : IComparable<T>
        {
            bool Swape;
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Swape = false;
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                        {
                            SwapeFun(ref Arr[j], ref Arr[j + 1]);
                            Swape = true;
                        }
                    }
                    if (!Swape)
                        break;
                }
            }
        }
        public static void SwapeFun<T>(ref T Value01, ref T Value02)
        {
            T Temp;
            Temp = Value01;
            Value01 = Value02;
            Value02 = Temp;
        }
        public static void PrintArr<T>(ref T[] Arr)
        {
            foreach (var item in Arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
