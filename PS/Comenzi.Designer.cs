namespace PS
{
    partial class Comenzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comenzi));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNotaPlata = new System.Windows.Forms.Button();
            this.btnNotaComanda = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnProdusNou = new System.Windows.Forms.Button();
            this.comboBoxProdus = new System.Windows.Forms.ComboBox();
            this.comboBoxOspatar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStergeComanda = new System.Windows.Forms.Button();
            this.lblProdus = new System.Windows.Forms.Label();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.txtBoxMasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.siticonePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comenzi";
            // 
            // btnNotaPlata
            // 
            this.btnNotaPlata.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNotaPlata.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaPlata.Location = new System.Drawing.Point(333, 572);
            this.btnNotaPlata.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotaPlata.Name = "btnNotaPlata";
            this.btnNotaPlata.Size = new System.Drawing.Size(283, 50);
            this.btnNotaPlata.TabIndex = 16;
            this.btnNotaPlata.Text = "Note de Plata";
            this.btnNotaPlata.UseVisualStyleBackColor = false;
            this.btnNotaPlata.Click += new System.EventHandler(this.btnNotaPlata_Click);
            // 
            // btnNotaComanda
            // 
            this.btnNotaComanda.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNotaComanda.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaComanda.Location = new System.Drawing.Point(26, 572);
            this.btnNotaComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotaComanda.Name = "btnNotaComanda";
            this.btnNotaComanda.Size = new System.Drawing.Size(283, 50);
            this.btnNotaComanda.TabIndex = 15;
            this.btnNotaComanda.Text = "Note de Comanda";
            this.btnNotaComanda.UseVisualStyleBackColor = false;
            this.btnNotaComanda.Click += new System.EventHandler(this.btnNotaComanda_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnInapoi.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoi.Location = new System.Drawing.Point(471, 655);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(145, 50);
            this.btnInapoi.TabIndex = 17;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 261);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticonePanel3.BorderColor = System.Drawing.SystemColors.Info;
            this.siticonePanel3.BorderThickness = 1;
            this.siticonePanel3.Controls.Add(this.btnProdusNou);
            this.siticonePanel3.Controls.Add(this.comboBoxProdus);
            this.siticonePanel3.Controls.Add(this.comboBoxOspatar);
            this.siticonePanel3.Controls.Add(this.label5);
            this.siticonePanel3.Controls.Add(this.btnStergeComanda);
            this.siticonePanel3.Controls.Add(this.lblProdus);
            this.siticonePanel3.Controls.Add(this.btnAdaugaComanda);
            this.siticonePanel3.Controls.Add(this.txtBoxMasa);
            this.siticonePanel3.Controls.Add(this.label2);
            this.siticonePanel3.Location = new System.Drawing.Point(26, 347);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(590, 190);
            this.siticonePanel3.TabIndex = 35;
            // 
            // btnProdusNou
            // 
            this.btnProdusNou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProdusNou.Enabled = false;
            this.btnProdusNou.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusNou.Location = new System.Drawing.Point(250, 126);
            this.btnProdusNou.Margin = new System.Windows.Forms.Padding(4);
            this.btnProdusNou.Name = "btnProdusNou";
            this.btnProdusNou.Size = new System.Drawing.Size(143, 49);
            this.btnProdusNou.TabIndex = 36;
            this.btnProdusNou.Text = "Produs Nou";
            this.btnProdusNou.UseVisualStyleBackColor = false;
            this.btnProdusNou.Click += new System.EventHandler(this.btnProdusNou_Click);
            // 
            // comboBoxProdus
            // 
            this.comboBoxProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProdus.FormattingEnabled = true;
            this.comboBoxProdus.Location = new System.Drawing.Point(24, 136);
            this.comboBoxProdus.Name = "comboBoxProdus";
            this.comboBoxProdus.Size = new System.Drawing.Size(205, 30);
            this.comboBoxProdus.TabIndex = 35;
            // 
            // comboBoxOspatar
            // 
            this.comboBoxOspatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOspatar.FormattingEnabled = true;
            this.comboBoxOspatar.Location = new System.Drawing.Point(199, 63);
            this.comboBoxOspatar.Name = "comboBoxOspatar";
            this.comboBoxOspatar.Size = new System.Drawing.Size(205, 30);
            this.comboBoxOspatar.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(194, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ospatar:";
            // 
            // btnStergeComanda
            // 
            this.btnStergeComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStergeComanda.Enabled = false;
            this.btnStergeComanda.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeComanda.Location = new System.Drawing.Point(505, 105);
            this.btnStergeComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergeComanda.Name = "btnStergeComanda";
            this.btnStergeComanda.Size = new System.Drawing.Size(56, 49);
            this.btnStergeComanda.TabIndex = 31;
            this.btnStergeComanda.Text = "-";
            this.btnStergeComanda.UseVisualStyleBackColor = false;
            this.btnStergeComanda.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // lblProdus
            // 
            this.lblProdus.AutoSize = true;
            this.lblProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProdus.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdus.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProdus.Location = new System.Drawing.Point(18, 100);
            this.lblProdus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(88, 33);
            this.lblProdus.TabIndex = 29;
            this.lblProdus.Text = "Produs:";
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdaugaComanda.Enabled = false;
            this.btnAdaugaComanda.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaComanda.Location = new System.Drawing.Point(505, 32);
            this.btnAdaugaComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(56, 49);
            this.btnAdaugaComanda.TabIndex = 26;
            this.btnAdaugaComanda.Text = "+";
            this.btnAdaugaComanda.UseVisualStyleBackColor = false;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // txtBoxMasa
            // 
            this.txtBoxMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMasa.Location = new System.Drawing.Point(23, 63);
            this.txtBoxMasa.Name = "txtBoxMasa";
            this.txtBoxMasa.Size = new System.Drawing.Size(137, 28);
            this.txtBoxMasa.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Numar Masa:";
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 746);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnNotaPlata);
            this.Controls.Add(this.btnNotaComanda);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNotaPlata;
        private System.Windows.Forms.Button btnNotaComanda;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Button btnStergeComanda;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.TextBox txtBoxMasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProdusNou;
        private System.Windows.Forms.ComboBox comboBoxProdus;
        private System.Windows.Forms.ComboBox comboBoxOspatar;
        private System.Windows.Forms.Label label5;
    }
}