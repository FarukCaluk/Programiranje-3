namespace FIT.WinForms.IspitIB220086
{
    partial class frmPretragaIB220086
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpOD = new DateTimePicker();
            dtpDO = new DateTimePicker();
            comboBox1 = new ComboBox();
            dgvPretraga = new DataGridView();
            brojindexa = new DataGridViewTextBoxColumn();
            imeprezime = new DataGridViewTextBoxColumn();
            prosjek = new DataGridViewTextBoxColumn();
            datumrođenja = new DataGridViewTextBoxColumn();
            aktivan = new DataGridViewCheckBoxColumn();
            uvjerenje = new DataGridViewButtonColumn();
            tbstc = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Spol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 19);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 0;
            label2.Text = "rođen u periodu od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(707, 21);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(380, 16);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(321, 27);
            dtpOD.TabIndex = 1;
            dtpOD.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(740, 16);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(308, 27);
            dtpDO.TabIndex = 1;
            dtpDO.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Musko", "Zensko", "Svi" });
            comboBox1.Location = new Point(63, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.AllowUserToOrderColumns = true;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { brojindexa, imeprezime, prosjek, datumrođenja, aktivan, uvjerenje });
            dgvPretraga.Location = new Point(12, 53);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.Size = new Size(1036, 255);
            dgvPretraga.TabIndex = 3;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
            // 
            // brojindexa
            // 
            brojindexa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brojindexa.DataPropertyName = "brojindexa";
            brojindexa.HeaderText = "Broj indexa";
            brojindexa.MinimumWidth = 6;
            brojindexa.Name = "brojindexa";
            brojindexa.ReadOnly = true;
            // 
            // imeprezime
            // 
            imeprezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imeprezime.DataPropertyName = "imeprezime";
            imeprezime.HeaderText = "Ime i prezime";
            imeprezime.MinimumWidth = 6;
            imeprezime.Name = "imeprezime";
            imeprezime.ReadOnly = true;
            // 
            // prosjek
            // 
            prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prosjek.DataPropertyName = "prosjek";
            prosjek.HeaderText = "Prosjek";
            prosjek.MinimumWidth = 6;
            prosjek.Name = "prosjek";
            prosjek.ReadOnly = true;
            // 
            // datumrođenja
            // 
            datumrođenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datumrođenja.DataPropertyName = "datumrođenja";
            datumrođenja.HeaderText = "Datum rođenja";
            datumrođenja.MinimumWidth = 6;
            datumrođenja.Name = "datumrođenja";
            datumrođenja.ReadOnly = true;
            // 
            // aktivan
            // 
            aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aktivan.DataPropertyName = "aktivan";
            aktivan.HeaderText = "Aktivan";
            aktivan.MinimumWidth = 6;
            aktivan.Name = "aktivan";
            aktivan.ReadOnly = true;
            aktivan.Resizable = DataGridViewTriState.True;
            aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // uvjerenje
            // 
            uvjerenje.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uvjerenje.DataPropertyName = "uvjerenje";
            uvjerenje.HeaderText = "";
            uvjerenje.MinimumWidth = 6;
            uvjerenje.Name = "uvjerenje";
            uvjerenje.ReadOnly = true;
            uvjerenje.Text = "Uvjerenje";
            uvjerenje.UseColumnTextForButtonValue = true;
            // 
            // tbstc
            // 
            tbstc.Location = new Point(236, 355);
            tbstc.Name = "tbstc";
            tbstc.Size = new Size(584, 27);
            tbstc.TabIndex = 4;
            tbstc.TextChanged += tbstc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 332);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 0;
            label4.Text = "rođen u periodu od";
            // 
            // frmPretragaIB220086
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 428);
            Controls.Add(tbstc);
            Controls.Add(dgvPretraga);
            Controls.Add(comboBox1);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB220086";
            Text = "frmPretragaIB220086";
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private ComboBox comboBox1;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn brojindexa;
        private DataGridViewTextBoxColumn imeprezime;
        private DataGridViewTextBoxColumn prosjek;
        private DataGridViewTextBoxColumn datumrođenja;
        private DataGridViewCheckBoxColumn aktivan;
        private DataGridViewButtonColumn uvjerenje;
        private TextBox tbstc;
        private Label label4;
    }
}