// do while 用法
string s;
int n, total = 0;

do
{
    Console.WriteLine("輸入n(輸入0即結束): ");
    s = Console.ReadLine();
    n = int.Parse(s);
    total += n;
} while (n != 0);

Console.WriteLine("Total {0}: ", total);
