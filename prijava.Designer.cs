
namespace MINIProjektUPB
{
    partial class prijava
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
            this.prijavaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gesloTextBox = new System.Windows.Forms.TextBox();
            this.gmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(348, 339);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(100, 23);
            this.prijavaButton.TabIndex = 11;
            this.prijavaButton.Text = "Potrdi";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Geslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gmail:";
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.Location = new System.Drawing.Point(348, 291);
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.Size = new System.Drawing.Size(100, 20);
            this.gesloTextBox.TabIndex = 8;
            // 
            // gmailTextBox
            // 
            this.gmailTextBox.Location = new System.Drawing.Point(348, 243);
            this.gmailTextBox.Name = "gmailTextBox";
            this.gmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.gmailTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRIJAVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 63);
            this.label4.TabIndex = 12;
            this.label4.Text = "UPB - MINI PROJEKT";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(345, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Še niste registrirani?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gesloTextBox);
            this.Controls.Add(this.gmailTextBox);
            this.Controls.Add(this.label1);
            this.Name = "prijava";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.TextBox gmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

