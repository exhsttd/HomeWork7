namespace FileTasks.ClassesFileTasks;

public class SystemAdministrator : Employee
{
    public SystemAdministrator(string name) : base(name, "Системщик") { }

    public bool TakeTask(string taskType)
    {
        return taskType == "Система"; // берут задачи с сетями
    }
    
}
