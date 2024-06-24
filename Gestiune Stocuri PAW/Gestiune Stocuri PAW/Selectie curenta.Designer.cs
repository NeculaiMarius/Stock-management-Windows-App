namespace Gestiune_Stocuri_PAW
{
	partial class Selectie_curenta
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblSelectie = new System.Windows.Forms.Label();
			this.tbSelectie = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// lblSelectie
			// 
			this.lblSelectie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectie.AutoSize = true;
			this.lblSelectie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectie.Location = new System.Drawing.Point(0, 0);
			this.lblSelectie.Name = "lblSelectie";
			this.lblSelectie.Size = new System.Drawing.Size(175, 28);
			this.lblSelectie.TabIndex = 0;
			this.lblSelectie.Text = "Selectia curenta: ";
			// 
			// tbSelectie
			// 
			this.tbSelectie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSelectie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSelectie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSelectie.Location = new System.Drawing.Point(181, 0);
			this.tbSelectie.Name = "tbSelectie";
			this.tbSelectie.ReadOnly = true;
			this.tbSelectie.Size = new System.Drawing.Size(986, 34);
			this.tbSelectie.TabIndex = 1;
			this.tbSelectie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Selectie_curenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbSelectie);
			this.Controls.Add(this.lblSelectie);
			this.Name = "Selectie_curenta";
			this.Size = new System.Drawing.Size(1167, 35);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSelectie;
		private System.Windows.Forms.TextBox tbSelectie;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}
