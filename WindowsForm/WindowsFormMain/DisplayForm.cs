﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormMain
{
    class DisplayForm : Form
    {
        private Label label1;

        public DisplayForm()
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DisplayForm
            // 
            this.ClientSize = new System.Drawing.Size(546, 253);
            this.Controls.Add(this.label1);
            this.Name = "DisplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
