using System.Windows.Forms;

namespace Gestiune_Stocuri_PAW
{
	partial class ComenziForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComenziForm));
			this.gvClienti = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gestiune_StocuriDataSet2 = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet2();
			this.clientiTableAdapter = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet2TableAdapters.ClientiTableAdapter();
			this.gvProduse = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gestiune_StocuriDataSet3 = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet3();
			this.produseTableAdapter = new Gestiune_Stocuri_PAW.Gestiune_StocuriDataSet3TableAdapters.ProduseTableAdapter();
			this.lblClient = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbClient = new System.Windows.Forms.TextBox();
			this.tbProdus = new System.Windows.Forms.TextBox();
			this.tbIdClient = new System.Windows.Forms.TextBox();
			this.tbIdProdus = new System.Windows.Forms.TextBox();
			this.gvComenzi = new System.Windows.Forms.DataGridView();
			this.contextMenuPrintare = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.printeazaChToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnComanda = new System.Windows.Forms.Button();
			this.numericCantitate = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblSelecteazaClient = new System.Windows.Forms.Label();
			this.lblSelecteazaProdus = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lblCantitate = new System.Windows.Forms.Label();
			this.tbSuma = new System.Windows.Forms.TextBox();
			this.btnStatistici = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.gvClienti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProduse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvComenzi)).BeginInit();
			this.contextMenuPrintare.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericCantitate)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gvClienti
			// 
			this.gvClienti.AllowUserToAddRows = false;
			this.gvClienti.AllowUserToDeleteRows = false;
			this.gvClienti.AllowUserToResizeRows = false;
			this.gvClienti.AutoGenerateColumns = false;
			this.gvClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvClienti.BackgroundColor = System.Drawing.Color.White;
			this.gvClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gvClienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvClienti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gvClienti.ColumnHeadersHeight = 77;
			this.gvClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
			this.gvClienti.DataSource = this.clientiBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvClienti.DefaultCellStyle = dataGridViewCellStyle2;
			this.gvClienti.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvClienti.EnableHeadersVisualStyles = false;
			this.gvClienti.GridColor = System.Drawing.Color.LightGray;
			this.gvClienti.Location = new System.Drawing.Point(3, 3);
			this.gvClienti.MultiSelect = false;
			this.gvClienti.Name = "gvClienti";
			this.gvClienti.ReadOnly = true;
			this.gvClienti.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gvClienti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gvClienti.RowHeadersVisible = false;
			this.gvClienti.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gvClienti.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.gvClienti.RowTemplate.Height = 30;
			this.gvClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvClienti.Size = new System.Drawing.Size(668, 232);
			this.gvClienti.TabIndex = 0;
			this.gvClienti.SelectionChanged += new System.EventHandler(this.gvClienti_SelectionChanged);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numeDataGridViewTextBoxColumn
			// 
			this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
			this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
			this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
			this.numeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// prenumeDataGridViewTextBoxColumn
			// 
			this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
			this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
			this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
			this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telefonDataGridViewTextBoxColumn
			// 
			this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
			this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
			this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
			this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// adresaDataGridViewTextBoxColumn
			// 
			this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
			this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
			this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
			this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clientiBindingSource
			// 
			this.clientiBindingSource.DataMember = "Clienti";
			this.clientiBindingSource.DataSource = this.gestiune_StocuriDataSet2;
			// 
			// gestiune_StocuriDataSet2
			// 
			this.gestiune_StocuriDataSet2.DataSetName = "Gestiune_StocuriDataSet2";
			this.gestiune_StocuriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clientiTableAdapter
			// 
			this.clientiTableAdapter.ClearBeforeFill = true;
			// 
			// gvProduse
			// 
			this.gvProduse.AllowDrop = true;
			this.gvProduse.AllowUserToAddRows = false;
			this.gvProduse.AllowUserToDeleteRows = false;
			this.gvProduse.AllowUserToResizeRows = false;
			this.gvProduse.AutoGenerateColumns = false;
			this.gvProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvProduse.BackgroundColor = System.Drawing.Color.White;
			this.gvProduse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gvProduse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvProduse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvProduse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gvProduse.ColumnHeadersHeight = 77;
			this.gvProduse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.gvProduse.DataSource = this.produseBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvProduse.DefaultCellStyle = dataGridViewCellStyle5;
			this.gvProduse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvProduse.EnableHeadersVisualStyles = false;
			this.gvProduse.GridColor = System.Drawing.Color.LightGray;
			this.gvProduse.Location = new System.Drawing.Point(677, 3);
			this.gvProduse.MultiSelect = false;
			this.gvProduse.Name = "gvProduse";
			this.gvProduse.ReadOnly = true;
			this.gvProduse.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gvProduse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gvProduse.RowHeadersVisible = false;
			this.gvProduse.RowHeadersWidth = 51;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gvProduse.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.gvProduse.RowTemplate.Height = 30;
			this.gvProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvProduse.Size = new System.Drawing.Size(668, 232);
			this.gvProduse.TabIndex = 1;
			this.gvProduse.SelectionChanged += new System.EventHandler(this.gvProduse_SelectionChanged);
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
			// produseBindingSource
			// 
			this.produseBindingSource.DataMember = "Produse";
			this.produseBindingSource.DataSource = this.gestiune_StocuriDataSet3;
			// 
			// gestiune_StocuriDataSet3
			// 
			this.gestiune_StocuriDataSet3.DataSetName = "Gestiune_StocuriDataSet3";
			this.gestiune_StocuriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// produseTableAdapter
			// 
			this.produseTableAdapter.ClearBeforeFill = true;
			// 
			// lblClient
			// 
			this.lblClient.AutoSize = true;
			this.lblClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClient.Location = new System.Drawing.Point(108, 432);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(133, 28);
			this.lblClient.TabIndex = 2;
			this.lblClient.Text = "Client selectat";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(108, 481);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Produs selectat";
			// 
			// tbClient
			// 
			this.tbClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbClient.Location = new System.Drawing.Point(436, 427);
			this.tbClient.Name = "tbClient";
			this.tbClient.ReadOnly = true;
			this.tbClient.Size = new System.Drawing.Size(364, 34);
			this.tbClient.TabIndex = 4;
			// 
			// tbProdus
			// 
			this.tbProdus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbProdus.Location = new System.Drawing.Point(436, 476);
			this.tbProdus.Name = "tbProdus";
			this.tbProdus.ReadOnly = true;
			this.tbProdus.Size = new System.Drawing.Size(364, 34);
			this.tbProdus.TabIndex = 5;
			// 
			// tbIdClient
			// 
			this.tbIdClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIdClient.Location = new System.Drawing.Point(278, 429);
			this.tbIdClient.Name = "tbIdClient";
			this.tbIdClient.ReadOnly = true;
			this.tbIdClient.Size = new System.Drawing.Size(136, 34);
			this.tbIdClient.TabIndex = 6;
			// 
			// tbIdProdus
			// 
			this.tbIdProdus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIdProdus.Location = new System.Drawing.Point(278, 478);
			this.tbIdProdus.Name = "tbIdProdus";
			this.tbIdProdus.ReadOnly = true;
			this.tbIdProdus.Size = new System.Drawing.Size(136, 34);
			this.tbIdProdus.TabIndex = 7;
			// 
			// gvComenzi
			// 
			this.gvComenzi.AllowUserToAddRows = false;
			this.gvComenzi.AllowUserToDeleteRows = false;
			this.gvComenzi.AllowUserToResizeRows = false;
			this.gvComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvComenzi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvComenzi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gvComenzi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvComenzi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateBlue;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvComenzi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gvComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvComenzi.ContextMenuStrip = this.contextMenuPrintare;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvComenzi.DefaultCellStyle = dataGridViewCellStyle8;
			this.gvComenzi.Location = new System.Drawing.Point(12, 606);
			this.gvComenzi.MultiSelect = false;
			this.gvComenzi.Name = "gvComenzi";
			this.gvComenzi.ReadOnly = true;
			this.gvComenzi.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gvComenzi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gvComenzi.RowHeadersVisible = false;
			this.gvComenzi.RowHeadersWidth = 51;
			this.gvComenzi.RowTemplate.Height = 30;
			this.gvComenzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvComenzi.Size = new System.Drawing.Size(1199, 261);
			this.gvComenzi.TabIndex = 17;
			this.gvComenzi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvComenzi_MouseDown);
			// 
			// contextMenuPrintare
			// 
			this.contextMenuPrintare.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuPrintare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printeazaChToolStripMenuItem});
			this.contextMenuPrintare.Name = "contextMenuPrintare";
			this.contextMenuPrintare.Size = new System.Drawing.Size(255, 36);
			// 
			// printeazaChToolStripMenuItem
			// 
			this.printeazaChToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.printeazaChToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.printeazaChToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.printeazaChToolStripMenuItem.Name = "printeazaChToolStripMenuItem";
			this.printeazaChToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
			this.printeazaChToolStripMenuItem.Text = "Printeaza chitanta";
			this.printeazaChToolStripMenuItem.Click += new System.EventHandler(this.printeazaChToolStripMenuItem_Click);
			// 
			// btnComanda
			// 
			this.btnComanda.BackColor = System.Drawing.Color.SeaGreen;
			this.btnComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnComanda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComanda.ForeColor = System.Drawing.Color.White;
			this.btnComanda.Location = new System.Drawing.Point(1102, 432);
			this.btnComanda.Name = "btnComanda";
			this.btnComanda.Size = new System.Drawing.Size(254, 72);
			this.btnComanda.TabIndex = 9;
			this.btnComanda.Text = "Plaseaza comanda";
			this.btnComanda.UseVisualStyleBackColor = false;
			this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
			// 
			// numericCantitate
			// 
			this.numericCantitate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericCantitate.Location = new System.Drawing.Point(278, 529);
			this.numericCantitate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericCantitate.Name = "numericCantitate";
			this.numericCantitate.Size = new System.Drawing.Size(136, 34);
			this.numericCantitate.TabIndex = 10;
			this.numericCantitate.ValueChanged += new System.EventHandler(this.numericCantitate_ValueChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.gvProduse, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.gvClienti, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 72);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 238);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// lblSelecteazaClient
			// 
			this.lblSelecteazaClient.AutoSize = true;
			this.lblSelecteazaClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSelecteazaClient.Location = new System.Drawing.Point(3, 0);
			this.lblSelecteazaClient.Name = "lblSelecteazaClient";
			this.lblSelecteazaClient.Size = new System.Drawing.Size(667, 35);
			this.lblSelecteazaClient.TabIndex = 13;
			this.lblSelecteazaClient.Text = "Selecteaza client";
			this.lblSelecteazaClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSelecteazaProdus
			// 
			this.lblSelecteazaProdus.AutoSize = true;
			this.lblSelecteazaProdus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSelecteazaProdus.Location = new System.Drawing.Point(676, 0);
			this.lblSelecteazaProdus.Name = "lblSelecteazaProdus";
			this.lblSelecteazaProdus.Size = new System.Drawing.Size(667, 35);
			this.lblSelecteazaProdus.TabIndex = 13;
			this.lblSelecteazaProdus.Text = "Selecteaza produs";
			this.lblSelecteazaProdus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.lblSelecteazaProdus, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblSelecteazaClient, 0, 0);
			this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 12);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1346, 35);
			this.tableLayoutPanel2.TabIndex = 12;
			// 
			// lblCantitate
			// 
			this.lblCantitate.AutoSize = true;
			this.lblCantitate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantitate.Location = new System.Drawing.Point(58, 535);
			this.lblCantitate.Name = "lblCantitate";
			this.lblCantitate.Size = new System.Drawing.Size(194, 28);
			this.lblCantitate.TabIndex = 13;
			this.lblCantitate.Text = "Cantitate comandata";
			// 
			// tbSuma
			// 
			this.tbSuma.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSuma.ForeColor = System.Drawing.Color.DarkOrange;
			this.tbSuma.Location = new System.Drawing.Point(911, 438);
			this.tbSuma.Name = "tbSuma";
			this.tbSuma.ReadOnly = true;
			this.tbSuma.Size = new System.Drawing.Size(185, 52);
			this.tbSuma.TabIndex = 14;
			this.tbSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnStatistici
			// 
			this.btnStatistici.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnStatistici.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnStatistici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatistici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatistici.ForeColor = System.Drawing.Color.White;
			this.btnStatistici.Location = new System.Drawing.Point(1239, 601);
			this.btnStatistici.Name = "btnStatistici";
			this.btnStatistici.Size = new System.Drawing.Size(118, 266);
			this.btnStatistici.TabIndex = 15;
			this.btnStatistici.Text = "Afiseaza grafic";
			this.btnStatistici.UseVisualStyleBackColor = false;
			this.btnStatistici.Click += new System.EventHandler(this.btnStatistici_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// ComenziForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1372, 948);
			this.Controls.Add(this.btnStatistici);
			this.Controls.Add(this.tbSuma);
			this.Controls.Add(this.lblCantitate);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.numericCantitate);
			this.Controls.Add(this.btnComanda);
			this.Controls.Add(this.gvComenzi);
			this.Controls.Add(this.tbIdProdus);
			this.Controls.Add(this.tbIdClient);
			this.Controls.Add(this.tbProdus);
			this.Controls.Add(this.tbClient);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblClient);
			this.KeyPreview = true;
			this.Name = "ComenziForm";
			this.Text = "Comenzi";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ComenziForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComenziForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gvClienti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProduse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestiune_StocuriDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvComenzi)).EndInit();
			this.contextMenuPrintare.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericCantitate)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvClienti;
		private Gestiune_StocuriDataSet2 gestiune_StocuriDataSet2;
		private System.Windows.Forms.BindingSource clientiBindingSource;
		private Gestiune_StocuriDataSet2TableAdapters.ClientiTableAdapter clientiTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView gvProduse;
		private Gestiune_StocuriDataSet3 gestiune_StocuriDataSet3;
		private System.Windows.Forms.BindingSource produseBindingSource;
		private Gestiune_StocuriDataSet3TableAdapters.ProduseTableAdapter produseTableAdapter;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbClient;
		private System.Windows.Forms.TextBox tbProdus;
		private System.Windows.Forms.TextBox tbIdClient;
		private System.Windows.Forms.TextBox tbIdProdus;
		private System.Windows.Forms.DataGridView gvComenzi;
		private System.Windows.Forms.Button btnComanda;
		private System.Windows.Forms.NumericUpDown numericCantitate;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lblSelecteazaClient;
		private Label lblSelecteazaProdus;
		private TableLayoutPanel tableLayoutPanel2;
		private Label lblCantitate;
		private TextBox tbSuma;
		private Button btnStatistici;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
		private ContextMenuStrip contextMenuPrintare;
		private ToolStripMenuItem printeazaChToolStripMenuItem;
	}
}