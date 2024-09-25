using System;
using System.Collections.Generic;

// Підпорядкований клас, що представляє оцінку з дисципліни
public class Grade
{
    public string Subject { get; set; } // Назва предмета
    public double Score { get; set; } // Оцінка

    // Конструктор
    public Grade(string subject, double score)
    {
        Subject = subject;
        Score = score;
    }

    // Метод для відображення інформації про оцінку
    public void ShowInfo()
    {
        Console.WriteLine($"Subject: {Subject}, Score: {Score}");
    }
}

// Головний клас, що представляє студента
public class Student
{
    public string Name { get; set; } // Ім'я студента
    public List<Grade> Grades { get; private set; } // Список оцінок

    // Конструктор
    public Student(string name)
    {
        Name = name;
        Grades = new List<Grade>();
    }

    // Метод для додавання оцінки
    public void AddGrade(Grade grade)
    {
        Grades.Add(grade);
    }

    // Метод для видалення оцінки
    public void RemoveGrade(Grade grade)
    {
        Grades.Remove(grade);
    }

    // Метод для відображення інформації про студента та його оцінки
    public void ShowInfo()
    {
        Console.WriteLine($"Student: {Name}");
        Console.WriteLine("Grades:");
        foreach (var grade in Grades)
        {
            grade.ShowInfo();
        }
    }
}

// Головний клас програми
class task04_2
{
    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення студента
        Student student = new Student("Ivan Ivanov");

        // Додавання оцінок
        student.AddGrade(new Grade("Mathematics", 95));
        student.AddGrade(new Grade("Physics", 88));
        student.AddGrade(new Grade("Chemistry", 92));

        // Відображення інформації про студента та його оцінки
        student.ShowInfo();

        // Видалення оцінки з предмету "Physics"
        var gradeToRemove = student.Grades.Find(g => g.Subject == "Physics");
        if (gradeToRemove != null)
        {
            student.RemoveGrade(gradeToRemove);
        }

        Console.WriteLine("\nAfter removing Physics grade:");
        student.ShowInfo();

        Console.ReadKey();
    }
}
