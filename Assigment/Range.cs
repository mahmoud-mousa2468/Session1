namespace Assigment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T Min, T Max)
        {
            if (Min.CompareTo(Max) > 0) Console.WriteLine("MinValue cannot be greater than MaxValue.");
            this.Min = Min;
            this.Max = Max;
        }
        public bool IsInRange(T Value)
        {
            if (Value is not null)
                return Min.CompareTo(Value) < 0 && Max.CompareTo(Value) > 0;
            return false;
        }
        public int Length()
        {
            if (this.Min is int Min && this.Max is int Max) return Max - Min;
            return -1;
        }
    }
}
