namespace Capacitor_Calaculator
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbCapacitorKVR = new System.Windows.Forms.TextBox();
            this.tbDesiredPF = new System.Windows.Forms.TextBox();
            this.tbKw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCurrentPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.tb1Volt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb1Freq = new System.Windows.Forms.TextBox();
            this.btnKVR2MF = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb1MF = new System.Windows.Forms.TextBox();
            this.tb1KVR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb2Volt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb2Freq = new System.Windows.Forms.TextBox();
            this.btnMF2KVR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb2KVR = new System.Windows.Forms.TextBox();
            this.tb2MF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0 , 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalculate);
            this.splitContainer1.Panel1.Controls.Add(this.tbCapacitorKVR);
            this.splitContainer1.Panel1.Controls.Add(this.tbDesiredPF);
            this.splitContainer1.Panel1.Controls.Add(this.tbKw);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentPF);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(904 , 501);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108 , 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(234 , 125);
            this.label16.TabIndex = 9;
            this.label16.Text = "جنرال الكترون\r\nالمهندس محمد كوكش\r\nسوريا - دمشق \r\nهاتف : 6615714\r\n\r\n";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(47 , 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(369 , 39);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "حساب";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbCapacitorKVR
            // 
            this.tbCapacitorKVR.Location = new System.Drawing.Point(47 , 301);
            this.tbCapacitorKVR.Name = "tbCapacitorKVR";
            this.tbCapacitorKVR.Size = new System.Drawing.Size(159 , 33);
            this.tbCapacitorKVR.TabIndex = 7;
            // 
            // tbDesiredPF
            // 
            this.tbDesiredPF.Location = new System.Drawing.Point(47 , 177);
            this.tbDesiredPF.Name = "tbDesiredPF";
            this.tbDesiredPF.Size = new System.Drawing.Size(159 , 33);
            this.tbDesiredPF.TabIndex = 6;
            this.tbDesiredPF.TextChanged += new System.EventHandler(this.tbDesiredPF_TextChanged);
            // 
            // tbKw
            // 
            this.tbKw.Location = new System.Drawing.Point(47 , 105);
            this.tbKw.Name = "tbKw";
            this.tbKw.Size = new System.Drawing.Size(159 , 33);
            this.tbKw.TabIndex = 5;
            this.tbKw.TextChanged += new System.EventHandler(this.tbKw_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236 , 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173 , 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "المكثف المطلوب\r\n(ك .ف . ر)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial" , 13F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241 , 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162 , 42);
            this.label5.TabIndex = 3;
            this.label5.Text = "عامل الاستطاعة المطلوب\r\nCos ø بين التيار و الجهد\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236 , 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173 , 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "المكثف المطلوب\r\n(ك .ف . ر)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263 , 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118 , 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "الاستطاعة\r\n (كيلو واط)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentPF
            // 
            this.tbCurrentPF.Location = new System.Drawing.Point(47 , 30);
            this.tbCurrentPF.Name = "tbCurrentPF";
            this.tbCurrentPF.Size = new System.Drawing.Size(159 , 33);
            this.tbCurrentPF.TabIndex = 1;
            this.tbCurrentPF.TextChanged += new System.EventHandler(this.tbCurrentPF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial" , 13F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241 , 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162 , 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "عامل الاستطاعة الحالي\r\nCos ø بين التيار و الجهد\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0 , 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.tb1Volt);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.tb1Freq);
            this.splitContainer2.Panel1.Controls.Add(this.btnKVR2MF);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.tb1MF);
            this.splitContainer2.Panel1.Controls.Add(this.tb1KVR);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.tb2Volt);
            this.splitContainer2.Panel2.Controls.Add(this.label15);
            this.splitContainer2.Panel2.Controls.Add(this.tb2Freq);
            this.splitContainer2.Panel2.Controls.Add(this.btnMF2KVR);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.tb2KVR);
            this.splitContainer2.Panel2.Controls.Add(this.tb2MF);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(468 , 501);
            this.splitContainer2.SplitterDistance = 235;
            this.splitContainer2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367 , 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65 , 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "الجهد";
            // 
            // tb1Volt
            // 
            this.tb1Volt.Location = new System.Drawing.Point(140 , 103);
            this.tb1Volt.Name = "tb1Volt";
            this.tb1Volt.Size = new System.Drawing.Size(159 , 33);
            this.tb1Volt.TabIndex = 9;
            this.tb1Volt.TextChanged += new System.EventHandler(this.tb1Volt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366 , 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66 , 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "التردد";
            // 
            // tb1Freq
            // 
            this.tb1Freq.Location = new System.Drawing.Point(140 , 151);
            this.tb1Freq.Name = "tb1Freq";
            this.tb1Freq.Size = new System.Drawing.Size(159 , 33);
            this.tb1Freq.TabIndex = 7;
            this.tb1Freq.TextChanged += new System.EventHandler(this.tb1Freq_TextChanged);
            // 
            // btnKVR2MF
            // 
            this.btnKVR2MF.Font = new System.Drawing.Font("Arial" , 14.25F , System.Drawing.FontStyle.Bold);
            this.btnKVR2MF.Location = new System.Drawing.Point(38 , 91);
            this.btnKVR2MF.Name = "btnKVR2MF";
            this.btnKVR2MF.Size = new System.Drawing.Size(85 , 83);
            this.btnKVR2MF.TabIndex = 6;
            this.btnKVR2MF.Text = "حساب";
            this.btnKVR2MF.UseVisualStyleBackColor = true;
            this.btnKVR2MF.Click += new System.EventHandler(this.btnKVR2MF_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343 , 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113 , 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "ميكروفاراد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352 , 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95 , 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "(ك.ف.ر)";
            // 
            // tb1MF
            // 
            this.tb1MF.Location = new System.Drawing.Point(140 , 199);
            this.tb1MF.MaxLength = 5;
            this.tb1MF.Name = "tb1MF";
            this.tb1MF.Size = new System.Drawing.Size(159 , 33);
            this.tb1MF.TabIndex = 3;
            this.tb1MF.TextChanged += new System.EventHandler(this.tb1MF_TextChanged);
            // 
            // tb1KVR
            // 
            this.tb1KVR.Location = new System.Drawing.Point(140 , 55);
            this.tb1KVR.Name = "tb1KVR";
            this.tb1KVR.Size = new System.Drawing.Size(159 , 33);
            this.tb1KVR.TabIndex = 2;
            this.tb1KVR.TextChanged += new System.EventHandler(this.tb1KVR_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99 , 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366 , 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "التحويل من (ك.ف.ر) الى ميكرو فاراد";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367 , 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65 , 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "الجهد";
            // 
            // tb2Volt
            // 
            this.tb2Volt.Location = new System.Drawing.Point(140 , 106);
            this.tb2Volt.Name = "tb2Volt";
            this.tb2Volt.Size = new System.Drawing.Size(159 , 33);
            this.tb2Volt.TabIndex = 14;
            this.tb2Volt.TextChanged += new System.EventHandler(this.tb2Volt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366 , 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66 , 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "التردد";
            // 
            // tb2Freq
            // 
            this.tb2Freq.Location = new System.Drawing.Point(140 , 154);
            this.tb2Freq.Name = "tb2Freq";
            this.tb2Freq.Size = new System.Drawing.Size(159 , 33);
            this.tb2Freq.TabIndex = 12;
            this.tb2Freq.TextChanged += new System.EventHandler(this.tb2Freq_TextChanged);
            // 
            // btnMF2KVR
            // 
            this.btnMF2KVR.Font = new System.Drawing.Font("Arial" , 14.25F , System.Drawing.FontStyle.Bold);
            this.btnMF2KVR.Location = new System.Drawing.Point(38 , 100);
            this.btnMF2KVR.Name = "btnMF2KVR";
            this.btnMF2KVR.Size = new System.Drawing.Size(85 , 83);
            this.btnMF2KVR.TabIndex = 11;
            this.btnMF2KVR.Text = "حساب";
            this.btnMF2KVR.UseVisualStyleBackColor = true;
            this.btnMF2KVR.Click += new System.EventHandler(this.btnMF2KVR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343 , 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113 , 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "ميكروفاراد";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352 , 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95 , 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "(ك.ف.ر)";
            // 
            // tb2KVR
            // 
            this.tb2KVR.Location = new System.Drawing.Point(140 , 217);
            this.tb2KVR.MaxLength = 5;
            this.tb2KVR.Name = "tb2KVR";
            this.tb2KVR.Size = new System.Drawing.Size(159 , 33);
            this.tb2KVR.TabIndex = 8;
            // 
            // tb2MF
            // 
            this.tb2MF.Location = new System.Drawing.Point(140 , 56);
            this.tb2MF.Name = "tb2MF";
            this.tb2MF.Size = new System.Drawing.Size(159 , 33);
            this.tb2MF.TabIndex = 7;
            this.tb2MF.TextChanged += new System.EventHandler(this.tb2MF_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105 , 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360 , 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "التحويل من ميكروفاراد الى (ك.ف.ر)";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F , 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904 , 501);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7 , 6 , 7 , 6);
            this.Name = "frmMainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جنرال الكترون | المهندس محمد كوكش";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCapacitorKVR;
        private System.Windows.Forms.TextBox tbDesiredPF;
        private System.Windows.Forms.TextBox tbKw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCurrentPF;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKVR2MF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb1MF;
        private System.Windows.Forms.TextBox tb1KVR;
        private System.Windows.Forms.Button btnMF2KVR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb2KVR;
        private System.Windows.Forms.TextBox tb2MF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb1Volt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb1Freq;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb2Volt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb2Freq;
        private System.Windows.Forms.Label label16;
    }
}

