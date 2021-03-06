﻿using System;
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
                // ORDENA E EDITA OS NÚMEROS INFORMADO PELO USUÁRIO   
                // Convert e edit ponto para virgula.
                var lista = Array.ConvertAll(txt_Numeros.Text.Replace(".", ",")
                    .Trim().Split(' ', '\n'), double.Parse).ToList();

                // Ordena os vlores digitados.
                lista.Sort();

                // Remove todos os valores zero da lista.
                lista.RemoveAll(p => p.Equals(0));
                var total = 0.0;
                foreach (var item in lista)
                {
                    txt_Ordenado.Text += item + @" ";
                    total += item;
                }
                lbl_Total.Text =total.ToString();

                // CALCULA A MÉDIA
                // Explicação: Soma todos os valores informados e divide pela quantidade de valores
                var media = Math.Round(lista.Sum() / lista.Count, 2);
                lbl_Media.Text = media.ToString();

                // CALCULA A MEDIANA
                // Explicação: Se a quantidade de valores for impar pega o valor que divide a seguencia ao meio,
                // sendo par soma os dois valores do meio e divide por 2
                _lista = new List<double>();
                foreach (var item in lista)
                {
                    _lista.Add(item);
                }
                lbl_Mediana.Text = _lista.Count % 2 == 0 ? ((_lista[_lista.Count / 2 - 1] + _lista[_lista.Count / 2]) / 2)
                    .ToString() : (_lista[_lista.Count / 2]).ToString();

                // CALCULA A MODA
                // Explicação: Valor que possui a maior frequência, caso todos valores sejam iguais ou caso todos valores sejam 
                // diferentes é chamado de amodal.
                var cont = 0;
                for (var i = 0; i < lista.Count; i++)
                {
                    for (var j = i + 1; j < lista.Count; j++)
                    {
                        if (lista[i].Equals(lista[j]))
                        {
                            cont++;
                        }
                    }
                }
                if (cont > 0)
                {
                    var moda = lista.GroupBy(p => p)
                        .OrderByDescending(p => p.Count())
                        .First()
                        .Key;

                    lbl_Moda.Text = moda.ToString();
                }
                else
                {
                    lbl_Moda.Text = @"Amodal";
                }

                // CALCULA VARIÂNCIA
                // Explicação: Valor(Xi) menos média elevado a dois.
                var listaVariancia = lista.Select(item => (item - media) * (item - media)).ToList();
                var variancia = Math.Round(listaVariancia.Sum() / (5 - 1));
                lbl_Variancia.Text = variancia.ToString();

                // CALCULA O DESVIO PADRÃO
                // Explicação: A raiz quadrada da variância.
                var desvioPadrao = Math.Round(Math.Sqrt(variancia));
                lbl_DesvioPadrao.Text = desvioPadrao.ToString();

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
            lbl_Total.Text = "";
            lbl_Media.Text = "";
            lbl_Mediana.Text = "";
            lbl_Moda.Text = "";
            lbl_Variancia.Text = "";
            lbl_DesvioPadrao.Text = "";
            btn_Gerar.BringToFront();
            txt_Numeros.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}