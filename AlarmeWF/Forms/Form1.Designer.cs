namespace AlarmeWF
{
    partial class FrmAlarme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mktHoras = new System.Windows.Forms.MaskedTextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRemedio = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbnHoras = new System.Windows.Forms.Label();
            this.tmVerificaHoras = new System.Windows.Forms.Timer(this.components);
            this.tmRelogio = new System.Windows.Forms.Timer(this.components);
            this.lbnData = new System.Windows.Forms.Label();
            this.panelID = new System.Windows.Forms.Panel();
            this.panelNome = new System.Windows.Forms.Panel();
            this.panelHorario = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mktHoras
            // 
            this.mktHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mktHoras.Location = new System.Drawing.Point(274, 39);
            this.mktHoras.Mask = "00:00";
            this.mktHoras.Name = "mktHoras";
            this.mktHoras.Size = new System.Drawing.Size(57, 22);
            this.mktHoras.TabIndex = 21;
            this.mktHoras.Text = "0000";
            this.mktHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktHoras.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMais.Location = new System.Drawing.Point(337, 38);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(28, 24);
            this.btnMais.TabIndex = 16;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(421, 162);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(384, 38);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(77, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Horas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Remedio:";
            // 
            // txbRemedio
            // 
            this.txbRemedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbRemedio.Location = new System.Drawing.Point(39, 39);
            this.txbRemedio.Name = "txbRemedio";
            this.txbRemedio.Size = new System.Drawing.Size(180, 22);
            this.txbRemedio.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.Location = new System.Drawing.Point(505, 83);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // lbnHoras
            // 
            this.lbnHoras.AutoSize = true;
            this.lbnHoras.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnHoras.Location = new System.Drawing.Point(524, 20);
            this.lbnHoras.Name = "lbnHoras";
            this.lbnHoras.Size = new System.Drawing.Size(183, 54);
            this.lbnHoras.TabIndex = 9;
            this.lbnHoras.Text = "12:45:21";
            // 
            // tmVerificaHoras
            // 
            this.tmVerificaHoras.Enabled = true;
            this.tmVerificaHoras.Interval = 60000;
            this.tmVerificaHoras.Tick += new System.EventHandler(this.tmVerificaHoras_Tick);
            // 
            // tmRelogio
            // 
            this.tmRelogio.Enabled = true;
            this.tmRelogio.Tick += new System.EventHandler(this.tmRelogio_Tick);
            // 
            // lbnData
            // 
            this.lbnData.AutoSize = true;
            this.lbnData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnData.Location = new System.Drawing.Point(505, 254);
            this.lbnData.Name = "lbnData";
            this.lbnData.Size = new System.Drawing.Size(76, 17);
            this.lbnData.TabIndex = 9;
            this.lbnData.Text = "13/12/2021";
            // 
            // panelID
            // 
            this.panelID.Location = new System.Drawing.Point(39, 235);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(52, 56);
            this.panelID.TabIndex = 22;
            // 
            // panelNome
            // 
            this.panelNome.Location = new System.Drawing.Point(100, 235);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(158, 56);
            this.panelNome.TabIndex = 22;
            // 
            // panelHorario
            // 
            this.panelHorario.Location = new System.Drawing.Point(271, 235);
            this.panelHorario.Name = "panelHorario";
            this.panelHorario.Size = new System.Drawing.Size(158, 56);
            this.panelHorario.TabIndex = 22;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(404, 240);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 25);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(320, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 23);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(404, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(57, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(180, 297);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(123, 23);
            this.btnAtualizar.TabIndex = 26;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(40, 297);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmAlarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panelHorario);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.panelID);
            this.Controls.Add(this.mktHoras);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRemedio);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbnData);
            this.Controls.Add(this.lbnHoras);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlarme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarme";
            this.Load += new System.EventHandler(this.FrmAlarme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mktHoras;
        private Button btnMais;
        private DataGridView dataGridView1;
        private Button btnCadastrar;
        private Label label2;
        private Label label1;
        private TextBox txbRemedio;
        private MonthCalendar monthCalendar1;
        private Label lbnHoras;
        private System.Windows.Forms.Timer tmVerificaHoras;
        private System.Windows.Forms.Timer tmRelogio;
        private Label lbnData;
        private Panel panelID;
        private Panel panelNome;
        private Panel panelHorario;
        private Button btnEditar;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnAtualizar;
        private Button btnExcluir;
    }
}