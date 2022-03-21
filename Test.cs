using System;
namespace C
{
    class Test
    {
        public static void Main(String[] args)
        {
            Student[] myStd = new Student[10];
            for (int i = 0; i < myStd.Length; i++)
            {
                myStd[i] = new Student();
                Console.Write(" Enter your name : ");
                myStd[i].name = Console.ReadLine();
                Console.Write(" Enter your year born in : ");
                myStd[i].age = Convert.ToInt16(Console.ReadLine());
                Console.Write(" Enter your id : ");
                myStd[i].id = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < myStd[i].course.Length; k++)
                {
                    Console.WriteLine("Enter your subject gpa for no."+(k+1)+" : ");
                    myStd[i].course[k] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for (int j = 0; j < myStd.Length; j++)
            {
                Console.WriteLine("Student no.:" + (j + 1));
                Console.WriteLine("-------------------------------------");
                myStd[j].print();
            }
            Console.ReadKey();
        }
    }
    class Student
    {
        public String name;
        public int age;
        public int id;
        public double[] course = new double[4];
        public int Age
        {
            get { return 2022-age; }
        }
        public double Averagegpa
        {
            get { double sum = 0;
                foreach (double var in course)
                {
                    sum += var;
                }
                return (sum / 4.0);
            }
        }
        public void print()
        {
            {
                Console.WriteLine("The Student name : " + name);
                Console.WriteLine("The Student id : " + id);
                Console.WriteLine("The Student age : " + Age);
                Console.WriteLine("The Student gpa : " + Averagegpa);
                Console.WriteLine("-------------------------------------");
            }
        }
     
    }
}
