// 利用 do while 猜數字
string s;
do
{
    GuessNumber();

    Console.Write("要再玩一次嗎(Y/N)?");
    s = Console.ReadLine();
} while (s == "Y" || s == "y");

static void GuessNumber()
{
    Random rnd = new Random();
    int ans, guess;
    ans = rnd.Next(1, 101); // 產生隨機數字 1~100

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