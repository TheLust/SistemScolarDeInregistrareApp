namespace SistemScolarDeInregistrareApp
{
    partial class FrmProfesori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesori));
            this.btn_pr_Date = new System.Windows.Forms.Button();
            this.btn_pr_Actualizare = new System.Windows.Forms.Button();
            this.btn_pr_Salvare = new System.Windows.Forms.Button();
            this.btn_pr_Adaugare = new System.Windows.Forms.Button();
            this.dt_pr_DataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_pr_Oras = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_pr_Municipiu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_pr_Judet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_pr_Stergere = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pr_Adresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pr_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rd_pr_Masculin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pr_Prenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pr_Nume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_pr_Feminin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExperienta = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_pr_Telefon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pr_Date
            // 
            this.btn_pr_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_pr_Date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pr_Date.ForeColor = System.Drawing.Color.White;
            this.btn_pr_Date.Image = ((System.Drawing.Image)(resources.GetObject("btn_pr_Date.Image")));
            this.btn_pr_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pr_Date.Location = new System.Drawing.Point(19, 384);
            this.btn_pr_Date.Name = "btn_pr_Date";
            this.btn_pr_Date.Size = new System.Drawing.Size(141, 47);
            this.btn_pr_Date.TabIndex = 4;
            this.btn_pr_Date.Text = "Date";
            this.btn_pr_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pr_Date.UseVisualStyleBackColor = false;
            this.btn_pr_Date.Click += new System.EventHandler(this.btn_pr_Date_Click);
            // 
            // btn_pr_Actualizare
            // 
            this.btn_pr_Actualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_pr_Actualizare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pr_Actualizare.ForeColor = System.Drawing.Color.White;
            this.btn_pr_Actualizare.Image = ((System.Drawing.Image)(resources.GetObject("btn_pr_Actualizare.Image")));
            this.btn_pr_Actualizare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pr_Actualizare.Location = new System.Drawing.Point(19, 203);
            this.btn_pr_Actualizare.Name = "btn_pr_Actualizare";
            this.btn_pr_Actualizare.Size = new System.Drawing.Size(141, 47);
            this.btn_pr_Actualizare.TabIndex = 2;
            this.btn_pr_Actualizare.Text = "Actualizare";
            this.btn_pr_Actualizare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pr_Actualizare.UseVisualStyleBackColor = false;
            this.btn_pr_Actualizare.Click += new System.EventHandler(this.btn_pr_Actualizare_Click);
            // 
            // btn_pr_Salvare
            // 
            this.btn_pr_Salvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_pr_Salvare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pr_Salvare.ForeColor = System.Drawing.Color.White;
            this.btn_pr_Salvare.Image = ((System.Drawing.Image)(resources.GetObject("btn_pr_Salvare.Image")));
            this.btn_pr_Salvare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pr_Salvare.Location = new System.Drawing.Point(19, 116);
            this.btn_pr_Salvare.Name = "btn_pr_Salvare";
            this.btn_pr_Salvare.Size = new System.Drawing.Size(141, 47);
            this.btn_pr_Salvare.TabIndex = 1;
            this.btn_pr_Salvare.Text = "Salvare";
            this.btn_pr_Salvare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pr_Salvare.UseVisualStyleBackColor = false;
            this.btn_pr_Salvare.Click += new System.EventHandler(this.btn_pr_Salvare_Click);
            // 
            // btn_pr_Adaugare
            // 
            this.btn_pr_Adaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_pr_Adaugare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pr_Adaugare.ForeColor = System.Drawing.Color.White;
            this.btn_pr_Adaugare.Image = ((System.Drawing.Image)(resources.GetObject("btn_pr_Adaugare.Image")));
            this.btn_pr_Adaugare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pr_Adaugare.Location = new System.Drawing.Point(19, 32);
            this.btn_pr_Adaugare.Name = "btn_pr_Adaugare";
            this.btn_pr_Adaugare.Size = new System.Drawing.Size(141, 47);
            this.btn_pr_Adaugare.TabIndex = 0;
            this.btn_pr_Adaugare.Text = "Adaugare";
            this.btn_pr_Adaugare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pr_Adaugare.UseVisualStyleBackColor = false;
            this.btn_pr_Adaugare.Click += new System.EventHandler(this.btn_pr_Adaugare_Click);
            // 
            // dt_pr_DataNasterii
            // 
            this.dt_pr_DataNasterii.CustomFormat = "dd-MM-yyyy";
            this.dt_pr_DataNasterii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dt_pr_DataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_pr_DataNasterii.Location = new System.Drawing.Point(94, 318);
            this.dt_pr_DataNasterii.Name = "dt_pr_DataNasterii";
            this.dt_pr_DataNasterii.Size = new System.Drawing.Size(217, 23);
            this.dt_pr_DataNasterii.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 34);
            this.label12.TabIndex = 25;
            this.label12.Text = "Oras";
            // 
            // cmb_pr_Oras
            // 
            this.cmb_pr_Oras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_pr_Oras.FormattingEnabled = true;
            this.cmb_pr_Oras.Location = new System.Drawing.Point(94, 384);
            this.cmb_pr_Oras.Name = "cmb_pr_Oras";
            this.cmb_pr_Oras.Size = new System.Drawing.Size(215, 24);
            this.cmb_pr_Oras.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(394, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 37);
            this.label10.TabIndex = 23;
            this.label10.Text = "Municipiul";
            // 
            // cmb_pr_Municipiu
            // 
            this.cmb_pr_Municipiu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_pr_Municipiu.FormattingEnabled = true;
            this.cmb_pr_Municipiu.Location = new System.Drawing.Point(479, 384);
            this.cmb_pr_Municipiu.Name = "cmb_pr_Municipiu";
            this.cmb_pr_Municipiu.Size = new System.Drawing.Size(215, 24);
            this.cmb_pr_Municipiu.TabIndex = 22;
            this.cmb_pr_Municipiu.SelectedIndexChanged += new System.EventHandler(this.cmb_pr_Municipiu_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(392, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 34);
            this.label11.TabIndex = 21;
            this.label11.Text = "Judet";
            // 
            // cmb_pr_Judet
            // 
            this.cmb_pr_Judet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_pr_Judet.FormattingEnabled = true;
            this.cmb_pr_Judet.Location = new System.Drawing.Point(477, 317);
            this.cmb_pr_Judet.Name = "cmb_pr_Judet";
            this.cmb_pr_Judet.Size = new System.Drawing.Size(215, 24);
            this.cmb_pr_Judet.TabIndex = 20;
            this.cmb_pr_Judet.SelectedIndexChanged += new System.EventHandler(this.cmb_pr_Judet_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data nasterii";
            // 
            // btn_pr_Stergere
            // 
            this.btn_pr_Stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_pr_Stergere.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pr_Stergere.ForeColor = System.Drawing.Color.White;
            this.btn_pr_Stergere.Image = ((System.Drawing.Image)(resources.GetObject("btn_pr_Stergere.Image")));
            this.btn_pr_Stergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pr_Stergere.Location = new System.Drawing.Point(19, 292);
            this.btn_pr_Stergere.Name = "btn_pr_Stergere";
            this.btn_pr_Stergere.Size = new System.Drawing.Size(141, 47);
            this.btn_pr_Stergere.TabIndex = 3;
            this.btn_pr_Stergere.Text = "Stergere";
            this.btn_pr_Stergere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pr_Stergere.UseVisualStyleBackColor = false;
            this.btn_pr_Stergere.Click += new System.EventHandler(this.btn_pr_Stergere_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adresa";
            // 
            // txt_pr_Adresa
            // 
            this.txt_pr_Adresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pr_Adresa.Location = new System.Drawing.Point(94, 195);
            this.txt_pr_Adresa.Name = "txt_pr_Adresa";
            this.txt_pr_Adresa.Size = new System.Drawing.Size(600, 23);
            this.txt_pr_Adresa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(392, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // txt_pr_Email
            // 
            this.txt_pr_Email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pr_Email.Location = new System.Drawing.Point(477, 249);
            this.txt_pr_Email.Name = "txt_pr_Email";
            this.txt_pr_Email.Size = new System.Drawing.Size(215, 23);
            this.txt_pr_Email.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // rd_pr_Masculin
            // 
            this.rd_pr_Masculin.AutoSize = true;
            this.rd_pr_Masculin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rd_pr_Masculin.Location = new System.Drawing.Point(95, 92);
            this.rd_pr_Masculin.Name = "rd_pr_Masculin";
            this.rd_pr_Masculin.Size = new System.Drawing.Size(81, 20);
            this.rd_pr_Masculin.TabIndex = 9;
            this.rd_pr_Masculin.Text = "Masculin";
            this.rd_pr_Masculin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(394, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prenume";
            // 
            // txt_pr_Prenume
            // 
            this.txt_pr_Prenume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pr_Prenume.Location = new System.Drawing.Point(479, 138);
            this.txt_pr_Prenume.Name = "txt_pr_Prenume";
            this.txt_pr_Prenume.Size = new System.Drawing.Size(215, 23);
            this.txt_pr_Prenume.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume";
            // 
            // txt_pr_Nume
            // 
            this.txt_pr_Nume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pr_Nume.Location = new System.Drawing.Point(95, 141);
            this.txt_pr_Nume.Name = "txt_pr_Nume";
            this.txt_pr_Nume.Size = new System.Drawing.Size(215, 23);
            this.txt_pr_Nume.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex";
            // 
            // rd_pr_Feminin
            // 
            this.rd_pr_Feminin.AutoSize = true;
            this.rd_pr_Feminin.Checked = true;
            this.rd_pr_Feminin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rd_pr_Feminin.Location = new System.Drawing.Point(199, 95);
            this.rd_pr_Feminin.Name = "rd_pr_Feminin";
            this.rd_pr_Feminin.Size = new System.Drawing.Size(74, 20);
            this.rd_pr_Feminin.TabIndex = 3;
            this.rd_pr_Feminin.TabStop = true;
            this.rd_pr_Feminin.Text = "Feminin";
            this.rd_pr_Feminin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Experienta";
            // 
            // cmbExperienta
            // 
            this.cmbExperienta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbExperienta.FormattingEnabled = true;
            this.cmbExperienta.Location = new System.Drawing.Point(95, 46);
            this.cmbExperienta.Name = "cmbExperienta";
            this.cmbExperienta.Size = new System.Drawing.Size(178, 24);
            this.cmbExperienta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_pr_Date);
            this.groupBox2.Controls.Add(this.btn_pr_Stergere);
            this.groupBox2.Controls.Add(this.btn_pr_Actualizare);
            this.groupBox2.Controls.Add(this.btn_pr_Salvare);
            this.groupBox2.Controls.Add(this.btn_pr_Adaugare);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(769, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 444);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesare";
            // 
            // txt_pr_Telefon
            // 
            this.txt_pr_Telefon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pr_Telefon.Location = new System.Drawing.Point(95, 252);
            this.txt_pr_Telefon.Name = "txt_pr_Telefon";
            this.txt_pr_Telefon.Size = new System.Drawing.Size(215, 23);
            this.txt_pr_Telefon.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dt_pr_DataNasterii);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_pr_Oras);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_pr_Municipiu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_pr_Judet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_pr_Adresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_pr_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_pr_Telefon);
            this.groupBox1.Controls.Add(this.rd_pr_Masculin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_pr_Prenume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_pr_Nume);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rd_pr_Feminin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbExperienta);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(22, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date personale";
            // 
            // FrmProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProfesori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesori";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_pr_Date;
        public System.Windows.Forms.Button btn_pr_Actualizare;
        public System.Windows.Forms.Button btn_pr_Salvare;
        public System.Windows.Forms.Button btn_pr_Adaugare;
        public System.Windows.Forms.DateTimePicker dt_pr_DataNasterii;
        public System.Windows.Forms.ComboBox cmb_pr_Oras;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_pr_Municipiu;
        public System.Windows.Forms.ComboBox cmb_pr_Judet;
        public System.Windows.Forms.Button btn_pr_Stergere;
        public System.Windows.Forms.TextBox txt_pr_Adresa;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_pr_Email;
        public System.Windows.Forms.RadioButton rd_pr_Masculin;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_pr_Prenume;
        public System.Windows.Forms.TextBox txt_pr_Nume;
        public System.Windows.Forms.RadioButton rd_pr_Feminin;
        public System.Windows.Forms.ComboBox cmbExperienta;
        public System.Windows.Forms.TextBox txt_pr_Telefon;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}