using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //for 1st assignment
            //employee o1 = new employee("arun");
            //employee o2 = new employee();
            //employee o3 = new employee();
            //Console.WriteLine(o1.EMPNO+" "+o1.NAME+" "+o1.DEPTNO);
            //Console.WriteLine(o2.EMPNO);
            //Console.WriteLine(o3.EMPNO);
            //o1.GetNetSalary(10000);

            //for 2nd assignment
            employee s1 = new Manager("ria");
            Manager s2 = new Manager("pia", 13000, 2);
            GeneralManager s3 = new GeneralManager("nia", 12000, 4, "delhi", "car");
            CEO s4 = new CEO("mia", 14000, 3);
            s1.CallNetSalary();
            s2.CallNetSalary();
            s3.CallNetSalary();
            s4.CallNetSalary();

            s1.display();
            s2.display();
            s3.display();
            s4.display();

            Console.ReadLine();
        }
    }

    public abstract class employee
    {

        private static int id = 0;

        private String Name;
        public String NAME
        {
            set
            {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    Name = value;
            }
            get
            {
                return Name;
            }
        }

        private int EmpNo = 0;
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal BASIC
        {
            set
            {
                if (value >= 10000 && value <= 40000)
                    Basic = value;
                else
                    Console.WriteLine("invalid Basic");
            }
            get
            {
                return Basic;
            }
        }

        private short DeptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid DeptNo");
                }
            }
            get
            {
                return DeptNo;
            }
        }

        public abstract void CallNetSalary();

        public employee(String Name = "", decimal Basic = 10000, short DeptNo = 1)
        {
            id++;
            this.EmpNo = id;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public virtual void display()
        {
            Console.WriteLine("EmpNo= " + EmpNo + "Name= " + Name + "Basic= " + Basic + "DeptNo= " + DeptNo);
        }

        //public employee(String Name, decimal Basic)
        //{
        //    this.Name = Name;
        //    this.Basic = Basic;
        //}

        //public employee(String Name)
        //{
        //    this.Name = Name;
        //}

        //public employee()
        //{
        //    id++;
        //    this.EmpNo = id;
        //}
    }

    public class Manager : employee
    {


        private String Designation;
        public String DESIGNATION
        {

            set
            {
                if (value == "")
                    Console.WriteLine("invalid Perks");
                else
                    Designation = value;
            }
            get
            {
                return Designation;
            }
        }
        public Manager()
        {
            Designation = "mumbai";
        }

        public Manager(String Name = "", decimal Basic = 10000, short DeptNo = 1, String Designation = "mumbai") : base(Name, Basic, DeptNo)
        {
            this.Designation = Designation;
        }

        public override void CallNetSalary()
        {
            decimal net = 2400 + 420 + this.BASIC - ((decimal)0.10 * this.BASIC);
            Console.WriteLine(net);

        }

        public override void display()
        {
            Console.WriteLine("EmpNo= " + this.EMPNO + "Name= " + this.NAME + "Basic= " + this.BASIC + "DeptNo= " + this.DEPTNO + "Designation" + this.DESIGNATION);
        }
    }

    public class GeneralManager : Manager
    {
        private String Perks;
        public String PERKS
        {
            set
            {
                Perks = value;
            }
            get
            {
                return Perks;
            }
        }

        public GeneralManager(String Name = "", decimal Basic = 10000, short DeptNo = 1, String Designation = "mumbai", String Perks = "") : base(Name, Basic, DeptNo, Designation)
        {
            this.Perks = Perks;
        }

        public override void CallNetSalary()
        {
            decimal net = 2400 + 420 + this.BASIC - ((decimal)0.10 * this.BASIC);
            Console.WriteLine(net + " " + "from GeneralManager");

        }

        public override void display()
        {
            Console.WriteLine("EmpNo= " + this.EMPNO + "Name= " + this.NAME + "Basic= " + this.BASIC + "DeptNo= " + this.DEPTNO + "Designation= " + this.DESIGNATION + "Perks= " + this.PERKS);
        }
    }

    public class CEO : employee
    {

        public CEO(String Name = "", decimal Basic = 10000, short DeptNo = 1) : base(Name, Basic, DeptNo)
        {

        }

        public sealed override void CallNetSalary()
        {
            decimal net = 2400 + 420 + this.BASIC - ((decimal)0.10 * this.BASIC);
            Console.WriteLine(net + " " + "from CEO");
        }

        public new void display()
        {
            Console.WriteLine("EmpNo= " + this.EMPNO + "Name= " + this.NAME + "Basic= " + this.BASIC + "DeptNo= " + this.DEPTNO);
        }
    }
}
