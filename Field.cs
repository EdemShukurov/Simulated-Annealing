using System;
using System.Collections.Generic;

namespace Simulated_annealing
{
	internal class Field
	{
		public List<City> Points { get; }

		public Field(int canvasWidth, int canvasHeight, int pointsCount)
		{
			Points = GeneratePoints(canvasWidth, canvasHeight, pointsCount);
		}

		private static List<City> GeneratePoints(int canvasWidth, int canvasHeight, int count)
		{
			var random = new Random();
			var points = new List<City>();

			for (int i = 0; i < count; i++)
			{
				points.Add(new City(random.Next(20, canvasWidth - 20), random.Next(20, canvasHeight - 20)));
			}

			return points;
		}
	}
}