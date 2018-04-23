namespace SuperStopNBuy
{
    partial class StoreCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreCart));
            this.labelCart = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.buttonShopMoar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.BackColor = System.Drawing.Color.Transparent;
            this.labelCart.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCart.Location = new System.Drawing.Point(293, 12);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(148, 72);
            this.labelCart.TabIndex = 0;
            this.labelCart.Text = "My Cart";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.buttonCheckout.FlatAppearance.BorderSize = 0;
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonCheckout.Location = new System.Drawing.Point(577, 199);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(145, 53);
            this.buttonCheckout.TabIndex = 1;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Onyx", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.labelLogo.Location = new System.Drawing.Point(12, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(169, 39);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Super Stop \'N Buy";
            this.labelLogo.Click += new System.EventHandler(this.labelLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(668, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.labelPrice.Font = new System.Drawing.Font("Onyx", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(577, 124);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 72);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "$ ";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(0, 200);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(145, 27);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.buttonClearCart.FlatAppearance.BorderSize = 0;
            this.buttonClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearCart.ForeColor = System.Drawing.Color.White;
            this.buttonClearCart.Location = new System.Drawing.Point(0, 229);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(145, 27);
            this.buttonClearCart.TabIndex = 4;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = false;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // buttonShopMoar
            // 
            this.buttonShopMoar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.buttonShopMoar.FlatAppearance.BorderSize = 0;
            this.buttonShopMoar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShopMoar.ForeColor = System.Drawing.Color.White;
            this.buttonShopMoar.Location = new System.Drawing.Point(0, 171);
            this.buttonShopMoar.Name = "buttonShopMoar";
            this.buttonShopMoar.Size = new System.Drawing.Size(145, 27);
            this.buttonShopMoar.TabIndex = 2;
            this.buttonShopMoar.Text = "Back to Shopping";
            this.buttonShopMoar.UseVisualStyleBackColor = false;
            this.buttonShopMoar.Click += new System.EventHandler(this.buttonShopMoar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonShopMoar);
            this.panel1.Controls.Add(this.buttonClearCart);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Location = new System.Drawing.Point(577, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 266);
            this.panel1.TabIndex = 0;
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.AllowUserToDeleteRows = false;
            this.dataGridCart.AllowUserToResizeColumns = false;
            this.dataGridCart.AllowUserToResizeRows = false;
            this.dataGridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCart.Location = new System.Drawing.Point(171, 87);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCart.Size = new System.Drawing.Size(391, 362);
            this.dataGridCart.TabIndex = 0;
            this.dataGridCart.TabStop = false;
            this.dataGridCart.DataSourceChanged += new System.EventHandler(this.dataGridCart_DataSourceChanged);
            this.dataGridCart.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCart_CellMouseClick);
            // 
            // StoreCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperStopNBuy.Properties.Resources.mainBackground;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StoreCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.Load += new System.EventHandler(this.StoreCart_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button buttonShopMoar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCart;
    }
}