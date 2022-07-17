// 一個類別
using System;

namespace Ap18 // 給空間
{
    internal class Person // 定義 Person 這一類
    {
        public string id, name;
        public void Display()
        {
            Console.WriteLine("Id --> {0}, Name --> {1}", id, name);
        }

        public Person(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
