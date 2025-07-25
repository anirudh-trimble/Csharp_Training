public class Student
{
    private int rollNo;

    // Read-Write Property
    public int RollNo
    {
        get
        {
            return rollNo;
        }
        set
        {
            rollNo = value;
        }
    }

    public Student(int rollNo)
    {
        this.RollNo = rollNo;
    }
}

public class Geeks
{
    public static void Main(string[] args)
    {
        Student obj = new Student(147);
        Console.WriteLine($"Roll No: {obj.RollNo}");

        obj.RollNo = 123;
        Console.WriteLine($"Changed Roll No: {obj.RollNo}");
    }
}