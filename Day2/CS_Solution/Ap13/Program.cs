// 擲骰子遊戲
for(; ; )
{
    Roll();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void Roll()
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

    if (dices[0] == dices[3]) // 4 顆骰子全部一樣
        Console.WriteLine("一色");
    else if (dices[0] == dices[2] || dices[1] == dices[3]) // 3 顆骰子一樣的情況下, 會有兩種排法
        Console.WriteLine("沒點重新");
    else if (dices[0] == dices[1] && dices[2] == dices[3]) // 兩對骰子相同, 取大的兩顆相加
        Console.WriteLine("{0}點", dices[2] + dices[3]);
    else if (dices[0] == dices[1]) // 兩顆相同、兩顆不同, 情況一
        Console.WriteLine("{0}點", dices[2] + dices[3]);
    else if (dices[1] == dices[2]) // 兩顆相同、兩顆不同, 情況二
        Console.WriteLine("{0}點", dices[0] + dices[3]);
    else if (dices[2] == dices[3]) // 兩顆相同、兩顆不同, 情況三
        Console.WriteLine("{0}點", dices[0] + dices[1]);
    else
        Console.WriteLine("沒點重擲");
}