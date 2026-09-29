namespace range_deciion
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
            this.btncheack = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter an integer in the range of 1 through 10";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "range decision";
            // 
            // btncheack
            // 
            this.btncheack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheack.Location = new System.Drawing.Point(227, 354);
            this.btncheack.Name = "btncheack";
            this.btncheack.Size = new System.Drawing.Size(126, 60);
            this.btncheack.TabIndex = 4;
            this.btncheack.Text = "cheack qualification";
            this.btncheack.UseVisualStyleBackColor = true;
            this.btncheack.Click += new System.EventHandler(this.btncheack_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(380, 354);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 34);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(380, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(306, 135);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(322, 26);
            this.txtnum.TabIndex = 7;
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(175, 264);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(562, 67);
            this.lblresult.TabIndex = 8;
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheack);
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
        private System.Windows.Forms.Button btncheack;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblresult;
    }
}

