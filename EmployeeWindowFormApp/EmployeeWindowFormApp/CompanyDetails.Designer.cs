
using System;

namespace EmployeeWindowFormApp
{
    partial class CompanyDetails
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
            this.empBtn = new System.Windows.Forms.Button();
            this.deptBtn = new System.Windows.Forms.Button();
            this.empGridView = new System.Windows.Forms.DataGridView();
            this.deptGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empBtn
            // 
            this.empBtn.Location = new System.Drawing.Point(151, 52);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(101, 47);
            this.empBtn.TabIndex = 0;
            this.empBtn.Text = "Show Emp";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // deptBtn
            // 
            this.deptBtn.Location = new System.Drawing.Point(514, 52);
            this.deptBtn.Name = "deptBtn";
            this.deptBtn.Size = new System.Drawing.Size(111, 47);
            this.deptBtn.TabIndex = 1;
            this.deptBtn.Text = "Show Dept";
            this.deptBtn.UseVisualStyleBackColor = true;
            this.deptBtn.Click += new System.EventHandler(this.DeptBtn_Click);
            // 
            // empGridView
            // 
            this.empGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGridView.Location = new System.Drawing.Point(21, 170);
            this.empGridView.Name = "empGridView";
            this.empGridView.RowHeadersWidth = 51;
            this.empGridView.RowTemplate.Height = 24;
            this.empGridView.Size = new System.Drawing.Size(332, 246);
            this.empGridView.TabIndex = 2;
            // 
            // deptGridView
            // 
            this.deptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptGridView.Location = new System.Drawing.Point(415, 170);
            this.deptGridView.Name = "deptGridView";
            this.deptGridView.RowHeadersWidth = 51;
            this.deptGridView.RowTemplate.Height = 24;
            this.deptGridView.Size = new System.Drawing.Size(348, 246);
            this.deptGridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deptGridView);
            this.Controls.Add(this.empGridView);
            this.Controls.Add(this.deptBtn);
            this.Controls.Add(this.empBtn);
            this.Name = "Form1";
            this.Text = "Company Details";
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptGridView)).EndInit();
            this.ResumeLayout(false);
            
        }


        #endregion

        private System.Windows.Forms.Button empBtn;
        private System.Windows.Forms.Button deptBtn;
        private System.Windows.Forms.DataGridView empGridView;
        private System.Windows.Forms.DataGridView deptGridView;
    }
}

