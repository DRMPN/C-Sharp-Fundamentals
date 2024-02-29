using System;

namespace StaticModifier
{
	public static class Circle
	{
		public static double Circumference(double r)
        {
			return 2 * Math.PI * r;
        }

		public static double Area(double r)
        {
			return Math.PI * Math.Pow(r, 2);
		}

		public static bool IsPointInCircle(double x, double y, double r, double centerX, double centerY)
        {
			return Math.Pow((x - centerX),2) + Math.Pow((y - centerY), 2) < r * r;
        }
	}
}