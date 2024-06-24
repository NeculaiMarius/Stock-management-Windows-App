namespace Gestiune_Stocuri_PAW
{
	partial class Meniu
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
			this.components = new System.ComponentModel.Container();
			this.btnProduse = new System.Windows.Forms.Button();
			this.btnClienti = new System.Windows.Forms.Button();
			this.btnComenzi = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imagine3 = new System.Windows.Forms.PictureBox();
			this.imagine2 = new System.Windows.Forms.PictureBox();
			this.imagine1 = new System.Windows.Forms.PictureBox();
			this.lblMeniu = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imagine3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagine2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagine1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnProduse
			// 
			this.btnProduse.Location = new System.Drawing.Point(76, 357);
			this.btnProduse.Name = "btnProduse";
			this.btnProduse.Size = new System.Drawing.Size(178, 41);
			this.btnProduse.TabIndex = 0;
			this.btnProduse.Text = "Produse";
			this.btnProduse.UseVisualStyleBackColor = true;
			this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
			// 
			// btnClienti
			// 
			this.btnClienti.Location = new System.Drawing.Point(297, 357);
			this.btnClienti.Name = "btnClienti";
			this.btnClienti.Size = new System.Drawing.Size(182, 41);
			this.btnClienti.TabIndex = 1;
			this.btnClienti.Text = "Clienti";
			this.btnClienti.UseVisualStyleBackColor = true;
			this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
			// 
			// btnComenzi
			// 
			this.btnComenzi.Location = new System.Drawing.Point(525, 357);
			this.btnComenzi.Name = "btnComenzi";
			this.btnComenzi.Size = new System.Drawing.Size(178, 41);
			this.btnComenzi.TabIndex = 2;
			this.btnComenzi.Text = "Comenzi";
			this.btnComenzi.UseVisualStyleBackColor = true;
			this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imagine3
			// 
			this.imagine3.Image = global::Gestiune_Stocuri_PAW.Properties.Resources.local_shipping_48dp_FILL0_wght400_GRAD0_opsz48;
			this.imagine3.Location = new System.Drawing.Point(525, 193);
			this.imagine3.Name = "imagine3";
			this.imagine3.Size = new System.Drawing.Size(178, 143);
			this.imagine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagine3.TabIndex = 5;
			this.imagine3.TabStop = false;
			this.imagine3.Click += new System.EventHandler(this.imagine3_Click);
			this.imagine3.MouseEnter += new System.EventHandler(this.imagine3_MouseEnter);
			this.imagine3.MouseLeave += new System.EventHandler(this.imagine3_MouseLeave);
			// 
			// imagine2
			// 
			this.imagine2.Image = global::Gestiune_Stocuri_PAW.Properties.Resources.manage_accounts_48dp_FILL0_wght400_GRAD0_opsz48;
			this.imagine2.Location = new System.Drawing.Point(301, 193);
			this.imagine2.Name = "imagine2";
			this.imagine2.Size = new System.Drawing.Size(178, 143);
			this.imagine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagine2.TabIndex = 4;
			this.imagine2.TabStop = false;
			this.imagine2.Click += new System.EventHandler(this.btnClienti_Click);
			this.imagine2.MouseEnter += new System.EventHandler(this.imagine2_MouseEnter);
			this.imagine2.MouseLeave += new System.EventHandler(this.imagine2_MouseLeave);
			// 
			// imagine1
			// 
			this.imagine1.Image = global::Gestiune_Stocuri_PAW.Properties.Resources.inventory_48dp_FILL0_wght400_GRAD0_opsz48;
			this.imagine1.Location = new System.Drawing.Point(76, 193);
			this.imagine1.Name = "imagine1";
			this.imagine1.Size = new System.Drawing.Size(178, 143);
			this.imagine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagine1.TabIndex = 3;
			this.imagine1.TabStop = false;
			this.imagine1.Click += new System.EventHandler(this.btnProduse_Click);
			this.imagine1.MouseEnter += new System.EventHandler(this.imagine1_MouseEnter);
			this.imagine1.MouseLeave += new System.EventHandler(this.imagine1_MouseLeave);
			// 
			// lblMeniu
			// 
			this.lblMeniu.AutoSize = true;
			this.lblMeniu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMeniu.ForeColor = System.Drawing.SystemColors.Menu;
			this.lblMeniu.Location = new System.Drawing.Point(255, 61);
			this.lblMeniu.Name = "lblMeniu";
			this.lblMeniu.Size = new System.Drawing.Size(273, 46);
			this.lblMeniu.TabIndex = 6;
			this.lblMeniu.Text = "Meniu principal";
			// 
			// Meniu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblMeniu);
			this.Controls.Add(this.imagine3);
			this.Controls.Add(this.imagine2);
			this.Controls.Add(this.imagine1);
			this.Controls.Add(this.btnComenzi);
			this.Controls.Add(this.btnClienti);
			this.Controls.Add(this.btnProduse);
			this.KeyPreview = true;
			this.Name = "Meniu";
			this.Text = "Meniu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Meniu_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Meniu_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.imagine3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagine2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagine1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProduse;
		private System.Windows.Forms.Button btnClienti;
		private System.Windows.Forms.Button btnComenzi;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox imagine1;
		private System.Windows.Forms.PictureBox imagine2;
		private System.Windows.Forms.PictureBox imagine3;
		private System.Windows.Forms.Label lblMeniu;
	}
}