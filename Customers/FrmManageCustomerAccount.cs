using System;
using System.Windows.Forms;
using CustomerAccountsUsingRaptorDb.Common;
using CustomerAccountsUsingRaptorDb.Common.Enum;
using CustomerAccountsUsingRaptorDb.Entities;

namespace CustomerAccountsUsingRaptorDb
{
    public partial class FrmManageCustomerAccount : Form
    {
        //Private members
        private readonly Guid _customerId;
        private readonly ManageAction _manageAction;

        /// <summary>
        /// Sets either the add or edit action as committed or not committed
        /// </summary>
        public bool ActionCommitted { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="manageAction"></param>
        public FrmManageCustomerAccount(ManageAction manageAction, Guid? customerId)
        {
            InitializeComponent();
            _manageAction = manageAction;
            if (customerId.HasValue)
            {
                _customerId = customerId.Value;
            }
            InitializeFormData();
        }

        /// <summary>
        /// Validates then submits the data to RaptorDb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                if (_manageAction == ManageAction.Add)
                {
                    try
                    {
                        var customerAccount = new CongTy()
                        {
                            HangKhachHang = CbAccountLevel.Text,
                            DiaChi1 = TxtAddress1.Text.Trim(),
                            DiaChi2 = TxtAddress2.Text.Trim(),
                            QuanHuyen = TxtCity.Text.Trim(),
                            TenCongTy = TxtCustomerName.Text.Trim(),
                            State = CbState.Text,
                            MaBuuChinh = TxtZipCode.Text.Trim()
                        };

                        Globals.RaptorDb.Save(customerAccount.Id, customerAccount);

                        this.ActionCommitted = true;
                    }
                    catch (Exception ex)
                    {
                        this.ActionCommitted = false;
                    }
                    finally
                    {
                        Close();
                    }
                }
                else
                {
                    try
                    {
                        var fetchedCustomerAccount = GetCustomerAccount();
                        if (fetchedCustomerAccount != null)
                        {
                            var customerAccount = fetchedCustomerAccount as CongTy;
                            customerAccount.TenCongTy = TxtCustomerName.Text.Trim();
                            customerAccount.DiaChi1 = TxtAddress1.Text.Trim();
                            customerAccount.DiaChi2 = TxtAddress2.Text.Trim();
                            customerAccount.QuanHuyen = TxtCity.Text.Trim();
                            customerAccount.State = CbState.Text;
                            customerAccount.MaBuuChinh = TxtZipCode.Text.Trim();
                            customerAccount.HangKhachHang = CbAccountLevel.Text;

                            Globals.RaptorDb.Save(customerAccount.Id, customerAccount);

                            this.ActionCommitted = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        this.ActionCommitted = false;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Initializes the UI with labels and data based on the current action
        /// </summary>
        private void InitializeFormData()
        {
            //Bind the account level settings
            foreach (HangKhachHang accountLevel in Enum.GetValues(typeof(HangKhachHang)))
            {
                CbAccountLevel.Items.Add(accountLevel.ToString());
            }

            if (_manageAction == ManageAction.Add)
            {
                //Set up the button text
                BtnAction.Text = "Add";

                //Set up the form header text
                this.Text = "Add Customer Account - Using RaptorDb";

                //Set up the state drop-down
                CbState.Text = CbState.Items[0].ToString();

                //Set up the account level drop-down
                CbAccountLevel.Text = CbAccountLevel.Items[0].ToString();
            }
            else
            {
                //Set up the button text
                BtnAction.Text = "Update";

                //Set up the form header text
                this.Text = "Update Customer Account - Using RaptorDb";

                //Use Raptor to look up the document by id and populate the form data
                var fetchedCustomerAccount = GetCustomerAccount();
                if (fetchedCustomerAccount != null)
                {
                    try
                    {
                        var customerAccount = fetchedCustomerAccount as CongTy;
                        TxtCustomerName.Text = customerAccount.TenCongTy;
                        TxtAddress1.Text = customerAccount.DiaChi1;
                        TxtAddress2.Text = customerAccount.DiaChi2;
                        TxtCity.Text = customerAccount.QuanHuyen;
                        CbState.Text = customerAccount.State;
                        TxtZipCode.Text = customerAccount.MaBuuChinh;
                        CbAccountLevel.Text = customerAccount.HangKhachHang;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the document. Error: " + ex.ToString());
                    }
                }
            }
        }

        private object GetCustomerAccount()
        {
            return Globals.RaptorDb.Fetch(_customerId);
        }

        /// <summary>
        /// Ensures that all UI fields have been provided before submitting data to RaptorDb
        /// </summary>
        /// <returns></returns>
        private bool ValidateUi()
        {
            //Customer name is required
            RequiredCustomerName.Visible = String.IsNullOrEmpty(TxtCustomerName.Text);

            //Address 1 is required
            RequiredAddress1.Visible = String.IsNullOrEmpty(TxtAddress1.Text);

            //City is required
            RequiredCity.Visible = String.IsNullOrEmpty(TxtCity.Text);

            //Zip code is required
            RequiredZipCode.Visible = String.IsNullOrEmpty(TxtZipCode.Text);

            return !RequiredCustomerName.Visible && !RequiredAddress1.Visible && !RequiredCity.Visible && !RequiredZipCode.Visible;
        }
    }
}
