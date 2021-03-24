
namespace Ayubo_Programming_Assignment
{
    partial class frmHome
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
            this.btnRent = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(212, 189);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(171, 76);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(85, 88);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(171, 76);
            this.btnVehicle.TabIndex = 0;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(307, 88);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(171, 76);
            this.btnPackage.TabIndex = 0;
            this.btnPackage.Text = "Package";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(444, 189);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(171, 76);
            this.btnTour.TabIndex = 0;
            this.btnTour.Text = "Tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 76);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnRent);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnExit;
    }
}