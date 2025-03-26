using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
	public interface IShape
	{
		double Area { get; }
		double CalculatePerimeter();
		void Resize(double factor);
	}

	public class Rectangle : IShape
	{
		public double Width { get; private set; }
		public double Height { get; private set; }
		public double Area => Width * Height;

		public Rectangle(double width, double height)
		{
			Width = width;
			Height = height;
		}

		public double CalculatePerimeter()
		{
			return 2 * (Width + Height);
		}

		public void Resize(double factor)
		{
			Width *= factor;
			Height *= factor;
		}
	}

	public class Circle : IShape
	{
		public double Radius { get; private set; }
		public double Area => Math.PI * Radius * Radius;

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double CalculatePerimeter()
		{
			return 2 * Math.PI * Radius;
		}

		public void Resize(double factor)
		{
			Radius *= factor;
		}

		public class ShapeController
		{
			private IShape _shape;
			private ShapeView _view;

			public ShapeController(IShape shape, ShapeView view)
			{
				_shape = shape;
				_view = view;
				_view.DisplayShapeInfo(_shape.Area, _shape.CalculatePerimeter());
			}

			public void ResizeShape(double factor)
			{
				_shape.Resize(factor);
				_view.DisplayShapeInfo(_shape.Area, _shape.CalculatePerimeter());
			}
		}
		public class ShapeView
		{
			public void DisplayShapeInfo(double area, double perimeter)
			{
				Console.WriteLine($"Oppervlakte: {area}, Omtrek: {perimeter}");
			}
		}
	}
}
