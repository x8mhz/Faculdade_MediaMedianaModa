namespace MediaMedianaModa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Numeros = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.lbl_Mediana = new System.Windows.Forms.Label();
            this.lbl_Moda = new System.Windows.Forms.Label();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Gerar = new Bunifu.Framework.UI.BunifuTileButton();
            this.txt_Ordenado = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Limpar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txt_Ordenado);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.txt_Numeros);
            this.panel1.Controls.Add(this.btn_Gerar);
            this.panel1.Controls.Add(this.btn_Limpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 157);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_Moda);
            this.panel2.Controls.Add(this.lbl_Mediana);
            this.panel2.Controls.Add(this.lbl_Media);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 151);
            this.panel2.TabIndex = 1;
            // 
            // txt_Numeros
            // 
            this.txt_Numeros.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numeros.Location = new System.Drawing.Point(153, 12);
            this.txt_Numeros.Multiline = true;
            this.txt_Numeros.Name = "txt_Numeros";
            this.txt_Numeros.Size = new System.Drawing.Size(444, 58);
            this.txt_Numeros.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 25);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Média: ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 55);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(107, 25);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Mediana: ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(61, 99);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Moda: ";
            // 
            // lbl_Media
            // 
            this.lbl_Media.AutoSize = true;
            this.lbl_Media.BackColor = System.Drawing.Color.Azure;
            this.lbl_Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Media.Location = new System.Drawing.Point(149, 19);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(69, 20);
            this.lbl_Media.TabIndex = 3;
            this.lbl_Media.Text = "               ";
            // 
            // lbl_Mediana
            // 
            this.lbl_Mediana.AutoSize = true;
            this.lbl_Mediana.BackColor = System.Drawing.Color.Thistle;
            this.lbl_Mediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mediana.Location = new System.Drawing.Point(149, 60);
            this.lbl_Mediana.Name = "lbl_Mediana";
            this.lbl_Mediana.Size = new System.Drawing.Size(69, 20);
            this.lbl_Mediana.TabIndex = 4;
            this.lbl_Mediana.Text = "               ";
            // 
            // lbl_Moda
            // 
            this.lbl_Moda.AutoSize = true;
            this.lbl_Moda.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Moda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moda.Location = new System.Drawing.Point(149, 104);
            this.lbl_Moda.Name = "lbl_Moda";
            this.lbl_Moda.Size = new System.Drawing.Size(69, 20);
            this.lbl_Moda.TabIndex = 5;
            this.lbl_Moda.Text = "               ";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(149, 73);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(189, 24);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Números ordenados:";
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Gerar.color = System.Drawing.Color.SeaGreen;
            this.btn_Gerar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Gerar.ForeColor = System.Drawing.Color.White;
            this.btn_Gerar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Gerar.Image")));
            this.btn_Gerar.ImagePosition = 20;
            this.btn_Gerar.ImageZoom = 50;
            this.btn_Gerar.LabelPosition = 41;
            this.btn_Gerar.LabelText = "Gerar";
            this.btn_Gerar.Location = new System.Drawing.Point(12, 12);
            this.btn_Gerar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(127, 133);
            this.btn_Gerar.TabIndex = 6;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // txt_Ordenado
            // 
            this.txt_Ordenado.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Ordenado.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Ordenado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Ordenado.Enabled = false;
            this.txt_Ordenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ordenado.Location = new System.Drawing.Point(153, 100);
            this.txt_Ordenado.Multiline = true;
            this.txt_Ordenado.Name = "txt_Ordenado";
            this.txt_Ordenado.Size = new System.Drawing.Size(443, 45);
            this.txt_Ordenado.TabIndex = 7;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_Limpar.color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_Limpar.colorActive = System.Drawing.Color.Crimson;
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.ImagePosition = 20;
            this.btn_Limpar.ImageZoom = 50;
            this.btn_Limpar.LabelPosition = 41;
            this.btn_Limpar.LabelText = "Limpar";
            this.btn_Limpar.Location = new System.Drawing.Point(12, 12);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(127, 133);
            this.btn_Limpar.TabIndex = 8;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "UNESA [Trabalho de Probabilidade e Estatística]";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Numeros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Moda;
        private System.Windows.Forms.Label lbl_Mediana;
        private System.Windows.Forms.Label lbl_Media;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Gerar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Ordenado;
        private Bunifu.Framework.UI.BunifuTileButton btn_Limpar;
    }
}

