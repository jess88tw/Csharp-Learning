// Random 用法
Random rnd = new Random(); // new 才可以分配空間

for (int i = 0; i < 10; i++)
    Console.WriteLine(rnd.Next(1, 7));
