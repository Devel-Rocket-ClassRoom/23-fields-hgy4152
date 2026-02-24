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
