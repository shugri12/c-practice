namespace assement1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.textdepartement = new System.Windows.Forms.TextBox();
            this.textstudentid = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.ibouput = new System.Windows.Forms.Button();
            this.bottonclear = new System.Windows.Forms.Button();
            this.enterthestudentname = new System.Windows.Forms.Label();
            this.enterthestudentid = new System.Windows.Forms.Label();
            this.enterthedeptement = new System.Windows.Forms.Label();
            this.enterthesemester = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(511, 116);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(337, 26);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // textdepartement
            // 
            this.textdepartement.Location = new System.Drawing.Point(511, 219);
            this.textdepartement.Name = "textdepartement";
            this.textdepartement.Size = new System.Drawing.Size(337, 26);
            this.textdepartement.TabIndex = 1;
            // 
            // textstudentid
            // 
            this.textstudentid.Location = new System.Drawing.Point(511, 168);
            this.textstudentid.Name = "textstudentid";
            this.textstudentid.Size = new System.Drawing.Size(337, 26);
            this.textstudentid.TabIndex = 2;
            this.textstudentid.TextChanged += new System.EventHandler(this.textstudent_TextChanged);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(462, 420);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(183, 43);
            this.btnshowinfo.TabIndex = 3;
            this.btnshowinfo.Text = "btnshowinfo";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(511, 264);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(328, 26);
            this.txtsemester.TabIndex = 4;
            this.txtsemester.TextChanged += new System.EventHandler(this.txtsemester_TextChanged);
            // 
            // ibouput
            // 
            this.ibouput.Location = new System.Drawing.Point(431, 326);
            this.ibouput.Name = "ibouput";
            this.ibouput.Size = new System.Drawing.Size(474, 64);
            this.ibouput.TabIndex = 5;
            this.ibouput.UseVisualStyleBackColor = true;
            // 
            // bottonclear
            // 
            this.bottonclear.Location = new System.Drawing.Point(722, 420);
            this.bottonclear.Name = "bottonclear";
            this.bottonclear.Size = new System.Drawing.Size(183, 43);
            this.bottonclear.TabIndex = 6;
            this.bottonclear.Text = "clear";
            this.bottonclear.UseVisualStyleBackColor = true;
            this.bottonclear.Click += new System.EventHandler(this.bottonclear_Click);
            // 
            // enterthestudentname
            // 
            this.enterthestudentname.AutoSize = true;
            this.enterthestudentname.Location = new System.Drawing.Point(331, 122);
            this.enterthestudentname.Name = "enterthestudentname";
            this.enterthestudentname.Size = new System.Drawing.Size(171, 20);
            this.enterthestudentname.TabIndex = 7;
            this.enterthestudentname.Text = "enter the studentname";
            // 
            // enterthestudentid
            // 
            this.enterthestudentid.AutoSize = true;
            this.enterthestudentid.Location = new System.Drawing.Point(344, 168);
            this.enterthestudentid.Name = "enterthestudentid";
            this.enterthestudentid.Size = new System.Drawing.Size(147, 20);
            this.enterthestudentid.TabIndex = 8;
            this.enterthestudentid.Text = "enter the student id";
            // 
            // enterthedeptement
            // 
            this.enterthedeptement.AutoSize = true;
            this.enterthedeptement.Location = new System.Drawing.Point(334, 222);
            this.enterthedeptement.Name = "enterthedeptement";
            this.enterthedeptement.Size = new System.Drawing.Size(168, 20);
            this.enterthedeptement.TabIndex = 9;
            this.enterthedeptement.Text = "enter the depertement";
            // 
            // enterthesemester
            // 
            this.enterthesemester.AutoSize = true;
            this.enterthesemester.Location = new System.Drawing.Point(344, 270);
            this.enterthesemester.Name = "enterthesemester";
            this.enterthesemester.Size = new System.Drawing.Size(143, 20);
            this.enterthesemester.TabIndex = 10;
            this.enterthesemester.Text = "enter the semester";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterthesemester);
            this.Controls.Add(this.enterthedeptement);
            this.Controls.Add(this.enterthestudentid);
            this.Controls.Add(this.enterthestudentname);
            this.Controls.Add(this.bottonclear);
            this.Controls.Add(this.ibouput);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.textstudentid);
            this.Controls.Add(this.textdepartement);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox textdepartement;
        private System.Windows.Forms.TextBox textstudentid;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button ibouput;
        private System.Windows.Forms.Button bottonclear;
        private System.Windows.Forms.Label enterthestudentname;
        private System.Windows.Forms.Label enterthestudentid;
        private System.Windows.Forms.Label enterthedeptement;
        private System.Windows.Forms.Label enterthesemester;
        private System.Windows.Forms.Button button1;
    }
}

