using System;
using System.Collections.Generic;
using System.Text;

class ClassroomManager
{
    public const int student = 5;
    public readonly string className;
    private string[] studentName;
    private int currentStudent = 0;
    private static int totalClass;


    public ClassroomManager(string className)
    {
        this.className = className;
        studentName = new string[student];

        totalClass++;
    }

    public void AddStudent(string name)
    {
        if (currentStudent < 5)
        {
            this.studentName[currentStudent] = name;
            currentStudent++;

        }
        else
        {
            Console.WriteLine("정원이 다 찼습니다");
        }


    }

    public void ShowStudent()
    {
        Console.WriteLine($"=== {className}반 학생 목록 ({currentStudent}/{student}) ===");

        for (int i = 0; i < studentName.Length; i++)
        {
            if (studentName[i] != null)
                Console.WriteLine($"{i + 1}. {studentName[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {totalClass}");
    }
}