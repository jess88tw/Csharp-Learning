// 檔案的讀取
StreamReader rd = new StreamReader("/Users/jess88tw/Visual Studio/Day2/CS_Solution/Ap21/test.txt");
Console.Write(rd.ReadToEnd());
rd.Close();
