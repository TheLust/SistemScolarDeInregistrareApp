namespace SistemScolarDeInregistrareApp
{
    partial class FrmElevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElevi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbClasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdFeminin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.rdMasculin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMunicipiu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbJudet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOras = new System.Windows.Forms.ComboBox();
            this.dtDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.dtDataInregistrarii = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtDataInregistrarii);
            this.groupBox1.Controls.Add(this.dtDataNasterii);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbOras);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbMunicipiu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbJudet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.rdMasculin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrenume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdFeminin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbClasa);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(25, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date personale";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnDate);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Controls.Add(this.btnActualizare);
            this.groupBox2.Controls.Add(this.btnSalvare);
            this.groupBox2.Controls.Add(this.btnAdaugare);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(772, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 444);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesare";
            // 
            // cmbClasa
            // 
            this.cmbClasa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbClasa.FormattingEnabled = true;
            this.cmbClasa.Location = new System.Drawing.Point(79, 47);
            this.cmbClasa.Name = "cmbClasa";
            this.cmbClasa.Size = new System.Drawing.Size(215, 24);
            this.cmbClasa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clasa";
            // 
            // rdFeminin
            // 
            this.rdFeminin.AutoSize = true;
            this.rdFeminin.Checked = true;
            this.rdFeminin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdFeminin.Location = new System.Drawing.Point(209, 85);
            this.rdFeminin.Name = "rdFeminin";
            this.rdFeminin.Size = new System.Drawing.Size(74, 20);
            this.rdFeminin.TabIndex = 3;
            this.rdFeminin.TabStop = true;
            this.rdFeminin.Text = "Feminin";
            this.rdFeminin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNume.Location = new System.Drawing.Point(79, 119);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(215, 23);
            this.txtNume.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(396, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prenume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrenume.Location = new System.Drawing.Point(481, 116);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(215, 23);
            this.txtPrenume.TabIndex = 7;
            // 
            // rdMasculin
            // 
            this.rdMasculin.AutoSize = true;
            this.rdMasculin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdMasculin.Location = new System.Drawing.Point(79, 85);
            this.rdMasculin.Name = "rdMasculin";
            this.rdMasculin.Size = new System.Drawing.Size(81, 20);
            this.rdMasculin.TabIndex = 9;
            this.rdMasculin.Text = "Masculin";
            this.rdMasculin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(394, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(479, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTelefon.Location = new System.Drawing.Point(77, 230);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(215, 23);
            this.txtTelefon.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAdresa.Location = new System.Drawing.Point(77, 173);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(619, 23);
            this.txtAdresa.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data nasterii";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(394, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data inregistrarii";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(396, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 37);
            this.label10.TabIndex = 23;
            this.label10.Text = "Municipiul";
            // 
            // cmbMunicipiu
            // 
            this.cmbMunicipiu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMunicipiu.FormattingEnabled = true;
            this.cmbMunicipiu.Location = new System.Drawing.Point(481, 362);
            this.cmbMunicipiu.Name = "cmbMunicipiu";
            this.cmbMunicipiu.Size = new System.Drawing.Size(215, 24);
            this.cmbMunicipiu.TabIndex = 22;
            this.cmbMunicipiu.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipiu_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 34);
            this.label11.TabIndex = 21;
            this.label11.Text = "Judet";
            // 
            // cmbJudet
            // 
            this.cmbJudet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbJudet.FormattingEnabled = true;
            this.cmbJudet.Location = new System.Drawing.Point(79, 359);
            this.cmbJudet.Name = "cmbJudet";
            this.cmbJudet.Size = new System.Drawing.Size(215, 24);
            this.cmbJudet.TabIndex = 20;
            this.cmbJudet.SelectedIndexChanged += new System.EventHandler(this.cmbJudet_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 34);
            this.label12.TabIndex = 25;
            this.label12.Text = "Oras";
            // 
            // cmbOras
            // 
            this.cmbOras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbOras.FormattingEnabled = true;
            this.cmbOras.Location = new System.Drawing.Point(79, 407);
            this.cmbOras.Name = "cmbOras";
            this.cmbOras.Size = new System.Drawing.Size(215, 24);
            this.cmbOras.TabIndex = 24;
            // 
            // dtDataNasterii
            // 
            this.dtDataNasterii.CustomFormat = "dd-MM-yyyy";
            this.dtDataNasterii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataNasterii.Location = new System.Drawing.Point(77, 295);
            this.dtDataNasterii.Name = "dtDataNasterii";
            this.dtDataNasterii.Size = new System.Drawing.Size(217, 23);
            this.dtDataNasterii.TabIndex = 26;
            // 
            // dtDataInregistrarii
            // 
            this.dtDataInregistrarii.CustomFormat = "dd-MM-yyyy";
            this.dtDataInregistrarii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDataInregistrarii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataInregistrarii.Location = new System.Drawing.Point(481, 292);
            this.dtDataInregistrarii.Name = "dtDataInregistrarii";
            this.dtDataInregistrarii.Size = new System.Drawing.Size(213, 23);
            this.dtDataInregistrarii.TabIndex = 27;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdaugare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdaugare.ForeColor = System.Drawing.Color.White;
            this.btnAdaugare.Image = ((System.Drawing.Image)(resources.GetObject("btnAdaugare.Image")));
            this.btnAdaugare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdaugare.Location = new System.Drawing.Point(19, 32);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(141, 47);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSalvare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSalvare.ForeColor = System.Drawing.Color.White;
            this.btnSalvare.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvare.Image")));
            this.btnSalvare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvare.Location = new System.Drawing.Point(19, 116);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(141, 47);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnActualizare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActualizare.ForeColor = System.Drawing.Color.White;
            this.btnActualizare.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizare.Image")));
            this.btnActualizare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizare.Location = new System.Drawing.Point(19, 203);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(141, 47);
            this.btnActualizare.TabIndex = 2;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStergere.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Image = ((System.Drawing.Image)(resources.GetObject("btnStergere.Image")));
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.Location = new System.Drawing.Point(19, 292);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(141, 47);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.Location = new System.Drawing.Point(19, 384);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(141, 47);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Date";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // FrmElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FrmElevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNume;
        public System.Windows.Forms.RadioButton rdFeminin;
        public System.Windows.Forms.ComboBox cmbClasa;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPrenume;
        public System.Windows.Forms.DateTimePicker dtDataInregistrarii;
        public System.Windows.Forms.DateTimePicker dtDataNasterii;
        public System.Windows.Forms.ComboBox cmbOras;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbMunicipiu;
        public System.Windows.Forms.ComboBox cmbJudet;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtAdresa;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.Button btnAdaugare;
        public System.Windows.Forms.Button btnDate;
        public System.Windows.Forms.Button btnStergere;
        public System.Windows.Forms.Button btnActualizare;
        public System.Windows.Forms.Button btnSalvare;
        public System.Windows.Forms.RadioButton rdMasculin;
    }
}