namespace RegisztracioAlkalmazas
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
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_szuldatum = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_szuldatum = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.radioButton_ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.listBox_hobbilista = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_mentes = new System.Windows.Forms.Button();
            this.button_betolt = new System.Windows.Forms.Button();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.textBox_hobbi = new System.Windows.Forms.TextBox();
            this.label_hobbihozzaad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(105, 14);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev.TabIndex = 0;
            // 
            // textBox_szuldatum
            // 
            this.textBox_szuldatum.Location = new System.Drawing.Point(105, 40);
            this.textBox_szuldatum.Name = "textBox_szuldatum";
            this.textBox_szuldatum.Size = new System.Drawing.Size(100, 20);
            this.textBox_szuldatum.TabIndex = 1;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(67, 17);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(32, 13);
            this.label_nev.TabIndex = 3;
            this.label_nev.Text = "NÉV:";
            // 
            // label_szuldatum
            // 
            this.label_szuldatum.AutoSize = true;
            this.label_szuldatum.Location = new System.Drawing.Point(12, 43);
            this.label_szuldatum.Name = "label_szuldatum";
            this.label_szuldatum.Size = new System.Drawing.Size(87, 13);
            this.label_szuldatum.TabIndex = 4;
            this.label_szuldatum.Text = "Születési dátum: ";
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Location = new System.Drawing.Point(65, 74);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(34, 13);
            this.label_nem.TabIndex = 5;
            this.label_nem.Text = "NEM:";
            // 
            // radioButton_ferfi
            // 
            this.radioButton_ferfi.AutoSize = true;
            this.radioButton_ferfi.Checked = true;
            this.radioButton_ferfi.Location = new System.Drawing.Point(105, 72);
            this.radioButton_ferfi.Name = "radioButton_ferfi";
            this.radioButton_ferfi.Size = new System.Drawing.Size(45, 17);
            this.radioButton_ferfi.TabIndex = 6;
            this.radioButton_ferfi.TabStop = true;
            this.radioButton_ferfi.Text = "Férfi";
            this.radioButton_ferfi.UseVisualStyleBackColor = true;
            this.radioButton_ferfi.CheckedChanged += new System.EventHandler(this.radioButton_ferfi_CheckedChanged);
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(166, 74);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(39, 17);
            this.radioButton_no.TabIndex = 7;
            this.radioButton_no.Text = "Nő";
            this.radioButton_no.UseVisualStyleBackColor = true;
            this.radioButton_no.CheckedChanged += new System.EventHandler(this.radioButton_no_CheckedChanged);
            // 
            // listBox_hobbilista
            // 
            this.listBox_hobbilista.FormattingEnabled = true;
            this.listBox_hobbilista.Location = new System.Drawing.Point(228, 30);
            this.listBox_hobbilista.Name = "listBox_hobbilista";
            this.listBox_hobbilista.Size = new System.Drawing.Size(120, 95);
            this.listBox_hobbilista.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "A kedvenc hobbijaim";
            // 
            // button_mentes
            // 
            this.button_mentes.Location = new System.Drawing.Point(189, 200);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(75, 23);
            this.button_mentes.TabIndex = 10;
            this.button_mentes.Text = "Mentes";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // button_betolt
            // 
            this.button_betolt.Location = new System.Drawing.Point(273, 200);
            this.button_betolt.Name = "button_betolt";
            this.button_betolt.Size = new System.Drawing.Size(75, 23);
            this.button_betolt.TabIndex = 11;
            this.button_betolt.Text = "Betöltés";
            this.button_betolt.UseVisualStyleBackColor = true;
            this.button_betolt.Click += new System.EventHandler(this.button_betolt_Click);
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(273, 157);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaad.TabIndex = 12;
            this.button_hozzaad.Text = "Hozzáad";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // textBox_hobbi
            // 
            this.textBox_hobbi.Location = new System.Drawing.Point(248, 131);
            this.textBox_hobbi.Name = "textBox_hobbi";
            this.textBox_hobbi.Size = new System.Drawing.Size(100, 20);
            this.textBox_hobbi.TabIndex = 13;
            // 
            // label_hobbihozzaad
            // 
            this.label_hobbihozzaad.AutoSize = true;
            this.label_hobbihozzaad.Location = new System.Drawing.Point(193, 134);
            this.label_hobbihozzaad.Name = "label_hobbihozzaad";
            this.label_hobbihozzaad.Size = new System.Drawing.Size(49, 13);
            this.label_hobbihozzaad.TabIndex = 14;
            this.label_hobbihozzaad.Text = "Új hobbi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 234);
            this.Controls.Add(this.label_hobbihozzaad);
            this.Controls.Add(this.textBox_hobbi);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.button_betolt);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_hobbilista);
            this.Controls.Add(this.radioButton_no);
            this.Controls.Add(this.radioButton_ferfi);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label_szuldatum);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.textBox_szuldatum);
            this.Controls.Add(this.textBox_nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_szuldatum;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_szuldatum;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.RadioButton radioButton_ferfi;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.ListBox listBox_hobbilista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Button button_betolt;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.TextBox textBox_hobbi;
        private System.Windows.Forms.Label label_hobbihozzaad;
    }
}

