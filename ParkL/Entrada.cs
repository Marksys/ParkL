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
    public partial class Entrada : Form
    {
        private StringReader leitor;
        Saida saida = new Saida();
        Relatorio relatorio = new Relatorio();

        public Entrada()
        {
            InitializeComponent();            
            saida.Owner = this;
            lblStatus.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Trim().Length == 8)
            {
                try
                {
                    string mensagemStatus = "Entrada realizada com sucesso!";
                    StringBuilder textPrinter = new StringBuilder();
                    textPrinter.Append(" KAINÁGUA EMPREENDIMENTOS \n     ESPORTIVOS S/C LTDA \n\n");
                    textPrinter.Append(" Av. Dr. Guilherme Dumont Villares,455 \n");
                    textPrinter.Append(" CNPJ- 62.284.757/0001-01 \n");

                    textPrinter.Append("\n Modelo: " + cbModelo.Text);
                    textPrinter.Append("\n Cor: " + cbCor.Text);
                    textPrinter.Append("\n Placa: " + txtPlaca.Text);
                    textPrinter.Append("\n Entrada: " + DateTime.Now.ToShortDateString());
                    textPrinter.Append(" Horário: " + DateTime.Now.ToLocalTime().Hour + ":" + DateTime.Now.ToLocalTime().Minute);
                    textPrinter.Append("\n\n Não nos responsabilizamos por objetos");
                    textPrinter.Append("\n deixados no interior do veículo.");

                    Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter entradasAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter();
                    Banco.ParkLotKainaguaDataSet.EntradasDataTable dtEn = new ParkL.Banco.ParkLotKainaguaDataSet.EntradasDataTable();

                    entradasAdapter.Fill(dtEn);

                    int ok = entradasAdapter.Insert(txtPlaca.Text, cbModelo.Text, cbCor.Text, DateTime.Now, null, null);
                    dtEn.AcceptChanges();

                    entradasAdapter.Fill(dtEn);

                    DataRow[] dr = dtEn.Select("", "cod desc");

                    textPrinter.Append("\n\n Código: " + dr[0]["cod"]);

                    try
                    {

                        Imprimir(textPrinter.ToString());
                    }
                    catch
                    {
                        mensagemStatus = "Entrada realizada com sucesso! Mas não foi possível imprimir.";
                    }

                    txtPlaca.Text = "";
                    cbCor.Text = "";
                    cbModelo.Text = "";

                    lblStatus.Text = mensagemStatus;
                }
                catch
                {
                    lblStatus.Text = "Erro! Não foi possível realizar entrada.";
                }
            }
            else
            {
                lblStatus.Text = "Digite a Placa.";
                txtPlaca.Focus();
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
            linhasPorPagina = 20;
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

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saida.Visible = false;
            saida.Show(this);
            saida.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            saida.Visible = true;
            this.Hide();
        }

        private void relatórioF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio.Visible = false;
            relatorio.Show(saida);
            relatorio.preencheDataGrid();
            relatorio.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            relatorio.Visible = true;
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboute = new About();
            aboute.ShowDialog();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkLotKainaguaDataSet.Cor' table. You can move, or remove it, as needed.
            this.corTableAdapter.Fill(this.parkLotKainaguaDataSet.Cor);
            // TODO: This line of code loads data into the 'parkLotKainaguaDataSet.Modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.parkLotKainaguaDataSet.Modelo);

        }

        private void Entrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}