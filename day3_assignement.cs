using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3assignment
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
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter Number of Entries : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Employee[] E = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEmployee No. : ");
                int empNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nName : ");
                string name = Console.ReadLine();
                Console.Write("\nBasic : ");
                decimal basic = Convert.ToDecimal(Console.ReadLine());

                E[i] = new Employee(empNo, name, basic);
            }

            Console.Write("\nEnter the Employee No. : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Employee e1 = new Employee();
            e1.GetEmpNo(no, E);
            Console.WriteLine("Employee No. : " + e1.GetMaxSalary(E));
            Console.ReadLine();
        }
    }
}

namespace Question_2
{
    /*2. CDAC has certain number of batches. each batch has certain number of students
         accept number of batches from the user. for each batch accept number of students.
         create an array to store mark for each student. 
         accept the marks.
         display the marks.
    */
    class Student
    {
        int StdNo;
        decimal Marks;

        public Student()
        {
            StdNo = 0;
            Marks = 0;
        }
        public Student(int StdNo, decimal Marks)
        {
            this.stdNo = StdNo;
            this.marks = Marks;
        }

        public int stdNo
        {
            set
            {
                if (value > 0)
                    StdNo = value;
                else
                    Console.WriteLine("Invalid Student No. !!!...");
            }

            get { return StdNo; }
        }

        public decimal marks
        {
            set
            {
                if (value > 0)
                    Marks = value;
                else
                    Console.WriteLine("Invalid Marks !!!...");
            }

            get { return Marks; }
        }

        public void GetMarks(Student[][] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("======== Batch - " + (i + 1) + "========");
                for (int j = 0; j < s[i].Length; j++)
                    Console.WriteLine("\nStudent No. : " + s[i][j].StdNo + "\n Marks : " + s[i][j].Marks);
            }

        }
    }

    class program
    {
        static void Main2(string[] args)
        {
            Console.Write("\nEnter Number of Batch : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Student[][] students = new Student[r][];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("=========== Batch-" + (i + 1) + " ===========");
                Console.Write("\nEnter Number of Students : ");
                int c = Convert.ToInt32(Console.ReadLine());
                students[i] = new Student[c];
                for (int j = 0; j < students[i].Length; j++)
                {
                    Console.WriteLine("--------- Student-" + (j + 1) + " ---------");
                    Console.Write("\nEnter Student Number : ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Student Marks : ");
                    decimal mark = Convert.ToDecimal(Console.ReadLine());

                    students[i][j] = new Student(no, mark);
                }
            }

            Student s = new Student();
            Console.WriteLine("===================== Marks ======================= ");
            s.GetMarks(students);
            Console.ReadLine();
        }

    }

}

namespace Question_3
{
    /*3. Create a struct Student with the following properties. Put in appropriate validations.
        string Name
        int RollNo
        decimal Marks
        Create a parameterized constructor.
        Create an array to accept details for 5 students
    */

    struct Student
    {
        private int RollNo;
        private string Name;
        private decimal Marks;


        public Student(int rollNo = 10, string name = "xyz", decimal marks = 90)
        {
            this.RollNo = 0;
            this.Name = "";
            this.Marks = 0;
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        public int rollNo
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Invalid RollNo. !!!...");
                else
                    RollNo = value;
            }

            get { return RollNo; }
        }

        public string name
        {
            set
            {
                if (Equals(value, ""))
                    Console.WriteLine("Invalid Name !!!...");
                else
                    Name = value;
            }

            get { return Name; }
        }

        public decimal marks
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Invalid Marks !!!...");
                else
                    Marks = value;
            }

            get { return Marks; }
        }


    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Students Array \n");
            Student[] student = new Student[2];
            Console.WriteLine("Enter 5 Students Details : \n");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("======== Student-" + (i + 1) + "========");
                Console.Write("RollNo. : ");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Marks : ");
                decimal marks = Convert.ToDecimal(Console.ReadLine());

                student[i] = new Student(rollno, name, marks);

            }

            for (int i = 0; i < student.Length; i++)
                Console.WriteLine("\nRoll NO: " + student[i].rollNo + "\nName: " + student[i].name + "\nMarks: " + student[i].marks);

            Console.ReadLine();
        }
    }
}
