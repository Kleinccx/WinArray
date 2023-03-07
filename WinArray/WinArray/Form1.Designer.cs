namespace WinArray
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IntersectionLBL = new System.Windows.Forms.Label();
            this.DifferenceLBL = new System.Windows.Forms.Label();
            this.SymmDiffLBL = new System.Windows.Forms.Label();
            this.UnionLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(241, 64);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(241, 91);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntersectionLBL
            // 
            this.IntersectionLBL.AutoSize = true;
            this.IntersectionLBL.BackColor = System.Drawing.Color.White;
            this.IntersectionLBL.Location = new System.Drawing.Point(238, 144);
            this.IntersectionLBL.Name = "IntersectionLBL";
            this.IntersectionLBL.Size = new System.Drawing.Size(68, 13);
            this.IntersectionLBL.TabIndex = 1;
            this.IntersectionLBL.Text = "Intersection :";
            // 
            // DifferenceLBL
            // 
            this.DifferenceLBL.AutoSize = true;
            this.DifferenceLBL.BackColor = System.Drawing.Color.White;
            this.DifferenceLBL.Location = new System.Drawing.Point(238, 169);
            this.DifferenceLBL.Name = "DifferenceLBL";
            this.DifferenceLBL.Size = new System.Drawing.Size(62, 13);
            this.DifferenceLBL.TabIndex = 1;
            this.DifferenceLBL.Text = "Difference :";
            // 
            // SymmDiffLBL
            // 
            this.SymmDiffLBL.AutoSize = true;
            this.SymmDiffLBL.BackColor = System.Drawing.Color.White;
            this.SymmDiffLBL.Location = new System.Drawing.Point(238, 192);
            this.SymmDiffLBL.Name = "SymmDiffLBL";
            this.SymmDiffLBL.Size = new System.Drawing.Size(121, 13);
            this.SymmDiffLBL.TabIndex = 1;
            this.SymmDiffLBL.Text = "Symmetrical Difference :";
            // 
            // UnionLBL
            // 
            this.UnionLBL.AutoSize = true;
            this.UnionLBL.BackColor = System.Drawing.Color.White;
            this.UnionLBL.Location = new System.Drawing.Point(238, 220);
            this.UnionLBL.Name = "UnionLBL";
            this.UnionLBL.Size = new System.Drawing.Size(41, 13);
            this.UnionLBL.TabIndex = 1;
            this.UnionLBL.Text = "Union :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.UnionLBL);
            this.Controls.Add(this.SymmDiffLBL);
            this.Controls.Add(this.DifferenceLBL);
            this.Controls.Add(this.IntersectionLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IntersectionLBL;
        private System.Windows.Forms.Label DifferenceLBL;
        private System.Windows.Forms.Label SymmDiffLBL;
        private System.Windows.Forms.Label UnionLBL;
    }
}

