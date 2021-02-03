using System;
public class Marks
{
    public string subject;
    public int score;

    public Marks(string subject, int score)
    {
        this.subject = subject;
        this.score = score;
    }
}
public class Student
{
    public string name;
    public int id;
    public Marks marks;

    public Student(string name, int id, Marks marks)
    {
        this.name = name;
        this.id = id;
        this.marks = marks;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + marks.subject + " " + marks.score);
    }
}
public class TestAggregation
{
    public static void Main(string[] args)
    {
        Marks m = new Marks("Maths", 98);
        Student s = new Student("Rishabh", 1, m);
        s.display();
    }
}