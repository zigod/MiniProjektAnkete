
namespace MINIProjektUPB
{
    partial class main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nazivLabel1 = new System.Windows.Forms.Label();
            this.dodajAnketoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opisBox = new System.Windows.Forms.RichTextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.naslovBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nazivLabel2 = new System.Windows.Forms.Label();
            this.dijakiGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priimek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_roj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nazivLabel3 = new System.Windows.Forms.Label();
            this.krajBox = new System.Windows.Forms.ComboBox();
            this.dodajDijakaButton = new System.Windows.Forms.Button();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.solaBox = new System.Windows.Forms.TextBox();
            this.priimekBox = new System.Windows.Forms.TextBox();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dijakiGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 559);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nazivLabel1);
            this.tabPage1.Controls.Add(this.dodajAnketoButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.opisBox);
            this.tabPage1.Controls.Add(this.urlBox);
            this.tabPage1.Controls.Add(this.naslovBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DODAJANJE ANKET";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nazivLabel1
            // 
            this.nazivLabel1.AutoSize = true;
            this.nazivLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.nazivLabel1.Location = new System.Drawing.Point(1071, 3);
            this.nazivLabel1.Name = "nazivLabel1";
            this.nazivLabel1.Size = new System.Drawing.Size(41, 13);
            this.nazivLabel1.TabIndex = 11;
            this.nazivLabel1.Text = "label11";
            // 
            // dodajAnketoButton
            // 
            this.dodajAnketoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajAnketoButton.Location = new System.Drawing.Point(444, 279);
            this.dodajAnketoButton.Name = "dodajAnketoButton";
            this.dodajAnketoButton.Size = new System.Drawing.Size(183, 23);
            this.dodajAnketoButton.TabIndex = 10;
            this.dodajAnketoButton.Text = "DODAJ";
            this.dodajAnketoButton.UseVisualStyleBackColor = true;
            this.dodajAnketoButton.Click += new System.EventHandler(this.dodajAnketoButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(674, 76);
            this.label4.TabIndex = 9;
            this.label4.Text = "DODAJANJE ANKET";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naslov:";
            // 
            // opisBox
            // 
            this.opisBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opisBox.Location = new System.Drawing.Point(444, 150);
            this.opisBox.Name = "opisBox";
            this.opisBox.Size = new System.Drawing.Size(183, 96);
            this.opisBox.TabIndex = 5;
            this.opisBox.Text = "";
            // 
            // urlBox
            // 
            this.urlBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urlBox.Location = new System.Drawing.Point(444, 102);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(183, 20);
            this.urlBox.TabIndex = 2;
            // 
            // naslovBox
            // 
            this.naslovBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naslovBox.Location = new System.Drawing.Point(444, 64);
            this.naslovBox.Name = "naslovBox";
            this.naslovBox.Size = new System.Drawing.Size(183, 20);
            this.naslovBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nazivLabel2);
            this.tabPage2.Controls.Add(this.dijakiGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PRIKAZ VSEH DIJAKOV";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nazivLabel2
            // 
            this.nazivLabel2.AutoSize = true;
            this.nazivLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.nazivLabel2.Location = new System.Drawing.Point(1065, 3);
            this.nazivLabel2.Name = "nazivLabel2";
            this.nazivLabel2.Size = new System.Drawing.Size(41, 13);
            this.nazivLabel2.TabIndex = 12;
            this.nazivLabel2.Text = "label12";
            // 
            // dijakiGridView
            // 
            this.dijakiGridView.AllowUserToAddRows = false;
            this.dijakiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dijakiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dijakiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Priimek,
            this.sola,
            this.datum_roj,
            this.kraj,
            this.vec});
            this.dijakiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dijakiGridView.Location = new System.Drawing.Point(3, 37);
            this.dijakiGridView.Name = "dijakiGridView";
            this.dijakiGridView.Size = new System.Drawing.Size(1103, 493);
            this.dijakiGridView.TabIndex = 0;
            this.dijakiGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dijakiGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Priimek
            // 
            this.Priimek.HeaderText = "Priimek";
            this.Priimek.Name = "Priimek";
            // 
            // sola
            // 
            this.sola.HeaderText = "Šola";
            this.sola.Name = "sola";
            // 
            // datum_roj
            // 
            this.datum_roj.HeaderText = "Datum rojstva";
            this.datum_roj.Name = "datum_roj";
            // 
            // kraj
            // 
            this.kraj.HeaderText = "Kraj";
            this.kraj.Name = "kraj";
            // 
            // vec
            // 
            this.vec.HeaderText = "Več";
            this.vec.Name = "vec";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nazivLabel3);
            this.tabPage3.Controls.Add(this.krajBox);
            this.tabPage3.Controls.Add(this.dodajDijakaButton);
            this.tabPage3.Controls.Add(this.datumPicker);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.solaBox);
            this.tabPage3.Controls.Add(this.priimekBox);
            this.tabPage3.Controls.Add(this.imeBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1115, 536);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DODAJANJE DIJAKOV";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nazivLabel3
            // 
            this.nazivLabel3.AutoSize = true;
            this.nazivLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.nazivLabel3.Location = new System.Drawing.Point(1071, 3);
            this.nazivLabel3.Name = "nazivLabel3";
            this.nazivLabel3.Size = new System.Drawing.Size(41, 13);
            this.nazivLabel3.TabIndex = 15;
            this.nazivLabel3.Text = "label13";
            // 
            // krajBox
            // 
            this.krajBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.krajBox.FormattingEnabled = true;
            this.krajBox.Location = new System.Drawing.Point(425, 264);
            this.krajBox.Name = "krajBox";
            this.krajBox.Size = new System.Drawing.Size(200, 21);
            this.krajBox.TabIndex = 14;
            // 
            // dodajDijakaButton
            // 
            this.dodajDijakaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajDijakaButton.Location = new System.Drawing.Point(425, 348);
            this.dodajDijakaButton.Name = "dodajDijakaButton";
            this.dodajDijakaButton.Size = new System.Drawing.Size(200, 23);
            this.dodajDijakaButton.TabIndex = 13;
            this.dodajDijakaButton.Text = "DODAJ";
            this.dodajDijakaButton.UseVisualStyleBackColor = true;
            this.dodajDijakaButton.Click += new System.EventHandler(this.dodajDijakaButton_Click);
            // 
            // datumPicker
            // 
            this.datumPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datumPicker.Location = new System.Drawing.Point(425, 303);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(200, 20);
            this.datumPicker.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Priimek:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Datum rojstva:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kraj:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Šola:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(738, 76);
            this.label5.TabIndex = 5;
            this.label5.Text = "DODAJANJE DIJAKOV";
            // 
            // solaBox
            // 
            this.solaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solaBox.Location = new System.Drawing.Point(425, 223);
            this.solaBox.Name = "solaBox";
            this.solaBox.Size = new System.Drawing.Size(200, 20);
            this.solaBox.TabIndex = 2;
            // 
            // priimekBox
            // 
            this.priimekBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priimekBox.Location = new System.Drawing.Point(425, 182);
            this.priimekBox.Name = "priimekBox";
            this.priimekBox.Size = new System.Drawing.Size(200, 20);
            this.priimekBox.TabIndex = 1;
            // 
            // imeBox
            // 
            this.imeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imeBox.Location = new System.Drawing.Point(425, 145);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(200, 20);
            this.imeBox.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dijakiGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button dodajAnketoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox opisBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox naslovBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dijakiGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priimek;
        private System.Windows.Forms.DataGridViewTextBoxColumn sola;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_roj;
        private System.Windows.Forms.DataGridViewTextBoxColumn kraj;
        private System.Windows.Forms.DataGridViewButtonColumn vec;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button dodajDijakaButton;
        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox solaBox;
        private System.Windows.Forms.TextBox priimekBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.ComboBox krajBox;
        private System.Windows.Forms.Label nazivLabel1;
        private System.Windows.Forms.Label nazivLabel2;
        private System.Windows.Forms.Label nazivLabel3;
    }
}