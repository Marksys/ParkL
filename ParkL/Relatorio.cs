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
    public partial class Relatorio : Form
    {
        private StringReader leitor;

        public Relatorio()
        {
            InitializeComponent();
            preencheDataGrid();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            this.Hide();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner.Owner.Show();
            Owner.Owner.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            this.Hide();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkLotKainaguaDataSet.Entradas' table. You can move, or remove it, as needed.
            this.entradasTableAdapter.Fill(this.parkLotKainaguaDataSet.Entradas);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            preencheDataGrid();
        }

        public void preencheDataGrid()
        {
            ParkL.Banco.ParkLotKainaguaDataSet.EntradasDataTable dt = new ParkL.Banco.ParkLotKainaguaDataSet.EntradasDataTable();
            entradasTableAdapter.Fill(dt);

            DateTime dtEntrada = dateTimePicker1.Value;

            String sql = "Convert(Entrada, 'System.String') like '" + dtEntrada.ToShortDateString() + "%'";

            foreach (DataRow row in dt.Rows)
            {
                if (row["Placa"] == DBNull.Value)
                    row["Placa"] = "";
                if (row["Modelo"] == DBNull.Value)
                    row["Modelo"] = "";
                if (row["Cor"] == DBNull.Value)
                    row["Cor"] = "";
                if (row["Entrada"] == DBNull.Value)
                    row["Entrada"] = DateTime.MinValue;
                if (row["Saida"] == DBNull.Value)
                    row["Saida"] = DateTime.MinValue;
                if (row["Valor"] == DBNull.Value)
                    row["Valor"] = "";                    
            }

            DataRow[] drs = dt.Select(sql);            

            dataGridView1.DataSource = drs;
            dataGridView1.Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboute = new About();
            aboute.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                DataRow[] dr = null;
                if (dataGridView1.DataSource != null)
                    dr = (DataRow[])dataGridView1.DataSource;

                sb.Append("###### RELATÓRIO DIÁRIO ######\n");

                DateTime dtEntrada = DateTime.MinValue;
                DateTime dtSaida = DateTime.MinValue;
                string Valor = "R$00.00";

                double valorTotal = 0.00;

                foreach (DataRow row in dr)
                {
                    dtEntrada = DateTime.MinValue;
                    dtSaida = DateTime.MinValue;
                    Valor = "R$00.00";
                    if (row["Valor"] != null)
                        if (row["Valor"].ToString() != "")
                        {
                            Valor = row["Valor"].ToString();
                            valorTotal += Convert.ToDouble(Valor.Replace("R$", "").Replace(".", ","));
                        }
                    sb.Append("\n  ----------------------------");
                    sb.Append("\n Placa: " + row["Placa"].ToString());
                    sb.Append(" Valor: " + Valor);
                    if (row["Entrada"] != null)
                        if (((DateTime)row["Entrada"]) != DateTime.MinValue)
                            sb.Append("\n Entrada: " + ((DateTime)row["Entrada"]).ToShortTimeString());
                        else
                            sb.Append("\n Entrada: - ");
                    if (row["Saida"] != null)
                        if (((DateTime)(row["Saida"]) != DateTime.MinValue))
                            sb.Append(" Saída: " + ((DateTime)(row["Saida"])).ToShortTimeString());
                        else
                            sb.Append(" Saída: - ");
                }

                sb.Append("\n----------------------");
                sb.Append("\n\n TOTAL: R$ " + valorTotal.ToString("N2"));

                Imprimir(sb.ToString());
            }
            catch
            {
                lblStatus.Text = "Não foi possível imprimir o relatório.";
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
            linhasPorPagina = 100;
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

        private void Relatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}