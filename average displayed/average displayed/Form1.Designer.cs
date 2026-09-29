namespace average_displayed
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txxstar = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtcenter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.clculte = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter three test score";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "test score #3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "test score #2";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "test score #1";
            // 
            // txxstar
            // 
            this.txxstar.Location = new System.Drawing.Point(379, 111);
            this.txxstar.Name = "txxstar";
            this.txxstar.Size = new System.Drawing.Size(204, 26);
            this.txxstar.TabIndex = 5;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(379, 218);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(204, 26);
            this.txtend.TabIndex = 8;
            // 
            // txtcenter
            // 
            this.txtcenter.Location = new System.Drawing.Point(379, 167);
            this.txtcenter.Name = "txtcenter";
            this.txtcenter.Size = new System.Drawing.Size(204, 26);
            this.txtcenter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "AVERAGE";
            // 
            // lbloutput
            // 
            this.lbloutput.Location = new System.Drawing.Point(358, 287);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(278, 41);
            this.lbloutput.TabIndex = 11;
            // 
            // clculte
            // 
            this.clculte.Location = new System.Drawing.Point(144, 400);
            this.clculte.Name = "clculte";
            this.clculte.Size = new System.Drawing.Size(159, 81);
            this.clculte.TabIndex = 12;
            this.clculte.Text = "calculate avrage";
            this.clculte.UseVisualStyleBackColor = true;
            this.clculte.Click += new System.EventHandler(this.clculte_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(352, 387);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(135, 44);
            this.clr.TabIndex = 13;
            this.clr.Text = "clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(352, 437);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(135, 44);
            this.ext.TabIndex = 14;
            this.ext.Text = "EXIT";
            this.ext.UseVisualStyleBackColor = true;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 508);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.clculte);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcenter);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txxstar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txxstar;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtcenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button clculte;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button ext;
    }
}

