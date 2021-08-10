
namespace WYDLauncher
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.Efeitos = new System.Windows.Forms.TrackBar();
            this.Musica = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrilhoTxt = new System.Windows.Forms.Label();
            this.Brilho = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.strtGameBtn = new System.Windows.Forms.Button();
            this.EfeitosTxt = new System.Windows.Forms.Label();
            this.MusicaTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Efeitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Musica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brilho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Efeitos
            // 
            this.Efeitos.Location = new System.Drawing.Point(57, 67);
            this.Efeitos.Maximum = 100;
            this.Efeitos.Name = "Efeitos";
            this.Efeitos.Size = new System.Drawing.Size(104, 45);
            this.Efeitos.TabIndex = 0;
            this.Efeitos.TickFrequency = 10;
            this.Efeitos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Efeitos.ValueChanged += new System.EventHandler(this.Efeitos_ValueChanged);
            // 
            // Musica
            // 
            this.Musica.Location = new System.Drawing.Point(57, 19);
            this.Musica.Maximum = 100;
            this.Musica.Name = "Musica";
            this.Musica.Size = new System.Drawing.Size(104, 45);
            this.Musica.TabIndex = 1;
            this.Musica.TickFrequency = 10;
            this.Musica.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Musica.ValueChanged += new System.EventHandler(this.Musica_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrilhoTxt);
            this.groupBox1.Controls.Add(this.Brilho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resolução de Tela";
            // 
            // BrilhoTxt
            // 
            this.BrilhoTxt.AutoSize = true;
            this.BrilhoTxt.Location = new System.Drawing.Point(158, 87);
            this.BrilhoTxt.Name = "BrilhoTxt";
            this.BrilhoTxt.Size = new System.Drawing.Size(13, 13);
            this.BrilhoTxt.TabIndex = 6;
            this.BrilhoTxt.Text = "0";
            // 
            // Brilho
            // 
            this.Brilho.Location = new System.Drawing.Point(49, 83);
            this.Brilho.Maximum = 100;
            this.Brilho.Name = "Brilho";
            this.Brilho.Size = new System.Drawing.Size(113, 45);
            this.Brilho.TabIndex = 4;
            this.Brilho.TickFrequency = 10;
            this.Brilho.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Brilho.ValueChanged += new System.EventHandler(this.Brilho_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Brilho:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(149, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(81, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            
            this.comboBox1.Location = new System.Drawing.Point(81, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Selecione...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tela Cheia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tamanho:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.strtGameBtn);
            this.groupBox2.Controls.Add(this.EfeitosTxt);
            this.groupBox2.Controls.Add(this.MusicaTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Efeitos);
            this.groupBox2.Controls.Add(this.Musica);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações de Áudio";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(112, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // strtGameBtn
            // 
            this.strtGameBtn.BackColor = System.Drawing.Color.LightGray;
            this.strtGameBtn.FlatAppearance.BorderSize = 2;
            this.strtGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strtGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtGameBtn.ForeColor = System.Drawing.Color.DimGray;
            this.strtGameBtn.Location = new System.Drawing.Point(10, 143);
            this.strtGameBtn.Name = "strtGameBtn";
            this.strtGameBtn.Size = new System.Drawing.Size(82, 33);
            this.strtGameBtn.TabIndex = 4;
            this.strtGameBtn.Text = "Padrão";
            this.strtGameBtn.UseVisualStyleBackColor = false;
            this.strtGameBtn.Click += new System.EventHandler(this.strtGameBtn_Click);
            // 
            // EfeitosTxt
            // 
            this.EfeitosTxt.AutoSize = true;
            this.EfeitosTxt.Location = new System.Drawing.Point(157, 70);
            this.EfeitosTxt.Name = "EfeitosTxt";
            this.EfeitosTxt.Size = new System.Drawing.Size(13, 13);
            this.EfeitosTxt.TabIndex = 8;
            this.EfeitosTxt.Text = "0";
            this.EfeitosTxt.Click += new System.EventHandler(this.EfeitosTxt_Click);
            // 
            // MusicaTxt
            // 
            this.MusicaTxt.AutoSize = true;
            this.MusicaTxt.Location = new System.Drawing.Point(157, 23);
            this.MusicaTxt.Name = "MusicaTxt";
            this.MusicaTxt.Size = new System.Drawing.Size(13, 13);
            this.MusicaTxt.TabIndex = 7;
            this.MusicaTxt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Efeitos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Música:";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(434, 203);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Efeitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Musica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brilho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar Efeitos;
        private System.Windows.Forms.TrackBar Musica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TrackBar Brilho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BrilhoTxt;
        private System.Windows.Forms.Label EfeitosTxt;
        private System.Windows.Forms.Label MusicaTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button strtGameBtn;
    }
}