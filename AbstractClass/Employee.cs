using System;

namespace AbstractClass
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        protected DateTime HireDate;

        public virtual void Hire()
        {
            HireDate = DateTime.Now;
        }

        public abstract void GiveRaise();
    }
}