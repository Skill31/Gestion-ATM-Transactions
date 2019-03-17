namespace GuichetSATM
{
    partial class Guichet
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
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EPGRadioBox = new System.Windows.Forms.RadioButton();
            this.CHQRadioBox = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PayFactureRadioBox = new System.Windows.Forms.RadioButton();
            this.TransfertRadioBox = new System.Windows.Forms.RadioButton();
            this.RetaritRadioBox = new System.Windows.Forms.RadioButton();
            this.DepotRadioBox = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(703, 552);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(168, 55);
            this.button13.TabIndex = 9;
            this.button13.Text = "Fermer";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(488, 552);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(160, 55);
            this.button12.TabIndex = 8;
            this.button12.Text = "Soumettre";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EPGRadioBox);
            this.groupBox3.Controls.Add(this.CHQRadioBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(488, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 167);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compte";
            // 
            // EPGRadioBox
            // 
            this.EPGRadioBox.AutoSize = true;
            this.EPGRadioBox.Location = new System.Drawing.Point(52, 112);
            this.EPGRadioBox.Name = "EPGRadioBox";
            this.EPGRadioBox.Size = new System.Drawing.Size(130, 33);
            this.EPGRadioBox.TabIndex = 1;
            this.EPGRadioBox.TabStop = true;
            this.EPGRadioBox.Text = "Epargne";
            this.EPGRadioBox.UseVisualStyleBackColor = true;
            // 
            // CHQRadioBox
            // 
            this.CHQRadioBox.AutoSize = true;
            this.CHQRadioBox.Location = new System.Drawing.Point(52, 57);
            this.CHQRadioBox.Name = "CHQRadioBox";
            this.CHQRadioBox.Size = new System.Drawing.Size(135, 33);
            this.CHQRadioBox.TabIndex = 0;
            this.CHQRadioBox.TabStop = true;
            this.CHQRadioBox.Text = "Chèques";
            this.CHQRadioBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PayFactureRadioBox);
            this.groupBox2.Controls.Add(this.TransfertRadioBox);
            this.groupBox2.Controls.Add(this.RetaritRadioBox);
            this.groupBox2.Controls.Add(this.DepotRadioBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(488, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 301);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // PayFactureRadioBox
            // 
            this.PayFactureRadioBox.AutoSize = true;
            this.PayFactureRadioBox.Location = new System.Drawing.Point(52, 236);
            this.PayFactureRadioBox.Name = "PayFactureRadioBox";
            this.PayFactureRadioBox.Size = new System.Drawing.Size(273, 33);
            this.PayFactureRadioBox.TabIndex = 3;
            this.PayFactureRadioBox.TabStop = true;
            this.PayFactureRadioBox.Text = "Paiement de Factures";
            this.PayFactureRadioBox.UseVisualStyleBackColor = true;
            this.PayFactureRadioBox.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // TransfertRadioBox
            // 
            this.TransfertRadioBox.AutoSize = true;
            this.TransfertRadioBox.Location = new System.Drawing.Point(52, 177);
            this.TransfertRadioBox.Name = "TransfertRadioBox";
            this.TransfertRadioBox.Size = new System.Drawing.Size(134, 33);
            this.TransfertRadioBox.TabIndex = 2;
            this.TransfertRadioBox.TabStop = true;
            this.TransfertRadioBox.Text = "Transfert";
            this.TransfertRadioBox.UseVisualStyleBackColor = true;
            this.TransfertRadioBox.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RetaritRadioBox
            // 
            this.RetaritRadioBox.AutoSize = true;
            this.RetaritRadioBox.Location = new System.Drawing.Point(52, 124);
            this.RetaritRadioBox.Name = "RetaritRadioBox";
            this.RetaritRadioBox.Size = new System.Drawing.Size(108, 33);
            this.RetaritRadioBox.TabIndex = 1;
            this.RetaritRadioBox.TabStop = true;
            this.RetaritRadioBox.Text = "Retrait";
            this.RetaritRadioBox.UseVisualStyleBackColor = true;
            this.RetaritRadioBox.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // DepotRadioBox
            // 
            this.DepotRadioBox.AutoSize = true;
            this.DepotRadioBox.Location = new System.Drawing.Point(52, 64);
            this.DepotRadioBox.Name = "DepotRadioBox";
            this.DepotRadioBox.Size = new System.Drawing.Size(103, 33);
            this.DepotRadioBox.TabIndex = 0;
            this.DepotRadioBox.TabStop = true;
            this.DepotRadioBox.Text = "Dépot";
            this.DepotRadioBox.UseVisualStyleBackColor = true;
            this.DepotRadioBox.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.AmountBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 580);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pavé Numérique";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(32, 373);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 75);
            this.button14.TabIndex = 13;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(149, 489);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(188, 35);
            this.AmountBox.TabIndex = 12;
            this.AmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Montant :";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(262, 373);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 10;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(149, 373);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(262, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(149, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(32, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(262, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guichet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 664);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Guichet";
            this.Text = "Guichet";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton EPGRadioBox;
        private System.Windows.Forms.RadioButton CHQRadioBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PayFactureRadioBox;
        private System.Windows.Forms.RadioButton TransfertRadioBox;
        private System.Windows.Forms.RadioButton RetaritRadioBox;
        private System.Windows.Forms.RadioButton DepotRadioBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
    }
}