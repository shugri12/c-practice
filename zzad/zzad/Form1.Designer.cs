namespace zzad
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
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.txtpricenight = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblservicetex = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.TextBox();
            this.lbltotalamount = new System.Windows.Forms.TextBox();
            this.txtroomtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(574, 86);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(225, 26);
            this.txtguestname.TabIndex = 0;
            // 
            // txtpricenight
            // 
            this.txtpricenight.Location = new System.Drawing.Point(574, 208);
            this.txtpricenight.Name = "txtpricenight";
            this.txtpricenight.Size = new System.Drawing.Size(225, 26);
            this.txtpricenight.TabIndex = 1;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(574, 176);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(225, 26);
            this.txtnights.TabIndex = 2;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculate.Location = new System.Drawing.Point(549, 249);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(268, 62);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "calculate booking";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(427, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "hotel room booking calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(363, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "enter guest name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(334, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "enter price per night:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(325, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "lenter number of nights:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(354, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "enter room type:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(363, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "service tax(10%) :";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(363, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "total amount";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(374, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "discount(5%)  :";
            // 
            // lblservicetex
            // 
            this.lblservicetex.Location = new System.Drawing.Point(532, 353);
            this.lblservicetex.Name = "lblservicetex";
            this.lblservicetex.Size = new System.Drawing.Size(225, 26);
            this.lblservicetex.TabIndex = 17;
            // 
            // lbldiscount
            // 
            this.lbldiscount.Location = new System.Drawing.Point(522, 409);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(225, 26);
            this.lbldiscount.TabIndex = 18;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.Location = new System.Drawing.Point(512, 472);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(225, 26);
            this.lbltotalamount.TabIndex = 19;
            // 
            // txtroomtype
            // 
            this.txtroomtype.FormattingEnabled = true;
            this.txtroomtype.Items.AddRange(new object[] {
            "deluxe",
            "standard",
            "suite"});
            this.txtroomtype.Location = new System.Drawing.Point(574, 131);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(214, 28);
            this.txtroomtype.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 563);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblservicetex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtpricenight);
            this.Controls.Add(this.txtguestname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox txtpricenight;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblservicetex;
        private System.Windows.Forms.TextBox lbldiscount;
        private System.Windows.Forms.TextBox lbltotalamount;
        private System.Windows.Forms.ComboBox txtroomtype;
    }
}

