﻿using System;
using System.Collections.Generic;

namespace SchoolManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = newStudent.Grade = int.Parse(Util.Console.Ask("Student Phone Number: "));

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.Write("Add another? (y/n) ");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("ERROR! Please enter a number.");
                }
                catch (System.Exception)
                {
                        Console.WriteLine("Error adding student, please try again.");
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 12303);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}
