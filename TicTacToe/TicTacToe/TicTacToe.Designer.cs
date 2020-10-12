namespace TicTacToe
{
    partial class TicTacToe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT22 = new System.Windows.Forms.Button();
            this.BT21 = new System.Windows.Forms.Button();
            this.BT20 = new System.Windows.Forms.Button();
            this.BT12 = new System.Windows.Forms.Button();
            this.BT11 = new System.Windows.Forms.Button();
            this.BT10 = new System.Windows.Forms.Button();
            this.BT02 = new System.Windows.Forms.Button();
            this.BT01 = new System.Windows.Forms.Button();
            this.BT00 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtDInf = new System.Windows.Forms.RadioButton();
            this.rbtD4 = new System.Windows.Forms.RadioButton();
            this.rbtD3 = new System.Windows.Forms.RadioButton();
            this.rbtD2 = new System.Windows.Forms.RadioButton();
            this.rbtD1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btChoiLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbOWin = new System.Windows.Forms.Label();
            this.lbBound = new System.Windows.Forms.Label();
            this.lbXWin = new System.Windows.Forms.Label();
            this.cbAlphaBeta = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(214, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 373);
            this.panel1.TabIndex = 3;
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
            this.BT22.Click += new System.EventHandler(this.BT22_Click);
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
            this.BT21.Click += new System.EventHandler(this.BT21_Click);
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
            this.BT20.Click += new System.EventHandler(this.BT20_Click);
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
            this.BT12.Click += new System.EventHandler(this.BT12_Click);
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
            this.BT11.Click += new System.EventHandler(this.BT11_Click);
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
            this.BT10.Click += new System.EventHandler(this.BT10_Click);
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
            this.BT02.Click += new System.EventHandler(this.BT02_Click);
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
            this.BT01.Click += new System.EventHandler(this.BT01_Click);
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
            this.BT00.Click += new System.EventHandler(this.BT00_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.rbtDInf);
            this.panel2.Controls.Add(this.rbtD4);
            this.panel2.Controls.Add(this.rbtD3);
            this.panel2.Controls.Add(this.rbtD2);
            this.panel2.Controls.Add(this.rbtD1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(108, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 50);
            this.panel2.TabIndex = 4;
            // 
            // rbtDInf
            // 
            this.rbtDInf.AutoSize = true;
            this.rbtDInf.Location = new System.Drawing.Point(498, 13);
            this.rbtDInf.Name = "rbtDInf";
            this.rbtDInf.Size = new System.Drawing.Size(60, 24);
            this.rbtDInf.TabIndex = 5;
            this.rbtDInf.TabStop = true;
            this.rbtDInf.Text = "INF";
            this.rbtDInf.UseVisualStyleBackColor = true;
            this.rbtDInf.CheckedChanged += new System.EventHandler(this.rbt_change);
            // 
            // rbtD4
            // 
            this.rbtD4.AutoSize = true;
            this.rbtD4.Location = new System.Drawing.Point(405, 13);
            this.rbtD4.Name = "rbtD4";
            this.rbtD4.Size = new System.Drawing.Size(43, 24);
            this.rbtD4.TabIndex = 5;
            this.rbtD4.TabStop = true;
            this.rbtD4.Text = "4";
            this.rbtD4.UseVisualStyleBackColor = true;
            this.rbtD4.CheckedChanged += new System.EventHandler(this.rbt_change);
            // 
            // rbtD3
            // 
            this.rbtD3.AutoSize = true;
            this.rbtD3.Location = new System.Drawing.Point(312, 13);
            this.rbtD3.Name = "rbtD3";
            this.rbtD3.Size = new System.Drawing.Size(43, 24);
            this.rbtD3.TabIndex = 5;
            this.rbtD3.TabStop = true;
            this.rbtD3.Text = "3";
            this.rbtD3.UseVisualStyleBackColor = true;
            this.rbtD3.CheckedChanged += new System.EventHandler(this.rbt_change);
            // 
            // rbtD2
            // 
            this.rbtD2.AutoSize = true;
            this.rbtD2.Location = new System.Drawing.Point(219, 13);
            this.rbtD2.Name = "rbtD2";
            this.rbtD2.Size = new System.Drawing.Size(43, 24);
            this.rbtD2.TabIndex = 5;
            this.rbtD2.TabStop = true;
            this.rbtD2.Text = "2";
            this.rbtD2.UseVisualStyleBackColor = true;
            this.rbtD2.CheckedChanged += new System.EventHandler(this.rbt_change);
            // 
            // rbtD1
            // 
            this.rbtD1.AutoSize = true;
            this.rbtD1.Location = new System.Drawing.Point(126, 13);
            this.rbtD1.Name = "rbtD1";
            this.rbtD1.Size = new System.Drawing.Size(43, 24);
            this.rbtD1.TabIndex = 1;
            this.rbtD1.TabStop = true;
            this.rbtD1.Text = "1";
            this.rbtD1.UseVisualStyleBackColor = true;
            this.rbtD1.CheckedChanged += new System.EventHandler(this.rbt_change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depth:";
            // 
            // btChoiLai
            // 
            this.btChoiLai.BackColor = System.Drawing.Color.MistyRose;
            this.btChoiLai.Enabled = false;
            this.btChoiLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoiLai.ForeColor = System.Drawing.Color.Red;
            this.btChoiLai.Location = new System.Drawing.Point(267, 620);
            this.btChoiLai.Name = "btChoiLai";
            this.btChoiLai.Size = new System.Drawing.Size(264, 64);
            this.btChoiLai.TabIndex = 5;
            this.btChoiLai.Text = "Restart";
            this.btChoiLai.UseVisualStyleBackColor = false;
            this.btChoiLai.Click += new System.EventHandler(this.btChoiLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player(X)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Computer(O)";
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
            this.panel3.Location = new System.Drawing.Point(110, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 78);
            this.panel3.TabIndex = 9;
            // 
            // lbOWin
            // 
            this.lbOWin.AutoSize = true;
            this.lbOWin.Location = new System.Drawing.Point(488, 46);
            this.lbOWin.Name = "lbOWin";
            this.lbOWin.Size = new System.Drawing.Size(18, 20);
            this.lbOWin.TabIndex = 10;
            this.lbOWin.Text = "0";
            // 
            // lbBound
            // 
            this.lbBound.AutoSize = true;
            this.lbBound.Location = new System.Drawing.Point(276, 46);
            this.lbBound.Name = "lbBound";
            this.lbBound.Size = new System.Drawing.Size(18, 20);
            this.lbBound.TabIndex = 10;
            this.lbBound.Text = "0";
            // 
            // lbXWin
            // 
            this.lbXWin.AutoSize = true;
            this.lbXWin.Location = new System.Drawing.Point(36, 46);
            this.lbXWin.Name = "lbXWin";
            this.lbXWin.Size = new System.Drawing.Size(18, 20);
            this.lbXWin.TabIndex = 9;
            this.lbXWin.Text = "0";
            // 
            // cbAlphaBeta
            // 
            this.cbAlphaBeta.AutoSize = true;
            this.cbAlphaBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlphaBeta.Location = new System.Drawing.Point(545, 641);
            this.cbAlphaBeta.Name = "cbAlphaBeta";
            this.cbAlphaBeta.Size = new System.Drawing.Size(205, 26);
            this.cbAlphaBeta.TabIndex = 1;
            this.cbAlphaBeta.Text = "Alpha–beta pruning";
            this.cbAlphaBeta.UseVisualStyleBackColor = true;
            this.cbAlphaBeta.CheckedChanged += new System.EventHandler(this.checkbox_change);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(262, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "PLAYER(X) vs BOSS(O)";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAlphaBeta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btChoiLai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic tac toe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT22;
        private System.Windows.Forms.Button BT21;
        private System.Windows.Forms.Button BT20;
        private System.Windows.Forms.Button BT12;
        private System.Windows.Forms.Button BT11;
        private System.Windows.Forms.Button BT10;
        private System.Windows.Forms.Button BT02;
        private System.Windows.Forms.Button BT01;
        private System.Windows.Forms.Button BT00;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtDInf;
        private System.Windows.Forms.RadioButton rbtD4;
        private System.Windows.Forms.RadioButton rbtD3;
        private System.Windows.Forms.RadioButton rbtD2;
        private System.Windows.Forms.RadioButton rbtD1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChoiLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbOWin;
        private System.Windows.Forms.Label lbBound;
        private System.Windows.Forms.Label lbXWin;
        private System.Windows.Forms.CheckBox cbAlphaBeta;
        private System.Windows.Forms.Label label6;
    }
}

