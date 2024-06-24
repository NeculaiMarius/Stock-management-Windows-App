namespace Gestiune_Stocuri_PAW
{
	partial class Grafic
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.graficComenzi = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.graficComenzi)).BeginInit();
			this.SuspendLayout();
			// 
			// graficComenzi
			// 
			this.graficComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.graficComenzi.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.graficComenzi.Legends.Add(legend1);
			this.graficComenzi.Location = new System.Drawing.Point(12, 12);
			this.graficComenzi.Name = "graficComenzi";
			this.graficComenzi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Comenzi";
			this.graficComenzi.Series.Add(series1);
			this.graficComenzi.Size = new System.Drawing.Size(1038, 525);
			this.graficComenzi.TabIndex = 0;
			this.graficComenzi.Text = "chart1";
			// 
			// Grafic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 549);
			this.Controls.Add(this.graficComenzi);
			this.Name = "Grafic";
			this.Text = "Grafic";
			this.Load += new System.EventHandler(this.Grafic_Load);
			((System.ComponentModel.ISupportInitialize)(this.graficComenzi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart graficComenzi;
	}
}