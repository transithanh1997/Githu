namespace slnTestGit_V2
{
    partial class frmnhan
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
            this.lba = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.lbb = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lbkq = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btnnhan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(0, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(30, 13);
            this.lba.TabIndex = 0;
            this.lba.Text = "So A";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(58, 0);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 1;
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(0, 44);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(30, 13);
            this.lbb.TabIndex = 2;
            this.lbb.Text = "So B";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(58, 44);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 3;
            this.txtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Location = new System.Drawing.Point(0, 91);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(46, 13);
            this.lbkq.TabIndex = 4;
            this.lbkq.Text = "Ket Qua";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(58, 88);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 5;
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(58, 131);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(75, 23);
            this.btnnhan.TabIndex = 6;
            this.btnnhan.Text = "Nhan";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lba);
            this.Name = "frmnhan";
            this.Text = "frmnhan";
            this.Load += new System.EventHandler(this.frmnhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button button2;
    }
}