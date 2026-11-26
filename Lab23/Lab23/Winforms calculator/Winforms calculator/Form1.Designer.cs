namespace Winforms_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.Divbutton = new System.Windows.Forms.Button();
            this.subtractionbutton = new System.Windows.Forms.Button();
            this.Multiplicationbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(237, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator application ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(64, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the first number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(64, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the second  number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cyan;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(404, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 28);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cyan;
            this.textBox2.Location = new System.Drawing.Point(404, 191);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 33);
            this.textBox2.TabIndex = 4;
            // 
            // ADDbutton
            // 
            this.ADDbutton.BackColor = System.Drawing.Color.Yellow;
            this.ADDbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ADDbutton.Location = new System.Drawing.Point(12, 298);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(75, 23);
            this.ADDbutton.TabIndex = 5;
            this.ADDbutton.Text = "ADD";
            this.ADDbutton.UseVisualStyleBackColor = false;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // Divbutton
            // 
            this.Divbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Divbutton.BackColor = System.Drawing.Color.SandyBrown;
            this.Divbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Divbutton.Location = new System.Drawing.Point(572, 298);
            this.Divbutton.Name = "Divbutton";
            this.Divbutton.Size = new System.Drawing.Size(75, 23);
            this.Divbutton.TabIndex = 6;
            this.Divbutton.Text = "Div";
            this.Divbutton.UseVisualStyleBackColor = false;
            // 
            // subtractionbutton
            // 
            this.subtractionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.subtractionbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subtractionbutton.Location = new System.Drawing.Point(207, 298);
            this.subtractionbutton.Name = "subtractionbutton";
            this.subtractionbutton.Size = new System.Drawing.Size(75, 23);
            this.subtractionbutton.TabIndex = 7;
            this.subtractionbutton.Text = "Sub";
            this.subtractionbutton.UseVisualStyleBackColor = false;
            //this.subtractionbutton.Click += new System.EventHandler(this.subtractionbutton_Click);
            // 
            // Multiplicationbutton
            // 
            this.Multiplicationbutton.BackColor = System.Drawing.Color.Peru;
            this.Multiplicationbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Multiplicationbutton.Location = new System.Drawing.Point(393, 298);
            this.Multiplicationbutton.Name = "Multiplicationbutton";
            this.Multiplicationbutton.Size = new System.Drawing.Size(118, 23);
            this.Multiplicationbutton.TabIndex = 8;
            this.Multiplicationbutton.Text = "Multiplication";
            this.Multiplicationbutton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(190, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Multiplicationbutton);
            this.Controls.Add(this.subtractionbutton);
            this.Controls.Add(this.Divbutton);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Button Divbutton;
        private System.Windows.Forms.Button subtractionbutton;
        private System.Windows.Forms.Button Multiplicationbutton;
        private System.Windows.Forms.Label label4;
    }
}

