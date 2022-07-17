// 畫星星
string s;
int n;

Console.WriteLine("輸入星星數量: ");
s = Console.ReadLine();
n = int.Parse(s);

// 正三角
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}
Console.WriteLine();

// 倒三角
for (int i = n; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}
Console.WriteLine();

// 金字塔型
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
        Console.Write(" ");
    for (int j = 1; j <= 2 * i - 1; j++)
        Console.Write("*");
    Console.WriteLine();
}