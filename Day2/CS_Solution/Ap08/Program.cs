// Array Sort 縮排用法
int[] ar = { 17, 20, 30, 40, 1, 8 };
int total = 0;

Array.Sort(ar);

foreach (int n in ar)
{
    Console.WriteLine(n);
    total += n; // total = tatal + n
}
Console.WriteLine("Total = {0}", total);
