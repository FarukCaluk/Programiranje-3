namespace FIT.WinForms.IspitIB220086
{
    partial class frmUvjerenjaIb220086
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
            components = new System.ComponentModel.Container();
            dgvuvjerenje = new DataGridView();
            DatumVrijeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            brisi = new DataGridViewButtonColumn();
            printaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            tbinfo = new RichTextBox();
            tbbroj = new TextBox();
            tbsvrha = new TextBox();
            cbvrsta = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btdodaj = new Button();
            btzahtjev = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvuvjerenje).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // dgvuvjerenje
            // 
            dgvuvjerenje.AllowUserToAddRows = false;
            dgvuvjerenje.AllowUserToDeleteRows = false;
            dgvuvjerenje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvuvjerenje.Columns.AddRange(new DataGridViewColumn[] { DatumVrijeme, Vrsta, Svrha, Uplatnica, Printano, brisi, printaj });
            dgvuvjerenje.Location = new Point(14, 40);
            dgvuvjerenje.Name = "dgvuvjerenje";
            dgvuvjerenje.ReadOnly = true;
            dgvuvjerenje.RowHeadersWidth = 51;
            dgvuvjerenje.RowTemplate.Height = 29;
            dgvuvjerenje.Size = new Size(961, 181);
            dgvuvjerenje.TabIndex = 0;
            dgvuvjerenje.CellContentClick += dgvuvjerenje_CellContentClick;
            // 
            // DatumVrijeme
            // 
            DatumVrijeme.DataPropertyName = "DatumVrijeme";
            DatumVrijeme.HeaderText = "Datum";
            DatumVrijeme.MinimumWidth = 6;
            DatumVrijeme.Name = "DatumVrijeme";
            DatumVrijeme.ReadOnly = true;
            DatumVrijeme.Width = 125;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Resizable = DataGridViewTriState.True;
            Uplatnica.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // brisi
            // 
            brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brisi.DataPropertyName = "brisi";
            brisi.HeaderText = "";
            brisi.MinimumWidth = 6;
            brisi.Name = "brisi";
            brisi.ReadOnly = true;
            brisi.Text = "Briši";
            brisi.UseColumnTextForButtonValue = true;
            // 
            // printaj
            // 
            printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            printaj.DataPropertyName = "printaj";
            printaj.HeaderText = "";
            printaj.MinimumWidth = 6;
            printaj.Name = "printaj";
            printaj.ReadOnly = true;
            printaj.Text = "Printaj";
            printaj.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbinfo);
            groupBox1.Controls.Add(tbbroj);
            groupBox1.Controls.Add(tbsvrha);
            groupBox1.Controls.Add(cbvrsta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btdodaj);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dotavanje zahtjeva za izdavanje uvjerenja";
            // 
            // tbinfo
            // 
            tbinfo.Enabled = false;
            tbinfo.Location = new Point(9, 98);
            tbinfo.Name = "tbinfo";
            tbinfo.Size = new Size(942, 134);
            tbinfo.TabIndex = 6;
            tbinfo.Text = "";
            // 
            // tbbroj
            // 
            tbbroj.Location = new Point(636, 57);
            tbbroj.Name = "tbbroj";
            tbbroj.Size = new Size(159, 27);
            tbbroj.TabIndex = 5;
            // 
            // tbsvrha
            // 
            tbsvrha.Location = new Point(303, 57);
            tbsvrha.Name = "tbsvrha";
            tbsvrha.Size = new Size(327, 27);
            tbsvrha.TabIndex = 5;
            // 
            // cbvrsta
            // 
            cbvrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbvrsta.FormattingEnabled = true;
            cbvrsta.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o položenim ispitima", "Uvjerenje o pracenju nastave" });
            cbvrsta.Location = new Point(9, 57);
            cbvrsta.Name = "cbvrsta";
            cbvrsta.Size = new Size(288, 28);
            cbvrsta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(636, 35);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 3;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 34);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "Svrha izdavanja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "Vrsta uvjerenja: ";
            // 
            // btdodaj
            // 
            btdodaj.Location = new Point(801, 58);
            btdodaj.Name = "btdodaj";
            btdodaj.Size = new Size(153, 28);
            btdodaj.TabIndex = 2;
            btdodaj.Text = "Dodaj=>";
            btdodaj.UseVisualStyleBackColor = true;
            btdodaj.Click += btdodaj_Click;
            // 
            // btzahtjev
            // 
            btzahtjev.Location = new Point(857, 7);
            btzahtjev.Name = "btzahtjev";
            btzahtjev.Size = new Size(117, 28);
            btzahtjev.TabIndex = 2;
            btzahtjev.Text = "Novi zahtjev";
            btzahtjev.UseVisualStyleBackColor = true;
            btzahtjev.Click += btzahtjev_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIb220086
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 504);
            Controls.Add(btzahtjev);
            Controls.Add(groupBox1);
            Controls.Add(dgvuvjerenje);
            Name = "frmUvjerenjaIb220086";
            Text = "frmUvjerenjaIb220086";
            ((System.ComponentModel.ISupportInitialize)dgvuvjerenje).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvuvjerenje;
        private GroupBox groupBox1;
        private RichTextBox tbinfo;
        private TextBox tbbroj;
        private TextBox tbsvrha;
        private ComboBox cbvrsta;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btdodaj;
        private Button btzahtjev;
        private DataGridViewTextBoxColumn DatumVrijeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn brisi;
        private DataGridViewButtonColumn printaj;
        private ErrorProvider err;
    }
}