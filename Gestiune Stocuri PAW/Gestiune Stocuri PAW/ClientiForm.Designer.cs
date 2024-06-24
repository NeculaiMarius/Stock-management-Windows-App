using System.Windows.Forms;

namespace Gestiune_Stocuri_PAW
{
	partial class ClientiForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gvClienti = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gestiune_StocuriDataSet1 = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet1();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvarebinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restaurarebinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvarexmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restaurarexmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editeazaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stergeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientiTableAdapter = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet1TableAdapters.ClientiTableAdapter();
			this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnModifica = new System.Windows.Forms.Button();
			this.btnSterge = new System.Windows.Forms.Button();
			this.btnAdauga = new System.Windows.Forms.Button();
			this.labelCautare = new System.Windows.Forms.Label();
			this.tbCautare = new System.Windows.Forms.TextBox();
			this.selectie_curenta1 = new Gestiune_Stocuri_PAW.Selectie_curenta();
			((System.ComponentModel.ISupportInitialize)(this.gvClienti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gvClienti
			// 
			this.gvClienti.AllowUserToAddRows = false;
			this.gvClienti.AllowUserToDeleteRows = false;
			this.gvClienti.AllowUserToResizeRows = false;
			this.gvClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gvClienti.AutoGenerateColumns = false;
			this.gvClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvClienti.BackgroundColor = System.Drawing.Color.White;
			this.gvClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gvClienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvClienti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.gvClienti.ColumnHeadersHeight = 70;
			this.gvClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Adresa});
			this.gvClienti.DataSource = this.clientiBindingSource;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvClienti.DefaultCellStyle = dataGridViewCellStyle11;
			this.gvClienti.EnableHeadersVisualStyles = false;
			this.gvClienti.GridColor = System.Drawing.Color.LightGray;
			this.gvClienti.Location = new System.Drawing.Point(32, 129);
			this.gvClienti.Name = "gvClienti";
			this.gvClienti.ReadOnly = true;
			this.gvClienti.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gvClienti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gvClienti.RowHeadersVisible = false;
			this.gvClienti.RowHeadersWidth = 51;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gvClienti.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.gvClienti.RowTemplate.Height = 40;
			this.gvClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvClienti.Size = new System.Drawing.Size(1222, 471);
			this.gvClienti.TabIndex = 0;
			this.gvClienti.SelectionChanged += new System.EventHandler(this.gvClienti_SelectionChanged);
			this.gvClienti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvClienti_MouseDown);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenume";
			this.dataGridViewTextBoxColumn3.HeaderText = "Prenume";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
			this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// Adresa
			// 
			this.Adresa.DataPropertyName = "Adresa";
			this.Adresa.HeaderText = "Adresa";
			this.Adresa.MinimumWidth = 6;
			this.Adresa.Name = "Adresa";
			this.Adresa.ReadOnly = true;
			// 
			// clientiBindingSource
			// 
			this.clientiBindingSource.DataMember = "Clienti";
			this.clientiBindingSource.DataSource = this.gestiune_StocuriDataSet1;
			// 
			// gestiune_StocuriDataSet1
			// 
			this.gestiune_StocuriDataSet1.DataSetName = "Gestiune_StocuriDataSet1";
			this.gestiune_StocuriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.clientiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1286, 30);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fisierToolStripMenuItem
			// 
			this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarebinToolStripMenuItem,
            this.restaurarebinToolStripMenuItem,
            this.salvarexmlToolStripMenuItem,
            this.restaurarexmlToolStripMenuItem});
			this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
			this.fisierToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
			this.fisierToolStripMenuItem.Text = "Fisier";
			// 
			// salvarebinToolStripMenuItem
			// 
			this.salvarebinToolStripMenuItem.Name = "salvarebinToolStripMenuItem";
			this.salvarebinToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.salvarebinToolStripMenuItem.Text = "Salvare (bin)";
			this.salvarebinToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
			// 
			// restaurarebinToolStripMenuItem
			// 
			this.restaurarebinToolStripMenuItem.Name = "restaurarebinToolStripMenuItem";
			this.restaurarebinToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.restaurarebinToolStripMenuItem.Text = "Restaurare (bin)";
			this.restaurarebinToolStripMenuItem.Click += new System.EventHandler(this.restaurarebinToolStripMenuItem_Click);
			// 
			// salvarexmlToolStripMenuItem
			// 
			this.salvarexmlToolStripMenuItem.Name = "salvarexmlToolStripMenuItem";
			this.salvarexmlToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.salvarexmlToolStripMenuItem.Text = "Salvare (xml)";
			this.salvarexmlToolStripMenuItem.Click += new System.EventHandler(this.salvarexmlToolStripMenuItem_Click);
			// 
			// restaurarexmlToolStripMenuItem
			// 
			this.restaurarexmlToolStripMenuItem.Name = "restaurarexmlToolStripMenuItem";
			this.restaurarexmlToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.restaurarexmlToolStripMenuItem.Text = "Restaurare (xml)";
			this.restaurarexmlToolStripMenuItem.Click += new System.EventHandler(this.restaurarexmlToolStripMenuItem_Click);
			// 
			// clientiToolStripMenuItem
			// 
			this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem,
            this.editeazaClientToolStripMenuItem,
            this.stergeClientToolStripMenuItem});
			this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
			this.clientiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.clientiToolStripMenuItem.Text = "Clienti";
			// 
			// adaugaClientToolStripMenuItem
			// 
			this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
			this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
			this.adaugaClientToolStripMenuItem.Text = "Adauga client";
			this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
			// 
			// editeazaClientToolStripMenuItem
			// 
			this.editeazaClientToolStripMenuItem.Name = "editeazaClientToolStripMenuItem";
			this.editeazaClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
			this.editeazaClientToolStripMenuItem.Text = "Editeaza client";
			this.editeazaClientToolStripMenuItem.Click += new System.EventHandler(this.editeazaClientToolStripMenuItem_Click);
			// 
			// stergeClientToolStripMenuItem
			// 
			this.stergeClientToolStripMenuItem.Name = "stergeClientToolStripMenuItem";
			this.stergeClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
			this.stergeClientToolStripMenuItem.Text = "Sterge client";
			this.stergeClientToolStripMenuItem.Click += new System.EventHandler(this.stergeClientToolStripMenuItem_Click);
			// 
			// clientiTableAdapter
			// 
			this.clientiTableAdapter.ClearBeforeFill = true;
			// 
			// adresaDataGridViewTextBoxColumn
			// 
			this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
			this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
			this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
			this.adresaDataGridViewTextBoxColumn.Width = 125;
			// 
			// btnModifica
			// 
			this.btnModifica.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnModifica.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnModifica.FlatAppearance.BorderSize = 0;
			this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifica.ForeColor = System.Drawing.Color.White;
			this.btnModifica.Location = new System.Drawing.Point(754, 606);
			this.btnModifica.Name = "btnModifica";
			this.btnModifica.Size = new System.Drawing.Size(247, 68);
			this.btnModifica.TabIndex = 4;
			this.btnModifica.Text = "Editeaza client";
			this.btnModifica.UseVisualStyleBackColor = false;
			this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
			// 
			// btnSterge
			// 
			this.btnSterge.AllowDrop = true;
			this.btnSterge.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSterge.BackColor = System.Drawing.Color.Crimson;
			this.btnSterge.FlatAppearance.BorderSize = 0;
			this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSterge.ForeColor = System.Drawing.Color.White;
			this.btnSterge.Location = new System.Drawing.Point(1007, 606);
			this.btnSterge.Name = "btnSterge";
			this.btnSterge.Size = new System.Drawing.Size(247, 68);
			this.btnSterge.TabIndex = 3;
			this.btnSterge.Text = "Sterge client";
			this.btnSterge.UseVisualStyleBackColor = false;
			this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
			this.btnSterge.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnSterge_DragDrop);
			this.btnSterge.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnSterge_DragEnter);
			this.btnSterge.DragLeave += new System.EventHandler(this.btnSterge_DragLeave);
			// 
			// btnAdauga
			// 
			this.btnAdauga.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnAdauga.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnAdauga.FlatAppearance.BorderSize = 0;
			this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdauga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdauga.ForeColor = System.Drawing.Color.White;
			this.btnAdauga.Location = new System.Drawing.Point(32, 606);
			this.btnAdauga.Name = "btnAdauga";
			this.btnAdauga.Size = new System.Drawing.Size(247, 68);
			this.btnAdauga.TabIndex = 2;
			this.btnAdauga.Text = "Adauga client";
			this.btnAdauga.UseVisualStyleBackColor = false;
			this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
			// 
			// labelCautare
			// 
			this.labelCautare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCautare.AutoSize = true;
			this.labelCautare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCautare.Location = new System.Drawing.Point(27, 89);
			this.labelCautare.Name = "labelCautare";
			this.labelCautare.Size = new System.Drawing.Size(66, 28);
			this.labelCautare.TabIndex = 9;
			this.labelCautare.Text = "Cauta";
			this.labelCautare.TextChanged += new System.EventHandler(this.tbCautare_TextChanged);
			// 
			// tbCautare
			// 
			this.tbCautare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCautare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCautare.Location = new System.Drawing.Point(99, 89);
			this.tbCautare.Name = "tbCautare";
			this.tbCautare.Size = new System.Drawing.Size(1155, 34);
			this.tbCautare.TabIndex = 8;
			this.tbCautare.TextChanged += new System.EventHandler(this.tbCautare_TextChanged);
			// 
			// selectie_curenta1
			// 
			this.selectie_curenta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.selectie_curenta1.Location = new System.Drawing.Point(285, 621);
			this.selectie_curenta1.Name = "selectie_curenta1";
			this.selectie_curenta1.Size = new System.Drawing.Size(463, 35);
			this.selectie_curenta1.TabIndex = 10;
			// 
			// ClientiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1286, 868);
			this.Controls.Add(this.selectie_curenta1);
			this.Controls.Add(this.btnModifica);
			this.Controls.Add(this.btnSterge);
			this.Controls.Add(this.btnAdauga);
			this.Controls.Add(this.gvClienti);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tbCautare);
			this.Controls.Add(this.labelCautare);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ClientiForm";
			this.Text = "ClientiForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ClientiForm_Load);
			this.Click += new System.EventHandler(this.ClientiForm_Click);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientiForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gvClienti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvClienti;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
		private Gestiune_StocuriDataSet1 gestiune_StocuriDataSet1;
		private System.Windows.Forms.BindingSource clientiBindingSource;
		private Gestiune_StocuriDataSet1TableAdapters.ClientiTableAdapter clientiTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem editeazaClientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stergeClientToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
		private System.Windows.Forms.Button btnModifica;
		private System.Windows.Forms.Button btnSterge;
		private System.Windows.Forms.Button btnAdauga;
		private System.Windows.Forms.Label labelCautare;
		private System.Windows.Forms.TextBox tbCautare;
		private System.Windows.Forms.ToolStripMenuItem salvarebinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restaurarebinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salvarexmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restaurarexmlToolStripMenuItem;
		private Selectie_curenta selectie_curenta1;
	}
}