using BulkInsertAPP.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;
using System.Linq;
using BulkInsertAPP.RegisteredTables;
using System.Transactions;
using System.Configuration;

namespace BulkInsertAPP
{
    public partial class FormImportarExcel : Form
    {
        public FormImportarExcel()
        {
            InitializeComponent();
            rdRegisteredTables.Checked = true;
        }

        #region Events
        private void FormImportarExcel_Load(object sender, EventArgs e)
        {
            //Load ComboBox
            var type = typeof(IRegisteredTable);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToList();

            List<ComboBoxEntity> dataSource = new List<ComboBoxEntity>();
            types.ForEach(x => dataSource.Add(new ComboBoxEntity(x.Name, x)));

            cmbRegisteredTables.ValueMember = "Value";
            cmbRegisteredTables.DisplayMember = "Text";
            cmbRegisteredTables.DataSource = dataSource;

            //Load Connection Settings
            string defaultConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(defaultConnectionString);
            txtServer.Text = builder.DataSource;
            txtDatabase.Text = builder.InitialCatalog;
            txtUserID.Text = builder.UserID;
            txtPassword.Text = builder.Password;
        }
        private void btnFindFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.FindFile(dialog.FileName);
                }
                else
                {
                    MessageBox.Show("Error finding the file!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnImportFile_Click(object sender, EventArgs e)

        {
            try
            {
                string fileName = txtFileName.Text;
                string sheetName = txtSheetName.Text;

                if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(sheetName))
                {
                    this.ImportFile(fileName, sheetName);
                }
                else
                {
                    MessageBox.Show("Missing file name or sheet name!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rdRegisteredTables_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRegisteredTables.Checked)
            {
                cmbRegisteredTables.Enabled = true;
                txtTableName.Enabled = false;
            }
            else
            {
                cmbRegisteredTables.Enabled = false;
                txtTableName.Enabled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string serverAddress = txtServer.Text;
                string dataBase = txtDatabase.Text;
                string userID = txtUserID.Text;
                string password = txtPassword.Text;
                string tableName = this.GetSelectedTableName();

                if (string.IsNullOrEmpty(tableName))
                    MessageBox.Show("Choose the destination table!");
                else if (!(string.IsNullOrEmpty(serverAddress) || string.IsNullOrEmpty(dataBase)
                    || string.IsNullOrEmpty(userID)))
                {
                    this.Save(serverAddress, dataBase, userID, password, tableName);
                    MessageBox.Show("Saved successfully!");
                }
                else
                {
                    MessageBox.Show("Missing connection parameters!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Methods
        private string GetSelectedTableName()
        {
            if (cmbRegisteredTables.Enabled)
                return cmbRegisteredTables.SelectedText;
            else if (!string.IsNullOrEmpty(txtTableName.Text))
                return txtTableName.Text;
            else
                return string.Empty;
        }
        private void FindFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            if (extension == ".xls")
            {
                txtFileName.Text = fileName;
            }
            else if (extension == ".xlsx")
            {
                string replacedExtensionPath = fileName.Replace(".xlsx", ".xls");
                if (!File.Exists(replacedExtensionPath))
                    File.Copy(fileName, replacedExtensionPath);

                txtFileName.Text = replacedExtensionPath;
            }
            else
            {
                MessageBox.Show("Only Excel files accepted!");
            }
        }
        private void ImportFile(string fileName, string sheetName)
        {
            string connString = string.Concat(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=", fileName, ";Extended Properties='Excel 8.0;HDR=Yes;'");
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(string.Format("select * from [{0}$]", sheetName), connection);

                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dr);

                    if (cmbRegisteredTables.Enabled)
                    {
                        IRegisteredTable selectedTable = (IRegisteredTable)Activator.CreateInstance((Type)cmbRegisteredTables.SelectedValue);
                        dataTable = (selectedTable.ConfigTable(dataTable));
                    }
                    
                    gridImportar.AutoGenerateColumns = true;
                    gridImportar.DataSource = dataTable;

                    lblTotalLines.Text = gridImportar.Rows.Count.ToString();
                }
            }
        }
        private void Save(string serverAddress, string dataBase, string userID, string password, string tableName)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                string connectionString = String.Format("Server={0};Database={1};User Id={2};Password={3};", serverAddress, dataBase, userID, password);
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlBulkCopy s = new SqlBulkCopy(conn);
                s.DestinationTableName = tableName;
                s.WriteToServer((DataTable)gridImportar.DataSource);

                ts.Complete();
            }
        }

        #endregion
    }
}

