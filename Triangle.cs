using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    /// <summary>
    /// Cоздание и вычисление площади треугольника.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Создание экземпляря Triangle с заданными сторонами
        /// </summary>
        /// <param name="sideA">Сторона треугольника A</param>
        /// <param name="sideB">Сторона треугольника B</param>
        /// <param name="sideC">Сторона треугольника C</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            Measurements = new List<double>() { sideA, sideB, sideC }.AsReadOnly();
        }

        /// <summary>
        /// Проверка переданного списка отрезков на описание существующего треугольника: (1)длина списка - 3, (2)double.MaxValue >= значение длины каждой из сторон > 0,
        /// (3)сумма длинн каждых 2 сторон больше длинны третьей стороны.
        /// </summary>
        /// <param name="measurments">Список отрезков треугольника.</param>
        /// <returns>True - список отрезков описывает существующий треугольник, в противном случае False.</returns>
        protected override bool IsValid(List<double> measurments)
        {
            if (measurments.Count == 3 &&
                measurments[0] > 0 &&               //(1)
                measurments[1] > 0 &&
                measurments[2] > 0 &&

                measurments[0] <= double.MaxValue &&                //(2)
                measurments[1] <= double.MaxValue &&
                measurments[2] <= double.MaxValue &&

                measurments[0] + measurments[1] > measurments[2] &&              //(3)
                measurments[0] + measurments[2] > measurments[1] &&
                measurments[1] + measurments[2] > measurments[0]
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Определение прмоугольного треугольника.
        /// </summary>
        /// <returns>True если треугольник является прямоугольным, False - не является прямоугольным, null - невозможно определить тип треугольника из-за переполнения double.</returns>
        public bool? IsRightTriangle()
        {
            var orderedMeasurments = _measurements.OrderByDescending(m => m).ToList();

            double sqrC = Math.Pow(orderedMeasurments[0], 2);
            double sqrB = Math.Pow(orderedMeasurments[1], 2);
            double sqrA = Math.Pow(orderedMeasurments[2], 2);

            if (double.IsInfinity(sqrC) || double.IsInfinity(sqrB + sqrA))
            {
                return null;
            }

            if (sqrC == sqrB + sqrA)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///Вычисление площади треугольника по 3 сторонам
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        protected override double CalculateArea()
        {
            double p = (Measurements[0] + Measurements[1] + Measurements[2]) / 2;
            return Math.Sqrt(p * (p - Measurements[0]) * (p - Measurements[1]) * (p - Measurements[2]));
        }
    }
}
