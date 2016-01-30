using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ParkL
{
    public partial class Saida : Form
    {
        private StringReader leitor;
        Relatorio relatorio = new Relatorio();

        public Saida()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                try
                {
                    Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter entradasAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter();
                    Banco.ParkLotKainaguaDataSet.EntradasDataTable dtEn = new ParkL.Banco.ParkLotKainaguaDataSet.EntradasDataTable();

                    entradasAdapter.Fill(dtEn);

                    DataRow[] row = dtEn.Select("cod = " + txtCod.Text);

                    if (row.Length > 0)
                    {
                        lblPlaca.Text = row[0]["Placa"].ToString();
                        lblCor.Text = row[0]["Cor"].ToString();
                        lblModelo.Text = row[0]["Modelo"].ToString();

                        DateTime dtEntrada = (DateTime)row[0]["Entrada"];
                        DateTime dtSaida = DateTime.Now;
                        TimeSpan spPeriodo = dtSaida - dtEntrada;

                        lblEntrada.Text = dtEntrada.ToShortTimeString();
                        lblSaida.Text = dtSaida.ToShortTimeString();
                        lblPeriodo.Text = spPeriodo.Hours + " hs " + spPeriodo.Minutes + " min";
                    }
                    else
                    {
                        lblPlaca.Text = "_______";
                        lblCor.Text = "_______";
                        lblModelo.Text = "_______";
                        lblEntrada.Text = "_______";
                        lblSaida.Text = "_______";
                        lblPeriodo.Text = "_______";
                        lblStatus.Text = "Erro! Não foi possível encontrar a Entrada.";
                    }
                }
                catch
                {
                    lblStatus.Text = "Erro! Não foi possível encontrar a Entrada.";
                }
            }
            else
            {
                lblStatus.Text = "Digite o código.";
                txtCod.Focus();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            try
            {   
                if (txtCod.Text != "")
                {
                    string mensagemStatus = "Baixa realizada com sucesso!";
                    Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter entradasAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter();
                    Banco.ParkLotKainaguaDataSet.EntradasDataTable dtEn = new ParkL.Banco.ParkLotKainaguaDataSet.EntradasDataTable();

                    entradasAdapter.Fill(dtEn);

                    DataRow[] row = dtEn.Select("cod = " + txtCod.Text);

                    DateTime dtEntrada = (DateTime)row[0]["Entrada"];
                    DateTime dtSaida = DateTime.Now;

                    row[0]["Saida"] = dtSaida;

                    StringBuilder textPrinter = new StringBuilder();
                    textPrinter.Append(" KAINÁGUA EMPREENDIMENTOS \n     ESPORTIVOS S/C LTDA \n\n");
                    textPrinter.Append(" Av. Dr. Guilherme Dumont Villares,455 \n");
                    textPrinter.Append(" CNPJ- 62.284.757/0001-01 \n");

                    textPrinter.Append("\n Código: " + txtCod.Text);
                    textPrinter.Append("\n Placa: " + lblPlaca.Text);
                    textPrinter.Append("\n Modelo: " + lblModelo.Text);
                    textPrinter.Append(" Cor: " + lblCor.Text);
                    textPrinter.Append("\n Entrada: " + dtEntrada.ToShortDateString());
                    textPrinter.Append(" " + dtEntrada.Hour + ":" + dtEntrada.Minute);
                    textPrinter.Append("\n Saída: " + DateTime.Now.ToShortDateString());
                    textPrinter.Append(" " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    textPrinter.Append("\n Período: " + lblPeriodo.Text);


                    if (valor.Replace("R$", "").Trim() != "." && valor.Replace("R$", "").Trim() != ",")
                    {
                        if (Convert.ToDouble(valor.Replace("R$", "").Replace(".", ",")) != 0)
                        {
                            textPrinter.Append("\n Valor: " + valor.Replace(".", ","));
                        }
                        else
                        {
                            textPrinter.Append("\n Valor: CORTESIA");
                            valor = "R$ 00.00";
                        }
                    }
                    else
                    {
                        textPrinter.Append("\n Valor: CORTESIA");
                        valor = "R$ 00.00";
                    }

                    row[0]["Valor"] = valor;
                    entradasAdapter.Update(row[0]);
                    dtEn.AcceptChanges();

                    try
                    {
                        Imprimir(textPrinter.ToString());
                    }
                    catch
                    {
                        mensagemStatus = "Baixa realizada com sucesso. Mas ocorreu um erro na impressão.";
                    }

                    lblStatus.Text = mensagemStatus;
                }
                else
                    lblStatus.Text = "Digite o código do comprovante.";
            }
            catch(Exception ex)
            {
                //label5.Text = txtValor.Text + " "+ valor +" " + ex.Message;
                lblStatus.Text = "Erro! Não foi possível realizar a Baixa.";
            }

        }

        void Imprimir(string texto)
        {
            leitor = new StringReader(texto);
            this.printDocument1.Print();
        }

        void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //variaveis usadas para definir as configurações da impressão
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            //float margemEsquerda = e.MarginBounds.Left;
            //float margemSuperior = e.MarginBounds.Top;
            float margemEsquerda = 0.1f;
            float margemSuperior = 0.1f;
            string linha = null;
            Font fonteImpressao = new Font("Arial", 12);
            SolidBrush mCaneta = new SolidBrush(Color.Black);

            // Define o numero de linhas por pagina, usando MarginBounds.
            //linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);
            linhasPorPagina = 12;
            //linhasPorPagina = 100 / fonteImpressao.GetHeight(e.Graphics);

            // Itera sobre a string usando StringReader, imprimindo cada linha
            while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
            {
                // calcula a posicao da proxima linha baseada
                // na altura da fonte de acordo com o dispositivo de impressão
                yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

                // desenha a proxima linha no controle RichTextBox
                e.Graphics.DrawString(linha, fonteImpressao, mCaneta, margemEsquerda, yPosicao, new StringFormat());
                contador++;
            }
            // Verifica se existe mais linhas para imprimir
            if (linha != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            //libera recursos		
            mCaneta.Dispose();
        }

        private void relatórioF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio.Show(this);
            relatorio.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            relatorio.preencheDataGrid();
            this.Hide();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            Owner.Visible = true;
            this.Visible = false;
        }

        private void aboutF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboute = new About();
            aboute.ShowDialog(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboute = new About();
            aboute.ShowDialog();
        }

        private void btnProcPlaca_Click(object sender, EventArgs e)
        {
            ProcurarPlaca pp = new ProcurarPlaca();
            pp.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            DialogResult dd = pp.ShowDialog(this);
            if (pp.codigo > 0)
            {
                txtCod.Text = pp.codigo.ToString();
                btnBuscar_Click(null, null);
            }
        }

        private void Saida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}