using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        
        new Student("Alice", 111);
        new Student("Bob", 222);
        new Student("Cathy", 333);
        new Student("David", 444);

        
        Student.UpdateGPA("Alice", 4.0);
        Student.UpdateGPA("Bob", 3.6);
        Student.UpdateGPA("Cathy", 2.5);
        Student.UpdateGPA("David", 1.8);

        
        if (!Student.Gradebook.ContainsKey("Tom"))
        {
            Student.UpdateGPA("Tom", 3.3); 
        }

        
        double totalGPA = 0;
        foreach (var gpa in Student.Gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / Student.Gradebook.Count;

        foreach (Student student in Student.Students)
        {
            student.PrintInfo(); 
        }

        Console.WriteLine($"Average GPA: {averageGPA}");

        
        Console.WriteLine("Students with GPA greater than the average:");
        foreach (var student in Student.Gradebook)
        {
            if (student.Value > averageGPA)
            {
                Console.WriteLine($"Student: {student.Key}, GPA: {student.Value}");
            }
        }
    }
}

public class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> Students = new List<Student>();
    public static Dictionary<string, double> Gradebook = new Dictionary<string, double>();

    
    public Student(string studentName, int studentID)
    {
        this.studentName = studentName;
        this.studentID = studentID;
        Students.Add(this);
        
        UpdateGPA(studentName, 0.0); 
    }

    
    public static void UpdateGPA(string studentName, double GPA)
    {
        Gradebook[studentName] = GPA; 
    }

    
    public void PrintInfo()
    {
        double gpa = Gradebook.ContainsKey(studentName) ? Gradebook[studentName] : 0.0;
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}, GPA: {gpa}");
    }
}
