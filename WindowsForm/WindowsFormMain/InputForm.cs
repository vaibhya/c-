using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormMain
{
    class InputForm : Form
    {
        private TextBox InputTextField;
        private Button SubmitBtn;
        private Label label1;

        public InputForm()
        {
            this.Text = "Input Frame";

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextField = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputTextField
            // 
            this.InputTextField.Location = new System.Drawing.Point(265, 94);
            this.InputTextField.Name = "InputTextField";
            this.InputTextField.Size = new System.Drawing.Size(136, 22);
            this.InputTextField.TabIndex = 1;
            this.InputTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(242, 166);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.ClientSize = new System.Drawing.Size(580, 315);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.InputTextField);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
