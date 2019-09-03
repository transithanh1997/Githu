namespace slnTestGit_V2
{
    partial class frmTru
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
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnkq = new System.Windows.Forms.Button();
            this.lbKq = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(12, 24);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(30, 13);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "So A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(97, 17);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(12, 56);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(30, 13);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "So B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(97, 53);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // btnkq
            // 
            this.btnkq.Location = new System.Drawing.Point(97, 125);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(75, 23);
            this.btnkq.TabIndex = 4;
            this.btnkq.Text = "Tru";
            this.btnkq.UseVisualStyleBackColor = true;
            this.btnkq.Click += new System.EventHandler(this.btnkq_Click);
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Location = new System.Drawing.Point(12, 97);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(46, 13);
            this.lbKq.TabIndex = 5;
            this.lbKq.Text = "Ket Qua";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(97, 90);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 20);
            this.txtKq.TabIndex = 6;
            // 
            // frmTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.btnkq);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Name = "frmTru";
            this.Text = "frmTru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnkq;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.TextBox txtKq;
    }
}