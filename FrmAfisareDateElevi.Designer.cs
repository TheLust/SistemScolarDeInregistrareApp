namespace SistemScolarDeInregistrareApp
{
    partial class FrmAfisareDateElevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfisareDateElevi));
            this.GDAfisareElevi = new System.Windows.Forms.DataGridView();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Excel_DateElevi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // GDAfisareElevi
            // 
            this.GDAfisareElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDAfisareElevi.Location = new System.Drawing.Point(12, 130);
            this.GDAfisareElevi.Name = "GDAfisareElevi";
            this.GDAfisareElevi.Size = new System.Drawing.Size(1002, 293);
            this.GDAfisareElevi.TabIndex = 0;
            this.GDAfisareElevi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDAfisareElevi_CellDoubleClick);
            // 
            // txtCautare
            // 
            this.txtCautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCautare.Location = new System.Drawing.Point(12, 89);
            this.txtCautare.Multiline = true;
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(249, 35);
            this.txtCautare.TabIndex = 1;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cautare dupa prenume !";
            // 
            // btn_Excel_DateElevi
            // 
            this.btn_Excel_DateElevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Excel_DateElevi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Excel_DateElevi.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_DateElevi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_DateElevi.Image")));
            this.btn_Excel_DateElevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_DateElevi.Location = new System.Drawing.Point(867, 84);
            this.btn_Excel_DateElevi.Name = "btn_Excel_DateElevi";
            this.btn_Excel_DateElevi.Size = new System.Drawing.Size(147, 40);
            this.btn_Excel_DateElevi.TabIndex = 3;
            this.btn_Excel_DateElevi.Text = "Export Excel";
            this.btn_Excel_DateElevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_DateElevi.UseVisualStyleBackColor = false;
            this.btn_Excel_DateElevi.Click += new System.EventHandler(this.btn_Excel_DateElevi_Click);
            // 
            // FrmAfisareDateElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.btn_Excel_DateElevi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.GDAfisareElevi);
            this.Name = "FrmAfisareDateElevi";
            this.Text = "Afisare Date Elevi";
            this.Load += new System.EventHandler(this.FrmAfisareDateElevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GDAfisareElevi;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Excel_DateElevi;
    }
}