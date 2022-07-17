using System;

namespace Ap20
{
    internal class BMICalculator
    {
        private double _height, _weight, _bmi;
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="height">體重(kg)</param>
        /// <param name="weight">身高(cm)</param>

        public BMICalculator(double height, double weight)
        {
            _weight = weight;
            _height = height / 100;
            _bmi = _weight / _height / _height;
        }

        public string Status()
        {
            if (_bmi < 18.5)
                return string.Format("身高:{0}cm, 體重:{1}kg, BMI:{2:0.00}, 體重過輕", _height * 100, _weight, _bmi);
            else if (_bmi < 24)
                return string.Format("身高:{0}cm, 體重:{1}kg, BMI:{2:0.00}, 體重正常", _height * 100, _weight, _bmi);
            else
                return string.Format("身高:{0}cm, 體重:{1}kg, BMI:{2:0.00}, 體重過重", _height * 100, _weight, _bmi);
        }
    }
}

