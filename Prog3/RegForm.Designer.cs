﻿namespace Prog2
{
    partial class RegForm
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
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.buttCalc = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.displayDateTime = new System.Windows.Forms.Label();
            this.creditHoursLbl = new System.Windows.Forms.Label();
            this.tBoxCreditHours = new System.Windows.Forms.TextBox();
            this.noteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(94, 12);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.tBoxLastName.TabIndex = 1;
            // 
            // buttCalc
            // 
            this.buttCalc.Location = new System.Drawing.Point(94, 92);
            this.buttCalc.Name = "buttCalc";
            this.buttCalc.Size = new System.Drawing.Size(99, 23);
            this.buttCalc.TabIndex = 5;
            this.buttCalc.Text = "Find Reg. Time";
            this.buttCalc.UseVisualStyleBackColor = true;
            this.buttCalc.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(29, 15);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Last name:";
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(66, 127);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(154, 13);
            this.RegLbl.TabIndex = 6;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // displayDateTime
            // 
            this.displayDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDateTime.Location = new System.Drawing.Point(13, 150);
            this.displayDateTime.Name = "displayDateTime";
            this.displayDateTime.Size = new System.Drawing.Size(263, 13);
            this.displayDateTime.TabIndex = 7;
            this.displayDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditHoursLbl
            // 
            this.creditHoursLbl.AutoSize = true;
            this.creditHoursLbl.Location = new System.Drawing.Point(20, 41);
            this.creditHoursLbl.Name = "creditHoursLbl";
            this.creditHoursLbl.Size = new System.Drawing.Size(68, 13);
            this.creditHoursLbl.TabIndex = 2;
            this.creditHoursLbl.Text = "Credit Hours:";
            // 
            // tBoxCreditHours
            // 
            this.tBoxCreditHours.Location = new System.Drawing.Point(94, 38);
            this.tBoxCreditHours.Name = "tBoxCreditHours";
            this.tBoxCreditHours.Size = new System.Drawing.Size(100, 20);
            this.tBoxCreditHours.TabIndex = 3;
            // 
            // noteLbl
            // 
            this.noteLbl.AutoSize = true;
            this.noteLbl.Location = new System.Drawing.Point(94, 65);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(129, 13);
            this.noteLbl.TabIndex = 4;
            this.noteLbl.Text = "Not including Spring 2018";
            // 
            // RegForm
            // 
            this.AcceptButton = this.buttCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.noteLbl);
            this.Controls.Add(this.creditHoursLbl);
            this.Controls.Add(this.tBoxCreditHours);
            this.Controls.Add(this.displayDateTime);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.buttCalc);
            this.Controls.Add(this.tBoxLastName);
            this.Name = "RegForm";
            this.Text = "Program 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Button buttCalc;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label displayDateTime;
        private System.Windows.Forms.Label creditHoursLbl;
        private System.Windows.Forms.TextBox tBoxCreditHours;
        private System.Windows.Forms.Label noteLbl;
    }
}

