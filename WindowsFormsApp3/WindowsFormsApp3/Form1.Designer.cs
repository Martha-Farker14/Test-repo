namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CSharp = new System.Windows.Forms.PictureBox();
            this.ASP = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSharp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Location = new System.Drawing.Point(48, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(71, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(71, 47);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(337, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(337, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(337, 220);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "ASP";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 121);
            this.listBox1.TabIndex = 10;
            // 
            // CSharp
            // 
            this.CSharp.Image = global::WindowsFormsApp3.Properties.Resources.csharp_e7b8fcd4ce;
            this.CSharp.Location = new System.Drawing.Point(654, 197);
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(135, 120);
            this.CSharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CSharp.TabIndex = 9;
            this.CSharp.TabStop = false;
            this.CSharp.Visible = false;
            // 
            // ASP
            // 
            this.ASP.Image = global::WindowsFormsApp3.Properties.Resources.aspnet_featured1;
            this.ASP.Location = new System.Drawing.Point(516, 197);
            this.ASP.Name = "ASP";
            this.ASP.Size = new System.Drawing.Size(132, 120);
            this.ASP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ASP.TabIndex = 7;
            this.ASP.TabStop = false;
            this.ASP.Visible = false;
            this.ASP.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(516, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 104);
            this.panel1.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(337, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 369);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CSharp);
            this.Controls.Add(this.ASP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSharp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ASP;
        private System.Windows.Forms.PictureBox CSharp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

