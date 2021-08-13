using System;

namespace GCD0904Interface
{
	class Rectangle : IShape
	{
		private double _width;
		private double _length;

		public Rectangle()
		{

		}

		public Rectangle(double width, double length)
		{
			_width = width;
			_length = length;
		}

		public void Draw()
		{
			DrawLine(_width, '*', '*');
			for (int i = 1; i < _length - 1; ++i)
				DrawLine(this._width, '*', ' ');
			DrawLine(this._width, '*', '*');

		}

		public double CalculateArea()
		{
			return _width * _length;
		}
		private void DrawLine(double width, char end, char mid)
		{
			Console.Write(end);
			for (int i = 1; i < width - 1; ++i)
				Console.Write(mid);
			Console.WriteLine(end);
		}
	}
}
