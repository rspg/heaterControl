using System;
using System.Collections.Generic;
using System.Text;

namespace heaterControlGui
{
	class Target
	{
		public double Temperature { get; private set; }
		public double TemperatureReal { get => temperatureImmediate; }
		public double Power { get => power; set { power = Math.Min(Math.Max(value, 0.0), 1.0); } }

		double temperatureImmediate;
		double remainT = 0.0;
		double power = 0;

		const double AmbientTemperature = 20.0;
		const double WaterWeight = 1000.0;
		const double R = 22.0;
		const double Dissipation = 0.0005;	// 放熱
		const double Conductivity = 0.01f;	// 伝達遅延

		public Target()
		{
			Temperature = AmbientTemperature;
			temperatureImmediate = AmbientTemperature;
		}

		public void Step(double t)
		{
			double stepT = 100 * Math.Pow(1000, -2);

			t += remainT;
			while(t >= stepT)
			{
				temperatureImmediate += Math.Pow(100.0, 2.0) * stepT * Power / (R * WaterWeight * 4.2);
				temperatureImmediate += (AmbientTemperature - temperatureImmediate) * Dissipation * stepT;

				Temperature += (temperatureImmediate - Temperature) * Conductivity * stepT;
				t -= stepT;
			}
			remainT = t;
		}

		public void Disturbance(double temperature)
		{
			temperatureImmediate = temperature;
		}
	}
}
