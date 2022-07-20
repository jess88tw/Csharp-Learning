// 將輸入字串轉換成整數型態 Parse
string s;
int a, b;

// 輸入a
Console.Write("a = ");
s = Console.ReadLine();
a = int.Parse(s);

// 輸入b
Console.Write("b = ");
s = Console.ReadLine();
b = int.Parse(s);

// 使其相加
Console.WriteLine("{0} + {1}  = {2}", a, b, a + b);
