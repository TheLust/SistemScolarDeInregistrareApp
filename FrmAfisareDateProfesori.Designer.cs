namespace SistemScolarDeInregistrareApp
{
    partial class FrmAfisareDateProfesori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfisareDateProfesori));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pr_cautare = new System.Windows.Forms.TextBox();
            this.dgwProfesori = new System.Windows.Forms.DataGridView();
            this.btn_Excel_DateProfesori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfesori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cautare dupa prenume !";
            // 
            // txt_pr_cautare
            // 
            this.txt_pr_cautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pr_cautare.Location = new System.Drawing.Point(11, 89);
            this.txt_pr_cautare.Multiline = true;
            this.txt_pr_cautare.Name = "txt_pr_cautare";
            this.txt_pr_cautare.Size = new System.Drawing.Size(249, 35);
            this.txt_pr_cautare.TabIndex = 4;
            this.txt_pr_cautare.TextChanged += new System.EventHandler(this.txt_pr_cautare_TextChanged);
            // 
            // dgwProfesori
            // 
            this.dgwProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfesori.Location = new System.Drawing.Point(11, 130);
            this.dgwProfesori.Name = "dgwProfesori";
            this.dgwProfesori.Size = new System.Drawing.Size(1002, 269);
            this.dgwProfesori.TabIndex = 3;
            this.dgwProfesori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProfesori_CellDoubleClick);
            // 
            // btn_Excel_DateProfesori
            // 
            this.btn_Excel_DateProfesori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Excel_DateProfesori.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Excel_DateProfesori.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_DateProfesori.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_DateProfesori.Image")));
            this.btn_Excel_DateProfesori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_DateProfesori.Location = new System.Drawing.Point(866, 84);
            this.btn_Excel_DateProfesori.Name = "btn_Excel_DateProfesori";
            this.btn_Excel_DateProfesori.Size = new System.Drawing.Size(147, 40);
            this.btn_Excel_DateProfesori.TabIndex = 6;
            this.btn_Excel_DateProfesori.Text = "Export Excel";
            this.btn_Excel_DateProfesori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_DateProfesori.UseVisualStyleBackColor = false;
            this.btn_Excel_DateProfesori.Click += new System.EventHandler(this.btn_Excel_DateProfesori_Click);
            // 
            // FrmAfisareDateProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 411);
            this.Controls.Add(this.btn_Excel_DateProfesori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pr_cautare);
            this.Controls.Add(this.dgwProfesori);
            this.MaximizeBox = false;
            this.Name = "FrmAfisareDateProfesori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Date Profesori";
            this.Load += new System.EventHandler(this.FrmAfisareDateProfesori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfesori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pr_cautare;
        private System.Windows.Forms.DataGridView dgwProfesori;
        public System.Windows.Forms.Button btn_Excel_DateProfesori;
    }
}