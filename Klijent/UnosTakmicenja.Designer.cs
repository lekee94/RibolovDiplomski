namespace Klijent
{
    partial class UnosTakmicenja
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
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbTakmicenje = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajObrisiTakmicare = new System.Windows.Forms.Button();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbStaza = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTakmicenje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "Senori ",
            "Dame",
            "Veterani",
            "Juniori U25",
            "Juniori U18",
            "Juniori U14"});
            this.cmbKategorija.Location = new System.Drawing.Point(94, 74);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(500, 28);
            this.cmbKategorija.TabIndex = 27;
            this.cmbKategorija.Text = "Izaberite kategoriju!";
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Kategorija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Naziv:";
            // 
            // gbTakmicenje
            // 
            this.gbTakmicenje.Controls.Add(this.label1);
            this.gbTakmicenje.Controls.Add(this.dataGridView1);
            this.gbTakmicenje.Controls.Add(this.btnDodajObrisiTakmicare);
            this.gbTakmicenje.Controls.Add(this.cmbKategorija);
            this.gbTakmicenje.Controls.Add(this.label10);
            this.gbTakmicenje.Controls.Add(this.txtnaziv);
            this.gbTakmicenje.Controls.Add(this.label5);
            this.gbTakmicenje.Controls.Add(this.dtpDatum);
            this.gbTakmicenje.Controls.Add(this.button2);
            this.gbTakmicenje.Controls.Add(this.cmbStaza);
            this.gbTakmicenje.Controls.Add(this.label6);
            this.gbTakmicenje.Controls.Add(this.label2);
            this.gbTakmicenje.Location = new System.Drawing.Point(23, 14);
            this.gbTakmicenje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTakmicenje.Name = "gbTakmicenje";
            this.gbTakmicenje.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTakmicenje.Size = new System.Drawing.Size(614, 658);
            this.gbTakmicenje.TabIndex = 23;
            this.gbTakmicenje.TabStop = false;
            this.gbTakmicenje.Text = "Novo takmičenje";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(580, 253);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnDodajObrisiTakmicare
            // 
            this.btnDodajObrisiTakmicare.Location = new System.Drawing.Point(14, 495);
            this.btnDodajObrisiTakmicare.Name = "btnDodajObrisiTakmicare";
            this.btnDodajObrisiTakmicare.Size = new System.Drawing.Size(581, 54);
            this.btnDodajObrisiTakmicare.TabIndex = 28;
            this.btnDodajObrisiTakmicare.Text = "Dodaj takmičare";
            this.btnDodajObrisiTakmicare.UseVisualStyleBackColor = true;
            this.btnDodajObrisiTakmicare.Click += new System.EventHandler(this.btnDodajObrisiTakmicare_Click);
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(94, 34);
            this.txtnaziv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(500, 26);
            this.txtnaziv.TabIndex = 22;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(94, 120);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(127, 26);
            this.dtpDatum.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 571);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(580, 77);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zapamti takmičenje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbStaza
            // 
            this.cmbStaza.FormattingEnabled = true;
            this.cmbStaza.Location = new System.Drawing.Point(328, 118);
            this.cmbStaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStaza.Name = "cmbStaza";
            this.cmbStaza.Size = new System.Drawing.Size(268, 28);
            this.cmbStaza.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Staza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Spisak takmicara:";
            // 
            // UnosTakmicenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(763, 840);
            this.Controls.Add(this.gbTakmicenje);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UnosTakmicenja";
            this.Text = "Unos Takmičenja";
            this.Load += new System.EventHandler(this.UnosTakmicenja_Load);
            this.gbTakmicenje.ResumeLayout(false);
            this.gbTakmicenje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTakmicenje;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbStaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajObrisiTakmicare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}