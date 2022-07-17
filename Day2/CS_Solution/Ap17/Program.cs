// 盡量不要使用 goto
Console.WriteLine("Star");
goto label2;

label1:
Console.WriteLine("label1");
goto label3;

label2:
Console.WriteLine("label2");
goto label1;

label3:
Console.WriteLine("label3");
