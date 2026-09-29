namespace overtime
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
            this.grosspaylabel = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.hoursworkedtexbox = new System.Windows.Forms.TextBox();
            this.hourlypayratetextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "hourse worked:";
            // 
            // grosspaylabel
            // 
            this.grosspaylabel.Location = new System.Drawing.Point(526, 194);
            this.grosspaylabel.Name = "grosspaylabel";
            this.grosspaylabel.Size = new System.Drawing.Size(193, 38);
            this.grosspaylabel.TabIndex = 1;
            this.grosspaylabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // calculatebutton
            // 
            this.calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.Location = new System.Drawing.Point(292, 327);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(159, 67);
            this.calculatebutton.TabIndex = 4;
            this.calculatebutton.Text = "calculate groos pay";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // hoursworkedtexbox
            // 
            this.hoursworkedtexbox.Location = new System.Drawing.Point(526, 75);
            this.hoursworkedtexbox.Name = "hoursworkedtexbox";
            this.hoursworkedtexbox.Size = new System.Drawing.Size(193, 26);
            this.hoursworkedtexbox.TabIndex = 5;
            // 
            // hourlypayratetextbox
            // 
            this.hourlypayratetextbox.Location = new System.Drawing.Point(526, 127);
            this.hourlypayratetextbox.Name = "hourlypayratetextbox";
            this.hourlypayratetextbox.Size = new System.Drawing.Size(193, 26);
            this.hourlypayratetextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "hourly pay rate:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "gross pay:";
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(488, 327);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(159, 67);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(680, 327);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(159, 67);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 526);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hourlypayratetextbox);
            this.Controls.Add(this.hoursworkedtexbox);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.grosspaylabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grosspaylabel;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.TextBox hoursworkedtexbox;
        private System.Windows.Forms.TextBox hourlypayratetextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

