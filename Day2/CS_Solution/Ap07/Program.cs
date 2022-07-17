// Array 用法

// 逐個列出
//string [] names = new string[5];
//names[0] = "Jess";
//names[1] = "Andy";
//names[2] = "Cany";
//names[3] = "Cancer";
//names[4] = "Bob";
//for (int i = 0; i < names.Length; i++)
//    Console.WriteLine(names[i]);

// 乾淨版
//string[] names = { "Jess", "Andy", "Cany", "Cancer", "Bob" };
//for (int i = 0; i < names.Length; i++)
//    Console.WriteLine(names[i]);

// 也可以使用 foreach
string[] names = { "Jess", "Andy", "Cany", "Cancer", "Bob" };
foreach (string name in names)
    Console.WriteLine(name);
