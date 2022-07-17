// 製作菜單
for(; ; )
{
    string s = Menu();
    switch(s)
    {
        case "1":
            DrawStar();
            break;
        case "2":
            GuessGame();
            break;
        case "3":
            Dice();
            break;
        case "4":
            ABmath();
            break;
        default:
            break;
    }
    if (s == "0")
        break;
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

static string Menu()
{
    Console.WriteLine("1 --> Draw Star");
    Console.WriteLine("2 --> Guess Game");
    Console.WriteLine("3 --> Dice");
    Console.WriteLine("4 --> A + B = ?");
    Console.WriteLine("0 --> Quit");
    Console.Write("Your chose --> ");
    return Console.ReadLine();
}

static void DrawStar()
{
    string s;
    int n;

    Console.WriteLine("輸入星星數量: ");
    s = Console.ReadLine();

    n = int.Parse(s);

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = n; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i; j++)
            Console.Write(" ");
        for (int j = 1; j <= 2 * i - 1; j++)
            Console.Write("*");
        Console.WriteLine();
    }
}

static void GuessGame()
{
    Random rnd = new Random();
    int ans, guess;
    ans = rnd.Next(1, 101);

    do
    {
        string s;
        Console.WriteLine("猜數字囉, 輸入數字: ");
        s = Console.ReadLine();
        guess = int.Parse(s);

        if (guess == -1)
        {
            Console.WriteLine("你認輸了! 答案是{0}", ans);
            break;
        }
        if (guess > 100)
        {
            Console.WriteLine("超出範圍!");
            continue;
        }

        if (guess == ans)
            Console.WriteLine("恭喜答對!");
        else if (guess > ans)
            Console.WriteLine("在低點");
        else
            Console.WriteLine("在高一點");
    } while (guess != ans);
}

static void Dice()
{
    Random rdn = new Random();
    int[] dices = new int[4];

    for (int i = 0; i < 4; i++)
    {
        dices[i] = rdn.Next(1, 7);
        Console.WriteLine(dices[i]);
    }

    Array.Sort(dices);

    Console.WriteLine("{0} {1} {2} {3}", dices[0], dices[1], dices[2], dices[3]);

    if (dices[0] == dices[3])
        Console.WriteLine("一色");
    else if (dices[0] == dices[2] || dices[1] == dices[3])
        Console.WriteLine("沒點重新");
    else if (dices[0] == dices[1])
        Console.WriteLine("{0}點", dices[2] + dices[3]);
    else if (dices[1] == dices[2])
        Console.WriteLine("{0}點", dices[0] + dices[3]);
    else if (dices[2] == dices[3])
        Console.WriteLine("{0}點", dices[0] + dices[1]);
    else
        Console.WriteLine("沒點重擲");
}

static void ABmath()
{
    string s;
    int a, b;
    bool iscorrect;

    do
    {
        Console.WriteLine("請輸入第一個數字: ");
        s = Console.ReadLine();
        iscorrect = int.TryParse(s, out a);
        if (!iscorrect)
            Console.WriteLine("請輸入整數!");
    } while (!iscorrect);

    do
    {
        Console.WriteLine("請輸入第二個數字: ");
        s = Console.ReadLine();
        iscorrect = int.TryParse(s, out b);
        if (!iscorrect)
            Console.WriteLine("請輸入整數!");
    } while (!iscorrect);

    Console.WriteLine("a + b = {0}", a + b);
}
