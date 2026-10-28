namespace labkakore
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
            this.label3 = new System.Windows.Forms.Label();
            this.textnumberpakge = new System.Windows.Forms.TextBox();
            this.textperpkage = new System.Windows.Forms.TextBox();
            this.btnclculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblq = new System.Windows.Forms.Label();
            this.labelu = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.labelt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.labeln = new System.Windows.Forms.Label();
            this.labellast = new System.Windows.Forms.Label();
            this.label1ber = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.softewesalesrepost = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "softawere sales";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter the number the discount amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "purchase information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textnumberpakge
            // 
            this.textnumberpakge.Location = new System.Drawing.Point(302, 192);
            this.textnumberpakge.Name = "textnumberpakge";
            this.textnumberpakge.Size = new System.Drawing.Size(258, 26);
            this.textnumberpakge.TabIndex = 3;
            // 
            // textperpkage
            // 
            this.textperpkage.Location = new System.Drawing.Point(302, 244);
            this.textperpkage.Name = "textperpkage";
            this.textperpkage.Size = new System.Drawing.Size(258, 26);
            this.textperpkage.TabIndex = 4;
            // 
            // btnclculate
            // 
            this.btnclculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnclculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclculate.Location = new System.Drawing.Point(1, 284);
            this.btnclculate.Name = "btnclculate";
            this.btnclculate.Size = new System.Drawing.Size(203, 63);
            this.btnclculate.TabIndex = 5;
            this.btnclculate.Text = "CALCULATE";
            this.btnclculate.UseVisualStyleBackColor = false;
            this.btnclculate.Click += new System.EventHandler(this.btnclculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(242, 284);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(191, 63);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(493, 286);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(191, 63);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(87, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "number of packege";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(76, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "price per package";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "quentity discount table";
            // 
            // lblq
            // 
            this.lblq.Location = new System.Drawing.Point(12, 460);
            this.lblq.Name = "lblq";
            this.lblq.Size = new System.Drawing.Size(203, 36);
            this.lblq.TabIndex = 11;
            this.lblq.Click += new System.EventHandler(this.lblq_Click);
            // 
            // labelu
            // 
            this.labelu.Location = new System.Drawing.Point(12, 496);
            this.labelu.Name = "labelu";
            this.labelu.Size = new System.Drawing.Size(203, 36);
            this.labelu.TabIndex = 12;
            this.labelu.Click += new System.EventHandler(this.labelu_Click);
            // 
            // labela
            // 
            this.labela.Location = new System.Drawing.Point(12, 551);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(203, 36);
            this.labela.TabIndex = 13;
            this.labela.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelt
            // 
            this.labelt.Location = new System.Drawing.Point(12, 619);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(203, 36);
            this.labelt.TabIndex = 14;
            this.labelt.Click += new System.EventHandler(this.labelt_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(12, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "quantity";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.RoyalBlue;
            this.discount.Location = new System.Drawing.Point(298, 412);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(203, 36);
            this.discount.TabIndex = 16;
            this.discount.Text = "discount";
            // 
            // labeln
            // 
            this.labeln.Location = new System.Drawing.Point(276, 460);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(203, 36);
            this.labeln.TabIndex = 17;
            // 
            // labellast
            // 
            this.labellast.Location = new System.Drawing.Point(264, 619);
            this.labellast.Name = "labellast";
            this.labellast.Size = new System.Drawing.Size(203, 36);
            this.labellast.TabIndex = 18;
            // 
            // label1ber
            // 
            this.label1ber.Location = new System.Drawing.Point(264, 551);
            this.label1ber.Name = "label1ber";
            this.label1ber.Size = new System.Drawing.Size(203, 36);
            this.label1ber.TabIndex = 19;
            // 
            // labelm
            // 
            this.labelm.Location = new System.Drawing.Point(264, 496);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(203, 36);
            this.labelm.TabIndex = 20;
            // 
            // softewesalesrepost
            // 
            this.softewesalesrepost.FormattingEnabled = true;
            this.softewesalesrepost.ItemHeight = 20;
            this.softewesalesrepost.Location = new System.Drawing.Point(786, 60);
            this.softewesalesrepost.Name = "softewesalesrepost";
            this.softewesalesrepost.Size = new System.Drawing.Size(415, 604);
            this.softewesalesrepost.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 679);
            this.Controls.Add(this.softewesalesrepost);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.label1ber);
            this.Controls.Add(this.labellast);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.labelu);
            this.Controls.Add(this.lblq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclculate);
            this.Controls.Add(this.textperpkage);
            this.Controls.Add(this.textnumberpakge);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnumberpakge;
        private System.Windows.Forms.TextBox textperpkage;
        private System.Windows.Forms.Button btnclculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblq;
        private System.Windows.Forms.Label labelu;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Label labellast;
        private System.Windows.Forms.Label label1ber;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.ListBox softewesalesrepost;
    }
}

