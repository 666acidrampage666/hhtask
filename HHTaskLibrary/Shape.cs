using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTaskLibrary
{
	public abstract class Shape
	{
		public string TypeName { get; set; }

		public Shape(string typeName)
		{
			TypeName = typeName;
		}

		public abstract double Square();

		public override string ToString()
		{
			return $"Текущий тип фигуры: " + TypeName;
		}
	}
}
