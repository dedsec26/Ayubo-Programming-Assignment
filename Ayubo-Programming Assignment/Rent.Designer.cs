﻿
namespace Ayubo_Programming_Assignment
{
    partial class frmRent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtimeEnd = new System.Windows.Forms.DateTimePicker();
            this.txtNDays = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNMonths = new System.Windows.Forms.TextBox();
            this.txtTdays = new System.Windows.Forms.TextBox();
            this.txtNWeeks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboReg = new System.Windows.Forms.ComboBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkDrvr = new System.Windows.Forms.CheckBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number Of Days";
            // 
            // dtimeStart
            // 
            this.dtimeStart.Location = new System.Drawing.Point(152, 16);
            this.dtimeStart.Name = "dtimeStart";
            this.dtimeStart.Size = new System.Drawing.Size(200, 20);
            this.dtimeStart.TabIndex = 1;
            // 
            // dtimeEnd
            // 
            this.dtimeEnd.Location = new System.Drawing.Point(152, 45);
            this.dtimeEnd.Name = "dtimeEnd";
            this.dtimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dtimeEnd.TabIndex = 1;
            // 
            // txtNDays
            // 
            this.txtNDays.Location = new System.Drawing.Point(152, 71);
            this.txtNDays.Name = "txtNDays";
            this.txtNDays.Size = new System.Drawing.Size(100, 20);
            this.txtNDays.TabIndex = 2;
            this.txtNDays.TextChanged += new System.EventHandler(this.txtNDays_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.dtimeEnd);
            this.groupBox1.Controls.Add(this.txtNMonths);
            this.groupBox1.Controls.Add(this.txtTdays);
            this.groupBox1.Controls.Add(this.txtNWeeks);
            this.groupBox1.Controls.Add(this.txtNDays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtimeStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Days";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(121, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtNMonths
            // 
            this.txtNMonths.Location = new System.Drawing.Point(152, 123);
            this.txtNMonths.Name = "txtNMonths";
            this.txtNMonths.Size = new System.Drawing.Size(100, 20);
            this.txtNMonths.TabIndex = 2;
            this.txtNMonths.TextChanged += new System.EventHandler(this.txtNDays_TextChanged);
            // 
            // txtTdays
            // 
            this.txtTdays.Location = new System.Drawing.Point(152, 149);
            this.txtTdays.Name = "txtTdays";
            this.txtTdays.Size = new System.Drawing.Size(100, 20);
            this.txtTdays.TabIndex = 2;
            this.txtTdays.TextChanged += new System.EventHandler(this.txtNDays_TextChanged);
            // 
            // txtNWeeks
            // 
            this.txtNWeeks.Location = new System.Drawing.Point(152, 97);
            this.txtNWeeks.Name = "txtNWeeks";
            this.txtNWeeks.Size = new System.Drawing.Size(100, 20);
            this.txtNWeeks.TabIndex = 2;
            this.txtNWeeks.TextChanged += new System.EventHandler(this.txtNDays_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number Of Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number Of Weeks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Days";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboReg);
            this.groupBox2.Controls.Add(this.txtDriver);
            this.groupBox2.Controls.Add(this.txtMonth);
            this.groupBox2.Controls.Add(this.txtDay);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtWeek);
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnRetrieve);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 280);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboReg
            // 
            this.comboReg.FormattingEnabled = true;
            this.comboReg.Location = new System.Drawing.Point(171, 31);
            this.comboReg.Name = "comboReg";
            this.comboReg.Size = new System.Drawing.Size(102, 21);
            this.comboReg.TabIndex = 23;
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(171, 188);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(102, 20);
            this.txtDriver.TabIndex = 22;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(171, 162);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(102, 20);
            this.txtMonth.TabIndex = 21;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(171, 110);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(102, 20);
            this.txtDay.TabIndex = 20;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(171, 58);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(102, 20);
            this.txtModel.TabIndex = 19;
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(171, 136);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(102, 20);
            this.txtWeek.TabIndex = 18;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(171, 84);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(102, 20);
            this.txtType.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(171, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(45, 225);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(102, 23);
            this.btnRetrieve.TabIndex = 14;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Driver rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Month rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Day rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Week rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Registration Number";
            // 
            // chkDrvr
            // 
            this.chkDrvr.AutoSize = true;
            this.chkDrvr.Location = new System.Drawing.Point(21, 316);
            this.chkDrvr.Name = "chkDrvr";
            this.chkDrvr.Size = new System.Drawing.Size(77, 17);
            this.chkDrvr.TabIndex = 24;
            this.chkDrvr.Text = "With driver";
            this.chkDrvr.UseVisualStyleBackColor = true;
            this.chkDrvr.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(116, 312);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(167, 23);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Calculate Total Cost";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(300, 312);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(440, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 23);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(565, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 23);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 358);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkDrvr);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtimeStart;
        private System.Windows.Forms.DateTimePicker dtimeEnd;
        private System.Windows.Forms.TextBox txtNDays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNMonths;
        private System.Windows.Forms.TextBox txtNWeeks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTdays;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboReg;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkDrvr;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}