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
            this.txt_Ordenado = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Numeros = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Gerar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Limpar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Mediana = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.TextBox();
            this.lbl_Media = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Moda = new System.Windows.Forms.TextBox();
            this.lbl_DesvioPadrao = new System.Windows.Forms.TextBox();
            this.lbl_Variancia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // txt_Ordenado
            // 
            this.txt_Ordenado.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Ordenado.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Ordenado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Ordenado.Enabled = false;
            this.txt_Ordenado.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ordenado.Location = new System.Drawing.Point(153, 100);
            this.txt_Ordenado.Multiline = true;
            this.txt_Ordenado.Name = "txt_Ordenado";
            this.txt_Ordenado.Size = new System.Drawing.Size(443, 45);
            this.txt_Ordenado.TabIndex = 7;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(152, 73);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(207, 19);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Números ordenados:";
            // 
            // txt_Numeros
            // 
            this.txt_Numeros.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Numeros.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numeros.Location = new System.Drawing.Point(153, 12);
            this.txt_Numeros.Multiline = true;
            this.txt_Numeros.Name = "txt_Numeros";
            this.txt_Numeros.Size = new System.Drawing.Size(444, 58);
            this.txt_Numeros.TabIndex = 0;
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Gerar.color = System.Drawing.Color.SeaGreen;
            this.btn_Gerar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gerar.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gerar.ForeColor = System.Drawing.Color.White;
            this.btn_Gerar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Gerar.Image")));
            this.btn_Gerar.ImagePosition = 17;
            this.btn_Gerar.ImageZoom = 50;
            this.btn_Gerar.LabelPosition = 34;
            this.btn_Gerar.LabelText = "Gerar";
            this.btn_Gerar.Location = new System.Drawing.Point(12, 10);
            this.btn_Gerar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(131, 135);
            this.btn_Gerar.TabIndex = 6;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_Limpar.color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_Limpar.colorActive = System.Drawing.Color.Crimson;
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.ImagePosition = 17;
            this.btn_Limpar.ImageZoom = 50;
            this.btn_Limpar.LabelPosition = 34;
            this.btn_Limpar.LabelText = "Limpar";
            this.btn_Limpar.Location = new System.Drawing.Point(13, 10);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(130, 135);
            this.btn_Limpar.TabIndex = 8;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lbl_Mediana);
            this.panel2.Controls.Add(this.lbl_Total);
            this.panel2.Controls.Add(this.lbl_Media);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 151);
            this.panel2.TabIndex = 1;
            // 
            // lbl_Mediana
            // 
            this.lbl_Mediana.BackColor = System.Drawing.Color.Beige;
            this.lbl_Mediana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Mediana.Enabled = false;
            this.lbl_Mediana.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mediana.Location = new System.Drawing.Point(153, 100);
            this.lbl_Mediana.Name = "lbl_Mediana";
            this.lbl_Mediana.Size = new System.Drawing.Size(109, 19);
            this.lbl_Mediana.TabIndex = 9;
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Total.Enabled = false;
            this.lbl_Total.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(153, 14);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(109, 19);
            this.lbl_Total.TabIndex = 8;
            // 
            // lbl_Media
            // 
            this.lbl_Media.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_Media.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Media.Enabled = false;
            this.lbl_Media.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Media.Location = new System.Drawing.Point(153, 55);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(109, 19);
            this.lbl_Media.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contato: fabricio.ramoss@hotmail.com";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(72, 14);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Total:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(72, 55);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Média:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(50, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Mediana:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(2, 100);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(163, 19);
            this.bunifuCustomLabel7.TabIndex = 11;
            this.bunifuCustomLabel7.Text = "Desvio padrão:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(46, 55);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(119, 19);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "Variância:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(101, 14);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Moda:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbl_Moda);
            this.panel3.Controls.Add(this.lbl_DesvioPadrao);
            this.panel3.Controls.Add(this.lbl_Variancia);
            this.panel3.Controls.Add(this.bunifuCustomLabel7);
            this.panel3.Controls.Add(this.bunifuCustomLabel6);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Location = new System.Drawing.Point(268, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 151);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 11);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contato: fabricio.ramoss@hotmail.com";
            // 
            // lbl_Moda
            // 
            this.lbl_Moda.BackColor = System.Drawing.Color.Ivory;
            this.lbl_Moda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Moda.Enabled = false;
            this.lbl_Moda.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moda.Location = new System.Drawing.Point(171, 14);
            this.lbl_Moda.Name = "lbl_Moda";
            this.lbl_Moda.Size = new System.Drawing.Size(109, 19);
            this.lbl_Moda.TabIndex = 10;
            // 
            // lbl_DesvioPadrao
            // 
            this.lbl_DesvioPadrao.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_DesvioPadrao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_DesvioPadrao.Enabled = false;
            this.lbl_DesvioPadrao.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DesvioPadrao.Location = new System.Drawing.Point(171, 101);
            this.lbl_DesvioPadrao.Name = "lbl_DesvioPadrao";
            this.lbl_DesvioPadrao.Size = new System.Drawing.Size(109, 19);
            this.lbl_DesvioPadrao.TabIndex = 14;
            // 
            // lbl_Variancia
            // 
            this.lbl_Variancia.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Variancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Variancia.Enabled = false;
            this.lbl_Variancia.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Variancia.Location = new System.Drawing.Point(171, 56);
            this.lbl_Variancia.Name = "lbl_Variancia";
            this.lbl_Variancia.Size = new System.Drawing.Size(109, 19);
            this.lbl_Variancia.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 308);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNESA [Trabalho de Probabilidade e Estatística]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Numeros;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Gerar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Ordenado;
        private Bunifu.Framework.UI.BunifuTileButton btn_Limpar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox lbl_Mediana;
        private System.Windows.Forms.TextBox lbl_Total;
        private System.Windows.Forms.TextBox lbl_Media;
        private System.Windows.Forms.TextBox lbl_Moda;
        private System.Windows.Forms.TextBox lbl_DesvioPadrao;
        private System.Windows.Forms.TextBox lbl_Variancia;
    }
}

