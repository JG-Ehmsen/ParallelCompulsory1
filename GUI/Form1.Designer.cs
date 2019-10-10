using System;

namespace GUI
{
    partial class Form1
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
            this.listResults = new System.Windows.Forms.ListView();
            this.btnRunSeq = new System.Windows.Forms.Button();
            this.btnRunPar = new System.Windows.Forms.Button();
            this.txtStartingNumber = new System.Windows.Forms.TextBox();
            this.txtEndingNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.Prime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listResults
            // 
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Prime});
            this.listResults.HideSelection = false;
            this.listResults.Location = new System.Drawing.Point(12, 12);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(253, 268);
            this.listResults.TabIndex = 0;
            this.listResults.UseCompatibleStateImageBehavior = false;
            // 
            // btnRunSeq
            // 
            this.btnRunSeq.Location = new System.Drawing.Point(12, 326);
            this.btnRunSeq.Name = "btnRunSeq";
            this.btnRunSeq.Size = new System.Drawing.Size(253, 23);
            this.btnRunSeq.TabIndex = 1;
            this.btnRunSeq.Text = "Sequential";
            this.btnRunSeq.UseVisualStyleBackColor = true;
            this.btnRunSeq.Click += new System.EventHandler(this.btnRunSeq_Click);
            // 
            // btnRunPar
            // 
            this.btnRunPar.Location = new System.Drawing.Point(13, 355);
            this.btnRunPar.Name = "btnRunPar";
            this.btnRunPar.Size = new System.Drawing.Size(252, 23);
            this.btnRunPar.TabIndex = 2;
            this.btnRunPar.Text = "Parallel";
            this.btnRunPar.UseVisualStyleBackColor = true;
            this.btnRunPar.Click += new System.EventHandler(this.btnRunPar_Click);
            // 
            // txtStartingNumber
            // 
            this.txtStartingNumber.Location = new System.Drawing.Point(13, 302);
            this.txtStartingNumber.Name = "txtStartingNumber";
            this.txtStartingNumber.Size = new System.Drawing.Size(120, 20);
            this.txtStartingNumber.TabIndex = 3;
            // 
            // txtEndingNumber
            // 
            this.txtEndingNumber.Location = new System.Drawing.Point(144, 301);
            this.txtEndingNumber.Name = "txtEndingNumber";
            this.txtEndingNumber.Size = new System.Drawing.Size(121, 20);
            this.txtEndingNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Starting Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duration: ";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(76, 384);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(46, 13);
            this.lblElapsedTime.TabIndex = 8;
            this.lblElapsedTime.Text = "0.00000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 412);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndingNumber);
            this.Controls.Add(this.txtStartingNumber);
            this.Controls.Add(this.btnRunPar);
            this.Controls.Add(this.btnRunSeq);
            this.Controls.Add(this.listResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.Button btnRunSeq;
        private System.Windows.Forms.Button btnRunPar;
        private System.Windows.Forms.TextBox txtStartingNumber;
        private System.Windows.Forms.TextBox txtEndingNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.ColumnHeader Prime;
    }
}

