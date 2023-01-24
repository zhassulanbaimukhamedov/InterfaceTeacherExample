



public class PhysicsTeacher: ITeacher
{
    public string Name { get; set; }
    public PhysicsTeacher(string name)
    {
        Name = name;
    }

    public void Teach()
    {
        Console.WriteLine("I am teaching Physics");
    }
}