namespace Lab8._3.EventsGeneration
{
	partial class ChartForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartPanel = new System.Windows.Forms.Panel();
			this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.aveLabel = new System.Windows.Forms.Label();
			this.varLabel = new System.Windows.Forms.Label();
			this.chiLabel = new System.Windows.Forms.Label();
			this.chartPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
			this.SuspendLayout();
			// 
			// chartPanel
			// 
			this.chartPanel.BackColor = System.Drawing.Color.SkyBlue;
			this.chartPanel.Controls.Add(this.chiLabel);
			this.chartPanel.Controls.Add(this.varLabel);
			this.chartPanel.Controls.Add(this.aveLabel);
			this.chartPanel.Controls.Add(this.mainChart);
			this.chartPanel.Location = new System.Drawing.Point(12, 12);
			this.chartPanel.Name = "chartPanel";
			this.chartPanel.Size = new System.Drawing.Size(891, 591);
			this.chartPanel.TabIndex = 0;
			// 
			// mainChart
			// 
			chartArea2.AxisX.Maximum = 6D;
			chartArea2.AxisY.Maximum = 1D;
			chartArea2.Name = "ChartArea1";
			this.mainChart.ChartAreas.Add(chartArea2);
			this.mainChart.Location = new System.Drawing.Point(15, 13);
			this.mainChart.Name = "mainChart";
			series2.ChartArea = "ChartArea1";
			series2.Name = "Series1";
			this.mainChart.Series.Add(series2);
			this.mainChart.Size = new System.Drawing.Size(859, 417);
			this.mainChart.TabIndex = 0;
			this.mainChart.Text = "chart1";
			// 
			// aveLabel
			// 
			this.aveLabel.AutoSize = true;
			this.aveLabel.BackColor = System.Drawing.Color.Transparent;
			this.aveLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.aveLabel.Location = new System.Drawing.Point(9, 449);
			this.aveLabel.Name = "aveLabel";
			this.aveLabel.Size = new System.Drawing.Size(88, 32);
			this.aveLabel.TabIndex = 1;
			this.aveLabel.Text = "label1";
			// 
			// varLabel
			// 
			this.varLabel.AutoSize = true;
			this.varLabel.BackColor = System.Drawing.Color.Transparent;
			this.varLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.varLabel.Location = new System.Drawing.Point(9, 499);
			this.varLabel.Name = "varLabel";
			this.varLabel.Size = new System.Drawing.Size(88, 32);
			this.varLabel.TabIndex = 2;
			this.varLabel.Text = "label1";
			// 
			// chiLabel
			// 
			this.chiLabel.AutoSize = true;
			this.chiLabel.BackColor = System.Drawing.Color.Transparent;
			this.chiLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chiLabel.Location = new System.Drawing.Point(9, 548);
			this.chiLabel.Name = "chiLabel";
			this.chiLabel.Size = new System.Drawing.Size(88, 32);
			this.chiLabel.TabIndex = 3;
			this.chiLabel.Text = "label1";
			// 
			// ChartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 615);
			this.Controls.Add(this.chartPanel);
			this.Name = "ChartForm";
			this.Text = "ChartForm";
			this.chartPanel.ResumeLayout(false);
			this.chartPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel chartPanel;
		private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
		private System.Windows.Forms.Label chiLabel;
		private System.Windows.Forms.Label varLabel;
		private System.Windows.Forms.Label aveLabel;
	}
}