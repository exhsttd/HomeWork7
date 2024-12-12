using System.Collections.Generic;

public class Manager : Employee
{
    public List<Employee> Podchinennie { get; private set; } = new List<Employee>();

    public Manager(string name, string position) : base(name, position) { }
    
    public void AddPodchinennie(Employee employee)
    {
        Podchinennie.Add(employee);
    }
    
    public override bool TakeTask(string taskType)
    {
        return true; // Начальство берет любые задачи
    }
}
