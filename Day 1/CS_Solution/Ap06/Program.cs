// 宣告變數(短 --> 長)
short a;
int b;
a = 10000;
b = a;
Console.WriteLine("a = {0}, b = {1}", a,b);

// 注意溢出(長 --> 短)
int c;
short d;
c = 1000000;
d = (short)c;
Console.WriteLine("c = {0}, d = {1}", c, d);
