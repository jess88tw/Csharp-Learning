// 使用 float 做迴圈會出錯, 建議使用 decimal

// 雖然四捨五入，但 <= 10 的 10 不見了, 若將 <= 10 改成 <= 10.1 會發現,
// 10.000002 => 10.00 大於 10, 所以就算四捨五入後等於 10, 也不會再回圈內 
//for (float i = 0; i <= 10; i += 0.1F)
//Console.WriteLine("{0} => {1}", i, i.ToString("0.00"));

// 不推薦使用 double
//for (double i = 0; i <= 10; i += 0.1)
    //Console.WriteLine("{0} => {1}", i, i.ToString("0.00"));

for (decimal i = 0; i <= 10; i += 0.1M)
    Console.WriteLine("{0} => {1}", i, i.ToString("0.00"));
