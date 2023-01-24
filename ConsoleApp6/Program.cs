WorkWith(new MathTeacher("Alice"));
WorkWith(new PhysicsTeacher("John"));
WorkWith(new Practicant("Tom"));
WorkWith("");

void WorkWith(object obj)
{
    // dynamic teacher = obj; // String not contain definition for Name, WorkWith("");
    // var teacher = (ITeacher)obj; // unable to cast Practicant to ITeacher, WorkWith(new Practicant("Tom"));
    var teacher = obj as ITeacher;
    if (teacher!=null)
    {
        Console.WriteLine(teacher?.Name);
        teacher?.Teach();
    }
}
