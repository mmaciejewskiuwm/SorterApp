﻿namespace AidsProjekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxLiczba = new TextBox();
            tbxWynik = new TextBox();
            btSB = new Button();
            btSS = new Button();
            btSI = new Button();
            btSM = new Button();
            btSQ = new Button();
            chbPrzelacz = new CheckBox();
            nudDlugosc = new NumericUpDown();
            btGen = new Button();
            lbNapis = new Label();
            lbCzas = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDlugosc).BeginInit();
            SuspendLayout();
            // 
            // tbxLiczba
            // 
            tbxLiczba.Location = new Point(76, 60);
            tbxLiczba.Multiline = true;
            tbxLiczba.Name = "tbxLiczba";
            tbxLiczba.Size = new Size(185, 37);
            tbxLiczba.TabIndex = 0;
            tbxLiczba.TextChanged += tbxLiczba_TextChanged;
            // 
            // tbxWynik
            // 
            tbxWynik.Location = new Point(76, 172);
            tbxWynik.Multiline = true;
            tbxWynik.Name = "tbxWynik";
            tbxWynik.Size = new Size(185, 39);
            tbxWynik.TabIndex = 1;
            tbxWynik.TextChanged += tbxWynik_TextChanged;
            // 
            // btSB
            // 
            btSB.Location = new Point(98, 315);
            btSB.Name = "btSB";
            btSB.Size = new Size(75, 47);
            btSB.TabIndex = 2;
            btSB.Text = "button1";
            btSB.UseVisualStyleBackColor = true;
            btSB.Click += btSB_Click;
            // 
            // btSS
            // 
            btSS.Location = new Point(239, 315);
            btSS.Name = "btSS";
            btSS.Size = new Size(75, 47);
            btSS.TabIndex = 3;
            btSS.Text = "button2";
            btSS.UseVisualStyleBackColor = true;
            // 
            // btSI
            // 
            btSI.Location = new Point(378, 315);
            btSI.Name = "btSI";
            btSI.Size = new Size(75, 47);
            btSI.TabIndex = 4;
            btSI.Text = "button3";
            btSI.UseVisualStyleBackColor = true;
            // 
            // btSM
            // 
            btSM.Location = new Point(515, 315);
            btSM.Name = "btSM";
            btSM.Size = new Size(75, 47);
            btSM.TabIndex = 5;
            btSM.Text = "button4";
            btSM.UseVisualStyleBackColor = true;
            // 
            // btSQ
            // 
            btSQ.Location = new Point(656, 315);
            btSQ.Name = "btSQ";
            btSQ.Size = new Size(75, 47);
            btSQ.TabIndex = 6;
            btSQ.Text = "button5";
            btSQ.UseVisualStyleBackColor = true;
            // 
            // chbPrzelacz
            // 
            chbPrzelacz.AutoSize = true;
            chbPrzelacz.Location = new Point(351, 62);
            chbPrzelacz.Name = "chbPrzelacz";
            chbPrzelacz.Size = new Size(83, 19);
            chbPrzelacz.TabIndex = 7;
            chbPrzelacz.Text = "checkBox1";
            chbPrzelacz.UseVisualStyleBackColor = true;
            // 
            // nudDlugosc
            // 
            nudDlugosc.Location = new Point(536, 58);
            nudDlugosc.Name = "nudDlugosc";
            nudDlugosc.Size = new Size(182, 23);
            nudDlugosc.TabIndex = 8;
            // 
            // btGen
            // 
            btGen.Location = new Point(560, 107);
            btGen.Name = "btGen";
            btGen.Size = new Size(116, 43);
            btGen.TabIndex = 9;
            btGen.Text = "button1";
            btGen.UseVisualStyleBackColor = true;
            // 
            // lbNapis
            // 
            lbNapis.AutoSize = true;
            lbNapis.Location = new Point(496, 196);
            lbNapis.Name = "lbNapis";
            lbNapis.Size = new Size(38, 15);
            lbNapis.TabIndex = 10;
            lbNapis.Text = "label1";
            // 
            // lbCzas
            // 
            lbCzas.AutoSize = true;
            lbCzas.Location = new Point(598, 196);
            lbCzas.Name = "lbCzas";
            lbCzas.Size = new Size(38, 15);
            lbCzas.TabIndex = 11;
            lbCzas.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCzas);
            Controls.Add(lbNapis);
            Controls.Add(btGen);
            Controls.Add(nudDlugosc);
            Controls.Add(chbPrzelacz);
            Controls.Add(btSQ);
            Controls.Add(btSM);
            Controls.Add(btSI);
            Controls.Add(btSS);
            Controls.Add(btSB);
            Controls.Add(tbxWynik);
            Controls.Add(tbxLiczba);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDlugosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxLiczba;
        private TextBox tbxWynik;
        private Button btSB;
        private Button btSS;
        private Button btSI;
        private Button btSM;
        private Button btSQ;
        private CheckBox chbPrzelacz;
        private NumericUpDown nudDlugosc;
        private Button btGen;
        private Label lbNapis;
        private Label lbCzas;
    }
}