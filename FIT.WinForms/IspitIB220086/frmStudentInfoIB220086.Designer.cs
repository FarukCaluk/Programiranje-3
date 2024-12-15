namespace FIT.WinForms.IspitIB220086
{
    partial class frmStudentInfoIB220086
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
            pbstudenta = new PictureBox();
            imeprezime = new Label();
            prosjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbstudenta).BeginInit();
            SuspendLayout();
            // 
            // pbstudenta
            // 
            pbstudenta.Location = new Point(25, 25);
            pbstudenta.Name = "pbstudenta";
            pbstudenta.Size = new Size(330, 297);
            pbstudenta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbstudenta.TabIndex = 0;
            pbstudenta.TabStop = false;
            // 
            // imeprezime
            // 
            imeprezime.AutoSize = true;
            imeprezime.Location = new Point(168, 351);
            imeprezime.Name = "imeprezime";
            imeprezime.Size = new Size(50, 20);
            imeprezime.TabIndex = 1;
            imeprezime.Text = "label1";
            // 
            // prosjek
            // 
            prosjek.AutoSize = true;
            prosjek.Location = new Point(168, 398);
            prosjek.Name = "prosjek";
            prosjek.Size = new Size(50, 20);
            prosjek.TabIndex = 2;
            prosjek.Text = "label2";
            // 
            // frmStudentInfoIB220086
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(prosjek);
            Controls.Add(imeprezime);
            Controls.Add(pbstudenta);
            Name = "frmStudentInfoIB220086";
            Text = "frmStudentInfoIB220086";
            ((System.ComponentModel.ISupportInitialize)pbstudenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbstudenta;
        private Label imeprezime;
        private Label prosjek;
    }
}