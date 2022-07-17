// 輸入兩個不是數字的字元, 丟出錯誤訊息
string s;
int a, b;

try
{

    Console.Write("a=");
    s = Console.ReadLine();
    a = int.Parse(s);

    Console.Write("b=");
    s = Console.ReadLine();
    b = int.Parse(s);

    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("bye.");
}