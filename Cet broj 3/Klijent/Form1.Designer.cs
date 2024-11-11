
namespace Klijent
{
    partial class Form1
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
            this.gbLogovanje = new System.Windows.Forms.GroupBox();
            this.gbPorukeSvima = new System.Windows.Forms.GroupBox();
            this.gbPorukeOdredjenom = new System.Windows.Forms.GroupBox();
            this.gbSvePoruke = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rtbSaljiSvima = new System.Windows.Forms.RichTextBox();
            this.btnSaljiSvima = new System.Windows.Forms.Button();
            this.btnSlanjeOdredjenom = new System.Windows.Forms.Button();
            this.rtbPorukaZaOdredjenog = new System.Windows.Forms.RichTextBox();
            this.cbKorisnici = new System.Windows.Forms.ComboBox();
            this.dgvPoslednje3 = new System.Windows.Forms.DataGridView();
            this.dgvOstale = new System.Windows.Forms.DataGridView();
            this.btnCitajPoruku = new System.Windows.Forms.Button();
            this.gbLogovanje.SuspendLayout();
            this.gbPorukeSvima.SuspendLayout();
            this.gbPorukeOdredjenom.SuspendLayout();
            this.gbSvePoruke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslednje3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOstale)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogovanje
            // 
            this.gbLogovanje.Controls.Add(this.btnLogin);
            this.gbLogovanje.Controls.Add(this.txtSifra);
            this.gbLogovanje.Controls.Add(this.txtIme);
            this.gbLogovanje.Controls.Add(this.label2);
            this.gbLogovanje.Controls.Add(this.label1);
            this.gbLogovanje.Location = new System.Drawing.Point(43, 50);
            this.gbLogovanje.Name = "gbLogovanje";
            this.gbLogovanje.Size = new System.Drawing.Size(338, 150);
            this.gbLogovanje.TabIndex = 0;
            this.gbLogovanje.TabStop = false;
            this.gbLogovanje.Text = "Logovanje korisnika";
            // 
            // gbPorukeSvima
            // 
            this.gbPorukeSvima.Controls.Add(this.btnSaljiSvima);
            this.gbPorukeSvima.Controls.Add(this.rtbSaljiSvima);
            this.gbPorukeSvima.Location = new System.Drawing.Point(442, 50);
            this.gbPorukeSvima.Name = "gbPorukeSvima";
            this.gbPorukeSvima.Size = new System.Drawing.Size(317, 191);
            this.gbPorukeSvima.TabIndex = 1;
            this.gbPorukeSvima.TabStop = false;
            this.gbPorukeSvima.Text = "Salji svima";
            // 
            // gbPorukeOdredjenom
            // 
            this.gbPorukeOdredjenom.Controls.Add(this.cbKorisnici);
            this.gbPorukeOdredjenom.Controls.Add(this.btnSlanjeOdredjenom);
            this.gbPorukeOdredjenom.Controls.Add(this.rtbPorukaZaOdredjenog);
            this.gbPorukeOdredjenom.Location = new System.Drawing.Point(43, 206);
            this.gbPorukeOdredjenom.Name = "gbPorukeOdredjenom";
            this.gbPorukeOdredjenom.Size = new System.Drawing.Size(338, 190);
            this.gbPorukeOdredjenom.TabIndex = 1;
            this.gbPorukeOdredjenom.TabStop = false;
            this.gbPorukeOdredjenom.Text = "Slanje odredjenom";
            // 
            // gbSvePoruke
            // 
            this.gbSvePoruke.Controls.Add(this.btnCitajPoruku);
            this.gbSvePoruke.Controls.Add(this.dgvOstale);
            this.gbSvePoruke.Controls.Add(this.dgvPoslednje3);
            this.gbSvePoruke.Location = new System.Drawing.Point(43, 432);
            this.gbSvePoruke.Name = "gbSvePoruke";
            this.gbSvePoruke.Size = new System.Drawing.Size(682, 364);
            this.gbSvePoruke.TabIndex = 1;
            this.gbSvePoruke.TabStop = false;
            this.gbSvePoruke.Text = "Poruke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(147, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(143, 22);
            this.txtIme.TabIndex = 2;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(147, 65);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(143, 22);
            this.txtSifra.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(41, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rtbSaljiSvima
            // 
            this.rtbSaljiSvima.Location = new System.Drawing.Point(6, 21);
            this.rtbSaljiSvima.Name = "rtbSaljiSvima";
            this.rtbSaljiSvima.Size = new System.Drawing.Size(277, 96);
            this.rtbSaljiSvima.TabIndex = 0;
            this.rtbSaljiSvima.Text = "";
            // 
            // btnSaljiSvima
            // 
            this.btnSaljiSvima.Location = new System.Drawing.Point(53, 143);
            this.btnSaljiSvima.Name = "btnSaljiSvima";
            this.btnSaljiSvima.Size = new System.Drawing.Size(147, 28);
            this.btnSaljiSvima.TabIndex = 1;
            this.btnSaljiSvima.Text = "Posalji poruku";
            this.btnSaljiSvima.UseVisualStyleBackColor = true;
            this.btnSaljiSvima.Click += new System.EventHandler(this.btnSaljiSvima_Click);
            // 
            // btnSlanjeOdredjenom
            // 
            this.btnSlanjeOdredjenom.Location = new System.Drawing.Point(12, 145);
            this.btnSlanjeOdredjenom.Name = "btnSlanjeOdredjenom";
            this.btnSlanjeOdredjenom.Size = new System.Drawing.Size(147, 28);
            this.btnSlanjeOdredjenom.TabIndex = 3;
            this.btnSlanjeOdredjenom.Text = "Posalji poruku";
            this.btnSlanjeOdredjenom.UseVisualStyleBackColor = true;
            this.btnSlanjeOdredjenom.Click += new System.EventHandler(this.btnSlanjeOdredjenom_Click);
            // 
            // rtbPorukaZaOdredjenog
            // 
            this.rtbPorukaZaOdredjenog.Location = new System.Drawing.Point(12, 23);
            this.rtbPorukaZaOdredjenog.Name = "rtbPorukaZaOdredjenog";
            this.rtbPorukaZaOdredjenog.Size = new System.Drawing.Size(289, 96);
            this.rtbPorukaZaOdredjenog.TabIndex = 2;
            this.rtbPorukaZaOdredjenog.Text = "";
            // 
            // cbKorisnici
            // 
            this.cbKorisnici.FormattingEnabled = true;
            this.cbKorisnici.Location = new System.Drawing.Point(180, 149);
            this.cbKorisnici.Name = "cbKorisnici";
            this.cbKorisnici.Size = new System.Drawing.Size(121, 24);
            this.cbKorisnici.TabIndex = 4;
            // 
            // dgvPoslednje3
            // 
            this.dgvPoslednje3.AllowUserToAddRows = false;
            this.dgvPoslednje3.AllowUserToDeleteRows = false;
            this.dgvPoslednje3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslednje3.Location = new System.Drawing.Point(12, 40);
            this.dgvPoslednje3.Name = "dgvPoslednje3";
            this.dgvPoslednje3.ReadOnly = true;
            this.dgvPoslednje3.RowHeadersWidth = 51;
            this.dgvPoslednje3.RowTemplate.Height = 24;
            this.dgvPoslednje3.Size = new System.Drawing.Size(645, 109);
            this.dgvPoslednje3.TabIndex = 0;
            // 
            // dgvOstale
            // 
            this.dgvOstale.AllowUserToAddRows = false;
            this.dgvOstale.AllowUserToDeleteRows = false;
            this.dgvOstale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOstale.Location = new System.Drawing.Point(12, 177);
            this.dgvOstale.Name = "dgvOstale";
            this.dgvOstale.ReadOnly = true;
            this.dgvOstale.RowHeadersWidth = 51;
            this.dgvOstale.RowTemplate.Height = 24;
            this.dgvOstale.Size = new System.Drawing.Size(645, 109);
            this.dgvOstale.TabIndex = 1;
            // 
            // btnCitajPoruku
            // 
            this.btnCitajPoruku.Location = new System.Drawing.Point(20, 304);
            this.btnCitajPoruku.Name = "btnCitajPoruku";
            this.btnCitajPoruku.Size = new System.Drawing.Size(106, 41);
            this.btnCitajPoruku.TabIndex = 2;
            this.btnCitajPoruku.Text = "Citaj poruku";
            this.btnCitajPoruku.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 861);
            this.Controls.Add(this.gbSvePoruke);
            this.Controls.Add(this.gbPorukeOdredjenom);
            this.Controls.Add(this.gbPorukeSvima);
            this.Controls.Add(this.gbLogovanje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLogovanje.ResumeLayout(false);
            this.gbLogovanje.PerformLayout();
            this.gbPorukeSvima.ResumeLayout(false);
            this.gbPorukeOdredjenom.ResumeLayout(false);
            this.gbSvePoruke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslednje3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOstale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogovanje;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPorukeSvima;
        private System.Windows.Forms.GroupBox gbPorukeOdredjenom;
        private System.Windows.Forms.GroupBox gbSvePoruke;
        private System.Windows.Forms.Button btnSaljiSvima;
        private System.Windows.Forms.RichTextBox rtbSaljiSvima;
        private System.Windows.Forms.ComboBox cbKorisnici;
        private System.Windows.Forms.Button btnSlanjeOdredjenom;
        private System.Windows.Forms.RichTextBox rtbPorukaZaOdredjenog;
        private System.Windows.Forms.Button btnCitajPoruku;
        private System.Windows.Forms.DataGridView dgvOstale;
        private System.Windows.Forms.DataGridView dgvPoslednje3;
    }
}

