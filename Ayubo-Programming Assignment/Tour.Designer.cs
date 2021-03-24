
namespace Ayubo_Programming_Assignment
{
    partial class frmTour
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
            this.btnLong = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLong
            // 
            this.btnLong.Location = new System.Drawing.Point(404, 140);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(171, 76);
            this.btnLong.TabIndex = 2;
            this.btnLong.Text = "Long Tour";
            this.btnLong.UseVisualStyleBackColor = true;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(170, 140);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(171, 76);
            this.btnDay.TabIndex = 3;
            this.btnDay.Text = "Day Tour";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(250, 296);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 76);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 76);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnDay);
            this.Name = "frmTour";
            this.Text = "Tour";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}