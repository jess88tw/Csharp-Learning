// 範圍會跟著縮減的猜數字遊戲
string s;
do
{
    GuessNumber_2();

    Console.Write("要再玩一次嗎(Y/N)?");
    s = Console.ReadLine();
} while (s == "Y" || s == "y");

static void GuessNumber_2()
{
    Random rnd = new Random();
    string s;
    int ans, guess, min = 1, max = 99;
    ans = rnd.Next(1, 100);

    do
    {
        Console.Write("猜數字({0} ~ {1}):", min, max);
        s = Console.ReadLine();
        guess = int.Parse(s);

        if (guess == -1)
        {
            Console.WriteLine("你輸不起, 答案是:{0}", ans);
        }
        if (guess < min || guess > max) // 超出最大、最小值
        {
            Console.WriteLine("超出範圍!");
            continue;
        }
        if (guess < ans)
            min = guess + 1;
        else if (guess > ans)
            max = guess - 1;
        else
            Console.WriteLine("猜對了");
    } while (guess != ans);
}