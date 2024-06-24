using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing.Drawing2D;


namespace Gestiune_Stocuri_PAW
{
	partial class ProduseForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gvProduse = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.produseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.gestiune_StocuriDataSet = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restaurarebinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fisierXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvareFisierXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restaurareFisierXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editeazaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stergeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAdauga = new System.Windows.Forms.Button();
			this.btnModifica = new System.Windows.Forms.Button();
			this.tbCautare = new System.Windows.Forms.TextBox();
			this.labelCautare = new System.Windows.Forms.Label();
			this.produseTableAdapter = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSetTableAdapters.ProduseTableAdapter();
			this.btnSterge = new System.Windows.Forms.Button();
			this.gestiune_StocuriDataSet1 = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet();
			this.gestiune_StocuriDataSet2 = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet();
			this.selectie_curenta1 = new Gestiune_Stocuri_PAW.Selectie_curenta();
			((System.ComponentModel.ISupportInitialize)(this.gvProduse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produseBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// gvProduse
			// 
			this.gvProduse.AllowDrop = true;
			this.gvProduse.AllowUserToAddRows = false;
			this.gvProduse.AllowUserToDeleteRows = false;
			this.gvProduse.AllowUserToResizeRows = false;
			this.gvProduse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvProduse.AutoGenerateColumns = false;
			this.gvProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvProduse.BackgroundColor = System.Drawing.Color.White;
			this.gvProduse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gvProduse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvProduse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvProduse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gvProduse.ColumnHeadersHeight = 70;
			this.gvProduse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.gvProduse.DataSource = this.produseBindingSource1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvProduse.DefaultCellStyle = dataGridViewCellStyle2;
			this.gvProduse.EnableHeadersVisualStyles = false;
			this.gvProduse.GridColor = System.Drawing.Color.LightGray;
			this.gvProduse.Location = new System.Drawing.Point(32, 171);
			this.gvProduse.Name = "gvProduse";
			this.gvProduse.ReadOnly = true;
			this.gvProduse.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gvProduse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gvProduse.RowHeadersVisible = false;
			this.gvProduse.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gvProduse.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.gvProduse.RowTemplate.Height = 40;
			this.gvProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvProduse.Size = new System.Drawing.Size(1052, 471);
			this.gvProduse.TabIndex = 0;
			this.gvProduse.SelectionChanged += new System.EventHandler(this.gvProduse_SelectionChanged);
			this.gvProduse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvProduse_MouseDown);
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume produs";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nume produs";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Categorie";
			this.dataGridViewTextBoxColumn3.HeaderText = "Categorie";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantitate";
			this.dataGridViewTextBoxColumn4.HeaderText = "Cantitate";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Unitate de masura";
			this.dataGridViewTextBoxColumn5.HeaderText = "Unitate de masura";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Pret";
			this.dataGridViewTextBoxColumn6.HeaderText = "Pret";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// produseBindingSource1
			// 
			this.produseBindingSource1.DataMember = "Produse";
			this.produseBindingSource1.DataSource = this.gestiune_StocuriDataSet;
			// 
			// gestiune_StocuriDataSet
			// 
			this.gestiune_StocuriDataSet.DataSetName = "Gestiune_StocuriDataSet";
			this.gestiune_StocuriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.fisierXmlToolStripMenuItem,
            this.produseToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1128, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fisierToolStripMenuItem
			// 
			this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurarebinToolStripMenuItem});
			this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
			this.fisierToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
			this.fisierToolStripMenuItem.Text = "Fisier binar";
			// 
			// salvareToolStripMenuItem
			// 
			this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
			this.salvareToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
			this.salvareToolStripMenuItem.Text = "Salvare fisier binar";
			this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
			// 
			// restaurarebinToolStripMenuItem
			// 
			this.restaurarebinToolStripMenuItem.Name = "restaurarebinToolStripMenuItem";
			this.restaurarebinToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
			this.restaurarebinToolStripMenuItem.Text = "Restaurare din fisier binar";
			this.restaurarebinToolStripMenuItem.Click += new System.EventHandler(this.restaurarebinToolStripMenuItem_Click);
			// 
			// fisierXmlToolStripMenuItem
			// 
			this.fisierXmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierXmlToolStripMenuItem,
            this.restaurareFisierXmlToolStripMenuItem});
			this.fisierXmlToolStripMenuItem.Name = "fisierXmlToolStripMenuItem";
			this.fisierXmlToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.fisierXmlToolStripMenuItem.Text = "Fisier xml";
			// 
			// salvareFisierXmlToolStripMenuItem
			// 
			this.salvareFisierXmlToolStripMenuItem.Name = "salvareFisierXmlToolStripMenuItem";
			this.salvareFisierXmlToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
			this.salvareFisierXmlToolStripMenuItem.Text = "Salvare fisier xml";
			this.salvareFisierXmlToolStripMenuItem.Click += new System.EventHandler(this.salvarexmlToolStripMenuItem_Click);
			// 
			// restaurareFisierXmlToolStripMenuItem
			// 
			this.restaurareFisierXmlToolStripMenuItem.Name = "restaurareFisierXmlToolStripMenuItem";
			this.restaurareFisierXmlToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
			this.restaurareFisierXmlToolStripMenuItem.Text = "Restaurare din fisier xml";
			this.restaurareFisierXmlToolStripMenuItem.Click += new System.EventHandler(this.restaurarexmlToolStripMenuItem_Click);
			// 
			// produseToolStripMenuItem
			// 
			this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProdusToolStripMenuItem,
            this.editeazaProdusToolStripMenuItem,
            this.stergeProdusToolStripMenuItem});
			this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
			this.produseToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
			this.produseToolStripMenuItem.Text = "Produse";
			// 
			// adaugaProdusToolStripMenuItem
			// 
			this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
			this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
			this.adaugaProdusToolStripMenuItem.Text = "Adauga produs";
			this.adaugaProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugaProdusToolStripMenuItem_Click);
			// 
			// editeazaProdusToolStripMenuItem
			// 
			this.editeazaProdusToolStripMenuItem.Name = "editeazaProdusToolStripMenuItem";
			this.editeazaProdusToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
			this.editeazaProdusToolStripMenuItem.Text = "Editeaza produs";
			this.editeazaProdusToolStripMenuItem.Click += new System.EventHandler(this.editeazaProdusToolStripMenuItem_Click);
			// 
			// stergeProdusToolStripMenuItem
			// 
			this.stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
			this.stergeProdusToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
			this.stergeProdusToolStripMenuItem.Text = "Sterge produs";
			this.stergeProdusToolStripMenuItem.Click += new System.EventHandler(this.stergeProdusToolStripMenuItem_Click);
			// 
			// btnAdauga
			// 
			this.btnAdauga.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnAdauga.FlatAppearance.BorderSize = 0;
			this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdauga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdauga.ForeColor = System.Drawing.Color.White;
			this.btnAdauga.Location = new System.Drawing.Point(32, 676);
			this.btnAdauga.Name = "btnAdauga";
			this.btnAdauga.Size = new System.Drawing.Size(247, 68);
			this.btnAdauga.TabIndex = 2;
			this.btnAdauga.Text = "Adauga produs";
			this.btnAdauga.UseVisualStyleBackColor = false;
			this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
			// 
			// btnModifica
			// 
			this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModifica.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnModifica.FlatAppearance.BorderSize = 0;
			this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifica.ForeColor = System.Drawing.Color.White;
			this.btnModifica.Location = new System.Drawing.Point(584, 676);
			this.btnModifica.Name = "btnModifica";
			this.btnModifica.Size = new System.Drawing.Size(247, 68);
			this.btnModifica.TabIndex = 4;
			this.btnModifica.Text = "Modifica produs";
			this.btnModifica.UseVisualStyleBackColor = false;
			this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
			// 
			// tbCautare
			// 
			this.tbCautare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCautare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCautare.Location = new System.Drawing.Point(98, 128);
			this.tbCautare.Name = "tbCautare";
			this.tbCautare.Size = new System.Drawing.Size(986, 34);
			this.tbCautare.TabIndex = 5;
			this.tbCautare.TextChanged += new System.EventHandler(this.tbCautare_TextChanged);
			// 
			// labelCautare
			// 
			this.labelCautare.AutoSize = true;
			this.labelCautare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCautare.Location = new System.Drawing.Point(26, 131);
			this.labelCautare.Name = "labelCautare";
			this.labelCautare.Size = new System.Drawing.Size(66, 28);
			this.labelCautare.TabIndex = 6;
			this.labelCautare.Text = "Cauta";
			// 
			// produseTableAdapter
			// 
			this.produseTableAdapter.ClearBeforeFill = true;
			// 
			// btnSterge
			// 
			this.btnSterge.AllowDrop = true;
			this.btnSterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSterge.BackColor = System.Drawing.Color.Crimson;
			this.btnSterge.FlatAppearance.BorderSize = 0;
			this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSterge.ForeColor = System.Drawing.Color.White;
			this.btnSterge.Location = new System.Drawing.Point(837, 676);
			this.btnSterge.Name = "btnSterge";
			this.btnSterge.Size = new System.Drawing.Size(247, 68);
			this.btnSterge.TabIndex = 3;
			this.btnSterge.Text = "Sterge produs";
			this.btnSterge.UseVisualStyleBackColor = false;
			this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
			this.btnSterge.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnSterge_DragDrop);
			this.btnSterge.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnSterge_DragEnter);
			this.btnSterge.DragLeave += new System.EventHandler(this.btnSterge_DragLeave);
			// 
			// gestiune_StocuriDataSet1
			// 
			this.gestiune_StocuriDataSet1.DataSetName = "Gestiune_StocuriDataSet";
			this.gestiune_StocuriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gestiune_StocuriDataSet2
			// 
			this.gestiune_StocuriDataSet2.DataSetName = "Gestiune_StocuriDataSet";
			this.gestiune_StocuriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// selectie_curenta1
			// 
			this.selectie_curenta1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectie_curenta1.Location = new System.Drawing.Point(301, 693);
			this.selectie_curenta1.Name = "selectie_curenta1";
			this.selectie_curenta1.Size = new System.Drawing.Size(252, 38);
			this.selectie_curenta1.TabIndex = 7;
			// 
			// ProduseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 1055);
			this.Controls.Add(this.selectie_curenta1);
			this.Controls.Add(this.labelCautare);
			this.Controls.Add(this.tbCautare);
			this.Controls.Add(this.btnModifica);
			this.Controls.Add(this.btnSterge);
			this.Controls.Add(this.btnAdauga);
			this.Controls.Add(this.gvProduse);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ProduseForm";
			this.Text = "Produse";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProduseForm_FormClosing);
			this.Load += new System.EventHandler(this.ProduseForm_Load);
			this.Click += new System.EventHandler(this.ProduseForm_Click);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProduseForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gvProduse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produseBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvProduse;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeProdusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitateDeMasuraDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editeazaProdusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
		private Button btnAdauga;
		private Button btnSterge;
		private Button btnModifica;
		private TextBox tbCautare;
		private Label labelCautare;
		private Gestiune_StocuriDataSet gestiune_StocuriDataSet;
		private BindingSource produseBindingSource1;
		private Gestiune_StocuriDataSetTableAdapters.ProduseTableAdapter produseTableAdapter;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private ToolStripMenuItem salvareToolStripMenuItem;
		private ToolStripMenuItem restaurarebinToolStripMenuItem;
		private ToolStripMenuItem fisierXmlToolStripMenuItem;
		private ToolStripMenuItem salvareFisierXmlToolStripMenuItem;
		private ToolStripMenuItem restaurareFisierXmlToolStripMenuItem;
		private Gestiune_StocuriDataSet gestiune_StocuriDataSet1;
		private Gestiune_StocuriDataSet gestiune_StocuriDataSet2;
		private Selectie_curenta selectie_curenta1;
	}
}