// 判斷句
string s;
int score;

// 輸入成績
Console.WriteLine("成績: ");
s = Console.ReadLine();
score = int.Parse(s);

// 判斷是否及格
if (score > 60)
    Console.WriteLine("及格");
else
    Console.WriteLine("不及格");
