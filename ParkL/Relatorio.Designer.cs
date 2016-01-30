namespace ParkL
{
    partial class Relatorio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkLotKainaguaDataSet = new ParkL.Banco.ParkLotKainaguaDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.entradasTableAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkLotKainaguaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem,
            this.relatórioF4ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.entradaToolStripMenuItem.Text = "Entrada (F2)";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.saídaToolStripMenuItem.Text = "Saída (F3)";
            this.saídaToolStripMenuItem.Click += new System.EventHandler(this.saídaToolStripMenuItem_Click);
            // 
            // relatórioF4ToolStripMenuItem
            // 
            this.relatórioF4ToolStripMenuItem.Name = "relatórioF4ToolStripMenuItem";
            this.relatórioF4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.relatórioF4ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.relatórioF4ToolStripMenuItem.Text = "Relatório (F4)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "F12";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Sobre";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.saidaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entradasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(395, 264);
            this.dataGridView1.TabIndex = 10;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDataGridViewTextBoxColumn.Width = 50;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn.Width = 80;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            this.corDataGridViewTextBoxColumn.Width = 80;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saidaDataGridViewTextBoxColumn
            // 
            this.saidaDataGridViewTextBoxColumn.DataPropertyName = "Saida";
            dataGridViewCellStyle1.NullValue = "__";
            this.saidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.saidaDataGridViewTextBoxColumn.HeaderText = "Saida";
            this.saidaDataGridViewTextBoxColumn.Name = "saidaDataGridViewTextBoxColumn";
            this.saidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradasBindingSource
            // 
            this.entradasBindingSource.DataMember = "Entradas";
            this.entradasBindingSource.DataSource = this.parkLotKainaguaDataSet;
            // 
            // parkLotKainaguaDataSet
            // 
            this.parkLotKainaguaDataSet.DataSetName = "ParkLotKainaguaDataSet";
            this.parkLotKainaguaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 135);
            this.dateTimePicker1.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // entradasTableAdapter
            // 
            this.entradasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Image = global::ParkL.Properties.Resources.Índice;
            this.button1.Location = new System.Drawing.Point(366, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkL.Properties.Resources.layout_01;
            this.pictureBox1.Location = new System.Drawing.Point(63, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 86);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 438);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 34;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 456);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Relatorio";
            this.Text = "KAINÁGUA - Relatório";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkLotKainaguaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioF4ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ParkL.Banco.ParkLotKainaguaDataSet parkLotKainaguaDataSet;
        private System.Windows.Forms.BindingSource entradasBindingSource;
        private ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.EntradasTableAdapter entradasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblStatus;
    }
}