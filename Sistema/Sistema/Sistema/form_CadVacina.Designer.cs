namespace Sistema
{
    partial class form_CadVacina
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
            System.Windows.Forms.Label vac_idLabel;
            System.Windows.Forms.Label vac_vacinaLabel;
            System.Windows.Forms.Label label2;
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.vac_idTextBox = new System.Windows.Forms.TextBox();
            this.tbVacinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.vac_vacinaTextBox = new System.Windows.Forms.TextBox();
            this.tbEspecialidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
     //       this.tbEspecialidadeTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbEspecialidadeTableAdapter();
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            vac_idLabel = new System.Windows.Forms.Label();
            vac_vacinaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVacinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecialidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vac_idLabel
            // 
            vac_idLabel.AutoSize = true;
            vac_idLabel.ForeColor = System.Drawing.Color.DimGray;
            vac_idLabel.Location = new System.Drawing.Point(3, 11);
            vac_idLabel.Name = "vac_idLabel";
            vac_idLabel.Size = new System.Drawing.Size(40, 18);
            vac_idLabel.TabIndex = 0;
            vac_idLabel.Text = "Cód.:";
            // 
            // vac_vacinaLabel
            // 
            vac_vacinaLabel.AutoSize = true;
            vac_vacinaLabel.ForeColor = System.Drawing.Color.DimGray;
            vac_vacinaLabel.Location = new System.Drawing.Point(3, 61);
            vac_vacinaLabel.Name = "vac_vacinaLabel";
            vac_vacinaLabel.Size = new System.Drawing.Size(52, 18);
            vac_vacinaLabel.TabIndex = 2;
            vac_vacinaLabel.Text = "Vacina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Maroon;
            label2.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label2.ForeColor = System.Drawing.Color.White;
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(208, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(216, 31);
            label2.TabIndex = 78;
            label2.Text = "Cadastrar Vacina ";
            // 
            // pnBotoes
            // 
            this.pnBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnBotoes.Controls.Add(this.btnPesquisar);
            this.pnBotoes.Controls.Add(this.btnCancelar);
            this.pnBotoes.Controls.Add(this.btnExcluir);
            this.pnBotoes.Controls.Add(this.btnAlterar);
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnNovo);
            this.pnBotoes.Location = new System.Drawing.Point(12, 413);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(676, 75);
            this.pnBotoes.TabIndex = 99;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(74, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(62, 40);
            this.btnPesquisar.TabIndex = 54;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Image = global::Sistema.Properties.Resources.cancelar_20px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(346, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 40);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.ForeColor = System.Drawing.Color.DimGray;
            this.btnExcluir.Image = global::Sistema.Properties.Resources.excluir_20px;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(278, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 40);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = global::Sistema.Properties.Resources.Editar_20px;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(210, 18);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(62, 40);
            this.btnAlterar.TabIndex = 47;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalvar.Image = global::Sistema.Properties.Resources.Savar_20px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(142, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 40);
            this.btnSalvar.TabIndex = 46;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.ForeColor = System.Drawing.Color.DimGray;
            this.btnNovo.Image = global::Sistema.Properties.Resources.novo_20px;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(6, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(62, 40);
            this.btnNovo.TabIndex = 45;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDados.Controls.Add(vac_idLabel);
            this.pnDados.Controls.Add(this.vac_idTextBox);
            this.pnDados.Controls.Add(vac_vacinaLabel);
            this.pnDados.Controls.Add(this.vac_vacinaTextBox);
            this.pnDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pnDados.Location = new System.Drawing.Point(12, 56);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(676, 351);
            this.pnDados.TabIndex = 98;
            // 
            // vac_idTextBox
            // 
            this.vac_idTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vac_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbVacinaBindingSource, "vac_id", true));
            this.vac_idTextBox.Enabled = false;
            this.vac_idTextBox.Location = new System.Drawing.Point(6, 32);
            this.vac_idTextBox.Name = "vac_idTextBox";
            this.vac_idTextBox.Size = new System.Drawing.Size(100, 26);
            this.vac_idTextBox.TabIndex = 1;
            // 
            // tbVacinaBindingSource
            // 
            this.tbVacinaBindingSource.DataMember = "tbVacina";
            this.tbVacinaBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vac_vacinaTextBox
            // 
            this.vac_vacinaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vac_vacinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbVacinaBindingSource, "vac_vacina", true));
            this.vac_vacinaTextBox.Location = new System.Drawing.Point(6, 82);
            this.vac_vacinaTextBox.Name = "vac_vacinaTextBox";
            this.vac_vacinaTextBox.Size = new System.Drawing.Size(188, 26);
            this.vac_vacinaTextBox.TabIndex = 3;
            // 
            // tbEspecialidadeBindingSource
            // 
            this.tbEspecialidadeBindingSource.DataMember = "tbEspecialidade";
            this.tbEspecialidadeBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // tbEspecialidadeTableAdapter
            // 
      //      this.tbEspecialidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
   /*         this.tableAdapterManager.tbAnimalTableAdapter = null;
            this.tableAdapterManager.tbAnoTableAdapter = null;
            this.tableAdapterManager.tbAplicaçaoTableAdapter = null;
            this.tableAdapterManager.tbAtendimentoTableAdapter = null;
            this.tableAdapterManager.tbCargoTableAdapter = null;
            this.tableAdapterManager.tbCidadeTableAdapter = null;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbDiaTableAdapter = null;
            this.tableAdapterManager.tbEspecialidadeTableAdapter = this.tbEspecialidadeTableAdapter;
            this.tableAdapterManager.tbEspecieTableAdapter = null;
            this.tableAdapterManager.tbEstadoTableAdapter = null;
            this.tableAdapterManager.tbExameATTableAdapter = null;
            this.tableAdapterManager.tbIdadeTableAdapter = null;
            this.tableAdapterManager.tbMedicoTableAdapter = null;
            this.tableAdapterManager.tbMesTableAdapter = null;
            this.tableAdapterManager.tbPesoTableAdapter = null;
            this.tableAdapterManager.tbPrescriçaoTableAdapter = null;
            this.tableAdapterManager.tbProtocoloATTableAdapter = null;
            this.tableAdapterManager.tbRaçaTableAdapter = null;
            this.tableAdapterManager.tbSexoTableAdapter = null;
            this.tableAdapterManager.tbSuspeitaTableAdapter = null;
            this.tableAdapterManager.tbTipoAtendimentoTableAdapter = null;
            this.tableAdapterManager.tbTPExameTableAdapter = null;
            this.tableAdapterManager.tbTPProtocoloTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null; */
            this.tableAdapterManager.UpdateOrder = Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.Location = new System.Drawing.Point(651, 9);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 94;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.Location = new System.Drawing.Point(618, 19);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 93;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Controls.Add(label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 108;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 103;
            this.label4.Text = "Nanovet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_CadVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadVacina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadVacina";
            this.Load += new System.EventHandler(this.form_CadVacina_Load);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVacinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecialidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.BindingSource tbEspecialidadeBindingSource;
        private dbSistemaDataSet dbSistemaDataSet;
  //      private dbSistemaDataSetTableAdapters.tbEspecialidadeTableAdapter tbEspecialidadeTableAdapter;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbVacinaBindingSource;
  //      private dbSistemaDataSetTableAdapters./tbVacinaTableAdapter tbVacinaTableAdapter;
        private System.Windows.Forms.TextBox vac_idTextBox;
        private System.Windows.Forms.TextBox vac_vacinaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}