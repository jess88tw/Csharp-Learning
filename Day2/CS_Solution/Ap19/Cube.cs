using System;

namespace Ap19
{
    internal class Cube
    {
        private double _length, _width, _height; // 此類別裡自己的長寬高
        public Cube(double length, double width, double heigh)
        {
            _length = length; // 這樣就不用 this 了, 可以跟傳入的參數分開
            _width = width;
            _height = heigh;
        }

        public double Volume() // 定義體積
        {
            return _length * _width * _height;
        }

        public double Area() // 定義表面積
        {
            return 2 * (_length * _width + _length * _height + _width * _height);
        }
    }
}

