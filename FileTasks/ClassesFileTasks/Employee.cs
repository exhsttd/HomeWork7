public class Employee
{
    public string Name { get; }
    public string Position { get; }
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }
    public virtual bool TakeTask(string taskType)
    {
        return false; 
    }
}
