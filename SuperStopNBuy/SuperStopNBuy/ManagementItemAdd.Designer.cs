/********************************
 * ManagementItemAdd.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class ManagementItemAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementItemAdd));
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textboxNumber = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.pictureBoxImport = new System.Windows.Forms.PictureBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxPrice = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.BackColor = System.Drawing.Color.Transparent;
            this.labelAdd.Font = new System.Drawing.Font("Onyx", 48F);
            this.labelAdd.Location = new System.Drawing.Point(291, 21);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(164, 72);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Add Item";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(355, 211);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(149, 24);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Product Number";
            // 
            // textboxNumber
            // 
            this.textboxNumber.Location = new System.Drawing.Point(511, 215);
            this.textboxNumber.MaxLength = 6;
            this.textboxNumber.Name = "textboxNumber";
            this.textboxNumber.Size = new System.Drawing.Size(197, 20);
            this.textboxNumber.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonSubmit.Location = new System.Drawing.Point(249, 323);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(256, 95);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Save And Submit ";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            // pictureBoxImport
            // 
            this.pictureBoxImport.Location = new System.Drawing.Point(162, 131);
            this.pictureBoxImport.Name = "pictureBoxImport";
            this.pictureBoxImport.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImport.TabIndex = 35;
            this.pictureBoxImport.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Category";
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
            // openFileDialogImport
            // 
            this.openFileDialogImport.DefaultExt = "png";
            this.openFileDialogImport.Filter = "Image Files|*.png";
            // 
            // ManagementItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperStopNBuy.Properties.Resources.managementBackground;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.pictureBoxImport);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxPrice);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textboxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagementItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textboxNumber;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.PictureBox pictureBoxImport;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxPrice;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
    }
}