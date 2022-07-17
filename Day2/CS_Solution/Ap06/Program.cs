// 輸入本金、利率、期數, 列出每一期的期數、本金、利息、本利和
for(; ; )
{
    CalcInterest();
    string s;
    Console.WriteLine("繼續執行(Y or N)?");
    s = Console.ReadLine();
    if (s == "N" || s == "n")
        break;
    Console.WriteLine();
}

static void CalcInterest()
{
    string s;
    int principal, n;
    double rate;

    // 輸入本金
    Console.Write("本金: ");
    s = Console.ReadLine();
    principal = int.Parse(s);

    // 輸入利率
    Console.Write("利率%: ");
    s = Console.ReadLine();
    rate = double.Parse(s);

    // 輸入期數
    Console.Write("期數: ");
    s = Console.ReadLine();
    n = int.Parse(s);

    // 列表
    Console.WriteLine("期數  本      金  利      息  合      計"); // 兩格空格等於一個中文字元
    Console.WriteLine("====  ==========  ==========  ==========");
    for (int i = 1; i <= n; i++)
    {
        int interest = (int)(principal * rate / 100 + 0.5);
        Console.WriteLine("{0,4}{1,12:#,##0}{2,12:#,##0}{3,12:#,##0}", i, principal, interest, principal + interest);
        principal += interest;
    }
    Console.WriteLine("====  ==========  ==========  ==========");
}
