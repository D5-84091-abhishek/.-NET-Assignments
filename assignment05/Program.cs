namespace assignment05
{
    public class Program
    {
        private static Student[] students;

        public static void Main(string[] args)
        {
            CreateArray();
            AcceptInfo();
            PrintInfo();
            ReverseArray();
            PrintInfo();
        }


        public static void CreateArray()
        {
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            students = new Student[numStudents];
        }


        public static void AcceptInfo()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter information for student {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Roll Number: ");
                int rollNumber = int.Parse(Console.ReadLine());
                students[i] = new Student(name, rollNumber);
            }
        }


        public static void PrintInfo()
        {
            Console.WriteLine("Student Information:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }


        public static void ReverseArray()
        {
            Student[] reversedArray = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                reversedArray[i] = students[students.Length - i - 1];
            }
            students = reversedArray;
        }
    }


    class Student
    {
        private string name;
        private int rollNumber;

        public Student(string name, int rollNumber)
        {
            this.name = name;
            this.rollNumber = rollNumber;
        }

        public override string ToString()
        {
            return $"Name: {name}, Roll Number: {rollNumber}";
        }
    }

}
