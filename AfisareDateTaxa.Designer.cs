﻿namespace SistemScolarDeInregistrareApp
{
    partial class FrmAfisareDateTaxa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfisareDateTaxa));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCautareDupaPrenume = new System.Windows.Forms.TextBox();
            this.dtgwAfisareDateTaxe = new System.Windows.Forms.DataGridView();
            this.btn_Excel_DateTaxa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwAfisareDateTaxe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cautare dupa prenume !";
            // 
            // txtCautareDupaPrenume
            // 
            this.txtCautareDupaPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCautareDupaPrenume.Location = new System.Drawing.Point(12, 94);
            this.txtCautareDupaPrenume.Multiline = true;
            this.txtCautareDupaPrenume.Name = "txtCautareDupaPrenume";
            this.txtCautareDupaPrenume.Size = new System.Drawing.Size(249, 35);
            this.txtCautareDupaPrenume.TabIndex = 4;
            this.txtCautareDupaPrenume.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // dtgwAfisareDateTaxe
            // 
            this.dtgwAfisareDateTaxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwAfisareDateTaxe.Location = new System.Drawing.Point(12, 135);
            this.dtgwAfisareDateTaxe.Name = "dtgwAfisareDateTaxe";
            this.dtgwAfisareDateTaxe.Size = new System.Drawing.Size(750, 293);
            this.dtgwAfisareDateTaxe.TabIndex = 3;
            this.dtgwAfisareDateTaxe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwAfisareDateTaxe_CellDoubleClick);
            // 
            // btn_Excel_DateTaxa
            // 
            this.btn_Excel_DateTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Excel_DateTaxa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Excel_DateTaxa.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_DateTaxa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_DateTaxa.Image")));
            this.btn_Excel_DateTaxa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_DateTaxa.Location = new System.Drawing.Point(615, 85);
            this.btn_Excel_DateTaxa.Name = "btn_Excel_DateTaxa";
            this.btn_Excel_DateTaxa.Size = new System.Drawing.Size(147, 40);
            this.btn_Excel_DateTaxa.TabIndex = 7;
            this.btn_Excel_DateTaxa.Text = "Export Excel";
            this.btn_Excel_DateTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_DateTaxa.UseVisualStyleBackColor = false;
            this.btn_Excel_DateTaxa.Click += new System.EventHandler(this.btn_Excel_DateTaxa_Click);
            // 
            // FrmAfisareDateTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.btn_Excel_DateTaxa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCautareDupaPrenume);
            this.Controls.Add(this.dtgwAfisareDateTaxe);
            this.Name = "FrmAfisareDateTaxa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Date Taxa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwAfisareDateTaxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCautareDupaPrenume;
        private System.Windows.Forms.DataGridView dtgwAfisareDateTaxe;
        public System.Windows.Forms.Button btn_Excel_DateTaxa;
    }
}