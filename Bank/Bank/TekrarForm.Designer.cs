namespace Bank
{
    partial class TekrarForm
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
            this.Btn_Go = new System.Windows.Forms.Button();
            this.TxbPassportNumber = new System.Windows.Forms.TextBox();
            this.TxbAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateCredit = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Go
            // 
            this.Btn_Go.Location = new System.Drawing.Point(81, 258);
            this.Btn_Go.Name = "Btn_Go";
            this.Btn_Go.Size = new System.Drawing.Size(75, 23);
            this.Btn_Go.TabIndex = 1;
            this.Btn_Go.Text = "Go";
            this.Btn_Go.UseVisualStyleBackColor = true;
            this.Btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
            // 
            // TxbPassportNumber
            // 
            this.TxbPassportNumber.Location = new System.Drawing.Point(81, 59);
            this.TxbPassportNumber.Name = "TxbPassportNumber";
            this.TxbPassportNumber.Size = new System.Drawing.Size(149, 22);
            this.TxbPassportNumber.TabIndex = 2;
            // 
            // TxbAmount
            // 
            this.TxbAmount.Location = new System.Drawing.Point(81, 127);
            this.TxbAmount.Name = "TxbAmount";
            this.TxbAmount.Size = new System.Drawing.Size(149, 22);
            this.TxbAmount.TabIndex = 3;
            // 
            // dateTimePickerDateCredit
            // 
            this.dateTimePickerDateCredit.Location = new System.Drawing.Point(87, 203);
            this.dateTimePickerDateCredit.Name = "dateTimePickerDateCredit";
            this.dateTimePickerDateCredit.Size = new System.Drawing.Size(149, 22);
            this.dateTimePickerDateCredit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PassportNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            // 
            // TekrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateCredit);
            this.Controls.Add(this.TxbAmount);
            this.Controls.Add(this.TxbPassportNumber);
            this.Controls.Add(this.Btn_Go);
            this.Name = "TekrarForm";
            this.Text = "TekrarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Go;
        private System.Windows.Forms.TextBox TxbPassportNumber;
        private System.Windows.Forms.TextBox TxbAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}