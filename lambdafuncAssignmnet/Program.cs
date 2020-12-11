using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdafuncAssignmnet
{
   
    class Employee
    {
        int EmpNo;
        decimal Basic;
        string Name;

        public Employee()
        {
        }

        public Employee(int EmpNo, string Name, decimal Basic)
        {
            this.empNo = EmpNo;
            this.name = Name;
            this.basic = Basic;
        }

        public int empNo
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Invaid Employee No. !!!...");
                else
                    EmpNo = value;
            }

            get { return EmpNo; }
        }

        public string name
        {
            set
            {
                if (Equals(value, ""))
                    Console.WriteLine("Invaid Employee Name !!!...");
                else
                    Name = value;
            }

            get { return Name; }
        }

        public decimal basic
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Invaid Employee Basic !!!...");
                else
                    Basic = value;
            }

            get { return Basic; }
        }

        public void GetEmpNo(int n, Employee[] E)
        {
            int e = 0;
            for (int i = 0; i < E.Length; i++)
            {
                if (E[i].empNo == n)
                {
                    Console.WriteLine("Employee No. : " + e);
                    break;
                }

                else
                    Console.WriteLine("Employee No. " + n + "not found !!!...");
            }
        }

        public decimal GetMaxSalary(Employee[] E)
        {
            decimal maxSal = 0;
            for (int i = 0; i < E.Length; i++)
            {
                if (E[i].Basic >= maxSal)
                    maxSal = E[i].Basic;
            }

            return maxSal;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression..........\n\n");
            /*Write lambdas for the following functions :
                1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
            */
            Func<decimal, decimal, decimal, decimal> d = (P, T, R) => P * R * T;
            Console.WriteLine("\nS.I = " + d(2000, 2, 5));

            //2. bool IsGreater(int a, int b) -> returns true if a is > b
            Func<int, int, bool> IsGreater = (a, b) => a > b;
            Console.WriteLine("\nIGreater : " + IsGreater(20, 30));



            //3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
            Employee E = new Employee(1, "Rohan", 6000);
            Func<Employee, decimal> GetBasic = (e) => e.basic;
            Console.WriteLine("\nBasic Salary = " + GetBasic(E));

            //4. bool IsEven(int num) -> returns true if the number is an even number
            Func<int, bool> IsEven = (a) => a % 2 == 0;
            Console.WriteLine("\nIsEven : " + IsEven(20));

            //5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000
            Func<Employee, bool> IsGreaterThan10000 = (e) => e.basic > 10000;
            Console.WriteLine("\nIsGreater : " + IsGreaterThan10000(E));

            Console.ReadLine();
        }
    }
}
