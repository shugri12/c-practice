namespace airline
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
            this.txtpassengername = new System.Windows.Forms.TextBox();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.txtnumberticket = new System.Windows.Forms.TextBox();
            this.txtpassengerage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltravel = new System.Windows.Forms.Label();
            this.radioButtonfirst = new System.Windows.Forms.RadioButton();
            this.radioButtonbusiness = new System.Windows.Forms.RadioButton();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxadd = new System.Windows.Forms.CheckBox();
            this.buttocalculate = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttoclear = new System.Windows.Forms.Button();
            this.listoutput = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpassengername
            // 
            this.txtpassengername.Location = new System.Drawing.Point(436, 90);
            this.txtpassengername.Name = "txtpassengername";
            this.txtpassengername.Size = new System.Drawing.Size(218, 26);
            this.txtpassengername.TabIndex = 0;
            // 
            // txtbaggage
            // 
            this.txtbaggage.Location = new System.Drawing.Point(436, 257);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(218, 26);
            this.txtbaggage.TabIndex = 1;
            // 
            // txtnumberticket
            // 
            this.txtnumberticket.Location = new System.Drawing.Point(436, 193);
            this.txtnumberticket.Name = "txtnumberticket";
            this.txtnumberticket.Size = new System.Drawing.Size(218, 26);
            this.txtnumberticket.TabIndex = 2;
            // 
            // txtpassengerage
            // 
            this.txtpassengerage.Location = new System.Drawing.Point(436, 136);
            this.txtpassengerage.Name = "txtpassengerage";
            this.txtpassengerage.Size = new System.Drawing.Size(218, 26);
            this.txtpassengerage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "passenger name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "number of tickets";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "baggage weight(kg)";
            // 
            // lbltravel
            // 
            this.lbltravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltravel.Location = new System.Drawing.Point(183, 339);
            this.lbltravel.Name = "lbltravel";
            this.lbltravel.Size = new System.Drawing.Size(187, 26);
            this.lbltravel.TabIndex = 9;
            this.lbltravel.Text = "travel class";
            // 
            // radioButtonfirst
            // 
            this.radioButtonfirst.AutoSize = true;
            this.radioButtonfirst.Location = new System.Drawing.Point(188, 419);
            this.radioButtonfirst.Name = "radioButtonfirst";
            this.radioButtonfirst.Size = new System.Drawing.Size(149, 24);
            this.radioButtonfirst.TabIndex = 10;
            this.radioButtonfirst.TabStop = true;
            this.radioButtonfirst.Text = "FIRST CLASES";
            this.radioButtonfirst.UseVisualStyleBackColor = true;
            // 
            // radioButtonbusiness
            // 
            this.radioButtonbusiness.AutoSize = true;
            this.radioButtonbusiness.Location = new System.Drawing.Point(636, 419);
            this.radioButtonbusiness.Name = "radioButtonbusiness";
            this.radioButtonbusiness.Size = new System.Drawing.Size(196, 24);
            this.radioButtonbusiness.TabIndex = 11;
            this.radioButtonbusiness.TabStop = true;
            this.radioButtonbusiness.Text = "BUSISNESS CLASES";
            this.radioButtonbusiness.UseVisualStyleBackColor = true;
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(408, 419);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(170, 24);
            this.radioButtonnormal.TabIndex = 12;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "NORMAL CLASES";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "addetioal option";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkBoxadd
            // 
            this.checkBoxadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxadd.Location = new System.Drawing.Point(161, 511);
            this.checkBoxadd.Name = "checkBoxadd";
            this.checkBoxadd.Size = new System.Drawing.Size(405, 31);
            this.checkBoxadd.TabIndex = 14;
            this.checkBoxadd.Text = "add travel insurces (25 per ticket)";
            this.checkBoxadd.UseVisualStyleBackColor = true;
            // 
            // buttocalculate
            // 
            this.buttocalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttocalculate.Location = new System.Drawing.Point(120, 563);
            this.buttocalculate.Name = "buttocalculate";
            this.buttocalculate.Size = new System.Drawing.Size(134, 39);
            this.buttocalculate.TabIndex = 15;
            this.buttocalculate.Text = "calculate";
            this.buttocalculate.UseVisualStyleBackColor = true;
            this.buttocalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(569, 563);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(134, 39);
            this.buttonexit.TabIndex = 16;
            this.buttonexit.Text = "exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttoclear
            // 
            this.buttoclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoclear.Location = new System.Drawing.Point(311, 563);
            this.buttoclear.Name = "buttoclear";
            this.buttoclear.Size = new System.Drawing.Size(134, 39);
            this.buttoclear.TabIndex = 17;
            this.buttoclear.Text = "clear";
            this.buttoclear.UseVisualStyleBackColor = true;
            this.buttoclear.Click += new System.EventHandler(this.buttoclear_Click);
            // 
            // listoutput
            // 
            this.listoutput.FormattingEnabled = true;
            this.listoutput.ItemHeight = 20;
            this.listoutput.Location = new System.Drawing.Point(878, 30);
            this.listoutput.Name = "listoutput";
            this.listoutput.Size = new System.Drawing.Size(281, 544);
            this.listoutput.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "passenger age";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "personal information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.listoutput);
            this.Controls.Add(this.buttoclear);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttocalculate);
            this.Controls.Add(this.checkBoxadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButtonnormal);
            this.Controls.Add(this.radioButtonbusiness);
            this.Controls.Add(this.radioButtonfirst);
            this.Controls.Add(this.lbltravel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassengerage);
            this.Controls.Add(this.txtnumberticket);
            this.Controls.Add(this.txtbaggage);
            this.Controls.Add(this.txtpassengername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassengername;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.TextBox txtnumberticket;
        private System.Windows.Forms.TextBox txtpassengerage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltravel;
        private System.Windows.Forms.RadioButton radioButtonfirst;
        private System.Windows.Forms.RadioButton radioButtonbusiness;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxadd;
        private System.Windows.Forms.Button buttocalculate;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttoclear;
        private System.Windows.Forms.ListBox listoutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

