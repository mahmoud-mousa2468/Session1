namespace Demo
{
    // Use <T> in The class if use the same T to All Class components
    internal static class Helper/*<T>*/
    {
        #region Generic Liner Search
        //public static int LinearSearch<T>(T [] Arr, T Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals(Value))
        //            {
        //                return i;
        //            }
        //        }

        //    }
        //    return -1;
        //}
        #endregion
        #region Non Generic Liner Search
        //public static int LinearSearch(int[] Arr,int Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals(Value))
        //            {
        //                return i;
        //            }
        //        }

        //    }
        //    return -1;
        //}
        #endregion
        #region Generic Swap
        //public static void SWAP<T>(ref T X, ref T Y)
        //{
        //    T Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #region Generic Swap with multi Types
        // we use this shape if we need function with diff two type
        //public static void SWAP<T01,T02>(ref T01 X, ref T02 Y)
        //{

        //}

        #endregion
        #endregion
        #region Non-Generic Swap
        //public static void SWAP(ref int X,ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref Point P01,ref Point P02)
        //{
        //    Point Temp = P01;
        //    P01 = P02;
        //    P02 = Temp;
        //} 
        #endregion


    }
}
