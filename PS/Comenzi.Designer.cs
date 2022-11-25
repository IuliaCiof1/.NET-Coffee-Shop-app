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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotaPlata = new System.Windows.Forms.Button();
            this.btnNodaComanda = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comenzi";
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdauga.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(361, 270);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(47, 42);
            this.btnAdauga.TabIndex = 13;
            this.btnAdauga.Text = "+";
            this.btnAdauga.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnNotaPlata
            // 
            this.btnNotaPlata.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNotaPlata.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaPlata.Location = new System.Drawing.Point(239, 363);
            this.btnNotaPlata.Name = "btnNotaPlata";
            this.btnNotaPlata.Size = new System.Drawing.Size(212, 41);
            this.btnNotaPlata.TabIndex = 16;
            this.btnNotaPlata.Text = "Note de Plata";
            this.btnNotaPlata.UseVisualStyleBackColor = false;
            this.btnNotaPlata.Click += new System.EventHandler(this.btnNotaPlata_Click);
            // 
            // btnNodaComanda
            // 
            this.btnNodaComanda.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNodaComanda.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodaComanda.Location = new System.Drawing.Point(12, 363);
            this.btnNodaComanda.Name = "btnNodaComanda";
            this.btnNodaComanda.Size = new System.Drawing.Size(212, 41);
            this.btnNodaComanda.TabIndex = 15;
            this.btnNodaComanda.Text = "Note de Comanda";
            this.btnNodaComanda.UseVisualStyleBackColor = false;
            this.btnNodaComanda.Click += new System.EventHandler(this.btnNodaComanda_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnInapoi.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoi.Location = new System.Drawing.Point(332, 459);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(109, 41);
            this.btnInapoi.TabIndex = 17;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 212);
            this.dataGridView1.TabIndex = 18;
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnNotaPlata);
            this.Controls.Add(this.btnNodaComanda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label1);
            this.Name = "Comenzi";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNotaPlata;
        private System.Windows.Forms.Button btnNodaComanda;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}