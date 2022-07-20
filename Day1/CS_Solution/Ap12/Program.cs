// 用 switch 的方法分類月份大小
string s;
int month;
Console.WriteLine("月份: ");
s = Console.ReadLine();
month = int.Parse(s);

// switch 的用法
switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("大月(31天)");
        break; // 1,3,5,7,8,10,11 都會印出("大月(31天)"), 另外可以使用 goto 指定去哪個 case
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("小月(30天)");
        break;
    case 2:
        Console.WriteLine("28或29天");
        break;
    default:
        Console.WriteLine("只接受1~12月");
        break;
}
