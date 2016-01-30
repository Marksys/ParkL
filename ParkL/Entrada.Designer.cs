namespace ParkL
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkLotKainaguaDataSet = new ParkL.Banco.ParkLotKainaguaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.corBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modeloTableAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.ModeloTableAdapter();
            this.corTableAdapter = new ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.CorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkLotKainaguaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(236, 325);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(88, 44);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa";
            // 
            // cbModelo
            // 
            this.cbModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloBindingSource, "Modelo", true));
            this.cbModelo.DataSource = this.modeloBindingSource;
            this.cbModelo.DisplayMember = "Modelo";
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(174, 197);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(150, 28);
            this.cbModelo.TabIndex = 1;
            this.cbModelo.ValueMember = "Modelo";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "Modelo";
            this.modeloBindingSource.DataSource = this.parkLotKainaguaDataSet;
            // 
            // parkLotKainaguaDataSet
            // 
            this.parkLotKainaguaDataSet.DataSetName = "ParkLotKainaguaDataSet";
            this.parkLotKainaguaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cor";
            // 
            // cbCor
            // 
            this.cbCor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corBindingSource, "Cor", true));
            this.cbCor.DataSource = this.corBindingSource;
            this.cbCor.DisplayMember = "Cor";
            this.cbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(174, 231);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(150, 28);
            this.cbCor.TabIndex = 2;
            this.cbCor.ValueMember = "Cor";
            // 
            // corBindingSource
            // 
            this.corBindingSource.DataMember = "Cor";
            this.corBindingSource.DataSource = this.parkLotKainaguaDataSet;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
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
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.entradaToolStripMenuItem.Text = "Entrada (F2)";
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
            this.relatórioF4ToolStripMenuItem.Click += new System.EventHandler(this.relatórioF4ToolStripMenuItem_Click);
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
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(174, 163);
            this.txtPlaca.Mask = ">LLL-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(150, 26);
            this.txtPlaca.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 427);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkL.Properties.Resources.layout_01;
            this.pictureBox1.Location = new System.Drawing.Point(63, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 86);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // corTableAdapter
            // 
            this.corTableAdapter.ClearBeforeFill = true;
            // 
            // Entrada
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Entrada";
            this.Text = "KAINÁGUA - Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entrada_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkLotKainaguaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem relatórioF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ParkL.Banco.ParkLotKainaguaDataSet parkLotKainaguaDataSet;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.ModeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.BindingSource corBindingSource;
        private ParkL.Banco.ParkLotKainaguaDataSetTableAdapters.CorTableAdapter corTableAdapter;
    }
}

