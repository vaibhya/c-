
namespace ContactAppUI
{
    partial class ContactAppUi
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
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.cAddress = new System.Windows.Forms.TextBox();
            this.addContactBtn = new System.Windows.Forms.Button();
            this.contactGridView = new System.Windows.Forms.DataGridView();
            this.displayContactBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Contact Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 4;
            // 
            // contactNo
            // 
            this.contactNo.Location = new System.Drawing.Point(362, 50);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(117, 22);
            this.contactNo.TabIndex = 5;
            // 
            // cAddress
            // 
            this.cAddress.Location = new System.Drawing.Point(603, 50);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(154, 22);
            this.cAddress.TabIndex = 6;
            // 
            // addContactBtn
            // 
            this.addContactBtn.Location = new System.Drawing.Point(306, 103);
            this.addContactBtn.Name = "addContactBtn";
            this.addContactBtn.Size = new System.Drawing.Size(140, 23);
            this.addContactBtn.TabIndex = 7;
            this.addContactBtn.Text = "Add To Contact";
            this.addContactBtn.UseVisualStyleBackColor = true;
            this.addContactBtn.Click += new System.EventHandler(this.AddContactBtn_Click);
            // 
            // contactGridView
            // 
            this.contactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGridView.Location = new System.Drawing.Point(63, 196);
            this.contactGridView.Name = "contactGridView";
            this.contactGridView.RowHeadersWidth = 51;
            this.contactGridView.RowTemplate.Height = 24;
            this.contactGridView.Size = new System.Drawing.Size(663, 232);
            this.contactGridView.TabIndex = 8;
            // 
            // displayContactBtn
            // 
            this.displayContactBtn.Location = new System.Drawing.Point(306, 155);
            this.displayContactBtn.Name = "displayContactBtn";
            this.displayContactBtn.Size = new System.Drawing.Size(140, 23);
            this.displayContactBtn.TabIndex = 9;
            this.displayContactBtn.Text = "Display Contacts";
            this.displayContactBtn.UseVisualStyleBackColor = true;
            this.displayContactBtn.Click += new System.EventHandler(this.DisplayContactBtn_Click);
            // 
            // ContactAppUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayContactBtn);
            this.Controls.Add(this.contactGridView);
            this.Controls.Add(this.addContactBtn);
            this.Controls.Add(this.cAddress);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContactAppUi";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.TextBox cAddress;
        private System.Windows.Forms.Button addContactBtn;
        private System.Windows.Forms.DataGridView contactGridView;
        private System.Windows.Forms.Button displayContactBtn;
    }
}

