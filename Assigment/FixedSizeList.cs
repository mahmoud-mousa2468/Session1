namespace Assigment
{
    internal class FixedSizeList<T>
    {
        public List<T> List { get; set; }
        public int Capacity { get; set; }
        public FixedSizeList(int Capacity)
        {
            List = new List<T>(Capacity);
            this.Capacity = Capacity;
        }
        public void AddFun(T Item)
        {
            if (List.Capacity <= Capacity)
                List.Add(Item);
            else Console.WriteLine("your capacity is finish");
        }
        public void GetFun(int Index)
        {
            if (Index > Capacity) Console.WriteLine("Out Of Range");
            else Console.WriteLine($"{List[Index]}");
        }

    }
}

