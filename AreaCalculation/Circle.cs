using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    /// <summary>
    /// Вычиление площади круга.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Создание экземпляра Circle с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Measurements = new List<double>() { radius }.AsReadOnly();
        }
        /// <summary>
        /// Проверка переданного списка отрезков на описание существующего круга: длина списка - 1, double.MaxValue >= значение длины > 0
        /// </summary>
        /// <param name="measurments">Радиус</param>
        /// <returns>Круг сушетсвует, False - в противном случае.</returns>
        protected override bool IsValid(List<double> measurments)
        {
            if (measurments.Count == 1 && measurments[0] > 0 && measurments[0] <= double.MaxValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Вычисление площади круга по радиусу
        /// </summary>
        /// <returns>Площадь круга</returns>
        protected override double CalculateArea()
        {
            return Math.PI * Measurements[0] * Measurements[0];
        }
    }

}
