using System;
using System.Drawing;
using System.Windows.Forms;
using CustomerAccountsUsingRaptorDb.Common;
using CustomerAccountsUsingRaptorDb.Common.Enum;
using CustomerAccountsUsingRaptorDb.Views.Schemas;

namespace CustomerAccountsUsingRaptorDb
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            Globals.StartRaptorDb();
            InitializeComponent();
            InitializeActionsComboBox();
            BindCustomerAccountsGrid();
        }

        /// <summary>
        /// Determines a UI event based on the current "actions" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbActions.Text == "Add a Customer Account")
            {
                using (var frmManageCustomerAccount = new FrmManageCustomerAccount(ManageAction.Add, null))
                {
                    frmManageCustomerAccount.ShowDialog();
                    if (frmManageCustomerAccount.ActionCommitted)
                    {
                        BindCustomerAccountsGrid();
                    }
                    InitializeActionsComboBox();
                }
            }
            else if (CbActions.Text == "Exit")
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Close the application
                    Close();
                }
                else
                {
                    InitializeActionsComboBox();
                }
            }
        }

        /// <summary>
        /// Shuts down RaptorDb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.StopRaptorDb();
        }

        /// <summary>
        /// Opens the currently selected row in detail mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvCustomerAccounts_DoubleClick(object sender, EventArgs e)
        {
            var currentRow = GvCustomerAccounts.CurrentRow;
            if (currentRow != null)
            {
                using (var frmManageCustomerAccount = new FrmManageCustomerAccount(ManageAction.Update, Guid.Parse(currentRow.Cells[0].Value.ToString())))
                {
                    frmManageCustomerAccount.ShowDialog();
                    if (frmManageCustomerAccount.ActionCommitted)
                    {
                        BindCustomerAccountsGrid();
                    }
                }
            }
        }

        /// <summary>
        /// Set the "actions" dropdown to the text "-- Actions --"
        /// </summary>
        private void InitializeActionsComboBox()
        {
            CbActions.Text = CbActions.Items[0].ToString();
        }

        /// <summary>
        /// Binds up the grid with rows and columns
        /// </summary>
        private void BindCustomerAccountsGrid()
        {
            GvCustomerAccounts.SuspendLayout();

            //First clear any existing records from the grid as it will be rebound
            if (GvCustomerAccounts.Rows.Count > 0)
            {
                GvCustomerAccounts.DataSource = null;
                GvCustomerAccounts.DataMember = null;
                GvCustomerAccounts.Rows.Clear();
            }

            GvCustomerAccounts.Columns.Clear();

            GvCustomerAccounts.ColumnCount = 8;

            GvCustomerAccounts.Columns[0].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[0].Name = "Id";
            GvCustomerAccounts.Columns[0].Width = 250;

            GvCustomerAccounts.Columns[1].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[1].Name = "Customer Name";
            GvCustomerAccounts.Columns[1].Width = 170;

            GvCustomerAccounts.Columns[2].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[2].Name = "Address 1";
            GvCustomerAccounts.Columns[2].Width = 160;

            GvCustomerAccounts.Columns[3].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[3].Name = "Address 2";
            GvCustomerAccounts.Columns[3].Width = 110;

            GvCustomerAccounts.Columns[4].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[4].Name = "City";
            GvCustomerAccounts.Columns[4].Width = 130;

            GvCustomerAccounts.Columns[5].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[5].Name = "State";
            GvCustomerAccounts.Columns[5].Width = 70;

            GvCustomerAccounts.Columns[6].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[6].Name = "Zip Code";
            GvCustomerAccounts.Columns[6].Width = 70;

            GvCustomerAccounts.Columns[7].DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            GvCustomerAccounts.Columns[7].Name = "Account Level";
            GvCustomerAccounts.Columns[7].Width = 110;

            GvCustomerAccounts.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            GvCustomerAccounts.RowsDefaultCellStyle.ForeColor = Color.Black;
            GvCustomerAccounts.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            GvCustomerAccounts.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#1F80BF");   //#FCDDA3
            GvCustomerAccounts.DefaultCellStyle.SelectionForeColor = Color.White;
            GvCustomerAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GvCustomerAccounts.AllowUserToAddRows = false;
            GvCustomerAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            GvCustomerAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            GvCustomerAccounts.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GvCustomerAccounts.GridColor = SystemColors.ActiveBorder;
            GvCustomerAccounts.RowHeadersVisible = false;
            GvCustomerAccounts.MultiSelect = true;
            GvCustomerAccounts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GvCustomerAccounts.AllowUserToResizeColumns = false;
            GvCustomerAccounts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);

            #region "Data stubbing"
            //TEST
            //for (var i = 0; i < 100; i++)
            //{
            //    GvCustomerAccounts.Rows.Add(Guid.NewGuid(), "Customer " + i, "123 County Line Road", "", "Bartlette", "PA", "18708", AccountLevel.Platinum);
            //}
            #endregion

            //Use RaptorDb to fetch the data
            var documentCount = Globals.RaptorDb.DocumentCount();
            if (documentCount > 0)
            {
                #region "Debugging"
                //Show the rows
                //Console.WriteLine(fastJSON.JSON.ToNiceJSON(customerAccounts.Rows, new fastJSON.JSONParameters { UseExtensions = false, UseFastGuid = false }));
                //Show the count
                //Console.WriteLine("Query result count = " + customerAccounts.Count);                
                #endregion

                RaptorDB.Result<CongTyViewRowSchema> customerAccounts = Globals.RaptorDb.Query<CongTyViewRowSchema>("", 0, 100);
                foreach (var ca in customerAccounts.Rows)
                {
                    GvCustomerAccounts.Rows.Add(ca.Id, ca.CustomerName, ca.Address1, ca.Address2, ca.City, ca.State, ca.ZipCode, ca.AccountLevel);
                }
            }

            GvCustomerAccounts.ResumeLayout(true);
        }





    }
}
