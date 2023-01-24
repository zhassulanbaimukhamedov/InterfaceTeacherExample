



public class MathTeacher : ITeacher
{
    public string Name { get; set; }
    public MathTeacher(string name)
    {
        Name = name;
    }
    public void Teach()
    {
        Console.WriteLine("I am teaching Mathematics");
    }
}
