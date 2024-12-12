using System;
using System;
using System.IO;
using System.Collections.Generic;
using TumakovLab.Classes;
using String = TumakovLab.Classes.String;
using CheckFormat = TumakovLab.Classes.CheckFormat;
using Song = TumakovLab.Classes.Song;

namespace Lab
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();

        }
        static void Task1()
        {
            Console.WriteLine("Упражнение 8.1");
            Account account1 = new Account(6789123.00m, TypeOfCheck.Текущий);
            Account account2 = new Account(500.00m, TypeOfCheck.Сберегательный);
            account1.GetAccountDetails();
            account2.GetAccountDetails();

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1) Положить деньги на счет");
            Console.WriteLine("2) Снять деньги со счета");
            Console.WriteLine("3) Перевести деньги на другой счет");

            string choice = Console.ReadLine()!;

            if (choice == "1")
            {
                Console.Write("Введите сумму для пополнения: ");
                decimal addmoney;
                while (!decimal.TryParse(Console.ReadLine(), out addmoney) || addmoney <= 0)
                {
                    Console.Write("Введите сумму больше нуля: ");
                }
                account2.Add(addmoney);
            }
            else if (choice == "2")
            {
                Console.Write("Введите сумму для снятия: ");
                decimal dropmoney;
                while (!decimal.TryParse(Console.ReadLine(), out dropmoney) || dropmoney <= 0)
                {
                    Console.Write("Введите сумму больше нуля: ");
                }
                account1.Drop(dropmoney);
            }
            
            // Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
            // метод, который переводит деньги с одного счета на другой.
            else if (choice == "3")
            {
                Console.Write("Введите сумму для перевода: ");
                decimal transferAmount;
                while (!decimal.TryParse(Console.ReadLine(), out transferAmount) || transferAmount <= 0)
                {
                    Console.Write("Введите сумму больше нуля: ");
                }
                account1.Transfer(account2, transferAmount);
            }
            else
            {
                Console.WriteLine("Нет такого варианта!");
            }
        }
        
        // Упражнение 8.2 Реализовать метод, который в качестве входного параметра принимает
        // строку string, возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.
        static void Task2()
        {
            Console.WriteLine("Упражнение 8.2.");
        // строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.");
            string testing = "Я люблю котлеты";
            string result = String.Reverse(testing);

            Console.WriteLine($"Исходная строка: {testing}");
            Console.WriteLine($"Реверсированная строка: {result}");
        }
        
        // Упражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. Если
        // такого файла не существует, то программа выдает пользователю сообщение и заканчивает
        // работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными буквами.
        static void Task3()
        {
            Console.WriteLine("Упражнение 8.3");
            Console.WriteLine("Введите имя файла (относительный путь): ");
            string fileName = Console.ReadLine()!;
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Такого файла не существует.");
                return; 
            }
            string fileContent = File.ReadAllText(fileName);
            string capsLock = fileContent.ToUpper();
            
            string newFileName = Path.Combine(Path.GetDirectoryName(fileName)!, 
                "CapsLock_" + Path.GetFileName(fileName));
            File.WriteAllText(newFileName, capsLock);

            Console.WriteLine($"Текст из файла записан в {newFileName}");
        }

        // Упражнение 8.4. Реализовать метод, который проверяет реализует ли входной параметр
        // метода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс IFormattable обеспечивает
        // функциональные возможности форматирования значения объекта в строковое представление.)
        static void Task4()
        {
            Console.WriteLine("Упражнение 8.4");
            object test1 = 123244536678; 
            object test2 = "Я люблю историю"; 

            Console.WriteLine(CheckFormat.CheckIfIFormattable(test1)); 
            Console.WriteLine(CheckFormat.CheckIfIFormattable(test2)); 
        }
        
        
        // Домашнее задание 8.1. Дан текстовый файл, содержащий ФИО и e-mail адрес.
        // Разделителем между ФИО и адресом электронной почты является символ #.
        // Сформировать новый файл, содержащий список адресов электронной почты.
        // Предусмотреть метод, выделяющий из строки адрес почты. Методу в
        // качестве параметра передается символьная строка s, e-mail возвращается в той же строке s
        static void Task5()
        {
            Console.WriteLine("Домашнее задание 8.1");
            string[] allLines = File.ReadAllLines(@"C:\Users\admin\RiderProjects\HomeWork7\TumakovLab\resources\Name&Emails.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                SearchMail(ref allLines[i]);
            }
            File.WriteAllLines(@"C:\Users\admin\RiderProjects\HomeWork7\TumakovLab\resources\OnlyEmails.txt", allLines);
            Console.WriteLine("Список адресов эл. почты был записан в файл");
        }
        public static void SearchMail(ref string s)
        {
            string[] parts = s.Split("#");
            if (parts.Length > 1)
            {
                s = parts[1].Trim(); 
            }
            else
            {
                s = ""; 
            }
        }

        
        // Домашнее задание 8.2. Список песен. В методе Main создать список из четырех песен. В
        // цикле вывести информацию о каждой песне. Сравнить между собой первую и вторую
        // песню в списке. Песня представляет собой класс с методами для заполнения каждого из
        // полей, методом вывода данных о песне на печать, методом, который сравнивает между собой два объекта
        static void Task6()
        {
            Console.WriteLine("Домашнее задание 8.2");
            List<Song> songs = new List<Song>
            {
                new Song { name = "Song1", author = "Author1" },
                new Song { name = "Song2", author = "Author2" },
                new Song { name = "Song3", author = "Author3" },
                new Song { name = "Song4", author = "Author4" }
            };
            Console.WriteLine("Список песен:");
            foreach (Song song in songs)
            {
                song.Print();
            }
            Console.WriteLine("Сравнение первой и второй песни:");
            bool equal = songs[0].Equals(songs[1]);
            Console.WriteLine($"Песни '{songs[0].Title()}' и '{songs[1].Title()}' " + (equal ? "равны." : "не равны."));
        }
    }
}



    

 
