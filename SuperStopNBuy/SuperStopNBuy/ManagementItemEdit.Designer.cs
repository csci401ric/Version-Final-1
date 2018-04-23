/********************************
 * ManagementItemEdit.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class ManagementItemEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementItemEdit));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textboxNumber = new System.Windows.Forms.TextBox();
            this.textboxPrice = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pictureBoxImport = new System.Windows.Forms.PictureBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImport)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(21, 21);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonSubmit.Location = new System.Drawing.Point(249, 323);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(256, 95);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Save And Submit ";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textboxNumber
            // 
            this.textboxNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textboxNumber.Location = new System.Drawing.Point(511, 215);
            this.textboxNumber.MaxLength = 6;
            this.textboxNumber.Name = "textboxNumber";
            this.textboxNumber.ReadOnly = true;
            this.textboxNumber.Size = new System.Drawing.Size(197, 20);
            this.textboxNumber.TabIndex = 3;
            // 
            // textboxPrice
            // 
            this.textboxPrice.Location = new System.Drawing.Point(511, 174);
            this.textboxPrice.MaxLength = 8;
            this.textboxPrice.Name = "textboxPrice";
            this.textboxPrice.Size = new System.Drawing.Size(197, 20);
            this.textboxPrice.TabIndex = 2;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(511, 131);
            this.textboxName.MaxLength = 32;
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(197, 20);
            this.textboxName.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelNumber.Location = new System.Drawing.Point(355, 211);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(149, 24);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Product Number";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(381, 170);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(123, 24);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Product Price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(373, 127);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Product Name";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit.Font = new System.Drawing.Font("Onyx", 48F);
            this.labelEdit.Location = new System.Drawing.Point(291, 21);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(172, 72);
            this.labelEdit.TabIndex = 0;
            this.labelEdit.Text = "Edit Item";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(349, 254);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(155, 24);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Product Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "grocery",
            "meat/deli",
            "frozen",
            "bakery",
            "produce",
            "dairy"});
            this.comboBoxCategory.Location = new System.Drawing.Point(511, 257);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(197, 21);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // pictureBoxImport
            // 
            this.pictureBoxImport.Location = new System.Drawing.Point(162, 131);
            this.pictureBoxImport.Name = "pictureBoxImport";
            this.pictureBoxImport.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImport.TabIndex = 25;
            this.pictureBoxImport.TabStop = false;
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonImport.Location = new System.Drawing.Point(21, 160);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(116, 75);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "Import Picture";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.DefaultExt = "png";
            this.openFileDialogImport.Filter = "Image Files|*.png";
            // 
            // ManagementItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperStopNBuy.Properties.Resources.managementBackground;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.pictureBoxImport);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textboxNumber);
            this.Controls.Add(this.textboxPrice);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagementItemEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.Load += new System.EventHandler(this.ManagementItemEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textboxNumber;
        private System.Windows.Forms.TextBox textboxPrice;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox pictureBoxImport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
    }
}