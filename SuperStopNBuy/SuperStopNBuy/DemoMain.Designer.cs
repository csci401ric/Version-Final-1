/********************************
 * DemoMain.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class DemoMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoMain));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWelcome.Location = new System.Drawing.Point(190, 82);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(125, 28);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome To";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Onyx", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(146, 71);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(459, 107);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Super Stop \'N Buy";
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMain.Location = new System.Drawing.Point(422, 167);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(126, 18);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Demo Application";
            // 
            // buttonStore
            // 
            this.buttonStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStore.Location = new System.Drawing.Point(164, 269);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(185, 36);
            this.buttonStore.TabIndex = 1;
            this.buttonStore.Text = "Store Application";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManagement.Location = new System.Drawing.Point(363, 269);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(208, 36);
            this.buttonManagement.TabIndex = 2;
            this.buttonManagement.Text = "Management Application";
            this.buttonManagement.UseVisualStyleBackColor = true;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // DemoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperStopNBuy.Properties.Resources.demoBackground;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonManagement);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DemoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonManagement;
    }
}

