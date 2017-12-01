namespace CustomerAccountsUsingRaptorDb
{
    partial class FrmManageCustomerAccount
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
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequiredZipCode = new System.Windows.Forms.Label();
            this.RequiredCity = new System.Windows.Forms.Label();
            this.RequiredAddress1 = new System.Windows.Forms.Label();
            this.RequiredCustomerName = new System.Windows.Forms.Label();
            this.CbAccountLevel = new System.Windows.Forms.ComboBox();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.CbState = new System.Windows.Forms.ComboBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAction
            // 
            this.BtnAction.Location = new System.Drawing.Point(343, 264);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(75, 29);
            this.BtnAction.TabIndex = 0;
            this.BtnAction.Text = "Action";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(424, 264);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 29);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RequiredZipCode);
            this.groupBox1.Controls.Add(this.RequiredCity);
            this.groupBox1.Controls.Add(this.RequiredAddress1);
            this.groupBox1.Controls.Add(this.RequiredCustomerName);
            this.groupBox1.Controls.Add(this.CbAccountLevel);
            this.groupBox1.Controls.Add(this.TxtZipCode);
            this.groupBox1.Controls.Add(this.CbState);
            this.groupBox1.Controls.Add(this.TxtCity);
            this.groupBox1.Controls.Add(this.TxtAddress2);
            this.groupBox1.Controls.Add(this.TxtAddress1);
            this.groupBox1.Controls.Add(this.TxtCustomerName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // RequiredZipCode
            // 
            this.RequiredZipCode.AutoSize = true;
            this.RequiredZipCode.ForeColor = System.Drawing.Color.Red;
            this.RequiredZipCode.Location = new System.Drawing.Point(244, 176);
            this.RequiredZipCode.Name = "RequiredZipCode";
            this.RequiredZipCode.Size = new System.Drawing.Size(14, 18);
            this.RequiredZipCode.TabIndex = 17;
            this.RequiredZipCode.Text = "*";
            this.RequiredZipCode.Visible = false;
            // 
            // RequiredCity
            // 
            this.RequiredCity.AutoSize = true;
            this.RequiredCity.ForeColor = System.Drawing.Color.Red;
            this.RequiredCity.Location = new System.Drawing.Point(402, 118);
            this.RequiredCity.Name = "RequiredCity";
            this.RequiredCity.Size = new System.Drawing.Size(14, 18);
            this.RequiredCity.TabIndex = 16;
            this.RequiredCity.Text = "*";
            this.RequiredCity.Visible = false;
            // 
            // RequiredAddress1
            // 
            this.RequiredAddress1.AutoSize = true;
            this.RequiredAddress1.ForeColor = System.Drawing.Color.Red;
            this.RequiredAddress1.Location = new System.Drawing.Point(402, 60);
            this.RequiredAddress1.Name = "RequiredAddress1";
            this.RequiredAddress1.Size = new System.Drawing.Size(14, 18);
            this.RequiredAddress1.TabIndex = 15;
            this.RequiredAddress1.Text = "*";
            this.RequiredAddress1.Visible = false;
            // 
            // RequiredCustomerName
            // 
            this.RequiredCustomerName.AutoSize = true;
            this.RequiredCustomerName.ForeColor = System.Drawing.Color.Red;
            this.RequiredCustomerName.Location = new System.Drawing.Point(402, 31);
            this.RequiredCustomerName.Name = "RequiredCustomerName";
            this.RequiredCustomerName.Size = new System.Drawing.Size(14, 18);
            this.RequiredCustomerName.TabIndex = 14;
            this.RequiredCustomerName.Text = "*";
            this.RequiredCustomerName.Visible = false;
            // 
            // CbAccountLevel
            // 
            this.CbAccountLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAccountLevel.FormattingEnabled = true;
            this.CbAccountLevel.Location = new System.Drawing.Point(143, 202);
            this.CbAccountLevel.Name = "CbAccountLevel";
            this.CbAccountLevel.Size = new System.Drawing.Size(257, 26);
            this.CbAccountLevel.TabIndex = 13;
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(143, 173);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(99, 24);
            this.TxtZipCode.TabIndex = 12;
            // 
            // CbState
            // 
            this.CbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbState.FormattingEnabled = true;
            this.CbState.Items.AddRange(new object[] {
            "MA",
            "MD",
            "ME",
            "NH",
            "NY",
            "PA",
            "VT",
            ""});
            this.CbState.Location = new System.Drawing.Point(143, 144);
            this.CbState.Name = "CbState";
            this.CbState.Size = new System.Drawing.Size(99, 26);
            this.CbState.TabIndex = 11;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(143, 115);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(257, 24);
            this.TxtCity.TabIndex = 10;
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Location = new System.Drawing.Point(143, 86);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(257, 24);
            this.TxtAddress2.TabIndex = 9;
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Location = new System.Drawing.Point(143, 57);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(257, 24);
            this.TxtAddress1.TabIndex = 8;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(143, 28);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(257, 24);
            this.TxtCustomerName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Account Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address 1";
            // 
            // FrmManageCustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmManageCustomerAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customer Account - Using RaptorDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbAccountLevel;
        private System.Windows.Forms.TextBox TxtZipCode;
        private System.Windows.Forms.ComboBox CbState;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label RequiredZipCode;
        private System.Windows.Forms.Label RequiredCity;
        private System.Windows.Forms.Label RequiredAddress1;
        private System.Windows.Forms.Label RequiredCustomerName;
    }
}