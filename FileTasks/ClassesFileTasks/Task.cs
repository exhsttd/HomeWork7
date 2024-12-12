namespace FileTasks.ClassesFileTasks;

public class Task
{ 
    public string Name { get; private set; }
    public string TaskType { get; private set; }

    public Task(string name, string taskType) 
    {
        Name = name;
        TaskType = taskType;
    }
}
