namespace Demo
{
    // Use <T> in The class if use the same T to All Class components
    internal static class Helper/*<T>*/
    {
        #region Non-Generic
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

        #region Generic
        // we use this shape if we need function with diff two type
        //public static void SWAP<T01,T02>(ref T01 X, ref T02 Y)
        //{

        //}
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion
    }
}
