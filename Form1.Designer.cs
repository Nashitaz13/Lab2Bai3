namespace Lab2Bai3
{
    partial class Lab2Bai3
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
            this.butopenfile = new System.Windows.Forms.Button();
            this.filedirection = new System.Windows.Forms.TextBox();
            this.butreadfile = new System.Windows.Forms.Button();
            this.butcalculator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.readfile = new System.Windows.Forms.RichTextBox();
            this.butopenout = new System.Windows.Forms.Button();
            this.filedirectionout = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butopenfile
            // 
            this.butopenfile.Location = new System.Drawing.Point(12, 27);
            this.butopenfile.Name = "butopenfile";
            this.butopenfile.Size = new System.Drawing.Size(109, 41);
            this.butopenfile.TabIndex = 0;
            this.butopenfile.Text = "Open File";
            this.butopenfile.UseVisualStyleBackColor = true;
            this.butopenfile.Click += new System.EventHandler(this.butopenfile_Click);
            // 
            // filedirection
            // 
            this.filedirection.Location = new System.Drawing.Point(131, 37);
            this.filedirection.Name = "filedirection";
            this.filedirection.ReadOnly = true;
            this.filedirection.Size = new System.Drawing.Size(532, 22);
            this.filedirection.TabIndex = 1;
            this.filedirection.TextChanged += new System.EventHandler(this.filedirection_TextChanged);
            // 
            // butreadfile
            // 
            this.butreadfile.Location = new System.Drawing.Point(676, 28);
            this.butreadfile.Name = "butreadfile";
            this.butreadfile.Size = new System.Drawing.Size(85, 41);
            this.butreadfile.TabIndex = 2;
            this.butreadfile.Text = "Read File";
            this.butreadfile.UseVisualStyleBackColor = true;
            this.butreadfile.Click += new System.EventHandler(this.butreadfile_Click);
            // 
            // butcalculator
            // 
            this.butcalculator.Location = new System.Drawing.Point(676, 75);
            this.butcalculator.Name = "butcalculator";
            this.butcalculator.Size = new System.Drawing.Size(85, 41);
            this.butcalculator.TabIndex = 3;
            this.butcalculator.Text = "Calculator";
            this.butcalculator.UseVisualStyleBackColor = true;
            this.butcalculator.Click += new System.EventHandler(this.butcalculator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readfile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Context ";
            // 
            // readfile
            // 
            this.readfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readfile.Location = new System.Drawing.Point(3, 24);
            this.readfile.Name = "readfile";
            this.readfile.ReadOnly = true;
            this.readfile.Size = new System.Drawing.Size(770, 299);
            this.readfile.TabIndex = 0;
            this.readfile.Text = "";
            this.readfile.TextChanged += new System.EventHandler(this.readfile_TextChanged);
            // 
            // butopenout
            // 
            this.butopenout.Location = new System.Drawing.Point(12, 73);
            this.butopenout.Name = "butopenout";
            this.butopenout.Size = new System.Drawing.Size(109, 41);
            this.butopenout.TabIndex = 5;
            this.butopenout.Text = "Choose File";
            this.butopenout.UseVisualStyleBackColor = true;
            this.butopenout.Click += new System.EventHandler(this.butopenout_Click);
            // 
            // filedirectionout
            // 
            this.filedirectionout.Location = new System.Drawing.Point(131, 82);
            this.filedirectionout.Name = "filedirectionout";
            this.filedirectionout.ReadOnly = true;
            this.filedirectionout.Size = new System.Drawing.Size(532, 22);
            this.filedirectionout.TabIndex = 6;
            this.filedirectionout.TextChanged += new System.EventHandler(this.filedirectionout_TextChanged);
            // 
            // Lab2Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filedirectionout);
            this.Controls.Add(this.butopenout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butcalculator);
            this.Controls.Add(this.butreadfile);
            this.Controls.Add(this.filedirection);
            this.Controls.Add(this.butopenfile);
            this.Name = "Lab2Bai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butopenfile;
        private System.Windows.Forms.TextBox filedirection;
        private System.Windows.Forms.Button butreadfile;
        private System.Windows.Forms.Button butcalculator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox readfile;
        private System.Windows.Forms.Button butopenout;
        private System.Windows.Forms.TextBox filedirectionout;
    }
}

