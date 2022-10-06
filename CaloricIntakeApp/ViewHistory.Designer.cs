﻿namespace CaloricIntakeApp
{
    partial class ViewHistory
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
            this.dGridViewHistory = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblLTtotal = new System.Windows.Forms.Label();
            this.lblLTaverage = new System.Windows.Forms.Label();
            this.lblLThigh = new System.Windows.Forms.Label();
            this.lblLTlow = new System.Windows.Forms.Label();
            this.lblLTtotalvalue = new System.Windows.Forms.Label();
            this.lblLTaveragevalue = new System.Windows.Forms.Label();
            this.lblLThighvalue = new System.Windows.Forms.Label();
            this.lblLTlowvalue = new System.Windows.Forms.Label();
            this.lblTDtotal = new System.Windows.Forms.Label();
            this.lblTDaverage = new System.Windows.Forms.Label();
            this.lblTDhigh = new System.Windows.Forms.Label();
            this.lblTDlow = new System.Windows.Forms.Label();
            this.lblTDtotalvalue = new System.Windows.Forms.Label();
            this.lblTDaveragevalue = new System.Windows.Forms.Label();
            this.lblTDhighvalue = new System.Windows.Forms.Label();
            this.lblTDlowvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridViewHistory
            // 
            this.dGridViewHistory.AllowUserToAddRows = false;
            this.dGridViewHistory.AllowUserToDeleteRows = false;
            this.dGridViewHistory.AllowUserToResizeColumns = false;
            this.dGridViewHistory.AllowUserToResizeRows = false;
            this.dGridViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Calories});
            this.dGridViewHistory.Location = new System.Drawing.Point(318, 12);
            this.dGridViewHistory.Name = "dGridViewHistory";
            this.dGridViewHistory.Size = new System.Drawing.Size(265, 252);
            this.dGridViewHistory.TabIndex = 0;
            this.dGridViewHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewHistory_CellClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Calories
            // 
            this.Calories.HeaderText = "Calories";
            this.Calories.Name = "Calories";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(67, 9);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(91, 24);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Summary";
            // 
            // lblLTtotal
            // 
            this.lblLTtotal.AutoSize = true;
            this.lblLTtotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTtotal.Location = new System.Drawing.Point(26, 53);
            this.lblLTtotal.Name = "lblLTtotal";
            this.lblLTtotal.Size = new System.Drawing.Size(110, 22);
            this.lblLTtotal.TabIndex = 2;
            this.lblLTtotal.Text = "Lifetime Total";
            // 
            // lblLTaverage
            // 
            this.lblLTaverage.AutoSize = true;
            this.lblLTaverage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTaverage.Location = new System.Drawing.Point(26, 75);
            this.lblLTaverage.Name = "lblLTaverage";
            this.lblLTaverage.Size = new System.Drawing.Size(132, 22);
            this.lblLTaverage.TabIndex = 3;
            this.lblLTaverage.Text = "Lifetime Average";
            // 
            // lblLThigh
            // 
            this.lblLThigh.AutoSize = true;
            this.lblLThigh.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLThigh.Location = new System.Drawing.Point(26, 97);
            this.lblLThigh.Name = "lblLThigh";
            this.lblLThigh.Size = new System.Drawing.Size(129, 22);
            this.lblLThigh.TabIndex = 4;
            this.lblLThigh.Text = "Lifetime Highest";
            // 
            // lblLTlow
            // 
            this.lblLTlow.AutoSize = true;
            this.lblLTlow.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTlow.Location = new System.Drawing.Point(26, 119);
            this.lblLTlow.Name = "lblLTlow";
            this.lblLTlow.Size = new System.Drawing.Size(127, 22);
            this.lblLTlow.TabIndex = 5;
            this.lblLTlow.Text = "Lifetime Lowest";
            // 
            // lblLTtotalvalue
            // 
            this.lblLTtotalvalue.AutoSize = true;
            this.lblLTtotalvalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTtotalvalue.Location = new System.Drawing.Point(165, 53);
            this.lblLTtotalvalue.Name = "lblLTtotalvalue";
            this.lblLTtotalvalue.Size = new System.Drawing.Size(52, 22);
            this.lblLTtotalvalue.TabIndex = 6;
            this.lblLTtotalvalue.Text = "label1";
            // 
            // lblLTaveragevalue
            // 
            this.lblLTaveragevalue.AutoSize = true;
            this.lblLTaveragevalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTaveragevalue.Location = new System.Drawing.Point(165, 75);
            this.lblLTaveragevalue.Name = "lblLTaveragevalue";
            this.lblLTaveragevalue.Size = new System.Drawing.Size(52, 22);
            this.lblLTaveragevalue.TabIndex = 7;
            this.lblLTaveragevalue.Text = "label2";
            // 
            // lblLThighvalue
            // 
            this.lblLThighvalue.AutoSize = true;
            this.lblLThighvalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLThighvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLThighvalue.Location = new System.Drawing.Point(165, 97);
            this.lblLThighvalue.Name = "lblLThighvalue";
            this.lblLThighvalue.Size = new System.Drawing.Size(52, 22);
            this.lblLThighvalue.TabIndex = 8;
            this.lblLThighvalue.Text = "label3";
            // 
            // lblLTlowvalue
            // 
            this.lblLTlowvalue.AutoSize = true;
            this.lblLTlowvalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTlowvalue.ForeColor = System.Drawing.Color.Green;
            this.lblLTlowvalue.Location = new System.Drawing.Point(165, 119);
            this.lblLTlowvalue.Name = "lblLTlowvalue";
            this.lblLTlowvalue.Size = new System.Drawing.Size(52, 22);
            this.lblLTlowvalue.TabIndex = 9;
            this.lblLTlowvalue.Text = "label4";
            // 
            // lblTDtotal
            // 
            this.lblTDtotal.AutoSize = true;
            this.lblTDtotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDtotal.Location = new System.Drawing.Point(34, 165);
            this.lblTDtotal.Name = "lblTDtotal";
            this.lblTDtotal.Size = new System.Drawing.Size(97, 22);
            this.lblTDtotal.TabIndex = 10;
            this.lblTDtotal.Text = "10-Day Total";
            // 
            // lblTDaverage
            // 
            this.lblTDaverage.AutoSize = true;
            this.lblTDaverage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDaverage.Location = new System.Drawing.Point(34, 187);
            this.lblTDaverage.Name = "lblTDaverage";
            this.lblTDaverage.Size = new System.Drawing.Size(119, 22);
            this.lblTDaverage.TabIndex = 11;
            this.lblTDaverage.Text = "10-Day Average";
            // 
            // lblTDhigh
            // 
            this.lblTDhigh.AutoSize = true;
            this.lblTDhigh.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDhigh.Location = new System.Drawing.Point(34, 209);
            this.lblTDhigh.Name = "lblTDhigh";
            this.lblTDhigh.Size = new System.Drawing.Size(116, 22);
            this.lblTDhigh.TabIndex = 12;
            this.lblTDhigh.Text = "10-Day Highest";
            // 
            // lblTDlow
            // 
            this.lblTDlow.AutoSize = true;
            this.lblTDlow.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDlow.Location = new System.Drawing.Point(34, 231);
            this.lblTDlow.Name = "lblTDlow";
            this.lblTDlow.Size = new System.Drawing.Size(114, 22);
            this.lblTDlow.TabIndex = 13;
            this.lblTDlow.Text = "10-Day Lowest";
            // 
            // lblTDtotalvalue
            // 
            this.lblTDtotalvalue.AutoSize = true;
            this.lblTDtotalvalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDtotalvalue.Location = new System.Drawing.Point(165, 165);
            this.lblTDtotalvalue.Name = "lblTDtotalvalue";
            this.lblTDtotalvalue.Size = new System.Drawing.Size(52, 22);
            this.lblTDtotalvalue.TabIndex = 14;
            this.lblTDtotalvalue.Text = "label1";
            // 
            // lblTDaveragevalue
            // 
            this.lblTDaveragevalue.AutoSize = true;
            this.lblTDaveragevalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDaveragevalue.Location = new System.Drawing.Point(165, 187);
            this.lblTDaveragevalue.Name = "lblTDaveragevalue";
            this.lblTDaveragevalue.Size = new System.Drawing.Size(52, 22);
            this.lblTDaveragevalue.TabIndex = 15;
            this.lblTDaveragevalue.Text = "label1";
            // 
            // lblTDhighvalue
            // 
            this.lblTDhighvalue.AutoSize = true;
            this.lblTDhighvalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDhighvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTDhighvalue.Location = new System.Drawing.Point(165, 209);
            this.lblTDhighvalue.Name = "lblTDhighvalue";
            this.lblTDhighvalue.Size = new System.Drawing.Size(52, 22);
            this.lblTDhighvalue.TabIndex = 16;
            this.lblTDhighvalue.Text = "label1";
            // 
            // lblTDlowvalue
            // 
            this.lblTDlowvalue.AutoSize = true;
            this.lblTDlowvalue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDlowvalue.ForeColor = System.Drawing.Color.Green;
            this.lblTDlowvalue.Location = new System.Drawing.Point(165, 231);
            this.lblTDlowvalue.Name = "lblTDlowvalue";
            this.lblTDlowvalue.Size = new System.Drawing.Size(52, 22);
            this.lblTDlowvalue.TabIndex = 17;
            this.lblTDlowvalue.Text = "label1";
            // 
            // ViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 278);
            this.Controls.Add(this.lblTDlowvalue);
            this.Controls.Add(this.lblTDhighvalue);
            this.Controls.Add(this.lblTDaveragevalue);
            this.Controls.Add(this.lblTDtotalvalue);
            this.Controls.Add(this.lblTDlow);
            this.Controls.Add(this.lblTDhigh);
            this.Controls.Add(this.lblTDaverage);
            this.Controls.Add(this.lblTDtotal);
            this.Controls.Add(this.lblLTlowvalue);
            this.Controls.Add(this.lblLThighvalue);
            this.Controls.Add(this.lblLTaveragevalue);
            this.Controls.Add(this.lblLTtotalvalue);
            this.Controls.Add(this.lblLTlow);
            this.Controls.Add(this.lblLThigh);
            this.Controls.Add(this.lblLTaverage);
            this.Controls.Add(this.lblLTtotal);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.dGridViewHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewHistory_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblLTtotal;
        private System.Windows.Forms.Label lblLTaverage;
        private System.Windows.Forms.Label lblLThigh;
        private System.Windows.Forms.Label lblLTlow;
        private System.Windows.Forms.Label lblLTtotalvalue;
        private System.Windows.Forms.Label lblLTaveragevalue;
        private System.Windows.Forms.Label lblLThighvalue;
        private System.Windows.Forms.Label lblLTlowvalue;
        private System.Windows.Forms.Label lblTDtotal;
        private System.Windows.Forms.Label lblTDaverage;
        private System.Windows.Forms.Label lblTDhigh;
        private System.Windows.Forms.Label lblTDlow;
        private System.Windows.Forms.Label lblTDtotalvalue;
        private System.Windows.Forms.Label lblTDaveragevalue;
        private System.Windows.Forms.Label lblTDhighvalue;
        private System.Windows.Forms.Label lblTDlowvalue;
    }
}