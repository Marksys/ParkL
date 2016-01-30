namespace ParkL
{
    partial class Saida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saida));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnProcPlaca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placa:";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(231, 383);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(88, 44);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Dar Baixa";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Codigo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(170, 192);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(109, 20);
            this.lblPlaca.TabIndex = 19;
            this.lblPlaca.Text = "__________";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(96, 225);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(99, 20);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "__________";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(287, 225);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(99, 20);
            this.lblCor.TabIndex = 21;
            this.lblCor.Text = "__________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Valor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(173, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 44);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(96, 256);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(99, 20);
            this.lblEntrada.TabIndex = 26;
            this.lblEntrada.Text = "__________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Entrada:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(287, 256);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(99, 20);
            this.lblSaida.TabIndex = 28;
            this.lblSaida.Text = "__________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(233, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Saída:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(122, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Período:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(195, 295);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(15, 20);
            this.lblPeriodo.TabIndex = 30;
            this.lblPeriodo.Text = "*";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(95, 145);
            this.txtCod.Mask = "999999";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(64, 26);
            this.txtCod.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(168, 339);
            this.txtValor.Mask = "$99.99";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 427);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 31;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
            // 
            // btnProcPlaca
            // 
            this.btnProcPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcPlaca.Location = new System.Drawing.Point(267, 136);
            this.btnProcPlaca.Name = "btnProcPlaca";
            this.btnProcPlaca.Size = new System.Drawing.Size(88, 44);
            this.btnProcPlaca.TabIndex = 2;
            this.btnProcPlaca.Text = "Procurar Placa";
            this.btnProcPlaca.UseVisualStyleBackColor = true;
            this.btnProcPlaca.Click += new System.EventHandler(this.btnProcPlaca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkL.Properties.Resources.layout_01;
            this.pictureBox1.Location = new System.Drawing.Point(63, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 86);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Saida
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 456);
            this.Controls.Add(this.btnProcPlaca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Saida";
            this.Text = "KAINÁGUA - Saida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saida_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblStatus;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem relatórioF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnProcPlaca;
    }
}