using Lab9.EventsGeneration.Models;
using System;
using System.Windows.Forms;

namespace Lab8._3.EventsGeneration
{
	public partial class ChartForm : Form
	{
		private const double _probCriticalValue = 9.488;
		
		private int[] _statistics;
		private double[] _frequencies;
		private decimal[] _probabilities;
		private int _trialsCount;

        public ChartForm(int[] statistics, double[] frequencies, decimal[] probabilities, int trialsCount)
        {
			InitializeComponent();

			_statistics = statistics;
			_frequencies = frequencies;
			_probabilities = probabilities;
			_trialsCount = trialsCount;

			for (var i = 1; i <= _frequencies.Length; i++)
			{
				mainChart.Series[0].Points.AddXY(i, _frequencies[i - 1]);
			}

			var average = CalculateAverageAndError();
			var variance = CalculateVarianceAndError(average.Value, average.EmpValue);
			var chiSquared = CalculateChiSquared();

			aveLabel.Text = $"Average: {Math.Round(average.Value, 2)} (error = {Math.Round(average.Error, 2)}%)";
			varLabel.Text = $"Variance: {Math.Round(variance.Value, 2)} (error = {Math.Round(variance.Error, 2)}%)";

			var sign = chiSquared > _probCriticalValue ? ">" : "<";
			chiLabel.Text = $"Chi-squared: {Math.Round(chiSquared, 4)} {sign} {_probCriticalValue}";
		}

		private Characteristic CalculateAverageAndError()
		{
			var average = 0d;
			var empAverage = 0d;

			for (var i = 0; i < _frequencies.Length; i++)
			{
				average += (double)_probabilities[i] * (i + 1);
				empAverage += _frequencies[i] * (i + 1);
			}

			var error = Math.Abs(empAverage - average);
			error = (error / average) * 100;

			return new Characteristic
			{
				Value = average,
				EmpValue = empAverage,
				Error = error
			};
		}

		private Characteristic CalculateVarianceAndError(double average, double empAverage)
		{
			var variance = 0d;
			var empVariance = 0d;

			for (var i = 0; i < _frequencies.Length; i++)
			{
				variance += (double)_probabilities[i] * Math.Pow(i + 1, 2);
				empVariance += _frequencies[i] * Math.Pow(i + 1, 2);
			}
			variance -= Math.Pow(average, 2);
			empVariance -= Math.Pow(empAverage, 2);

			var error = Math.Abs(empVariance - variance);
			error = (error / variance) * 100;

			return new Characteristic
			{
				Value = variance,
				EmpValue = empVariance,
				Error = error
			};
		}

		private double CalculateChiSquared()
		{
			var chiSquared = 0d;

			for (var i = 0; i < _statistics.Length; i++)
			{
				chiSquared += (_statistics[i] * _statistics[i]) / (_trialsCount * (double)_probabilities[i]);
			}
			chiSquared -= _trialsCount;

			return chiSquared;
		}
    }
}
