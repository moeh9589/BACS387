using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManager2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            bool getting_students = true;
            String student_info = "";

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter Students");
            Console.WriteLine("2. Enter Student Grade");
            Console.WriteLine("3. Remove Student(s)");
            Console.WriteLine("4. Grade Analytics");
            Console.WriteLine("5. Quit");
            String choice = Console.ReadLine();
            List<string> students = new List<string>();
            List<List<T> list_info = new List<List<T>();

            while (run == true)
            {
                if (choice == "5")
                {
                    run = false;
                }

                else if (choice == "1")
                {
                    getting_students = true;
                    Console.WriteLine("Enter students (id, first name, last name) 0 to stop:");

                    while (getting_students == true)
                    {

                        Console.Write("Student info:");
                        student_info = Console.ReadLine();
                        list_info = student_info.Split(", ").ToList();
                        if (student_info == "0")
                        {
                            getting_students = false;
                        }
                        else
                        {
                            students.Add(list_info);

                        }

                    }

                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter Students");
                    Console.WriteLine("2. Enter Student Grade");
                    Console.WriteLine("3. Remove Student(s)");
                    Console.WriteLine("4. Grade Analytics");
                    Console.WriteLine("5. Quit");
                    choice = Console.ReadLine();
                }

                else if (choice == "2")
                {
                    Console.WriteLine("Enter student grade");
                    Console.WriteLine("List of students:");
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine(students[i]);
                    }
                    Console.WriteLine("Enter id of student to enter grade:");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter Students");
                    Console.WriteLine("2. Enter Student Grade");
                    Console.WriteLine("3. Remove Student(s)");
                    Console.WriteLine("4. Grade Analytics");
                    Console.WriteLine("5. Quit");
                    choice = Console.ReadLine();
                }

                else if (choice == "3")
                {
                    Console.WriteLine("Remove students");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter Students");
                    Console.WriteLine("2. Enter Student Grade");
                    Console.WriteLine("3. Remove Student(s)");
                    Console.WriteLine("4. Grade Analytics");
                    Console.WriteLine("5. Quit");
                    choice = Console.ReadLine();
                }

                else if (choice == "4")
                {
                    Console.WriteLine("Grade analytics");
                    Console.WriteLine("Student Grade Average: ");
                    Console.WriteLine("Minimum Grade");
                    Console.WriteLine("Maximum Grade");
                    Console.WriteLine("% of A's");
                    Console.WriteLine("% of B's");
                    Console.WriteLine("% of C's");
                    Console.WriteLine("% of D's");
                    Console.WriteLine("% of F's");

                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter Students");
                    Console.WriteLine("2. Enter Student Grade");
                    Console.WriteLine("3. Remove Student(s)");
                    Console.WriteLine("4. Grade Analytics");
                    Console.WriteLine("5. Quit");
                    choice = Console.ReadLine();
                }

                

                
            }
        }
    }
}
