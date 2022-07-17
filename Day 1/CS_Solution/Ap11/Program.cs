// 判斷句加上運算
string s;
int income, tax;

// 輸入年收
Console.WriteLine("所得年收: ");
s = Console.ReadLine();
income = int.Parse(s);

// 判斷級距
if (income <= 540000)
    tax = (int)(income * 0.05 + 0.5); // +0.5 是為了四捨五入
else if (income <= 1210000)
    tax = (int)(income * 0.12 - 37800 + 0.5);
else if (income <= 2420000)
    tax = (int)(income * 0.2 - 134600 + 0.5);
else if (income <= 4530000)
    tax = (int)(income * 0.3 - 376600 + 0.5);
else
    tax = (int)(income * 0.4 - 829600 + 0.5);
Console.WriteLine("年收所得: {0:#,##0}, 應該繳納稅金: {1:#,##0}", income, tax); // ("{0:#,##0}"), :#,##0 = 在多個位數裡加入逗號, 例如年薪 500000 --> 500,000
