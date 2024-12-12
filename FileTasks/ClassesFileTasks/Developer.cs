namespace FileTasks.ClassesFileTasks;

public class Developer : Employee
{
    public Developer(string name) : base(name, "Разработчик") { }

    public bool TakeTask(string taskType)
    {
            return taskType == "Разработка"; // берут задачи на разработку
    }
    
}
