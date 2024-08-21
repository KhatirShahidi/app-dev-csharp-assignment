using System;

namespace StudentManagementSystem
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Grade: {3} - {4}", ID, Name, Age, Grade, IsPassing());
        }

        public string IsPassing()
        {
            return Grade >= 60 ? "Passing" : "Failing";
        }

    

        public static string CapitalizeWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

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
                        AddStudent(students);
                        break;
                    case 2:
                        DisplayAllStudents(students);
                        break;
                    case 3:
                        SearchStudent(students);
                        break;
                    case 4:
                        RemoveStudent(students);
                        break;
                    case 5:
                        UpdateStudentGrade(students);
                        break;
                    case 6:
                        SortStudentsByGrade(students);
                        break;
                    case 7:
                        DisplayAverageGrade(students);
                        break;
                    case 8:
                        CountPassingStudents(students);
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

        static void AddStudent(List<Student> students)
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Student.CapitalizeWords(Console.ReadLine());
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Grade: ");
            int grade = int.Parse(Console.ReadLine());
            students.Add(new Student { ID = id, Name = name, Age = age, Grade = grade });
        }



        static void SearchStudent(List<Student> students)
        {
            Console.Write("Enter Student ID to search: ");
            int searchId = int.Parse(Console.ReadLine());
            var student = students.Find(s => s.ID == searchId);

            if (student != null)
            {
                student.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void RemoveStudent(List<Student> students)
        {
            Console.Write("Enter Student ID to remove: ");
            int removeId = int.Parse(Console.ReadLine());
            var student = students.Find(s => s.ID == removeId);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void UpdateStudentGrade(List<Student> students)
        {
            Console.Write("Enter Student ID to update: ");
            int updateId = int.Parse(Console.ReadLine());
            var student = students.Find(s => s.ID == updateId);

            if (student != null)
            {
                Console.Write("Enter new grade: ");
                int newGrade = int.Parse(Console.ReadLine());
                student.Grade = newGrade;
                Console.WriteLine("Grade updated successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void SortStudentsByGrade(List<Student> students)
        {
            students.Sort((s1, s2) => s1.Grade.CompareTo(s2.Grade));
        }

        static void DisplayAverageGrade(List<Student> students)
        {
            int totalGrade = 0;
            foreach (var student in students)
            {
                totalGrade += student.Grade;
            }
            Console.WriteLine("Average grade: " + (students.Count > 0 ? totalGrade / students.Count : 0));
        }

        static void CountPassingStudents(List<Student> students)
        {
            int passingCount = students.Count(s => s.Grade >= 60);
            Console.WriteLine("Number of passing students: " + passingCount);
        }

        static void DisplayAllStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                student.DisplayDetails();
            }
        }
    }
}



