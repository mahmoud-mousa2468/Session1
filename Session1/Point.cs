namespace Demo
{
    internal struct Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"({X},{Y}) ";
        }

        public int CompareTo(object? obj)
        {
            Point P = (Point)obj;
            if (X == P.X) return Y.CompareTo(P.Y);
            else return X.CompareTo(P.X);
        }
    }
}
