using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CalculateShapeArea
{
    /// <summary>
    /// ���������� ������� ����� �� ������������� ������ �������� (�� ������� �����, �� �������� ������������ � �.�.).
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// ������� ������.
        /// </summary>
        public double Area { get { return CalculateArea(); } }
        /// <summary>
        /// ������ ������ ��������, ����������� ���������� ������.
        /// </summary>
        /// <exception cref="ArgumentException">��������������� ����� �������� �� ��������� �������������� ������</exception>
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
                    throw new ArgumentException("���������� ����������.");
                }
            }
            get
            {
                return _measurements.AsReadOnly();
            }
        }
        protected List<double> _measurements;
        /// <summary>
        /// ���������� ������� ������.
        /// </summary>
        /// <returns>������� ������</returns>
        protected abstract double CalculateArea();
        /// <summary>
        /// �������� ������ ���������� �������� �� ��, ��� ��� ��������� ������������ ������.
        /// </summary>
        /// <param name="measurments">������ ��������</param>
        /// <returns>���� True - ������ �������� ��������� ������������ ������, � ��������� ������ ������ �������� �� ��������� ������������ ������.</returns>
        protected abstract bool IsValid(List<double> measurments);
    }

    
    
}
