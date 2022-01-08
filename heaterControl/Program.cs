using System;

namespace heaterControl
{
	class Program
	{
		static void Main(string[] args)
		{
			double stepT = 1;
			double targetTemperature = 60;
			//double preTemperature = 0;
			double integral = 0;
			double Kp = 0.2;
			double Ti = 500;
			//double Rs = 500;

			var target = new Target();

			for (double t = 0; t < 60000000; t += stepT)
			{
				target.Step(stepT);

				double e = targetTemperature - target.Temperature;
				//double v = target.Temperature - preTemperature;
				integral += e / Ti;
				//integral += (e - integral)/Ti;
				//integral += e / (1 + Math.Abs(v) * Rs);

				//preTemperature = target.Temperature;

				var p = Kp * e;
				var i = Kp * integral;
				target.Power = Kp * (e + integral);
				Console.WriteLine($"{t} {target.Temperature:F4}({target.TemperatureReal:F4}) {target.Power:F4}({p:F4} + {i / Ti:F4})");

				if (t == 5000)
					target.Disturbance(targetTemperature - 20);
			}
		}
	}
}
