using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MediaMedianaModa
{
    /*
     * Esse sistema apenas aceita numeros inteiros e decimais, 
     * que estejam separados por um espaço ou virgula com espaço em seguida.
     * Este é um modelo inicial de sistema com o intuito de ser um trabalho da faculdade,
     * portanto quem quiser aprimora-lo que fique a vontade.
     * Qualquer dúvida sobre o sistema podem me contactar pelo email: fabricio.ramoss@hotmail.com
     * BONS ESTUDOS!
     */

    public partial class Form1 : Form
    {
        private List<double> _lista;

        public Form1()
        {
            InitializeComponent();
        }  

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            try
            {
                /* 
                 * Ordenas os números digitados
                 */
                #region Ordenacao

                var lista = Array.ConvertAll(txt_Numeros.Text.Replace(".", ",").Trim().Split(' ', '\n'), double.Parse).ToList();
                lista.Sort();

                foreach (var item in lista)
                {
                    txt_Ordenado.Text += item + @" ";
                }

                #endregion

                /*
                 * Calcula a média
                 * Exemplo: ((10 10 30 = 50) / 3 = 15)
                 */
                #region Media

                _lista = new List<double>();

                foreach (var item in lista)
                {
                    _lista.Add(item);
                }
                lbl_Media.Text = Math.Round(_lista.Sum() / _lista.Count, 2).ToString(CultureInfo.InvariantCulture);

                #endregion

                /*
                 * Calcula a mediana
                 * Exemplo: ((10 10 30 = 10) ou (((10 10 20 30 = 10 + 20) = 30) / 2 = 15))
                 */
                #region MyRegion

                _lista = new List<double>();
                foreach (var item in lista)
                {
                    _lista.Add(item);
                }

                if (_lista.Count % 2 == 0)
                {
                    lbl_Mediana.Text =
                        ((_lista[_lista.Count / 2 - 1] + _lista[_lista.Count / 2]) / 2).ToString(CultureInfo
                            .InvariantCulture);
                }
                else
                {
                    lbl_Mediana.Text = (_lista[_lista.Count / 2]).ToString(CultureInfo.InvariantCulture);
                }

                #endregion

                /*
                 * CALCULA A MODA
                 * Exemplo: (10 10 20 30 40 = 10) (qual possui a maior frequência)
                 */
                #region Moda

                var moda = lista.GroupBy(p => p)
                    .OrderByDescending(p => p.Count())
                    .First()
                    .Key;

                lbl_Moda.Text = moda.ToString(CultureInfo.InvariantCulture);

                #endregion


                // Configuração do botão
                btn_Limpar.BringToFront();
            }
            catch
            {
                // Caso o usuário não digite nenhum número, o sistema returna sem qualquer alteração
                if (txt_Numeros.Text == string.Empty) return;

                // Configurações e mensagem de restrição
                btn_Limpar.BringToFront();
                txt_Numeros.Enabled = false;
                txt_Numeros.Text = @"Apenas inteiros ou decimais são aceitos";
            }
        }

        // O botão de limpera os componentes está apenas por de trás do botão de Gerar resultado,
        // assim apenas jogos os botões para frente ou para trás no intúito de ficar visível para o usuário.
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Numeros.Clear();
            txt_Ordenado.Clear();

            lbl_Media.Text = "";
            lbl_Mediana.Text = "";
            lbl_Moda.Text = "";

            btn_Gerar.BringToFront();
            txt_Numeros.Enabled = true;
        }
    }
}
