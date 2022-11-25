namespace PS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnMeniu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAngajati = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.btnIncasari = new System.Windows.Forms.Button();
            this.btnInchide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMeniu
            // 
            this.btnMeniu.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMeniu.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniu.Location = new System.Drawing.Point(64, 123);
            this.btnMeniu.Name = "btnMeniu";
            this.btnMeniu.Size = new System.Drawing.Size(166, 41);
            this.btnMeniu.TabIndex = 0;
            this.btnMeniu.Text = "Meniu";
            this.btnMeniu.UseVisualStyleBackColor = false;
            this.btnMeniu.Click += new System.EventHandler(this.btnMeniu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "CoffeShop";
            // 
            // btnAngajati
            // 
            this.btnAngajati.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAngajati.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngajati.Location = new System.Drawing.Point(64, 180);
            this.btnAngajati.Name = "btnAngajati";
            this.btnAngajati.Size = new System.Drawing.Size(166, 41);
            this.btnAngajati.TabIndex = 2;
            this.btnAngajati.Text = "Angajati";
            this.btnAngajati.UseVisualStyleBackColor = false;
            // 
            // btnComenzi
            // 
            this.btnComenzi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnComenzi.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzi.Location = new System.Drawing.Point(64, 237);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(166, 41);
            this.btnComenzi.TabIndex = 3;
            this.btnComenzi.Text = "Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = false;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // btnIncasari
            // 
            this.btnIncasari.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIncasari.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncasari.Location = new System.Drawing.Point(64, 318);
            this.btnIncasari.Name = "btnIncasari";
            this.btnIncasari.Size = new System.Drawing.Size(166, 41);
            this.btnIncasari.TabIndex = 4;
            this.btnIncasari.Text = "Incasari";
            this.btnIncasari.UseVisualStyleBackColor = false;
            // 
            // btnInchide
            // 
            this.btnInchide.BackColor = System.Drawing.Color.RosyBrown;
            this.btnInchide.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchide.Location = new System.Drawing.Point(64, 424);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(166, 41);
            this.btnInchide.TabIndex = 5;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 502);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.btnIncasari);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnAngajati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMeniu);
            this.Name = "Form1";
            this.Text = "Activitate Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeniu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAngajati;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.Button btnIncasari;
        private System.Windows.Forms.Button btnInchide;
    }
}

