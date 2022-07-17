// 限制只能輸入數字
string s;
int a, b;
bool iscorrect;

do
{
    Console.WriteLine("請輸入第一個數字: ");
    s = Console.ReadLine();
    iscorrect = int.TryParse(s, out a);
    if (!iscorrect) // iscorrect == false 等同於 !iscorrect
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
