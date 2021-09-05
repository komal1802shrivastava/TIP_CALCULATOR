namespace TipCalculator2
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
            this.BillL = new System.Windows.Forms.Label();
            this.billBoxField = new System.Windows.Forms.TextBox();
            this.TipL = new System.Windows.Forms.Label();
            this.tipBoxField = new System.Windows.Forms.TextBox();
            this.NoofpeopleL = new System.Windows.Forms.Label();
            this.noOfPeopleField = new System.Windows.Forms.TextBox();
            this.PerpersonLL = new System.Windows.Forms.Label();
            this.TipLL = new System.Windows.Forms.Label();
            this.TotalL = new System.Windows.Forms.Label();
            this.PerpersonL = new System.Windows.Forms.Label();
            this.Incrementnoofpeople = new System.Windows.Forms.Button();
            this.Decrementnoofpeople = new System.Windows.Forms.Button();
            this.Incrementtip = new System.Windows.Forms.Button();
            this.Decrementtip = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BillL
            // 
            this.BillL.AutoSize = true;
            this.BillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillL.Location = new System.Drawing.Point(104, 59);
            this.BillL.Name = "BillL";
            this.BillL.Size = new System.Drawing.Size(56, 25);
            this.BillL.TabIndex = 0;
            this.BillL.Text = "BILL";
            // 
            // billBoxField
            // 
            this.billBoxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBoxField.Location = new System.Drawing.Point(23, 87);
            this.billBoxField.Name = "billBoxField";
            this.billBoxField.Size = new System.Drawing.Size(250, 30);
            this.billBoxField.TabIndex = 1;
            this.billBoxField.TextChanged += new System.EventHandler(this.billBox);
            // 
            // TipL
            // 
            this.TipL.AutoSize = true;
            this.TipL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipL.Location = new System.Drawing.Point(104, 139);
            this.TipL.Name = "TipL";
            this.TipL.Size = new System.Drawing.Size(77, 25);
            this.TipL.TabIndex = 2;
            this.TipL.Text = " TIP %";
            // 
            // tipBoxField
            // 
            this.tipBoxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipBoxField.Location = new System.Drawing.Point(94, 176);
            this.tipBoxField.Name = "tipBoxField";
            this.tipBoxField.Size = new System.Drawing.Size(120, 30);
            this.tipBoxField.TabIndex = 3;
            this.tipBoxField.TextChanged += new System.EventHandler(this.tipBox);
            // 
            // NoofpeopleL
            // 
            this.NoofpeopleL.AutoSize = true;
            this.NoofpeopleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoofpeopleL.Location = new System.Drawing.Point(104, 228);
            this.NoofpeopleL.Name = "NoofpeopleL";
            this.NoofpeopleL.Size = new System.Drawing.Size(153, 25);
            this.NoofpeopleL.TabIndex = 4;
            this.NoofpeopleL.Text = " No. Of People";
            // 
            // noOfPeopleField
            // 
            this.noOfPeopleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfPeopleField.Location = new System.Drawing.Point(94, 265);
            this.noOfPeopleField.Name = "noOfPeopleField";
            this.noOfPeopleField.Size = new System.Drawing.Size(120, 30);
            this.noOfPeopleField.TabIndex = 5;
            this.noOfPeopleField.TextChanged += new System.EventHandler(this.noOfPeopleBox);
            // 
            // PerpersonLL
            // 
            this.PerpersonLL.Location = new System.Drawing.Point(0, 0);
            this.PerpersonLL.Name = "PerpersonLL";
            this.PerpersonLL.Size = new System.Drawing.Size(100, 23);
            this.PerpersonLL.TabIndex = 20;
            // 
            // TipLL
            // 
            this.TipLL.AutoSize = true;
            this.TipLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipLL.Location = new System.Drawing.Point(427, 90);
            this.TipLL.Name = "TipLL";
            this.TipLL.Size = new System.Drawing.Size(65, 38);
            this.TipLL.TabIndex = 7;
            this.TipLL.Text = "Tip";
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.Location = new System.Drawing.Point(427, 228);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(94, 38);
            this.TotalL.TabIndex = 8;
            this.TotalL.Text = "Total";
            // 
            // PerpersonL
            // 
            this.PerpersonL.AutoSize = true;
            this.PerpersonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerpersonL.Location = new System.Drawing.Point(429, 265);
            this.PerpersonL.Name = "PerpersonL";
            this.PerpersonL.Size = new System.Drawing.Size(123, 25);
            this.PerpersonL.TabIndex = 9;
            this.PerpersonL.Text = " Per person";
            // 
            // Incrementnoofpeople
            // 
            this.Incrementnoofpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incrementnoofpeople.Location = new System.Drawing.Point(213, 265);
            this.Incrementnoofpeople.Name = "Incrementnoofpeople";
            this.Incrementnoofpeople.Size = new System.Drawing.Size(60, 30);
            this.Incrementnoofpeople.TabIndex = 13;
            this.Incrementnoofpeople.Text = "+";
            this.Incrementnoofpeople.UseVisualStyleBackColor = true;
            this.Incrementnoofpeople.Click += new System.EventHandler(this.incrementNoOfPeople);
            // 
            // Decrementnoofpeople
            // 
            this.Decrementnoofpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrementnoofpeople.Location = new System.Drawing.Point(38, 265);
            this.Decrementnoofpeople.Name = "Decrementnoofpeople";
            this.Decrementnoofpeople.Size = new System.Drawing.Size(60, 30);
            this.Decrementnoofpeople.TabIndex = 14;
            this.Decrementnoofpeople.Text = "-";
            this.Decrementnoofpeople.UseVisualStyleBackColor = true;
            this.Decrementnoofpeople.Click += new System.EventHandler(this.decrementNoOfPeople);
            // 
            // Incrementtip
            // 
            this.Incrementtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incrementtip.Location = new System.Drawing.Point(213, 176);
            this.Incrementtip.Name = "Incrementtip";
            this.Incrementtip.Size = new System.Drawing.Size(60, 30);
            this.Incrementtip.TabIndex = 15;
            this.Incrementtip.Text = "+";
            this.Incrementtip.UseVisualStyleBackColor = true;
            this.Incrementtip.Click += new System.EventHandler(this.incrementTip);
            // 
            // Decrementtip
            // 
            this.Decrementtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrementtip.Location = new System.Drawing.Point(38, 176);
            this.Decrementtip.Name = "Decrementtip";
            this.Decrementtip.Size = new System.Drawing.Size(60, 30);
            this.Decrementtip.TabIndex = 16;
            this.Decrementtip.Text = "-";
            this.Decrementtip.UseVisualStyleBackColor = true;
            this.Decrementtip.Click += new System.EventHandler(this.decrementTip);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(582, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 80);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 38;
            this.listBox2.Location = new System.Drawing.Point(582, 216);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 80);
            this.listBox2.TabIndex = 18;
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(330, 352);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(121, 47);
            this.Submitbutton.TabIndex = 19;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.submitButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Per person";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Decrementtip);
            this.Controls.Add(this.Incrementtip);
            this.Controls.Add(this.Decrementnoofpeople);
            this.Controls.Add(this.Incrementnoofpeople);
            this.Controls.Add(this.PerpersonL);
            this.Controls.Add(this.TotalL);
            this.Controls.Add(this.TipLL);
            this.Controls.Add(this.PerpersonLL);
            this.Controls.Add(this.noOfPeopleField);
            this.Controls.Add(this.NoofpeopleL);
            this.Controls.Add(this.tipBoxField);
            this.Controls.Add(this.TipL);
            this.Controls.Add(this.billBoxField);
            this.Controls.Add(this.BillL);
            this.Name = "Form1";
            this.Text = "TIP CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillL;
        private System.Windows.Forms.TextBox billBoxField;
        private System.Windows.Forms.Label TipL;
        private System.Windows.Forms.TextBox tipBoxField;
        private System.Windows.Forms.Label NoofpeopleL;
        private System.Windows.Forms.TextBox noOfPeopleField;
        private System.Windows.Forms.Label PerpersonLL;
        private System.Windows.Forms.Label TipLL;
        private System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.Label PerpersonL;
        private System.Windows.Forms.Button Incrementnoofpeople;
        private System.Windows.Forms.Button Decrementnoofpeople;
        private System.Windows.Forms.Button Incrementtip;
        private System.Windows.Forms.Button Decrementtip;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label label1;
    }
}

