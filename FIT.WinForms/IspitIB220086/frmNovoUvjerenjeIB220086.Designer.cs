namespace FIT.WinForms.IspitIB220086
{
    partial class frmNovoUvjerenjeIB220086
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbvrsta = new ComboBox();
            rbsvrha = new RichTextBox();
            btsacuvaj = new Button();
            err = new ErrorProvider(components);
            pbUplatnica = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 71);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Svrha uvjerenja.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 40);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 0;
            label3.Text = "Skenirana uplatnica:";
            // 
            // cbvrsta
            // 
            cbvrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbvrsta.FormattingEnabled = true;
            cbvrsta.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o položenim ispitima", "Uvjerenje o pracenju nastave" });
            cbvrsta.Location = new Point(13, 40);
            cbvrsta.Name = "cbvrsta";
            cbvrsta.Size = new Size(267, 28);
            cbvrsta.TabIndex = 2;
            // 
            // rbsvrha
            // 
            rbsvrha.Location = new Point(13, 94);
            rbsvrha.Name = "rbsvrha";
            rbsvrha.Size = new Size(286, 314);
            rbsvrha.TabIndex = 3;
            rbsvrha.Text = "";
            // 
            // btsacuvaj
            // 
            btsacuvaj.Location = new Point(773, 374);
            btsacuvaj.Name = "btsacuvaj";
            btsacuvaj.Size = new Size(110, 34);
            btsacuvaj.TabIndex = 4;
            btsacuvaj.Text = "Sačuvaj";
            btsacuvaj.UseVisualStyleBackColor = true;
            btsacuvaj.Click += btsacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(321, 71);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(572, 297);
            pbUplatnica.TabIndex = 5;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB220086
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 421);
            Controls.Add(pbUplatnica);
            Controls.Add(btsacuvaj);
            Controls.Add(rbsvrha);
            Controls.Add(cbvrsta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB220086";
            Text = "frmNovoUvjerenjeIB220086";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbvrsta;
        private RichTextBox rbsvrha;
        private Button btsacuvaj;
        private ErrorProvider err;
        private PictureBox pbUplatnica;
        private OpenFileDialog openFileDialog1;
    }
}