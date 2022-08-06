using System;
using System.Collections;

namespace HashTableChallenge
{
    //Challenge
    /*
     * Write a program that will iterate through each element of the students array and inset them 
     * into a hashtable.  If a student with the same ID already exists in the hashtable, skip it and
     * display the following error:
     * "Sorry, A student with the same ID already exists".
     * Hint: Use the method ContainsKey() to check if a student with the same ID already exists.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach(Student student in students)
            {
                if (!studentTable.ContainsKey(student.ID))
                {
                    studentTable.Add(student.ID, student);
                    Console.WriteLine("Student ID {0} has been successfully added!", student.ID);
                    Console.WriteLine("Student ID: {0} \nStudent Name: {1} \nStudent GPA: {2}\n",student.ID,student.Name,student.GPA);
                }
                else
                {
                    Console.WriteLine("A student already exists with ID : {0}",student.ID);
                    Console.WriteLine("Please change the Student ID for {0}!\n",student.Name);
                }
            }
            
            Console.Read();
            
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int ID, string Name, float GPA)
        {
            this.ID = ID;
            this.Name = Name;
            this.GPA = GPA;
        }
    }
}
