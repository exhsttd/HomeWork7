using System;
using System.Collections.Generic;
using System.Linq;

namespace FileTasks.ClassesFileTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Работники компании
            var employees = new List<Employee>
            {
                new Manager("Тимур", "Генеральный директор"),
                new Manager("Рашид", "Финансовый директор"),
                new Manager("О Ильхам", "Директор по автоматизации"),
                new Manager("Оркадий", "Начальник инф систем"),
                new Manager("Володя", "Зам.начальника"),
                new SystemAdministrator("Ильшат"),
                new SystemAdministrator("Иваныч"),
                new SystemAdministrator("Илья"),
                new SystemAdministrator("Витя"),
                new SystemAdministrator("Женя"),
                new Developer("Сергей"),
                new Developer("Ляйсан"),
                new Developer("Марат"),
                new Developer("Дина"),
                new Developer("Ильдар"),
                new Developer("Антон")
            };

            // Типы задач
            var tasks = new List<Task>
            {
                new Task("Автоматизация отчетности", "Разработка"),
                new Task("Настройка сети", "Система"),
                new Task("Создание нового ПО", "Разработка"),
                new Task("Обслуживание серверов", "Система")
            };

            AssignTasks(employees, tasks);
        }
        static void CreateHierarchy(List<Employee> employees)
        {
            var genDirector = (Manager)employees[0]; 
            var financeDirector = (Manager)employees[1]; 
            var automatikaDirector = (Manager)employees[2]; 
            
            genDirector.AddPodchinennie(financeDirector);
            genDirector.AddPodchinennie(automatikaDirector);
            
            financeDirector.AddPodchinennie(new Developer("Лариса")); 
            financeDirector.AddPodchinennie(new Developer("Михаил")); 
            financeDirector.AddPodchinennie(new SystemAdministrator("Алексей")); 
            
            automatikaDirector.AddPodchinennie(new Developer("Иван")); 
            automatikaDirector.AddPodchinennie(new SystemAdministrator("Петр")); 
            
            var itManager = (Manager)employees[3]; 
            genDirector.AddPodchinennie(itManager); 
            
            itManager.AddPodchinennie(employees[10]); 
            itManager.AddPodchinennie(employees[11]); 
            itManager.AddPodchinennie(employees[12]); 
            itManager.AddPodchinennie(employees[13]); 
            itManager.AddPodchinennie(employees[14]); 
            itManager.AddPodchinennie(employees[15]); 
        }

        static void AssignTasks(List<Employee> employees, List<Task> tasks)
        {
            foreach (var task in tasks)
            {
                var assignedEmployee = employees.FirstOrDefault(e => e.TakeTask(task.TaskType));
                if (assignedEmployee != null)
                {
                    Console.WriteLine($"Задача - {task.Name}, назначена {assignedEmployee.Name}. Берет задачу: Да");
                }
                else
                {
                    Console.WriteLine($"Задача - {task.Name}. Не берет задачу.");
                }
            }
        }
    }
}

