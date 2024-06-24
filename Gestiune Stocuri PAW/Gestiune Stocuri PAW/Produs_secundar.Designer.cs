namespace Gestiune_Stocuri_PAW
{
	partial class Produs_secundar
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
			this.tbPret = new System.Windows.Forms.TextBox();
			this.tbCantitate = new System.Windows.Forms.TextBox();
			this.cbUM = new System.Windows.Forms.ComboBox();
			this.cbCategorie = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbNume = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// tbPret
			// 
			this.tbPret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPret.Location = new System.Drawing.Point(302, 318);
			this.tbPret.Name = "tbPret";
			this.tbPret.Size = new System.Drawing.Size(329, 34);
			this.tbPret.TabIndex = 19;
			// 
			// tbCantitate
			// 
			this.tbCantitate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCantitate.Location = new System.Drawing.Point(301, 230);
			this.tbCantitate.Name = "tbCantitate";
			this.tbCantitate.Size = new System.Drawing.Size(330, 34);
			this.tbCantitate.TabIndex = 18;
			// 
			// cbUM
			// 
			this.cbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUM.FormattingEnabled = true;
			this.cbUM.Items.AddRange(new object[] {
            "kilogram",
            "litru",
            "metru",
            "bucata"});
			this.cbUM.Location = new System.Drawing.Point(301, 272);
			this.cbUM.Name = "cbUM";
			this.cbUM.Size = new System.Drawing.Size(330, 36);
			this.cbUM.TabIndex = 17;
			// 
			// cbCategorie
			// 
			this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategorie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCategorie.FormattingEnabled = true;
			this.cbCategorie.Items.AddRange(new object[] {
            "Electronice si electrocasnice",
            "Mobilier si decoratiuni interioare",
            "Produse alimentare si bauturi",
            "Imbracaminte si accesorii vestimentare",
            "Unelte si echipamente pentru casa si gradina",
            "Articole de ingrijire personala si cosmetice",
            "Jucarii si articole pentru copii",
            "Echipamente sportive si de agrement",
            "Produse pentru animale de companie",
            "Articole de papetarie si birotica"});
			this.cbCategorie.Location = new System.Drawing.Point(301, 176);
			this.cbCategorie.Name = "cbCategorie";
			this.cbCategorie.Size = new System.Drawing.Size(330, 36);
			this.cbCategorie.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(162, 321);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 28);
			this.label5.TabIndex = 15;
			this.label5.Text = "Pret/UM";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(102, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(187, 28);
			this.label4.TabIndex = 14;
			this.label4.Text = "Unitate de Masura";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(159, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 28);
			this.label3.TabIndex = 13;
			this.label3.Text = "Cantitate";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(152, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 28);
			this.label2.TabIndex = 12;
			this.label2.Text = "Categorie";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(124, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 28);
			this.label1.TabIndex = 11;
			this.label1.Text = "Nume material";
			// 
			// tbNume
			// 
			this.tbNume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNume.Location = new System.Drawing.Point(301, 134);
			this.tbNume.Name = "tbNume";
			this.tbNume.Size = new System.Drawing.Size(330, 34);
			this.tbNume.TabIndex = 10;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Crimson;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(407, 395);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(179, 43);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Anulare";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.SlateBlue;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(592, 395);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(179, 43);
			this.btnOk.TabIndex = 20;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(205, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(436, 41);
			this.label6.TabIndex = 22;
			this.label6.Text = "Formular de adaugare produs";
			// 
			// Produs_secundar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tbPret);
			this.Controls.Add(this.tbCantitate);
			this.Controls.Add(this.cbUM);
			this.Controls.Add(this.cbCategorie);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNume);
			this.Name = "Produs_secundar";
			this.Text = "Produs_secundar";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPret;
		private System.Windows.Forms.TextBox tbCantitate;
		private System.Windows.Forms.ComboBox cbUM;
		private System.Windows.Forms.ComboBox cbCategorie;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNume;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Label label6;
	}
}