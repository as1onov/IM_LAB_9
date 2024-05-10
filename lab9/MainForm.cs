using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab8._3.EventsGeneration
{
	public partial class MainForm : Form
	{
		private int[] _statistics = new int[5];
		private decimal[] _probabilities = new decimal[5];
		
		public MainForm()
		{
			InitializeComponent();
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			var trialsCount = int.Parse(edTrials.Text);

			Array.Clear(_statistics, 0, _statistics.Length);

			GetProbabilities();

			GenerateTrials(trialsCount);

			var frequencies = _statistics.Select(x => (double)x / trialsCount).ToArray();
			var form = new ChartForm(_statistics, frequencies, _probabilities, trialsCount);
			form.Show();
		}

		private void GetProbabilities()
		{
			_probabilities[0] = edProb1.Value;
			_probabilities[1] = edProb2.Value;
			_probabilities[2] = edProb3.Value;
			_probabilities[3] = edProb4.Value;

			var sum = _probabilities.Take(4).Sum();
			if (sum > 1)
				throw new Exception("Сумма вероятностей не должна превышать 1");

			_probabilities[4] = 1 - sum;
		}

		private void GenerateTrials(int trialsCount)
		{
			var rnd = new Random();
			for (var i = 0; i < trialsCount; i++)
			{
				var value = rnd.NextDouble();
				for (var j = 0; j < _probabilities.Length; j++)
				{
					value = value - (double)_probabilities[j];
					if (value <= 0)
					{
						_statistics[j]++;
						break;
					}
				}
			}
		}
	}
}
