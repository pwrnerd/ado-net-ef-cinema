namespace DemoKino
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvFilme = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSK18DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSaal = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anzahlPlaetzeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dreidimensionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVorfuehrung = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.saalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vorfuehrungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBuchung = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platzNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vorfuehrungDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buchungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVorfuehrung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vorfuehrungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuchung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilme
            // 
            this.dgvFilme.AutoGenerateColumns = false;
            this.dgvFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.dauerDataGridViewTextBoxColumn,
            this.fSK18DataGridViewCheckBoxColumn,
            this.preisDataGridViewTextBoxColumn});
            this.dgvFilme.DataSource = this.filmBindingSource;
            this.dgvFilme.Location = new System.Drawing.Point(23, 52);
            this.dgvFilme.Name = "dgvFilme";
            this.dgvFilme.RowTemplate.Height = 24;
            this.dgvFilme.Size = new System.Drawing.Size(649, 318);
            this.dgvFilme.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // dauerDataGridViewTextBoxColumn
            // 
            this.dauerDataGridViewTextBoxColumn.DataPropertyName = "Dauer";
            this.dauerDataGridViewTextBoxColumn.HeaderText = "Dauer";
            this.dauerDataGridViewTextBoxColumn.Name = "dauerDataGridViewTextBoxColumn";
            // 
            // fSK18DataGridViewCheckBoxColumn
            // 
            this.fSK18DataGridViewCheckBoxColumn.DataPropertyName = "FSK18";
            this.fSK18DataGridViewCheckBoxColumn.HeaderText = "FSK18";
            this.fSK18DataGridViewCheckBoxColumn.Name = "fSK18DataGridViewCheckBoxColumn";
            // 
            // preisDataGridViewTextBoxColumn
            // 
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(DAO.Film);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saal";
            // 
            // dgvSaal
            // 
            this.dgvSaal.AutoGenerateColumns = false;
            this.dgvSaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.bezeichnungDataGridViewTextBoxColumn1,
            this.anzahlPlaetzeDataGridViewTextBoxColumn,
            this.dreidimensionalDataGridViewCheckBoxColumn});
            this.dgvSaal.DataSource = this.saalBindingSource;
            this.dgvSaal.Location = new System.Drawing.Point(23, 421);
            this.dgvSaal.Name = "dgvSaal";
            this.dgvSaal.RowTemplate.Height = 24;
            this.dgvSaal.Size = new System.Drawing.Size(649, 254);
            this.dgvSaal.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // bezeichnungDataGridViewTextBoxColumn1
            // 
            this.bezeichnungDataGridViewTextBoxColumn1.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn1.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn1.Name = "bezeichnungDataGridViewTextBoxColumn1";
            // 
            // anzahlPlaetzeDataGridViewTextBoxColumn
            // 
            this.anzahlPlaetzeDataGridViewTextBoxColumn.DataPropertyName = "AnzahlPlaetze";
            this.anzahlPlaetzeDataGridViewTextBoxColumn.HeaderText = "AnzahlPlaetze";
            this.anzahlPlaetzeDataGridViewTextBoxColumn.Name = "anzahlPlaetzeDataGridViewTextBoxColumn";
            // 
            // dreidimensionalDataGridViewCheckBoxColumn
            // 
            this.dreidimensionalDataGridViewCheckBoxColumn.DataPropertyName = "Dreidimensional";
            this.dreidimensionalDataGridViewCheckBoxColumn.HeaderText = "Dreidimensional";
            this.dreidimensionalDataGridViewCheckBoxColumn.Name = "dreidimensionalDataGridViewCheckBoxColumn";
            // 
            // saalBindingSource
            // 
            this.saalBindingSource.DataSource = typeof(DAO.Saal);
            // 
            // dgvVorfuehrung
            // 
            this.dgvVorfuehrung.AutoGenerateColumns = false;
            this.dgvVorfuehrung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVorfuehrung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.datumDataGridViewTextBoxColumn,
            this.RemainingSeats,
            this.bezeichnungDataGridViewTextBoxColumn2,
            this.filmDataGridViewTextBoxColumn,
            this.saalDataGridViewTextBoxColumn});
            this.dgvVorfuehrung.DataSource = this.vorfuehrungBindingSource;
            this.dgvVorfuehrung.Location = new System.Drawing.Point(710, 52);
            this.dgvVorfuehrung.Name = "dgvVorfuehrung";
            this.dgvVorfuehrung.RowTemplate.Height = 24;
            this.dgvVorfuehrung.Size = new System.Drawing.Size(750, 623);
            this.dgvVorfuehrung.TabIndex = 4;
            this.dgvVorfuehrung.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVorfuehrung_DataError);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // RemainingSeats
            // 
            this.RemainingSeats.DataPropertyName = "RemainingSeats";
            this.RemainingSeats.HeaderText = "RemainingSeats";
            this.RemainingSeats.Name = "RemainingSeats";
            this.RemainingSeats.ReadOnly = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn2
            // 
            this.bezeichnungDataGridViewTextBoxColumn2.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn2.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn2.Name = "bezeichnungDataGridViewTextBoxColumn2";
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            this.filmDataGridViewTextBoxColumn.DataSource = this.filmBindingSource;
            this.filmDataGridViewTextBoxColumn.DisplayMember = "Bezeichnung";
            this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            this.filmDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.filmDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.filmDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // saalDataGridViewTextBoxColumn
            // 
            this.saalDataGridViewTextBoxColumn.DataPropertyName = "SaalID";
            this.saalDataGridViewTextBoxColumn.DataSource = this.saalBindingSource;
            this.saalDataGridViewTextBoxColumn.DisplayMember = "Bezeichnung";
            this.saalDataGridViewTextBoxColumn.HeaderText = "Saal";
            this.saalDataGridViewTextBoxColumn.Name = "saalDataGridViewTextBoxColumn";
            this.saalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.saalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.saalDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // vorfuehrungBindingSource
            // 
            this.vorfuehrungBindingSource.DataSource = typeof(DAO.Vorfuehrung);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vorfuehrung";
            // 
            // dgvBuchung
            // 
            this.dgvBuchung.AutoGenerateColumns = false;
            this.dgvBuchung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuchung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.platzNrDataGridViewTextBoxColumn,
            this.vorfuehrungDataGridViewTextBoxColumn3});
            this.dgvBuchung.DataSource = this.buchungBindingSource;
            this.dgvBuchung.Location = new System.Drawing.Point(1502, 52);
            this.dgvBuchung.Name = "dgvBuchung";
            this.dgvBuchung.RowTemplate.Height = 24;
            this.dgvBuchung.Size = new System.Drawing.Size(648, 623);
            this.dgvBuchung.TabIndex = 6;
            this.dgvBuchung.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBuchung_DataError);
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // platzNrDataGridViewTextBoxColumn
            // 
            this.platzNrDataGridViewTextBoxColumn.DataPropertyName = "PlatzNr";
            this.platzNrDataGridViewTextBoxColumn.HeaderText = "PlatzNr";
            this.platzNrDataGridViewTextBoxColumn.Name = "platzNrDataGridViewTextBoxColumn";
            // 
            // vorfuehrungDataGridViewTextBoxColumn3
            // 
            this.vorfuehrungDataGridViewTextBoxColumn3.DataPropertyName = "VorfuehrungID";
            this.vorfuehrungDataGridViewTextBoxColumn3.DataSource = this.vorfuehrungBindingSource;
            this.vorfuehrungDataGridViewTextBoxColumn3.DisplayMember = "Bezeichnung";
            this.vorfuehrungDataGridViewTextBoxColumn3.HeaderText = "Vorfuehrung";
            this.vorfuehrungDataGridViewTextBoxColumn3.Name = "vorfuehrungDataGridViewTextBoxColumn3";
            this.vorfuehrungDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vorfuehrungDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vorfuehrungDataGridViewTextBoxColumn3.ValueMember = "ID";
            // 
            // buchungBindingSource
            // 
            this.buchungBindingSource.DataSource = typeof(DAO.Buchung);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1499, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buchung";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1502, 707);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2071, 839);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvBuchung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVorfuehrung);
            this.Controls.Add(this.dgvSaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFilme);
            this.Name = "Main";
            this.Text = "Hauptformular";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVorfuehrung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vorfuehrungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuchung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSaal;
        private System.Windows.Forms.DataGridView dgvVorfuehrung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBuchung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn film1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.BindingSource saalBindingSource;
        private System.Windows.Forms.BindingSource buchungBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fSK18DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anzahlPlaetzeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dreidimensionalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource vorfuehrungBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platzNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vorfuehrungDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn saalDataGridViewTextBoxColumn;
    }
}

