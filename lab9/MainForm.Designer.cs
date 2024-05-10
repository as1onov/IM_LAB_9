namespace Lab8._3.EventsGeneration
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainPanel = new System.Windows.Forms.Panel();
			this.probPanel = new System.Windows.Forms.Panel();
			this.edProb4 = new System.Windows.Forms.NumericUpDown();
			this.edProb1 = new System.Windows.Forms.NumericUpDown();
			this.probLabel1 = new System.Windows.Forms.Label();
			this.edProb2 = new System.Windows.Forms.NumericUpDown();
			this.autoLabel = new System.Windows.Forms.Label();
			this.probLabel2 = new System.Windows.Forms.Label();
			this.probLabel5 = new System.Windows.Forms.Label();
			this.edProb3 = new System.Windows.Forms.NumericUpDown();
			this.probLabel4 = new System.Windows.Forms.Label();
			this.probLabel3 = new System.Windows.Forms.Label();
			this.startBtn = new System.Windows.Forms.Button();
			this.edTrials = new System.Windows.Forms.NumericUpDown();
			this.trialsLabel = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.probPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.edProb4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edProb1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edProb2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edProb3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edTrials)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.SkyBlue;
			this.mainPanel.Controls.Add(this.probPanel);
			this.mainPanel.Controls.Add(this.startBtn);
			this.mainPanel.Controls.Add(this.edTrials);
			this.mainPanel.Controls.Add(this.trialsLabel);
			this.mainPanel.Location = new System.Drawing.Point(12, 12);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(498, 492);
			this.mainPanel.TabIndex = 0;
			// 
			// probPanel
			// 
			this.probPanel.Controls.Add(this.edProb4);
			this.probPanel.Controls.Add(this.edProb1);
			this.probPanel.Controls.Add(this.probLabel1);
			this.probPanel.Controls.Add(this.edProb2);
			this.probPanel.Controls.Add(this.autoLabel);
			this.probPanel.Controls.Add(this.probLabel2);
			this.probPanel.Controls.Add(this.probLabel5);
			this.probPanel.Controls.Add(this.edProb3);
			this.probPanel.Controls.Add(this.probLabel4);
			this.probPanel.Controls.Add(this.probLabel3);
			this.probPanel.Location = new System.Drawing.Point(33, 12);
			this.probPanel.Name = "probPanel";
			this.probPanel.Size = new System.Drawing.Size(311, 286);
			this.probPanel.TabIndex = 14;
			// 
			// edProb4
			// 
			this.edProb4.DecimalPlaces = 2;
			this.edProb4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.edProb4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.edProb4.Location = new System.Drawing.Point(116, 180);
			this.edProb4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.edProb4.Name = "edProb4";
			this.edProb4.Size = new System.Drawing.Size(134, 33);
			this.edProb4.TabIndex = 6;
			// 
			// edProb1
			// 
			this.edProb1.DecimalPlaces = 2;
			this.edProb1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.edProb1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.edProb1.Location = new System.Drawing.Point(116, 11);
			this.edProb1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.edProb1.Name = "edProb1";
			this.edProb1.Size = new System.Drawing.Size(134, 33);
			this.edProb1.TabIndex = 0;
			// 
			// probLabel1
			// 
			this.probLabel1.AutoSize = true;
			this.probLabel1.BackColor = System.Drawing.Color.Transparent;
			this.probLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.probLabel1.Location = new System.Drawing.Point(13, 11);
			this.probLabel1.Name = "probLabel1";
			this.probLabel1.Size = new System.Drawing.Size(105, 32);
			this.probLabel1.TabIndex = 1;
			this.probLabel1.Text = "Prob 1:";
			// 
			// edProb2
			// 
			this.edProb2.DecimalPlaces = 2;
			this.edProb2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.edProb2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.edProb2.Location = new System.Drawing.Point(116, 68);
			this.edProb2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.edProb2.Name = "edProb2";
			this.edProb2.Size = new System.Drawing.Size(134, 33);
			this.edProb2.TabIndex = 2;
			// 
			// autoLabel
			// 
			this.autoLabel.AutoSize = true;
			this.autoLabel.BackColor = System.Drawing.Color.Silver;
			this.autoLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.autoLabel.Location = new System.Drawing.Point(126, 237);
			this.autoLabel.Name = "autoLabel";
			this.autoLabel.Size = new System.Drawing.Size(77, 33);
			this.autoLabel.TabIndex = 10;
			this.autoLabel.Text = "Auto";
			this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// probLabel2
			// 
			this.probLabel2.AutoSize = true;
			this.probLabel2.BackColor = System.Drawing.Color.Transparent;
			this.probLabel2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.probLabel2.Location = new System.Drawing.Point(13, 69);
			this.probLabel2.Name = "probLabel2";
			this.probLabel2.Size = new System.Drawing.Size(105, 32);
			this.probLabel2.TabIndex = 3;
			this.probLabel2.Text = "Prob 2:";
			// 
			// probLabel5
			// 
			this.probLabel5.AutoSize = true;
			this.probLabel5.BackColor = System.Drawing.Color.Transparent;
			this.probLabel5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.probLabel5.Location = new System.Drawing.Point(13, 237);
			this.probLabel5.Name = "probLabel5";
			this.probLabel5.Size = new System.Drawing.Size(105, 32);
			this.probLabel5.TabIndex = 9;
			this.probLabel5.Text = "Prob 5:";
			// 
			// edProb3
			// 
			this.edProb3.DecimalPlaces = 2;
			this.edProb3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.edProb3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.edProb3.Location = new System.Drawing.Point(116, 125);
			this.edProb3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.edProb3.Name = "edProb3";
			this.edProb3.Size = new System.Drawing.Size(134, 33);
			this.edProb3.TabIndex = 4;
			// 
			// probLabel4
			// 
			this.probLabel4.AutoSize = true;
			this.probLabel4.BackColor = System.Drawing.Color.Transparent;
			this.probLabel4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.probLabel4.Location = new System.Drawing.Point(13, 180);
			this.probLabel4.Name = "probLabel4";
			this.probLabel4.Size = new System.Drawing.Size(105, 32);
			this.probLabel4.TabIndex = 7;
			this.probLabel4.Text = "Prob 4:";
			// 
			// probLabel3
			// 
			this.probLabel3.AutoSize = true;
			this.probLabel3.BackColor = System.Drawing.Color.Transparent;
			this.probLabel3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.probLabel3.Location = new System.Drawing.Point(13, 125);
			this.probLabel3.Name = "probLabel3";
			this.probLabel3.Size = new System.Drawing.Size(105, 32);
			this.probLabel3.TabIndex = 5;
			this.probLabel3.Text = "Prob 3:";
			// 
			// startBtn
			// 
			this.startBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.startBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.startBtn.Location = new System.Drawing.Point(158, 429);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(164, 51);
			this.startBtn.TabIndex = 13;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = false;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// edTrials
			// 
			this.edTrials.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.edTrials.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.edTrials.Location = new System.Drawing.Point(251, 338);
			this.edTrials.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.edTrials.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.edTrials.Name = "edTrials";
			this.edTrials.Size = new System.Drawing.Size(134, 33);
			this.edTrials.TabIndex = 12;
			this.edTrials.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// trialsLabel
			// 
			this.trialsLabel.AutoSize = true;
			this.trialsLabel.BackColor = System.Drawing.Color.Transparent;
			this.trialsLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.trialsLabel.Location = new System.Drawing.Point(27, 339);
			this.trialsLabel.Name = "trialsLabel";
			this.trialsLabel.Size = new System.Drawing.Size(218, 32);
			this.trialsLabel.TabIndex = 11;
			this.trialsLabel.Text = "Number of trials:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 516);
			this.Controls.Add(this.mainPanel);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.probPanel.ResumeLayout(false);
			this.probPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.edProb4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edProb1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edProb2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edProb3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edTrials)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.NumericUpDown edProb1;
		private System.Windows.Forms.Label probLabel1;
		private System.Windows.Forms.Label probLabel5;
		private System.Windows.Forms.Label probLabel4;
		private System.Windows.Forms.NumericUpDown edProb4;
		private System.Windows.Forms.Label probLabel3;
		private System.Windows.Forms.NumericUpDown edProb3;
		private System.Windows.Forms.Label probLabel2;
		private System.Windows.Forms.NumericUpDown edProb2;
		private System.Windows.Forms.Label autoLabel;
		private System.Windows.Forms.Label trialsLabel;
		private System.Windows.Forms.NumericUpDown edTrials;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Panel probPanel;
	}
}

