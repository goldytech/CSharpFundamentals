using System;

namespace AbstractClass
{
    public class Manager : Employee
    {
        public override void Hire()
        {
            base.Hire();
            Console.WriteLine("Method overridden from the derived class");
            this.HireDate = this.HireDate.AddDays(3);
        }

        public override void GiveRaise()
        {
            Salary += Salary * 0.05;
        }
    }
}