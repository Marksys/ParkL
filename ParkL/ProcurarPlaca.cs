using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParkL
{
    public partial class ProcurarPlaca : Form
    {
        public ProcurarPlaca()
        {
            InitializeComponent();
        }

        public int codigo = 0;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Trim().Length == 8)
            {
                Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter entradasAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter();
                Banco.ParkLotKainaguaDataSet.EntradasDataTable dtEn = new ParkL.Banco.ParkLotKainaguaDataSet.EntradasDataTable();

                entradasAdapter.Fill(dtEn);

                DataRow[] row = dtEn.Select("Placa = '" + txtPlaca.Text + "'","cod Desc");

                if (row.Length > 0)
                {
                    codigo = (int)row[0]["cod"];
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    lblStatus.Text = "Não foi encontrado nenhuma entrada com esta placa.";
                }   
            }
            else
                lblStatus.Text = "Digite uma placa.";
        }
    }
}