WorkWith(new MathTeacher("Alice"));
WorkWith(new PhysicsTeacher("John"));



void WorkWith(object obj)
{
    var teacher = obj as ITeacher;
    Console.WriteLine(teacher?.Name);
    teacher?.Teach();
}