
namespace MINIProjektUPB
{
    partial class podatkiodijaku
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
            this.imeBox = new System.Windows.Forms.TextBox();
            this.priimekBox = new System.Windows.Forms.TextBox();
            this.solaBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.urediButton = new System.Windows.Forms.Button();
            this.potrdiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeBox
            // 
            this.imeBox.Enabled = false;
            this.imeBox.Location = new System.Drawing.Point(177, 40);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(200, 20);
            this.imeBox.TabIndex = 0;
            // 
            // priimekBox
            // 
            this.priimekBox.Enabled = false;
            this.priimekBox.Location = new System.Drawing.Point(177, 88);
            this.priimekBox.Name = "priimekBox";
            this.priimekBox.Size = new System.Drawing.Size(200, 20);
            this.priimekBox.TabIndex = 1;
            // 
            // solaBox
            // 
            this.solaBox.Enabled = false;
            this.solaBox.Location = new System.Drawing.Point(177, 137);
            this.solaBox.Name = "solaBox";
            this.solaBox.Size = new System.Drawing.Size(200, 20);
            this.solaBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naslov,
            this.URL,
            this.opis});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 253);
            this.dataGridView1.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // naslov
            // 
            this.naslov.HeaderText = "Naslov";
            this.naslov.Name = "naslov";
            this.naslov.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            // 
            // krajBox
            // 
            this.krajBox.Enabled = false;
            this.krajBox.FormattingEnabled = true;
            this.krajBox.Location = new System.Drawing.Point(177, 182);
            this.krajBox.Name = "krajBox";
            this.krajBox.Size = new System.Drawing.Size(200, 21);
            this.krajBox.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(177, 227);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Priimek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Datum rojstva:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kraj:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Šola:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ime:";
            // 
            // urediButton
            // 
            this.urediButton.Location = new System.Drawing.Point(542, 118);
            this.urediButton.Name = "urediButton";
            this.urediButton.Size = new System.Drawing.Size(190, 85);
            this.urediButton.TabIndex = 16;
            this.urediButton.Text = "Uredi podatke o dijaku";
            this.urediButton.UseVisualStyleBackColor = true;
            this.urediButton.Click += new System.EventHandler(this.urediButton_Click);
            // 
            // potrdiButton
            // 
            this.potrdiButton.Location = new System.Drawing.Point(177, 272);
            this.potrdiButton.Name = "potrdiButton";
            this.potrdiButton.Size = new System.Drawing.Size(200, 50);
            this.potrdiButton.TabIndex = 17;
            this.potrdiButton.Text = "Potrdi";
            this.potrdiButton.UseVisualStyleBackColor = true;
            // 
            // podatkiodijaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 618);
            this.Controls.Add(this.potrdiButton);
            this.Controls.Add(this.urediButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.krajBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.solaBox);
            this.Controls.Add(this.priimekBox);
            this.Controls.Add(this.imeBox);
            this.Name = "podatkiodijaku";
            this.Text = "podatkiodijaku";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.TextBox priimekBox;
        private System.Windows.Forms.TextBox solaBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.ComboBox krajBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button urediButton;
        private System.Windows.Forms.Button potrdiButton;
    }
}