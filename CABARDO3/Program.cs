using System;
class Program
{
    static string[] studentNames = new string[100];
    static int[,] grades = new int[100, 3];
    staic int studentCount = 0;

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Compute Class Average");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Add();
                    break;

                case "2":
                    View();
                    break;

                case "3":
                    Average();
                    break;

                case "4":
                    Find()
                    break;

                case "5":
                    Console.WriteLine("Goddbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
    }

    static void Add()
    {
        Console.WriteLine("\nEnter Student name: ");
        studentNames[studentCount] = Console.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter grade " + (i + 1) + ": ");
            grades[studentCount, i] = Convert.ToInt32(Console.ReadLine());
        }

        studentCount++;
        Console.WriteLine("Student added successfully!");
    }

    static void View()
    {
        Console.WriteLine("\n===== STUDENT SYSTEM =====");

        if (studentNamesCount == 0)
        {
            Console.WriteLine("No students found.")
            return;
        }

        for (int i = 0; i < studentCount; i++[i])
        {
            int total = 0;

            Console.WriteLine("\nName: " + studentNames[i]);
            Console.WriteLine("Grades: ");

            for (int i = 0; i < studentCount; i++)
            {
                int total = 0;

                Console.WriteLine("\nName: " + studentNames[i]);
                Console.WriteLine("Grades: ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grades[i, j] + " ");
                    total += grades[i, j];
                }

                double average = total / 3.0;
                Console.WriteLine("\nAverage: " + average.ToString("F2"));
            }
        }
    }

    static void Average()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        double totalAverage == 0;

        for (int i = 0; i < studentCount; i++)
        {
            int total = 0;
            for (int j = 0; j < 3; j++)
            {
                total += grades[i, j];
            }

            totalAverage += total / 3.0;
        }

        double classAverage += totalAverage / 3.0;
        Console.WriteLine("\nClass Average: " + classAverage.ToString("F2"));
    }

    static void Find()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No student records Available.");
            return;
        }

        int highestGrade = grades[0, 0];
        string topStudent = studentNames[0];

        for (int i = 0; i < studentCount; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grades[i, j] > highestGrade)
                {
                    highestGrade = grades[i, j];
                    topStudent = studentNames[i];
                }
            }
        }

        Console.WriteLine("\nTop Student: " + topStudent);
        Console.WriteLine("\nHighest Grade: " + thighestGrade);

    }
}
    


