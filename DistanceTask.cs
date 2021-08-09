using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			var A = ay - by;
			var B = bx - ax;
			var C = ax * by - bx * ay;
			if ((ax == x && ay == y) || (bx == x && by == y))
				return 0.0;
			else if ((x - bx) * (ax - bx) + (y - by) * (ay - by) < 0 || (ax == bx && ay == by))
				return Math.Sqrt(Math.Pow(Math.Abs(x - bx), 2) + Math.Pow(Math.Abs(y - by), 2));
			else if((x - ax) * (bx - ax) + (y - ay) * (by - ay) < 0)
				return Math.Sqrt(Math.Pow(Math.Abs(x - ax), 2) + Math.Pow(Math.Abs(y - ay), 2));
			else
				return Math.Abs(A * x + B * y + C) / Math.Sqrt(A * A + B * B);
		}
	}
}