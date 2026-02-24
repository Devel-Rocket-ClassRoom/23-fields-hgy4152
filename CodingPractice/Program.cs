using System;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.


Player player = new Player("용사");
player.ShowStatus();

Character character = new Character();
character.name = "용사";
character.level = 10;
Console.WriteLine(character.name);
Console.WriteLine(character.level);

character.SetInfo("용사", 10);
character.ShowInfo();

Say say = new Say();
say.Hi();

Schedule schedule = new Schedule();
schedule.PrintWeekDays();

DefaultValues defaultValues = new DefaultValues();
defaultValues.ShowDefaults();

Counter counter1 = new Counter();
Counter counter2 = new Counter();
Counter counter3 = new Counter();

Player player1 = new Player("용사");
Player player2 = new Player("마법사");
Player player3 = new Player("궁수");

player1.Total();// 맨위에 한번 써서 4로 나옴


GameConfig gameConfig = new GameConfig(4);
gameConfig.ShowConfig();

Example example = new Example();
example.ShowValue();

player.SetInfo("용사", 10);

Person person = new Person();
person.ShowProfile();

Console.WriteLine();
Console.WriteLine();
GameCharacter gameCharacter1 = new GameCharacter("용사", 15);
GameCharacter gameCharacter2 = new GameCharacter("마법사", 25);
gameCharacter2.Attack(gameCharacter1);
gameCharacter2.Attack(gameCharacter1);
gameCharacter2.Attack(gameCharacter1);

Console.WriteLine($"총 캐릭터 수: {GameCharacter.count}");
#region
class Player
{
    public string name = "이름 없음";
    public int health = 100;
    public int level = 1;

    public static int totalCount = 0;

    private string _name;
    private int _level;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
        Console.WriteLine($"레벨: {level}");
    }

    public Player(string name)
    {
        this.name = name;
        totalCount++;
        Console.WriteLine(name);
    }

    public void Total()
    {
        Console.WriteLine($"총 플레이어 수: {totalCount}");

    }

    public void SetInfo(string _name, int _level)
    {
        this._name = _name;
        this._level = _level;

        Console.WriteLine($"이름: {_name}");
        Console.WriteLine($"레벨: {_level}");
    }
}


class Character
{
    public string name;
    public int level;

    public static string _name;
    public static int _level;

    public void SetInfo(string name, int level)
    {
        _name = name;
        _level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {_name}");
        Console.WriteLine($"레벨: {_level}");
    }
}

class Say
{
    public string message = "안녕하세요.";

    public void Hi()
    {
        message = "반갑습니다.";
        Console.WriteLine(message);
    }
}

class Schedule
{ 
    public string[] date = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

    public void PrintWeekDays()
    {
        foreach(var date in date)
            Console.Write(date + " ");
    }
}


class DefaultValues
{
    public int number;
    public bool flag;
    public string text;

    public void ShowDefaults()
    {
        Console.WriteLine($"number: {number}");
        Console.WriteLine($"flag: {flag}");
        Console.WriteLine($"text: {text}");
    }
}

class Counter
{
    public static int count;

    public Counter()
    {
        count++;
        Console.WriteLine($"현재 카운트: {count}");
    }
}

class GameConfig
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayers;

    public GameConfig(int players)
    {
        maxPlayers = players;
    }

    public void ShowConfig()
    {
        Console.WriteLine($"버전: {version}");
        Console.WriteLine($"최대 플레이어: {maxPlayers}");
    }
}

#endregion

class Example
{
    public const double Pi = 3.14159;
    public readonly DateTime createdAt = DateTime.Now;

    public void ShowValue()
    {
        Console.WriteLine($"원주율: {Pi}");
        Console.WriteLine($"생성시간: {createdAt}");
    }
}


class Person
{
    public const string name = "홍길동";
    public int age = 21;
    public readonly string nickName = "길동이";
    public string[] site = { "네이버", "구글" };

    public void ShowProfile()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"나이: {age}");
        Console.WriteLine($"닉네임: {nickName}");
        Console.Write($"사이트: {string.Join(",", site)} ");
        
    }
}

class GameCharacter
{
    public static int count = 0;
    public const int maxHealth = 100;
    public int currentHealth;
    public readonly int attack;
    public string name;

    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.attack = attack;
        currentHealth = maxHealth;
        count++;

        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {currentHealth}/{maxHealth}");
        Console.WriteLine($"공격력: {attack}");
        Console.WriteLine();
    }

    

    public void Attack(GameCharacter person)
    {
        Random random = new Random();
        int damage = attack * (random.Next(1, 3));
        person.Damaged(damage);
        Console.WriteLine($"{person.name}이(가) {damage} 데미지를 받음! 남은 체력: {person.currentHealth}");
    }

    public void Damaged(int attack)
    {
        if (currentHealth > 0)
            currentHealth -= attack;
        else
            currentHealth = 0;
    }
}