
namespace MINIProjektUPB
{
    partial class registracija
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nazivBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gesloBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(351, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ste že prijavljeni?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Registracija";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Naziv:";
            // 
            // nazivBox
            // 
            this.nazivBox.Location = new System.Drawing.Point(345, 154);
            this.nazivBox.Name = "nazivBox";
            this.nazivBox.Size = new System.Drawing.Size(100, 20);
            this.nazivBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Geslo:";
            // 
            // gesloBox
            // 
            this.gesloBox.Location = new System.Drawing.Point(345, 268);
            this.gesloBox.Name = "gesloBox";
            this.gesloBox.Size = new System.Drawing.Size(100, 20);
            this.gesloBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "REGISTRACIJA:";
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(345, 209);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(100, 20);
            this.mailBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mail:";
            // 
            // registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazivBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gesloBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.label1);
            this.Name = "registracija";
            this.Text = "registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazivBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gesloBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label label1;
    }
}