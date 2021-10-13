
namespace EncryptionApp
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblBasicCeasar = new System.Windows.Forms.Label();
            this.lblSeperatedCeasar = new System.Windows.Forms.Label();
            this.lblBasicKey = new System.Windows.Forms.Label();
            this.lbl2Dkey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(778, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 38);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Go";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblBasicCeasar
            // 
            this.lblBasicCeasar.AutoSize = true;
            this.lblBasicCeasar.Location = new System.Drawing.Point(10, 80);
            this.lblBasicCeasar.Name = "lblBasicCeasar";
            this.lblBasicCeasar.Size = new System.Drawing.Size(35, 13);
            this.lblBasicCeasar.TabIndex = 2;
            this.lblBasicCeasar.Text = "label1";
            // 
            // lblSeperatedCeasar
            // 
            this.lblSeperatedCeasar.AutoSize = true;
            this.lblSeperatedCeasar.Location = new System.Drawing.Point(10, 110);
            this.lblSeperatedCeasar.Name = "lblSeperatedCeasar";
            this.lblSeperatedCeasar.Size = new System.Drawing.Size(35, 13);
            this.lblSeperatedCeasar.TabIndex = 3;
            this.lblSeperatedCeasar.Text = "label2";
            // 
            // lblBasicKey
            // 
            this.lblBasicKey.AutoSize = true;
            this.lblBasicKey.Location = new System.Drawing.Point(10, 140);
            this.lblBasicKey.Name = "lblBasicKey";
            this.lblBasicKey.Size = new System.Drawing.Size(35, 13);
            this.lblBasicKey.TabIndex = 4;
            this.lblBasicKey.Text = "label3";
            // 
            // lbl2Dkey
            // 
            this.lbl2Dkey.AutoSize = true;
            this.lbl2Dkey.Location = new System.Drawing.Point(10, 170);
            this.lbl2Dkey.Name = "lbl2Dkey";
            this.lbl2Dkey.Size = new System.Drawing.Size(35, 13);
            this.lbl2Dkey.TabIndex = 5;
            this.lbl2Dkey.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.lbl2Dkey);
            this.Controls.Add(this.lblBasicKey);
            this.Controls.Add(this.lblSeperatedCeasar);
            this.Controls.Add(this.lblBasicCeasar);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblBasicCeasar;
        private System.Windows.Forms.Label lblSeperatedCeasar;
        private System.Windows.Forms.Label lblBasicKey;
        private System.Windows.Forms.Label lbl2Dkey;
    }
}

