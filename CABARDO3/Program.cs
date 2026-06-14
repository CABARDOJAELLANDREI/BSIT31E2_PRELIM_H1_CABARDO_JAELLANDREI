using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> studentNames = new List<string>();
    static List<int[]> studentGrades = new List<int[]>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==========================");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    ViewStudents();
                    break;

                case "3":
                    ComputeClassAverage();
                    break;

                case "4":
                    FindHighestGrade();
                    break;

                case "5":
                    Console.WriteLine("Exiting program...");
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddStudent()
    {
        Console.WriteLine("===== ADD STUDENT =====");

        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter grade 1: ");
        int grade1 = int.Parse(Console.ReadLine());

        Console.Write("Enter grade 2: ");
        int grade2 = int.Parse(Console.ReadLine());

        Console.Write("Enter grade 3: ");
        int grade3 = int.Parse(Console.ReadLine());

        studentNames.Add(name);
        studentGrades.Add(new int[] { grade1, grade2, grade3 });

        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("===== STUDENT LIST =====");

        if (studentNames.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        for (int i = 0; i < studentNames.Count; i++)
        {
            double average = studentGrades[i].Average();

            Console.WriteLine($"Name: {studentNames[i]}");
            Console.WriteLine($"Grades: {studentGrades[i][0]}, {studentGrades[i][1]}, {studentGrades[i][2]}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine();
        }
    }

    static void ComputeClassAverage()
    {
        Console.WriteLine("===== CLASS AVERAGE =====");

        if (studentNames.Count == 0)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        double totalAverage = 0;

        for (int i = 0; i < studentNames.Count; i++)
        {
            totalAverage += studentGrades[i].Average();
        }

        double classAverage = totalAverage / studentNames.Count;

        Console.WriteLine($"Overall Average Grade: {classAverage:F2}");
    }

    static void FindHighestGrade()
    {
        Console.WriteLine("===== HIGHEST GRADE =====");

        if (studentNames.Count == 0)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        int highestGrade = -1;
        string topStudent = "";

        for (int i = 0; i < studentNames.Count; i++)
        {
            foreach (int grade in studentGrades[i])
            {
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    topStudent = studentNames[i];
                }
            }
        }

        Console.WriteLine($"Top Student: {topStudent}");
        Console.WriteLine($"Highest Grade: {highestGrade}");
    }
}

