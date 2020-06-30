using System;
using System.Collections.Generic;

namespace Simulated_annealing
{
	internal class SimulatedAnnealing
	{
		private readonly IReadOnlyList<City> _cities;
		private readonly int _iter;

		private static Random _random;

		public SimulatedAnnealing(IReadOnlyList<City> cities, int iter)
		{
			_cities = cities;
			_iter = iter;

			_random = new Random();
		}

		public List<int> PerformSimulatedAnnealing(double initialTemperature = 10000, double endTemperature = 0.001)
		{
			var state = new List<int>();

			for (int i = 0; i < _cities.Count; i++)
			{
				state.Add(i);
			}

			for (int i = 1; i < _cities.Count; i++)
			{
				int rnd1 = _random.Next(1, _cities.Count);
				int rnd2 = _random.Next(1, _cities.Count);

				int temp = state[rnd1];
				state[rnd1] = state[rnd2];
				state[rnd2] = temp;
			}

			double currentEnergy = CalculateEnergy(state);
			double T = initialTemperature;

			for (int i = 0; i < _iter; i++)
			{
				var stateCandidate = GenerateStateCandidate(state);
				double candidateEnergy = CalculateEnergy(stateCandidate);

				if (candidateEnergy + 0.000002 < currentEnergy)
				{
					Console.WriteLine($"{candidateEnergy} was less than {currentEnergy} at {i} iterration");
					currentEnergy = candidateEnergy;
					state = stateCandidate;
				}
				else
				{
					double p = GetTransitionProbability(candidateEnergy - currentEnergy, T);
					
					if (CanMakeTransit(p))
					{
						currentEnergy = candidateEnergy;
						state = stateCandidate;
					}
				}

				T = DecreaseTemperature(initialTemperature, i);

				if (T <= endTemperature)
				{
					break;
				}
			}

			return state;
		}

		private double CalculateEnergy(IReadOnlyList<int> sequence)
		{
			int n = sequence.Count;
			double e = 0;
			for (int i = 0; i < n - 1; i++)
			{
				e += GetMetric(_cities[sequence[i + 1]], _cities[sequence[i]]);
			}

			e += GetMetric(_cities[sequence[n - 1]], _cities[sequence[0]]);

			return e;
		}

		private static double GetMetric(City a, City b)
		{
			return Math.Sqrt(Math.Pow(a.From - b.From, 2) + Math.Pow(a.To - b.To, 2));
		}

		private static List<int> GenerateStateCandidate(List<int> sequence)
		{
			int i = _random.Next(1, sequence.Count);
			int j = _random.Next(1, sequence.Count);

			while (j == i)
			{
				j = _random.Next(1, sequence.Count);
			}

			if (i > j)
            {
                Swap(ref i, ref j);
            }

            var temp = sequence.ToArray();
			Array.Reverse(temp, i, j - i + 1);

			return new List<int>(temp);
		}

        private static void Swap(ref int i, ref int j)
        {
            int a = j;
            j = i;
            i = a;
        }

        private static double GetTransitionProbability(double e, double T)
		{
			return Math.Exp(-e / T);
		}

		private static bool CanMakeTransit(double probability)
		{
			return _random.NextDouble() <= probability;
		}

		private static double DecreaseTemperature(double initialTemperature, int i)
		{
			return initialTemperature * 0.1 / i;
		}
	}
}