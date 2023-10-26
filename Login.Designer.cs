namespace SistemScolarDeInregistrareApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chkArataParola = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLoginParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginUtilizator = new System.Windows.Forms.TextBox();
            this.lblLoginUtilizator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkArataParola
            // 
            this.chkArataParola.AutoSize = true;
            this.chkArataParola.BackColor = System.Drawing.Color.White;
            this.chkArataParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkArataParola.Location = new System.Drawing.Point(197, 514);
            this.chkArataParola.Name = "chkArataParola";
            this.chkArataParola.Size = new System.Drawing.Size(128, 24);
            this.chkArataParola.TabIndex = 11;
            this.chkArataParola.Text = "Arata Parola";
            this.chkArataParola.UseVisualStyleBackColor = false;
            this.chkArataParola.CheckedChanged += new System.EventHandler(this.chkArataParola_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(262, 556);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 49);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.ForeColor = System.Drawing.Color.White;
            this.btnIesire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIesire.Location = new System.Drawing.Point(22, 556);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(143, 49);
            this.btnIesire.TabIndex = 8;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtLoginParola
            // 
            this.txtLoginParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLoginParola.Location = new System.Drawing.Point(137, 468);
            this.txtLoginParola.Name = "txtLoginParola";
            this.txtLoginParola.Size = new System.Drawing.Size(268, 26);
            this.txtLoginParola.TabIndex = 7;
            this.txtLoginParola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parola";
            // 
            // txtLoginUtilizator
            // 
            this.txtLoginUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLoginUtilizator.Location = new System.Drawing.Point(137, 416);
            this.txtLoginUtilizator.Name = "txtLoginUtilizator";
            this.txtLoginUtilizator.Size = new System.Drawing.Size(268, 26);
            this.txtLoginUtilizator.TabIndex = 6;
            // 
            // lblLoginUtilizator
            // 
            this.lblLoginUtilizator.AutoSize = true;
            this.lblLoginUtilizator.BackColor = System.Drawing.Color.White;
            this.lblLoginUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginUtilizator.Location = new System.Drawing.Point(18, 414);
            this.lblLoginUtilizator.Name = "lblLoginUtilizator";
            this.lblLoginUtilizator.Size = new System.Drawing.Size(81, 20);
            this.lblLoginUtilizator.TabIndex = 12;
            this.lblLoginUtilizator.Text = "Utilizator";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 620);
            this.Controls.Add(this.chkArataParola);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLoginParola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginUtilizator);
            this.Controls.Add(this.lblLoginUtilizator);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkArataParola;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLoginParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginUtilizator;
        private System.Windows.Forms.Label lblLoginUtilizator;
    }
}