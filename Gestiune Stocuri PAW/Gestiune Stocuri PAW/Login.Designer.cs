using System.Drawing;
using System;
using System.Windows.Forms;

namespace Gestiune_Stocuri_PAW
{
	partial class Login
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
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.labelUsername = new System.Windows.Forms.Label();
			this.labelParola = new System.Windows.Forms.Label();
			this.btnSterge = new System.Windows.Forms.Button();
			this.btnAutentificare = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbUsername
			// 
			this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.Location = new System.Drawing.Point(84, 62);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(307, 34);
			this.tbUsername.TabIndex = 0;
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(84, 146);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(307, 34);
			this.tbPassword.TabIndex = 1;
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsername.Location = new System.Drawing.Point(97, 31);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(162, 28);
			this.labelUsername.TabIndex = 2;
			this.labelUsername.Text = "Nume utilizator";
			// 
			// labelParola
			// 
			this.labelParola.AutoSize = true;
			this.labelParola.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelParola.Location = new System.Drawing.Point(97, 115);
			this.labelParola.Name = "labelParola";
			this.labelParola.Size = new System.Drawing.Size(72, 28);
			this.labelParola.TabIndex = 3;
			this.labelParola.Text = "Parola";
			// 
			// btnSterge
			// 
			this.btnSterge.BackColor = System.Drawing.Color.Crimson;
			this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSterge.ForeColor = System.Drawing.Color.White;
			this.btnSterge.Location = new System.Drawing.Point(38, 205);
			this.btnSterge.Name = "btnSterge";
			this.btnSterge.Size = new System.Drawing.Size(169, 45);
			this.btnSterge.TabIndex = 4;
			this.btnSterge.Text = "Sterge";
			this.btnSterge.UseVisualStyleBackColor = false;
			this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
			this.btnSterge.MouseEnter += new System.EventHandler(this.btn_MouseEnter_Sterge);
			this.btnSterge.MouseLeave += new System.EventHandler(this.btn_MouseLeave_Sterge);
			// 
			// btnAutentificare
			// 
			this.btnAutentificare.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnAutentificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAutentificare.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAutentificare.ForeColor = System.Drawing.Color.White;
			this.btnAutentificare.Location = new System.Drawing.Point(272, 206);
			this.btnAutentificare.Name = "btnAutentificare";
			this.btnAutentificare.Size = new System.Drawing.Size(169, 44);
			this.btnAutentificare.TabIndex = 5;
			this.btnAutentificare.Text = "Autentificare";
			this.btnAutentificare.UseVisualStyleBackColor = false;
			this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
			this.btnAutentificare.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btnAutentificare.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(488, 275);
			this.Controls.Add(this.btnAutentificare);
			this.Controls.Add(this.btnSterge);
			this.Controls.Add(this.labelParola);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUsername);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void btn_MouseEnter(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			btn.BackColor = Color.DarkSlateBlue;
		}

		private void btn_MouseLeave(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			btn.BackColor = Color.MediumSlateBlue;
		}

		private void btn_MouseEnter_Sterge(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			btn.BackColor = Color.DarkRed;
		}

		private void btn_MouseLeave_Sterge(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			btn.BackColor = Color.Crimson;
		}



		#endregion

		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelParola;
		private System.Windows.Forms.Button btnSterge;
		private System.Windows.Forms.Button btnAutentificare;
	}
}

