using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace heaterControlGui
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Simulate_Click(object sender, EventArgs arg)
		{
			double stepT = 1;
			double targetTemperature = (double)TargetTemperatureInput.Value;
			//double preTemperature = 0;
			double integral = 0;
			double Kp = (double)KpInput.Value;
			double Ti = (double)TiInput.Value;
			double Duration =(double) DurationInput.Value;
			//double Rs = (double)RsInput.Value;
			bool errorIntegration = ErrorIntegrationCheck.Checked;

			var target = new Target();

			//chart1.Series.Clear();
			//var measurement = chart1.Series.Add("Measurement");
			//measurement.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			var real = chart1.Series.Add("Real" + chart1.Series.Count.ToString());
			real.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

			for (double t = 0; t < Duration; t += stepT)
			{
				target.Step(stepT);

				double e = targetTemperature - target.Temperature;
				//double v = target.Temperature - preTemperature;
				if (errorIntegration)
					integral += e / Ti;
				//else
				//	integral += e / (1 + Math.Abs(v) * Rs);

				//preTemperature = target.Temperature;

				var p = Kp * e;
				var i = Kp * integral;
				target.Power = p + i;
				Console.WriteLine($"{t} {target.Temperature:F4}({target.TemperatureReal:F4}) {target.Power:F4}({p:F4} + {i:F4})");

				//measurement.Points.AddXY(t, target.Temperature);
				real.Points.AddXY(t, target.TemperatureReal);

				//if (t == 5000)
				//	target.Disturbance(targetTemperature - 20);
			}

			/*
			var anno = new TextAnnotation();
			anno.Text = "Distubance";
			anno.AnchorDataPoint = real.Points[5000];
			chart1.Annotations.Add(anno);
			*/
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			chart1.Series.Clear();
		}
	}
}
