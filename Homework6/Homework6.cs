using System;

class Program
{
    static void Main(string[] args)
    {
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(9000);
        Console.WriteLine($"Professor {prof1.profName} teaches {prof1.classTeach} and has a salary of:{prof1.GetSalary()}");

        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Math";
        prof2.SetSalary(8000);
        Console.WriteLine($"Professor {prof2.profName} teaches {prof2.classTeach} and has a salary of:{prof2.GetSalary()}");

        Student stu1 = new Student();
        stu1.studentName = "Lisa";
        stu1.classEnroll = "Java";
        stu1.SetGrade(90);
        Console.WriteLine($"Student {stu1.studentName} is taking {stu1.classEnroll} and has a grade of: {stu1.GetGrade()}");

        Student stu2 = new Student();
        stu2.studentName = "Tom";
        stu2.classEnroll = "Math";
        stu2.SetGrade(80);
        Console.WriteLine($"Student {stu2.studentName} is taking {stu2.classEnroll} and has a grade of: {stu2.GetGrade()}");

        double profSalaryDifference = Professor.CalcProfSalDifference(prof1, prof2);
        Console.WriteLine($"The difference between {prof1.profName} and {prof2.profName}'s salaries is: {profSalaryDifference}");

        double stuGradeDifference = Student.CalcStuGradeDifference(stu1, stu2);
        Console.WriteLine($"The difference between {stu1.studentName} and {stu2.studentName}'s grades is: {stuGradeDifference}");

    }
}
public class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
        {
            return salary;
        }

//      I used ChatGPT to help with the calulations here. I wasn't sure how to do it.
//      I had it explain to be what Math.Abs meant and I understand it now. 
//      Math.Abs is used to take a number of a type and returns it as its absolute value.
//      Meaning that no matter if it is positive or negative it will always be positive.
//      I also used the same type of calculation for the student section.  
        public static double CalcProfSalDifference(Professor prof1, Professor prof2)
        {
            return Math.Abs(prof1.GetSalary() - prof2.GetSalary());
        }
}
public class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        return studentGrade;
    }

    public static double CalcStuGradeDifference(Student stu1, Student stu2)
    {
        return Math.Abs(stu1.GetGrade() - stu2.GetGrade());
    }
}