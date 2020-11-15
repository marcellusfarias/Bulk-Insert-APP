namespace BulkInsertAPP
{
	partial class FormImportarExcel
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSalvarTabela = new System.Windows.Forms.Label();
            this.cmbRegisteredTables = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalLines = new System.Windows.Forms.Label();
            this.lblTotalLinesText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridImportar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTableName = new System.Windows.Forms.RadioButton();
            this.rdRegisteredTables = new System.Windows.Forms.RadioButton();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.groupBoxExcelFileSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.groupBoxServerSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxExcelFileSettings.SuspendLayout();
            this.groupBoxServerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(106, 22);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(252, 22);
            this.txtFileName.TabIndex = 19;
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(7, 27);
            this.lblArquivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(34, 17);
            this.lblArquivo.TabIndex = 18;
            this.lblArquivo.Text = "File:";
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(366, 17);
            this.btnFindFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(37, 28);
            this.btnFindFile.TabIndex = 21;
            this.btnFindFile.Text = "...";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(551, 233);
            this.btnImportFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(100, 31);
            this.btnImportFile.TabIndex = 22;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(712, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSalvarTabela
            // 
            this.lblSalvarTabela.AutoSize = true;
            this.lblSalvarTabela.Location = new System.Drawing.Point(7, 60);
            this.lblSalvarTabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalvarTabela.Name = "lblSalvarTabela";
            this.lblSalvarTabela.Size = new System.Drawing.Size(128, 17);
            this.lblSalvarTabela.TabIndex = 24;
            this.lblSalvarTabela.Text = "Registered Tables:";
            // 
            // cmbRegisteredTables
            // 
            this.cmbRegisteredTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegisteredTables.FormattingEnabled = true;
            this.cmbRegisteredTables.Location = new System.Drawing.Point(143, 57);
            this.cmbRegisteredTables.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRegisteredTables.Name = "cmbRegisteredTables";
            this.cmbRegisteredTables.Size = new System.Drawing.Size(252, 24);
            this.cmbRegisteredTables.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 558);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalLines);
            this.panel3.Controls.Add(this.lblTotalLinesText);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 513);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 41);
            this.panel3.TabIndex = 2;
            // 
            // lblTotalLines
            // 
            this.lblTotalLines.AutoSize = true;
            this.lblTotalLines.Location = new System.Drawing.Point(97, 14);
            this.lblTotalLines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLines.Name = "lblTotalLines";
            this.lblTotalLines.Size = new System.Drawing.Size(16, 17);
            this.lblTotalLines.TabIndex = 2;
            this.lblTotalLines.Text = "0";
            // 
            // lblTotalLinesText
            // 
            this.lblTotalLinesText.AutoSize = true;
            this.lblTotalLinesText.Location = new System.Drawing.Point(4, 14);
            this.lblTotalLinesText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLinesText.Name = "lblTotalLinesText";
            this.lblTotalLinesText.Size = new System.Drawing.Size(82, 17);
            this.lblTotalLinesText.TabIndex = 1;
            this.lblTotalLinesText.Text = "Total Lines:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(820, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridImportar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 211);
            this.panel2.TabIndex = 1;
            // 
            // gridImportar
            // 
            this.gridImportar.AllowUserToAddRows = false;
            this.gridImportar.AllowUserToDeleteRows = false;
            this.gridImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridImportar.Location = new System.Drawing.Point(0, 0);
            this.gridImportar.Margin = new System.Windows.Forms.Padding(4);
            this.gridImportar.Name = "gridImportar";
            this.gridImportar.ReadOnly = true;
            this.gridImportar.Size = new System.Drawing.Size(924, 211);
            this.gridImportar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBoxExcelFileSettings);
            this.panel1.Controls.Add(this.groupBoxServerSettings);
            this.panel1.Controls.Add(this.btnImportFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 282);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTableName);
            this.groupBox2.Controls.Add(this.lblSalvarTabela);
            this.groupBox2.Controls.Add(this.rdRegisteredTables);
            this.groupBox2.Controls.Add(this.cmbRegisteredTables);
            this.groupBox2.Controls.Add(this.txtTableName);
            this.groupBox2.Controls.Add(this.lblTabela);
            this.groupBox2.Location = new System.Drawing.Point(233, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 125);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataBase Table";
            // 
            // rdTableName
            // 
            this.rdTableName.AutoSize = true;
            this.rdTableName.Location = new System.Drawing.Point(158, 24);
            this.rdTableName.Name = "rdTableName";
            this.rdTableName.Size = new System.Drawing.Size(138, 21);
            this.rdTableName.TabIndex = 34;
            this.rdTableName.TabStop = true;
            this.rdTableName.Text = "Digit Table Name";
            this.rdTableName.UseVisualStyleBackColor = true;
            // 
            // rdRegisteredTables
            // 
            this.rdRegisteredTables.AutoSize = true;
            this.rdRegisteredTables.Location = new System.Drawing.Point(7, 24);
            this.rdRegisteredTables.Name = "rdRegisteredTables";
            this.rdRegisteredTables.Size = new System.Drawing.Size(145, 21);
            this.rdRegisteredTables.TabIndex = 33;
            this.rdRegisteredTables.TabStop = true;
            this.rdRegisteredTables.Text = "Registered Tables";
            this.rdRegisteredTables.UseVisualStyleBackColor = true;
            this.rdRegisteredTables.CheckedChanged += new System.EventHandler(this.rdRegisteredTables_CheckedChanged);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(143, 90);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(252, 22);
            this.txtTableName.TabIndex = 31;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(7, 93);
            this.lblTabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(89, 17);
            this.lblTabela.TabIndex = 32;
            this.lblTabela.Text = "Table Name:";
            // 
            // groupBoxExcelFileSettings
            // 
            this.groupBoxExcelFileSettings.Controls.Add(this.lblArquivo);
            this.groupBoxExcelFileSettings.Controls.Add(this.btnFindFile);
            this.groupBoxExcelFileSettings.Controls.Add(this.label3);
            this.groupBoxExcelFileSettings.Controls.Add(this.txtSheetName);
            this.groupBoxExcelFileSettings.Controls.Add(this.txtFileName);
            this.groupBoxExcelFileSettings.Location = new System.Drawing.Point(232, 9);
            this.groupBoxExcelFileSettings.Name = "groupBoxExcelFileSettings";
            this.groupBoxExcelFileSettings.Size = new System.Drawing.Size(419, 86);
            this.groupBoxExcelFileSettings.TabIndex = 40;
            this.groupBoxExcelFileSettings.TabStop = false;
            this.groupBoxExcelFileSettings.Text = "Excel File Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sheet Name:";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(106, 52);
            this.txtSheetName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(113, 22);
            this.txtSheetName.TabIndex = 37;
            // 
            // groupBoxServerSettings
            // 
            this.groupBoxServerSettings.Controls.Add(this.label4);
            this.groupBoxServerSettings.Controls.Add(this.txtUserID);
            this.groupBoxServerSettings.Controls.Add(this.txtPassword);
            this.groupBoxServerSettings.Controls.Add(this.label5);
            this.groupBoxServerSettings.Controls.Add(this.label1);
            this.groupBoxServerSettings.Controls.Add(this.txtServer);
            this.groupBoxServerSettings.Controls.Add(this.txtDatabase);
            this.groupBoxServerSettings.Controls.Add(this.label2);
            this.groupBoxServerSettings.Location = new System.Drawing.Point(8, 9);
            this.groupBoxServerSettings.Name = "groupBoxServerSettings";
            this.groupBoxServerSettings.Size = new System.Drawing.Size(218, 217);
            this.groupBoxServerSettings.TabIndex = 39;
            this.groupBoxServerSettings.TabStop = false;
            this.groupBoxServerSettings.Text = "Server Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "UserID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(92, 82);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(113, 22);
            this.txtUserID.TabIndex = 37;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 112);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 22);
            this.txtPassword.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(92, 22);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(113, 22);
            this.txtServer.TabIndex = 33;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(92, 52);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(113, 22);
            this.txtDatabase.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Database:";
            // 
            // FormImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormImportarExcel";
            this.ShowIcon = false;
            this.Text = "Bulk Insert APP";
            this.Load += new System.EventHandler(this.FormImportarExcel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridImportar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxExcelFileSettings.ResumeLayout(false);
            this.groupBoxExcelFileSettings.PerformLayout();
            this.groupBoxServerSettings.ResumeLayout(false);
            this.groupBoxServerSettings.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label lblArquivo;
		private System.Windows.Forms.Button btnFindFile;
		private System.Windows.Forms.Button btnImportFile;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblSalvarTabela;
		private System.Windows.Forms.ComboBox cmbRegisteredTables;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView gridImportar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTotalLines;
		private System.Windows.Forms.Label lblTotalLinesText;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.GroupBox groupBoxServerSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTableName;
        private System.Windows.Forms.RadioButton rdRegisteredTables;
        private System.Windows.Forms.GroupBox groupBoxExcelFileSettings;
    }
}

