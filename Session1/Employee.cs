﻿namespace Demo
{
    internal class Employee : IComparable<Employee>,IEquatable<Employee>
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(int Id, int Age, string Name, double Salary)
        {
            this.Id = Id;
            this.Age = Age;
            this.Name = Name;
            this.Salary = Salary;
        }
        public static bool operator ==(Employee left, Employee Right)
        {
            return left.Id == Right.Id && left.Age == Right.Age;
        }
        public static bool operator !=(Employee left, Employee Right)
        {
            return left.Id != Right.Id || left.Age != Right.Age;
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return this == E;
        //}
        public override string ToString()
        {
            return $"Id : {Id} :: Age : {Age} :: Name : {Name} :: Salary : {Salary}";
        }

        //public int CompareTo(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return Age.CompareTo(E.Age);
        //}

        public int CompareTo(Employee? other)
        {
            if(other is not null)
            {
                return Age.CompareTo(other.Age);
            }
            return 1;
        }

        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;
        }
    }
}
