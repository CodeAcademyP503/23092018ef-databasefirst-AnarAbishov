﻿namespace Bank
{
    partial class MainForm
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbPassportNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.Btn_tekrarCredit = new System.Windows.Forms.Button();
            this.Btn_showAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(43, 58);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(132, 22);
            this.txbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(43, 139);
            this.txbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(132, 22);
            this.txbSurname.TabIndex = 3;
            // 
            // txbPassportNumber
            // 
            this.txbPassportNumber.Location = new System.Drawing.Point(43, 233);
            this.txbPassportNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassportNumber.Name = "txbPassportNumber";
            this.txbPassportNumber.Size = new System.Drawing.Size(132, 22);
            this.txbPassportNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "PassportNumber";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGo.Location = new System.Drawing.Point(43, 322);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(132, 34);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Btn_tekrarCredit
            // 
            this.Btn_tekrarCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_tekrarCredit.Location = new System.Drawing.Point(317, 317);
            this.Btn_tekrarCredit.Name = "Btn_tekrarCredit";
            this.Btn_tekrarCredit.Size = new System.Drawing.Size(157, 39);
            this.Btn_tekrarCredit.TabIndex = 7;
            this.Btn_tekrarCredit.Text = "Tekrar Kredit";
            this.Btn_tekrarCredit.UseVisualStyleBackColor = false;
            this.Btn_tekrarCredit.Click += new System.EventHandler(this.Btn_tekrarCredit_Click);
            // 
            // Btn_showAll
            // 
            this.Btn_showAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_showAll.Location = new System.Drawing.Point(317, 254);
            this.Btn_showAll.Name = "Btn_showAll";
            this.Btn_showAll.Size = new System.Drawing.Size(157, 35);
            this.Btn_showAll.TabIndex = 8;
            this.Btn_showAll.Text = "Show All";
            this.Btn_showAll.UseVisualStyleBackColor = false;
            this.Btn_showAll.Click += new System.EventHandler(this.Btn_showAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 420);
            this.Controls.Add(this.Btn_showAll);
            this.Controls.Add(this.Btn_tekrarCredit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txbPassportNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbPassportNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button Btn_tekrarCredit;
        private System.Windows.Forms.Button Btn_showAll;
    }
}

