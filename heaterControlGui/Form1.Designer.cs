namespace heaterControlGui
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ErrorIntegrationCheck = new System.Windows.Forms.CheckBox();
			this.Clear = new System.Windows.Forms.Button();
			this.Simulate = new System.Windows.Forms.Button();
			this.RsInput = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.TiInput = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.KpInput = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.TargetTemperatureInput = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.DurationInput = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RsInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TiInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KpInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TargetTemperatureInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DurationInput)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.chart1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.DurationInput);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.ErrorIntegrationCheck);
			this.splitContainer1.Panel2.Controls.Add(this.Clear);
			this.splitContainer1.Panel2.Controls.Add(this.Simulate);
			this.splitContainer1.Panel2.Controls.Add(this.RsInput);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.TiInput);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.KpInput);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.TargetTemperatureInput);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(1474, 841);
			this.splitContainer1.SplitterDistance = 600;
			this.splitContainer1.TabIndex = 1;
			// 
			// chart1
			// 
			chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
			chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(1474, 600);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// ErrorIntegrationCheck
			// 
			this.ErrorIntegrationCheck.AutoSize = true;
			this.ErrorIntegrationCheck.Checked = true;
			this.ErrorIntegrationCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ErrorIntegrationCheck.Location = new System.Drawing.Point(341, 37);
			this.ErrorIntegrationCheck.Name = "ErrorIntegrationCheck";
			this.ErrorIntegrationCheck.Size = new System.Drawing.Size(107, 16);
			this.ErrorIntegrationCheck.TabIndex = 10;
			this.ErrorIntegrationCheck.Text = "Error Integration";
			this.ErrorIntegrationCheck.UseVisualStyleBackColor = true;
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(287, 193);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(234, 23);
			this.Clear.TabIndex = 9;
			this.Clear.Text = "Clear";
			this.Clear.UseVisualStyleBackColor = true;
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// Simulate
			// 
			this.Simulate.Location = new System.Drawing.Point(47, 193);
			this.Simulate.Name = "Simulate";
			this.Simulate.Size = new System.Drawing.Size(234, 23);
			this.Simulate.TabIndex = 8;
			this.Simulate.Text = "Simulate";
			this.Simulate.UseVisualStyleBackColor = true;
			this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
			// 
			// RsInput
			// 
			this.RsInput.Enabled = false;
			this.RsInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.RsInput.Location = new System.Drawing.Point(153, 111);
			this.RsInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.RsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.RsInput.Name = "RsInput";
			this.RsInput.Size = new System.Drawing.Size(120, 19);
			this.RsInput.TabIndex = 7;
			this.RsInput.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "Rs";
			// 
			// TiInput
			// 
			this.TiInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.TiInput.Location = new System.Drawing.Point(153, 86);
			this.TiInput.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.TiInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.TiInput.Name = "TiInput";
			this.TiInput.Size = new System.Drawing.Size(120, 19);
			this.TiInput.TabIndex = 5;
			this.TiInput.Value = new decimal(new int[] {
            5500,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ti";
			// 
			// KpInput
			// 
			this.KpInput.DecimalPlaces = 4;
			this.KpInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.KpInput.Location = new System.Drawing.Point(153, 61);
			this.KpInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.KpInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.KpInput.Name = "KpInput";
			this.KpInput.Size = new System.Drawing.Size(120, 19);
			this.KpInput.TabIndex = 3;
			this.KpInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kp";
			// 
			// TargetTemperatureInput
			// 
			this.TargetTemperatureInput.Location = new System.Drawing.Point(153, 35);
			this.TargetTemperatureInput.Name = "TargetTemperatureInput";
			this.TargetTemperatureInput.Size = new System.Drawing.Size(120, 19);
			this.TargetTemperatureInput.TabIndex = 1;
			this.TargetTemperatureInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "TargetTemperature";
			// 
			// DurationInput
			// 
			this.DurationInput.Location = new System.Drawing.Point(650, 37);
			this.DurationInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.DurationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DurationInput.Name = "DurationInput";
			this.DurationInput.Size = new System.Drawing.Size(120, 19);
			this.DurationInput.TabIndex = 12;
			this.DurationInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(542, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "Duration";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1474, 841);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RsInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TiInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KpInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TargetTemperatureInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DurationInput)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.NumericUpDown TargetTemperatureInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown KpInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown RsInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown TiInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Simulate;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.CheckBox ErrorIntegrationCheck;
		private System.Windows.Forms.NumericUpDown DurationInput;
		private System.Windows.Forms.Label label5;
	}
}

