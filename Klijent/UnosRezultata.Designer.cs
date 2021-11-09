
namespace Klijent
{
    partial class UnosRezultata
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtUlov = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTakmicari = new System.Windows.Forms.DataGridView();
            this.btnDodajUlov = new System.Windows.Forms.Button();
            this.btnNazadNaDetaljeTakmicenja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicari)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ulov:";
            // 
            // txtUlov
            // 
            this.txtUlov.Location = new System.Drawing.Point(65, 278);
            this.txtUlov.Name = "txtUlov";
            this.txtUlov.Size = new System.Drawing.Size(115, 26);
            this.txtUlov.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNazadNaDetaljeTakmicenja);
            this.groupBox1.Controls.Add(this.dgvTakmicari);
            this.groupBox1.Controls.Add(this.btnDodajUlov);
            this.groupBox1.Controls.Add(this.txtUlov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 411);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos ulova";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvTakmicari
            // 
            this.dgvTakmicari.AllowUserToAddRows = false;
            this.dgvTakmicari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakmicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicari.Location = new System.Drawing.Point(6, 45);
            this.dgvTakmicari.Name = "dgvTakmicari";
            this.dgvTakmicari.RowHeadersWidth = 62;
            this.dgvTakmicari.RowTemplate.Height = 28;
            this.dgvTakmicari.Size = new System.Drawing.Size(563, 208);
            this.dgvTakmicari.TabIndex = 8;
            this.dgvTakmicari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTakmicari_CellContentClick);
            // 
            // btnDodajUlov
            // 
            this.btnDodajUlov.Location = new System.Drawing.Point(263, 278);
            this.btnDodajUlov.Name = "btnDodajUlov";
            this.btnDodajUlov.Size = new System.Drawing.Size(306, 35);
            this.btnDodajUlov.TabIndex = 7;
            this.btnDodajUlov.Text = "Dodaj ulov";
            this.btnDodajUlov.UseVisualStyleBackColor = true;
            this.btnDodajUlov.Click += new System.EventHandler(this.btnDodajUlov_Click);
            // 
            // btnNazadNaDetaljeTakmicenja
            // 
            this.btnNazadNaDetaljeTakmicenja.Location = new System.Drawing.Point(155, 357);
            this.btnNazadNaDetaljeTakmicenja.Name = "btnNazadNaDetaljeTakmicenja";
            this.btnNazadNaDetaljeTakmicenja.Size = new System.Drawing.Size(247, 37);
            this.btnNazadNaDetaljeTakmicenja.TabIndex = 7;
            this.btnNazadNaDetaljeTakmicenja.Text = "Nazad na detalje takmičenja";
            this.btnNazadNaDetaljeTakmicenja.UseVisualStyleBackColor = true;
            this.btnNazadNaDetaljeTakmicenja.Click += new System.EventHandler(this.btnNazadNaDetaljeTakmicenja_Click);
            // 
            // UnosRezultata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 448);
            this.Controls.Add(this.groupBox1);
            this.Name = "UnosRezultata";
            this.Text = "Unos Rezultata";
            this.Load += new System.EventHandler(this.UnosRezultata_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUlov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTakmicari;
        private System.Windows.Forms.Button btnDodajUlov;
        private System.Windows.Forms.Button btnNazadNaDetaljeTakmicenja;
    }
}