using System;

// README.md를 읽고 아래에 코드를 작성하세요.


ClassroomManager classroom1 = new ClassroomManager("1");
ClassroomManager classroom2 = new ClassroomManager("2");

classroom1.AddStudent("홍길동");
classroom1.AddStudent("김철수");
classroom1.AddStudent("이영희");

classroom2.AddStudent("박민수");
classroom2.AddStudent("정수진");

classroom1.ShowStudent();
Console.WriteLine();
classroom2.ShowStudent();
Console.WriteLine();

ClassroomManager.ShowTotalClassrooms();
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
                Console.WriteLine($"{i+1}. {studentName[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {totalClass}");
    }
}