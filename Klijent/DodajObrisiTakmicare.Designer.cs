
namespace Klijent
{
    partial class DodajObrisiTakmicare
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
            this.txtStartniBroj = new System.Windows.Forms.TextBox();
            this.dgvTakmicari = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNoviTakmicar = new System.Windows.Forms.Button();
            this.btnNazadNaDetaljeTakmicenja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Startni broj:";
            // 
            // txtStartniBroj
            // 
            this.txtStartniBroj.Location = new System.Drawing.Point(110, 39);
            this.txtStartniBroj.Name = "txtStartniBroj";
            this.txtStartniBroj.Size = new System.Drawing.Size(80, 26);
            this.txtStartniBroj.TabIndex = 3;
            // 
            // dgvTakmicari
            // 
            this.dgvTakmicari.AllowUserToAddRows = false;
            this.dgvTakmicari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakmicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicari.Location = new System.Drawing.Point(12, 81);
            this.dgvTakmicari.Name = "dgvTakmicari";
            this.dgvTakmicari.RowHeadersWidth = 62;
            this.dgvTakmicari.RowTemplate.Height = 28;
            this.dgvTakmicari.Size = new System.Drawing.Size(580, 245);
            this.dgvTakmicari.TabIndex = 4;
            this.dgvTakmicari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTakmicari_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 342);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(580, 37);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj takmičara";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNoviTakmicar
            // 
            this.btnNoviTakmicar.Location = new System.Drawing.Point(400, 25);
            this.btnNoviTakmicar.Name = "btnNoviTakmicar";
            this.btnNoviTakmicar.Size = new System.Drawing.Size(192, 40);
            this.btnNoviTakmicar.TabIndex = 9;
            this.btnNoviTakmicar.Text = "Unesi novog takmičara";
            this.btnNoviTakmicar.UseVisualStyleBackColor = true;
            this.btnNoviTakmicar.Click += new System.EventHandler(this.btnNoviTakmicar_Click);
            // 
            // btnNazadNaDetaljeTakmicenja
            // 
            this.btnNazadNaDetaljeTakmicenja.Location = new System.Drawing.Point(174, 416);
            this.btnNazadNaDetaljeTakmicenja.Name = "btnNazadNaDetaljeTakmicenja";
            this.btnNazadNaDetaljeTakmicenja.Size = new System.Drawing.Size(250, 36);
            this.btnNazadNaDetaljeTakmicenja.TabIndex = 10;
            this.btnNazadNaDetaljeTakmicenja.Text = "Nazad na detalje takmičenja";
            this.btnNazadNaDetaljeTakmicenja.UseVisualStyleBackColor = true;
            this.btnNazadNaDetaljeTakmicenja.Click += new System.EventHandler(this.btnNazadNaDetaljeTakmicenja_Click);
            // 
            // DodajObrisiTakmicare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 467);
            this.Controls.Add(this.btnNazadNaDetaljeTakmicenja);
            this.Controls.Add(this.btnNoviTakmicar);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvTakmicari);
            this.Controls.Add(this.txtStartniBroj);
            this.Controls.Add(this.label1);
            this.Name = "DodajObrisiTakmicare";
            this.Text = "Spisak takmičara";
            this.Load += new System.EventHandler(this.DodajObrisiTakmicare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartniBroj;
        private System.Windows.Forms.DataGridView dgvTakmicari;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNoviTakmicar;
        private System.Windows.Forms.Button btnNazadNaDetaljeTakmicenja;
    }
}