namespace TicTacToe
{
    partial class AutoTicTacToe
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
            this.cbAlphaBeta = new System.Windows.Forms.CheckBox();
            this.lbOWin = new System.Windows.Forms.Label();
            this.lbBound = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbXWin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btChoiLai = new System.Windows.Forms.Button();
            this.rbtDXInf = new System.Windows.Forms.RadioButton();
            this.rbtDX4 = new System.Windows.Forms.RadioButton();
            this.BT01 = new System.Windows.Forms.Button();
            this.BT00 = new System.Windows.Forms.Button();
            this.rbtDX3 = new System.Windows.Forms.RadioButton();
            this.rbtDX2 = new System.Windows.Forms.RadioButton();
            this.rbtDX1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BT22 = new System.Windows.Forms.Button();
            this.BT21 = new System.Windows.Forms.Button();
            this.BT20 = new System.Windows.Forms.Button();
            this.BT12 = new System.Windows.Forms.Button();
            this.BT11 = new System.Windows.Forms.Button();
            this.BT10 = new System.Windows.Forms.Button();
            this.BT02 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtDOInf = new System.Windows.Forms.RadioButton();
            this.rbtDO4 = new System.Windows.Forms.RadioButton();
            this.rbtDO3 = new System.Windows.Forms.RadioButton();
            this.rbtDO2 = new System.Windows.Forms.RadioButton();
            this.rbtDO1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAlphaBeta
            // 
            this.cbAlphaBeta.AutoSize = true;
            this.cbAlphaBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlphaBeta.Location = new System.Drawing.Point(495, 657);
            this.cbAlphaBeta.Name = "cbAlphaBeta";
            this.cbAlphaBeta.Size = new System.Drawing.Size(205, 26);
            this.cbAlphaBeta.TabIndex = 10;
            this.cbAlphaBeta.Text = "Alpha–beta pruning";
            this.cbAlphaBeta.UseVisualStyleBackColor = true;
            // 
            // lbOWin
            // 
            this.lbOWin.AutoSize = true;
            this.lbOWin.Location = new System.Drawing.Point(597, 46);
            this.lbOWin.Name = "lbOWin";
            this.lbOWin.Size = new System.Drawing.Size(18, 20);
            this.lbOWin.TabIndex = 10;
            this.lbOWin.Text = "0";
            // 
            // lbBound
            // 
            this.lbBound.AutoSize = true;
            this.lbBound.Location = new System.Drawing.Point(318, 46);
            this.lbBound.Name = "lbBound";
            this.lbBound.Size = new System.Drawing.Size(18, 20);
            this.lbBound.TabIndex = 10;
            this.lbBound.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.lbOWin);
            this.panel3.Controls.Add(this.lbBound);
            this.panel3.Controls.Add(this.lbXWin);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(44, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 78);
            this.panel3.TabIndex = 14;
            // 
            // lbXWin
            // 
            this.lbXWin.AutoSize = true;
            this.lbXWin.Location = new System.Drawing.Point(39, 46);
            this.lbXWin.Name = "lbXWin";
            this.lbXWin.Size = new System.Drawing.Size(18, 20);
            this.lbXWin.TabIndex = 9;
            this.lbXWin.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(566, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bot(O)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bot(X)";
            // 
            // btChoiLai
            // 
            this.btChoiLai.BackColor = System.Drawing.Color.MistyRose;
            this.btChoiLai.Enabled = false;
            this.btChoiLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoiLai.ForeColor = System.Drawing.Color.Red;
            this.btChoiLai.Location = new System.Drawing.Point(263, 632);
            this.btChoiLai.Name = "btChoiLai";
            this.btChoiLai.Size = new System.Drawing.Size(214, 63);
            this.btChoiLai.TabIndex = 13;
            this.btChoiLai.Text = "Restart";
            this.btChoiLai.UseVisualStyleBackColor = false;
            this.btChoiLai.Click += new System.EventHandler(this.btChoiLai_Click);
            // 
            // rbtDXInf
            // 
            this.rbtDXInf.AutoSize = true;
            this.rbtDXInf.Location = new System.Drawing.Point(25, 323);
            this.rbtDXInf.Name = "rbtDXInf";
            this.rbtDXInf.Size = new System.Drawing.Size(60, 24);
            this.rbtDXInf.TabIndex = 5;
            this.rbtDXInf.TabStop = true;
            this.rbtDXInf.Text = "INF";
            this.rbtDXInf.UseVisualStyleBackColor = true;
            this.rbtDXInf.CheckedChanged += new System.EventHandler(this.rbt_changeX);
            // 
            // rbtDX4
            // 
            this.rbtDX4.AutoSize = true;
            this.rbtDX4.Location = new System.Drawing.Point(25, 259);
            this.rbtDX4.Name = "rbtDX4";
            this.rbtDX4.Size = new System.Drawing.Size(43, 24);
            this.rbtDX4.TabIndex = 5;
            this.rbtDX4.TabStop = true;
            this.rbtDX4.Text = "4";
            this.rbtDX4.UseVisualStyleBackColor = true;
            this.rbtDX4.CheckedChanged += new System.EventHandler(this.rbt_changeX);
            // 
            // BT01
            // 
            this.BT01.BackColor = System.Drawing.Color.White;
            this.BT01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT01.Location = new System.Drawing.Point(124, -1);
            this.BT01.Name = "BT01";
            this.BT01.Size = new System.Drawing.Size(125, 125);
            this.BT01.TabIndex = 2;
            this.BT01.UseVisualStyleBackColor = false;
            // 
            // BT00
            // 
            this.BT00.BackColor = System.Drawing.Color.White;
            this.BT00.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT00.ForeColor = System.Drawing.Color.Black;
            this.BT00.Location = new System.Drawing.Point(-1, -1);
            this.BT00.Name = "BT00";
            this.BT00.Size = new System.Drawing.Size(125, 125);
            this.BT00.TabIndex = 0;
            this.BT00.UseVisualStyleBackColor = false;
            // 
            // rbtDX3
            // 
            this.rbtDX3.AutoSize = true;
            this.rbtDX3.Location = new System.Drawing.Point(25, 190);
            this.rbtDX3.Name = "rbtDX3";
            this.rbtDX3.Size = new System.Drawing.Size(43, 24);
            this.rbtDX3.TabIndex = 5;
            this.rbtDX3.TabStop = true;
            this.rbtDX3.Text = "3";
            this.rbtDX3.UseVisualStyleBackColor = true;
            this.rbtDX3.CheckedChanged += new System.EventHandler(this.rbt_changeX);
            // 
            // rbtDX2
            // 
            this.rbtDX2.AutoSize = true;
            this.rbtDX2.Location = new System.Drawing.Point(25, 125);
            this.rbtDX2.Name = "rbtDX2";
            this.rbtDX2.Size = new System.Drawing.Size(43, 24);
            this.rbtDX2.TabIndex = 5;
            this.rbtDX2.TabStop = true;
            this.rbtDX2.Text = "2";
            this.rbtDX2.UseVisualStyleBackColor = true;
            this.rbtDX2.CheckedChanged += new System.EventHandler(this.rbt_changeX);
            // 
            // rbtDX1
            // 
            this.rbtDX1.AutoSize = true;
            this.rbtDX1.Location = new System.Drawing.Point(25, 60);
            this.rbtDX1.Name = "rbtDX1";
            this.rbtDX1.Size = new System.Drawing.Size(43, 24);
            this.rbtDX1.TabIndex = 1;
            this.rbtDX1.TabStop = true;
            this.rbtDX1.Text = "1";
            this.rbtDX1.UseVisualStyleBackColor = true;
            this.rbtDX1.CheckedChanged += new System.EventHandler(this.rbt_changeX);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depth(X):";
            // 
            // BT22
            // 
            this.BT22.BackColor = System.Drawing.Color.White;
            this.BT22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT22.Location = new System.Drawing.Point(249, 249);
            this.BT22.Name = "BT22";
            this.BT22.Size = new System.Drawing.Size(125, 125);
            this.BT22.TabIndex = 9;
            this.BT22.UseVisualStyleBackColor = false;
            // 
            // BT21
            // 
            this.BT21.BackColor = System.Drawing.Color.White;
            this.BT21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT21.ForeColor = System.Drawing.Color.Black;
            this.BT21.Location = new System.Drawing.Point(124, 249);
            this.BT21.Name = "BT21";
            this.BT21.Size = new System.Drawing.Size(125, 125);
            this.BT21.TabIndex = 8;
            this.BT21.UseVisualStyleBackColor = false;
            // 
            // BT20
            // 
            this.BT20.BackColor = System.Drawing.Color.White;
            this.BT20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT20.ForeColor = System.Drawing.Color.Black;
            this.BT20.Location = new System.Drawing.Point(-1, 249);
            this.BT20.Name = "BT20";
            this.BT20.Size = new System.Drawing.Size(125, 125);
            this.BT20.TabIndex = 7;
            this.BT20.UseVisualStyleBackColor = false;
            // 
            // BT12
            // 
            this.BT12.BackColor = System.Drawing.Color.White;
            this.BT12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT12.ForeColor = System.Drawing.Color.Black;
            this.BT12.Location = new System.Drawing.Point(249, 124);
            this.BT12.Name = "BT12";
            this.BT12.Size = new System.Drawing.Size(125, 125);
            this.BT12.TabIndex = 6;
            this.BT12.UseVisualStyleBackColor = false;
            // 
            // BT11
            // 
            this.BT11.BackColor = System.Drawing.Color.White;
            this.BT11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT11.Location = new System.Drawing.Point(124, 124);
            this.BT11.Name = "BT11";
            this.BT11.Size = new System.Drawing.Size(125, 125);
            this.BT11.TabIndex = 5;
            this.BT11.UseVisualStyleBackColor = false;
            // 
            // BT10
            // 
            this.BT10.BackColor = System.Drawing.Color.White;
            this.BT10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT10.Location = new System.Drawing.Point(-1, 124);
            this.BT10.Name = "BT10";
            this.BT10.Size = new System.Drawing.Size(125, 125);
            this.BT10.TabIndex = 4;
            this.BT10.UseVisualStyleBackColor = false;
            // 
            // BT02
            // 
            this.BT02.BackColor = System.Drawing.Color.White;
            this.BT02.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT02.ForeColor = System.Drawing.Color.Black;
            this.BT02.Location = new System.Drawing.Point(249, -1);
            this.BT02.Name = "BT02";
            this.BT02.Size = new System.Drawing.Size(125, 125);
            this.BT02.TabIndex = 3;
            this.BT02.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.rbtDXInf);
            this.panel2.Controls.Add(this.rbtDX4);
            this.panel2.Controls.Add(this.rbtDX3);
            this.panel2.Controls.Add(this.rbtDX2);
            this.panel2.Controls.Add(this.rbtDX1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 375);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.BT22);
            this.panel1.Controls.Add(this.BT21);
            this.panel1.Controls.Add(this.BT20);
            this.panel1.Controls.Add(this.BT12);
            this.panel1.Controls.Add(this.BT11);
            this.panel1.Controls.Add(this.BT10);
            this.panel1.Controls.Add(this.BT02);
            this.panel1.Controls.Add(this.BT01);
            this.panel1.Controls.Add(this.BT00);
            this.panel1.Location = new System.Drawing.Point(186, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 373);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.rbtDOInf);
            this.panel4.Controls.Add(this.rbtDO4);
            this.panel4.Controls.Add(this.rbtDO3);
            this.panel4.Controls.Add(this.rbtDO2);
            this.panel4.Controls.Add(this.rbtDO1);
            this.panel4.Location = new System.Drawing.Point(590, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 375);
            this.panel4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Depth(O):";
            // 
            // rbtDOInf
            // 
            this.rbtDOInf.AutoSize = true;
            this.rbtDOInf.Location = new System.Drawing.Point(25, 323);
            this.rbtDOInf.Name = "rbtDOInf";
            this.rbtDOInf.Size = new System.Drawing.Size(60, 24);
            this.rbtDOInf.TabIndex = 5;
            this.rbtDOInf.TabStop = true;
            this.rbtDOInf.Text = "INF";
            this.rbtDOInf.UseVisualStyleBackColor = true;
            this.rbtDOInf.CheckedChanged += new System.EventHandler(this.rbt_changeO);
            // 
            // rbtDO4
            // 
            this.rbtDO4.AutoSize = true;
            this.rbtDO4.Location = new System.Drawing.Point(25, 259);
            this.rbtDO4.Name = "rbtDO4";
            this.rbtDO4.Size = new System.Drawing.Size(43, 24);
            this.rbtDO4.TabIndex = 5;
            this.rbtDO4.TabStop = true;
            this.rbtDO4.Text = "4";
            this.rbtDO4.UseVisualStyleBackColor = true;
            this.rbtDO4.CheckedChanged += new System.EventHandler(this.rbt_changeO);
            // 
            // rbtDO3
            // 
            this.rbtDO3.AutoSize = true;
            this.rbtDO3.Location = new System.Drawing.Point(25, 190);
            this.rbtDO3.Name = "rbtDO3";
            this.rbtDO3.Size = new System.Drawing.Size(43, 24);
            this.rbtDO3.TabIndex = 5;
            this.rbtDO3.TabStop = true;
            this.rbtDO3.Text = "3";
            this.rbtDO3.UseVisualStyleBackColor = true;
            this.rbtDO3.CheckedChanged += new System.EventHandler(this.rbt_changeO);
            // 
            // rbtDO2
            // 
            this.rbtDO2.AutoSize = true;
            this.rbtDO2.Location = new System.Drawing.Point(25, 125);
            this.rbtDO2.Name = "rbtDO2";
            this.rbtDO2.Size = new System.Drawing.Size(43, 24);
            this.rbtDO2.TabIndex = 5;
            this.rbtDO2.TabStop = true;
            this.rbtDO2.Text = "2";
            this.rbtDO2.UseVisualStyleBackColor = true;
            this.rbtDO2.CheckedChanged += new System.EventHandler(this.rbt_changeO);
            // 
            // rbtDO1
            // 
            this.rbtDO1.AutoSize = true;
            this.rbtDO1.Location = new System.Drawing.Point(25, 60);
            this.rbtDO1.Name = "rbtDO1";
            this.rbtDO1.Size = new System.Drawing.Size(43, 24);
            this.rbtDO1.TabIndex = 1;
            this.rbtDO1.TabStop = true;
            this.rbtDO1.Text = "1";
            this.rbtDO1.UseVisualStyleBackColor = true;
            this.rbtDO1.CheckedChanged += new System.EventHandler(this.rbt_changeO);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(258, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "BOSS(X) vs BOSS(O)";
            // 
            // AutoTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 723);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cbAlphaBeta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btChoiLai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AutoTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoTicTacToe";
            this.Load += new System.EventHandler(this.AutoTicTacToe_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAlphaBeta;
        private System.Windows.Forms.Label lbOWin;
        private System.Windows.Forms.Label lbBound;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbXWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btChoiLai;
        private System.Windows.Forms.RadioButton rbtDXInf;
        private System.Windows.Forms.RadioButton rbtDX4;
        private System.Windows.Forms.Button BT01;
        private System.Windows.Forms.Button BT00;
        private System.Windows.Forms.RadioButton rbtDX3;
        private System.Windows.Forms.RadioButton rbtDX2;
        private System.Windows.Forms.RadioButton rbtDX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT22;
        private System.Windows.Forms.Button BT21;
        private System.Windows.Forms.Button BT20;
        private System.Windows.Forms.Button BT12;
        private System.Windows.Forms.Button BT11;
        private System.Windows.Forms.Button BT10;
        private System.Windows.Forms.Button BT02;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtDOInf;
        private System.Windows.Forms.RadioButton rbtDO4;
        private System.Windows.Forms.RadioButton rbtDO3;
        private System.Windows.Forms.RadioButton rbtDO2;
        private System.Windows.Forms.RadioButton rbtDO1;
        private System.Windows.Forms.Label label6;
    }
}