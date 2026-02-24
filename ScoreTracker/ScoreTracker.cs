using System;
using System.Collections.Generic;
using System.Text;

class ScoreTracker
{
    public const int maxScore = 100;
    public const int minScore = 0;

    public readonly string className;
    private int currentScore = 0;
    private int bonus = 0;


    public ScoreTracker(string className)
    {
        this.className = className;
    }

    public void SetScore(int score)
    {
        if (minScore <= score && score <= maxScore)
        {
            this.currentScore = score;
            Console.WriteLine($"점수를 {score}으로 설정했습니다.");
        }
        else
        {
            Console.WriteLine("0~100 범위의 점수를 설정해주세요");
        }
    }

    public void AddBonus(int bonusScore)
    {
        this.bonus++;
        currentScore += bonusScore;


        if (currentScore > maxScore)
        {
            currentScore = maxScore;
            Console.WriteLine($"{bonusScore}점 보너스 적용! 현재 점수: {currentScore}점 (최대 점수 도달)");
        }
        else
        {
            Console.WriteLine($"{bonusScore}점 보너스 적용! 현재 점수: {currentScore}점");
        }

    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {className} ===");
        Console.WriteLine($"점수: {currentScore}/{maxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonus}");
    }
}