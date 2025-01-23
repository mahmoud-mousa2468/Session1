namespace Demo
{
    internal struct Point
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
            return $"X : {X} :: Y : {Y}";
        }
    }
}
