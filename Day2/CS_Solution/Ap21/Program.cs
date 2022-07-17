// 文字檔案的寫入
StreamWriter wr = new StreamWriter("/Users/jess88tw/Visual Studio/Day2/CS_Solution/Ap21/test.txt");
for (int i = 0; i < 10; i++)
    wr.WriteLine("Hello {0}", i);
wr.Close(); // 記得關閉檔案
