using System;

// README.md를 읽고 아래에 코드를 작성하세요.



ScoreTracker scoreTracker1 = new ScoreTracker("수학");

scoreTracker1.ShowScore();
Console.WriteLine();
scoreTracker1.SetScore(85);
scoreTracker1.AddBonus(10);
scoreTracker1.AddBonus(20);
scoreTracker1.SetScore(101);

Console.WriteLine();

scoreTracker1.ShowScore();



