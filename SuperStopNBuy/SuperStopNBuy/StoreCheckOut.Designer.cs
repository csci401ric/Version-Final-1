namespace SuperStopNBuy
{
    partial class StoreCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreCheckOut));
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCCN = new System.Windows.Forms.Label();
            this.labelCCV = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelCardType = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCCN = new System.Windows.Forms.TextBox();
            this.textBoxCCV = new System.Windows.Forms.TextBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.labelLogo.Location = new System.Drawing.Point(229, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(296, 72);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Super Stop \'N Buy";
            this.labelLogo.Click += new System.EventHandler(this.labelLogo_Click);
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.BackColor = System.Drawing.Color.Transparent;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(49, 174);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(86, 20);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "First Name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.BackColor = System.Drawing.Color.Transparent;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(49, 205);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(86, 20);
            this.labelLName.TabIndex = 0;
            this.labelLName.Text = "Last Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(87, 238);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(67, 270);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // labelCCN
            // 
            this.labelCCN.AutoSize = true;
            this.labelCCN.BackColor = System.Drawing.Color.Transparent;
            this.labelCCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCN.Location = new System.Drawing.Point(301, 174);
            this.labelCCN.Name = "labelCCN";
            this.labelCCN.Size = new System.Drawing.Size(149, 20);
            this.labelCCN.TabIndex = 0;
            this.labelCCN.Text = "Credit Card Number";
            // 
            // labelCCV
            // 
            this.labelCCV.AutoSize = true;
            this.labelCCV.BackColor = System.Drawing.Color.Transparent;
            this.labelCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCV.Location = new System.Drawing.Point(354, 205);
            this.labelCCV.Name = "labelCCV";
            this.labelCCV.Size = new System.Drawing.Size(92, 20);
            this.labelCCV.TabIndex = 0;
            this.labelCCV.Text = "3-Digit CCV";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Mastercard",
            "Visa",
            "American Express",
            "Discover",
            "Other"});
            this.comboBoxType.Location = new System.Drawing.Point(452, 269);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxType.TabIndex = 8;
            // 
            // labelCardType
            // 
            this.labelCardType.AutoSize = true;
            this.labelCardType.BackColor = System.Drawing.Color.Transparent;
            this.labelCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardType.Location = new System.Drawing.Point(365, 270);
            this.labelCardType.Name = "labelCardType";
            this.labelCardType.Size = new System.Drawing.Size(81, 20);
            this.labelCardType.TabIndex = 0;
            this.labelCardType.Text = "Card Type";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(367, 238);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Exp. Date";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(141, 175);
            this.textBoxFName.MaxLength = 32;
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(120, 20);
            this.textBoxFName.TabIndex = 1;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(141, 206);
            this.textBoxLName.MaxLength = 32;
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(120, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(141, 238);
            this.textBoxEmail.MaxLength = 32;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(141, 270);
            this.textBoxAddress.MaxLength = 32;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(120, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxCCN
            // 
            this.textBoxCCN.Location = new System.Drawing.Point(452, 175);
            this.textBoxCCN.MaxLength = 16;
            this.textBoxCCN.Name = "textBoxCCN";
            this.textBoxCCN.Size = new System.Drawing.Size(120, 20);
            this.textBoxCCN.TabIndex = 5;
            // 
            // textBoxCCV
            // 
            this.textBoxCCV.Location = new System.Drawing.Point(452, 206);
            this.textBoxCCV.MaxLength = 3;
            this.textBoxCCV.Name = "textBoxCCV";
            this.textBoxCCV.Size = new System.Drawing.Size(120, 20);
            this.textBoxCCV.TabIndex = 6;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCheckout.FlatAppearance.BorderSize = 0;
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonCheckout.Location = new System.Drawing.Point(249, 323);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(256, 95);
            this.buttonCheckout.TabIndex = 9;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(616, 221);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(82, 54);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(452, 238);
            this.dateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2018, 4, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 72);
            this.label3.TabIndex = 0;
            this.label3.Text = "Checkout";
            // 
            // StoreCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperStopNBuy.Properties.Resources.mainBackground;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.textBoxCCV);
            this.Controls.Add(this.textBoxCCN);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCardType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelCCV);
            this.Controls.Add(this.labelCCN);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StoreCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.Load += new System.EventHandler(this.StoreCheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCCN;
        private System.Windows.Forms.Label labelCCV;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelCardType;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCCN;
        private System.Windows.Forms.TextBox textBoxCCV;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
    }
}