using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CalculateShapeArea
{
    /// <summary>
    /// ¬ычисление площади фигур по определенному набору отрезков (по радиусу круга, по сторонам треугольника и т.д.).
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// ѕлощадь фигуры.
        /// </summary>
        public double Area { get { return CalculateArea(); } }
        /// <summary>
        /// —писок набора отрезков, описывающий конкретную фигуру.
        /// </summary>
        /// <exception cref="ArgumentException">”станавливаемый набор отрезков не описывает действительную фигуру</exception>
        public ReadOnlyCollection<double> Measurements
        {
            set
            {
                if (IsValid(value.ToList()))
                {
                    _measurements = value.ToList();
                }
                else
                {
                    throw new ArgumentException("¬ычисление невозможно.");
                }
            }
            get
            {
                return _measurements.AsReadOnly();
            }
        }
        protected List<double> _measurements;
        /// <summary>
        /// ¬ычисление площади фигуры.
        /// </summary>
        /// <returns>ѕлощадь фигуры</returns>
        protected abstract double CalculateArea();
        /// <summary>
        /// ѕроверка списка переданных отрезков на то, что они описывают существующую фигуру.
        /// </summary>
        /// <param name="measurments">—писок отрезков</param>
        /// <returns>≈сли True - список отрезков описывает существующую фигуру, в противном случае список отрезков не описывает существующую фигуру.</returns>
        protected abstract bool IsValid(List<double> measurments);
    }

    
    
}
