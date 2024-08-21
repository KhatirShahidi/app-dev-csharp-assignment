using System;

namespace StudentManagementSystem
{
    class Student
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Grade: {3} - {4}", ID, Name, Age, Grade, IsPassing());
        }

        public string IsPassing()
        {
            if (Grade >= 60)
            {
                return "Passing";
            }
            else
            {
                return "Failing";
            }
        }

        public string CapitalizeWords()
        {
            string[] words = Name.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[50];
            int studentCount = 0;

            while (true)
            {
                Console.Write("Welcome to Student Management System!\n");
                Console.Write("----------------------------------------\n");
                DisplayMenu();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(students, studentCount);
                        studentCount++;
                        break;
                    case 2:
                        DisplayAllStudents(students, studentCount);
                        break;
                    case 3:
                        SearchStudent(students, studentCount);
                        break;
                    case 4:
                        RemoveStudent(students, studentCount);
                        studentCount--;
                        break;
                    case 5:
                        UpdateStudentGrade(students, studentCount);
                        break;
                    case 6:
                        SortStudentsByGrade(students, studentCount);
                        break;
                    case 7:
                        DisplayAverageGrade(students, studentCount);
                        break;
                    case 8:
                        CountPassingStudents(students, studentCount);
                        break;
                    case 9:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1. Add a New Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search for a Student by ID");
            Console.WriteLine("4. Remove a Student by ID");
            Console.WriteLine("5. Update a Student's Grade");
            Console.WriteLine("6. Sort Students by Grade");
            Console.WriteLine("7. Display Average Grade");
            Console.WriteLine("8. Count Passing Students");
            Console.WriteLine("9. Exit");
        }

        static void AddStudent(Student[] students, int studentCount)
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Grade: ");
            int grade = int.Parse(Console.ReadLine());
            students[studentCount] = new Student { ID = id, Name = name, Age = age, Grade = grade };
            studentCount++;
            Console.WriteLine("Student added successfully!");
        }

        static void SearchStudent(Student[] students, int studentCount)
        {
            Console.Write("Enter Student ID to search: ");
            int searchId = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].ID == searchId)
                {
                    students[i].DisplayDetails();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void RemoveStudent(Student[] students, int studentCount)
        {
            Console.Write("Enter Student ID to remove: ");
            int removeId = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].ID == removeId)
                {
                    for (int j = i; j < studentCount - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    studentCount--;
                    Console.WriteLine("Student removed successfully!");
                    break;
                }
            }
        }

        static void UpdateStudentGrade(Student[] students, int studentCount)
        {
            Console.Write("Enter Student ID to update: ");
            int updateId = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].ID == updateId)
                {
                    Console.Write("Enter new grade: ");
                    int newGrade = int.Parse(Console.ReadLine());
                    students[i].Grade = newGrade;
                    Console.WriteLine("Grade updated successfully!");
                    break;
                }
            }
        }

        static void SortStudentsByGrade(Student[] students, int studentCount)
        {
            for (int i = 0; i < studentCount - 1; i++)
            {
                for (int j = 0; j < studentCount - i - 1; j++)
                {
                    if (students[j].Grade > students[j + 1].Grade)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        static void DisplayAverageGrade(Student[] students, int studentCount)
        {
            int totalGrade = 0;
            for (int i = 0; i < studentCount; i++)
            {
                totalGrade += students[i].Grade;
            }
            Console.WriteLine("Average grade: " + totalGrade / studentCount);
        }

        static void CountPassingStudents(Student[] students, int studentCount)
        {
            int passingCount = 0;
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].Grade >= 60)
                {
                    passingCount++;
                }
            }
            Console.WriteLine("Number of passing students: " + passingCount);
        }

        static void DisplayAllStudents(Student[] students, int studentCount)
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].DisplayDetails();
            }
        }

        static void DisplayDetails(Student[] students, int studentCount)
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].DisplayDetails();
            }
        }
    }
}



