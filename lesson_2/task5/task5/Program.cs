using System;

namespace task5
{
    //метод для возможности установки/получения оценки
    class Student
    {
        string firstName;
        string secondName;
        string lastName;
        string group;
        int age;
        int[][] marks;

        public Student(string firstName, string secondName, string lastName, string group, int age, int [][] marks)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.group = group;
            this.age = age;
            this.marks = marks;
        }

        public void Print()
        {
            Console.WriteLine($"Student: {lastName} {firstName} {secondName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
            for(int i = 0; i<marks.Length; i++)
            {
                if(i==1)
                {
                    Console.Write("Marks for administration: ");
                }
                else if(i<1)
                {
                    Console.Write("Marks for programming: ");
                }
                else
                {
                    Console.Write("Marks for design: ");
                }
                for (int j =0;j<marks[i].Length;j++)
                {
                    Console.Write(marks[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public double Srednee(int a)
        {
            double res = 0;
            int count = 0;
            switch (a)
            {
                case 1:
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < marks[i].Length; j++)
                        {
                            res += marks[i][j];
                            count++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i < 2; i++)
                    {
                        for (int j = 0; j < marks[i].Length; j++)
                        {
                            res += marks[i][j];
                            count++;
                        }
                    }
                    break;
                case 3:
                    for (int i = 2; i < 3; i++)
                    {
                        for (int j = 0; j < marks[i].Length; j++)
                        {
                            res += marks[i][j];
                            count++;
                        }
                    }
                    break;
            }
            res /= count;
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[][] marks = new int[3][];
           // marks[0] = new int[] { 9, 8, 6 };
            //marks[1] = new int[] { 8, 8 };
            //marks[2] = new int[] { 7, 7, 8, 9 };
            Student Pavel = new Student("Pavel", "Alexandrovich", "Kozlov", "FA-32", 19, marks);
            Pavel.Print();
            Console.WriteLine("In what subject do you want to know the GPA?");
            Console.WriteLine("1 - programming\n2 - administration\n3 - design");
            int choise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GPA = " + Pavel.Srednee(choise));
        }
    }
}
