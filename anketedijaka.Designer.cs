
namespace MINIProjektUPB
{
    partial class anketedijaka
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
            this.anketeGrid = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodaj = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.anketeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // anketeGrid
            // 
            this.anketeGrid.AllowUserToAddRows = false;
            this.anketeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anketeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.naslov,
            this.url,
            this.opis,
            this.dodaj});
            this.anketeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.anketeGrid.Location = new System.Drawing.Point(0, 93);
            this.anketeGrid.Name = "anketeGrid";
            this.anketeGrid.Size = new System.Drawing.Size(847, 357);
            this.anketeGrid.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 43);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 20);
            this.searchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iskanje:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(258, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 20);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Išči";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 151;
            // 
            // naslov
            // 
            this.naslov.HeaderText = "Naslov";
            this.naslov.Name = "naslov";
            this.naslov.ReadOnly = true;
            this.naslov.Width = 152;
            // 
            // url
            // 
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 151;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            this.opis.Width = 200;
            // 
            // dodaj
            // 
            this.dodaj.HeaderText = "Dodaj";
            this.dodaj.Name = "dodaj";
            this.dodaj.ReadOnly = true;
            this.dodaj.Width = 151;
            // 
            // anketedijaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.anketeGrid);
            this.Name = "anketedijaka";
            this.Text = "Ankete, ki jih želite dodati dijaku";
            ((System.ComponentModel.ISupportInitialize)(this.anketeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView anketeGrid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewButtonColumn dodaj;
    }
}