// 台幣換算指定貨幣
string s, curr;
int money;
decimal amount;

Console.WriteLine("台幣: ");
s = Console.ReadLine();
money = int.Parse(s);

Console.WriteLine("輸入要兌換的幣別(USD = U, JPY = J, EUR = E): ");
curr = Console.ReadLine();

switch (curr)
{
    case "U":
    case "u":
        amount = money / 30.05M; // decimal 等號左右兩邊需要是一樣的形式, M 是 decimal 的縮寫
        break;
    case "J":
    case "j":
        amount = money / 0.2758M;
        break;
    case "E":
    case "e":
        amount = money / 32.55M;
        break;
    default:
        amount = 0;
        break;
}
Console.WriteLine("台幣: {0:#,##0}, 兌換 {1:#,##0.00}", money, amount);
