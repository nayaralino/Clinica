namespace Sistema
{
    partial class form_CadMedico
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
            System.Windows.Forms.Label med_idLabel1;
            System.Windows.Forms.Label med_nomeLabel1;
            System.Windows.Forms.Label med_crmvLabel1;
            System.Windows.Forms.Label med_bairroLabel;
            System.Windows.Forms.Label med_cidadeLabel;
            System.Windows.Forms.Label med_estadoLabel;
            System.Windows.Forms.Label med_especialidadeLabel1;
            System.Windows.Forms.Label med_logradouroLabel;
            System.Windows.Forms.Label med_numeroLabel;
            System.Windows.Forms.Label med_complementoLabel;
            System.Windows.Forms.Label label1;
            this.pnDados = new System.Windows.Forms.Panel();
            this.med_idTextBox = new System.Windows.Forms.TextBox();
            this.tbMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.med_nomeTextBox = new System.Windows.Forms.TextBox();
            this.med_crmvTextBox = new System.Windows.Forms.TextBox();
            this.med_bairroTextBox = new System.Windows.Forms.TextBox();
            this.med_cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.med_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.med_especialidadeComboBox = new System.Windows.Forms.ComboBox();
            this.med_logradouroTextBox = new System.Windows.Forms.TextBox();
            this.med_numeroTextBox = new System.Windows.Forms.TextBox();
            this.med_complementoTextBox = new System.Windows.Forms.TextBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.tbAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.tbEspecieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet1 = new Sistema.dbSistemaDataSet();
            this.tableAdapterManager1 = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
     //       this.tbEspecieTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbEspecieTableAdapter();
     //       this.tbAnimalTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbAnimalTableAdapter();
     //       this.tbMedicoTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbMedicoTableAdapter();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            med_idLabel1 = new System.Windows.Forms.Label();
            med_nomeLabel1 = new System.Windows.Forms.Label();
            med_crmvLabel1 = new System.Windows.Forms.Label();
            med_bairroLabel = new System.Windows.Forms.Label();
            med_cidadeLabel = new System.Windows.Forms.Label();
            med_estadoLabel = new System.Windows.Forms.Label();
            med_especialidadeLabel1 = new System.Windows.Forms.Label();
            med_logradouroLabel = new System.Windows.Forms.Label();
            med_numeroLabel = new System.Windows.Forms.Label();
            med_complementoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet1)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // med_idLabel1
            // 
            med_idLabel1.AutoSize = true;
            med_idLabel1.ForeColor = System.Drawing.Color.DimGray;
            med_idLabel1.Location = new System.Drawing.Point(3, 12);
            med_idLabel1.Name = "med_idLabel1";
            med_idLabel1.Size = new System.Drawing.Size(40, 18);
            med_idLabel1.TabIndex = 0;
            med_idLabel1.Text = "Cód.:";
            // 
            // med_nomeLabel1
            // 
            med_nomeLabel1.AutoSize = true;
            med_nomeLabel1.ForeColor = System.Drawing.Color.DimGray;
            med_nomeLabel1.Location = new System.Drawing.Point(3, 62);
            med_nomeLabel1.Name = "med_nomeLabel1";
            med_nomeLabel1.Size = new System.Drawing.Size(118, 18);
            med_nomeLabel1.TabIndex = 2;
            med_nomeLabel1.Text = "Nome do Médico:";
            // 
            // med_crmvLabel1
            // 
            med_crmvLabel1.AutoSize = true;
            med_crmvLabel1.ForeColor = System.Drawing.Color.DimGray;
            med_crmvLabel1.Location = new System.Drawing.Point(263, 62);
            med_crmvLabel1.Name = "med_crmvLabel1";
            med_crmvLabel1.Size = new System.Drawing.Size(48, 18);
            med_crmvLabel1.TabIndex = 4;
            med_crmvLabel1.Text = "CRMV:";
            // 
            // med_bairroLabel
            // 
            med_bairroLabel.AutoSize = true;
            med_bairroLabel.ForeColor = System.Drawing.Color.DimGray;
            med_bairroLabel.Location = new System.Drawing.Point(6, 164);
            med_bairroLabel.Name = "med_bairroLabel";
            med_bairroLabel.Size = new System.Drawing.Size(49, 18);
            med_bairroLabel.TabIndex = 6;
            med_bairroLabel.Text = "Bairro:";
            // 
            // med_cidadeLabel
            // 
            med_cidadeLabel.AutoSize = true;
            med_cidadeLabel.ForeColor = System.Drawing.Color.DimGray;
            med_cidadeLabel.Location = new System.Drawing.Point(263, 164);
            med_cidadeLabel.Name = "med_cidadeLabel";
            med_cidadeLabel.Size = new System.Drawing.Size(55, 18);
            med_cidadeLabel.TabIndex = 8;
            med_cidadeLabel.Text = "Cidade:";
            // 
            // med_estadoLabel
            // 
            med_estadoLabel.AutoSize = true;
            med_estadoLabel.ForeColor = System.Drawing.Color.DimGray;
            med_estadoLabel.Location = new System.Drawing.Point(387, 164);
            med_estadoLabel.Name = "med_estadoLabel";
            med_estadoLabel.Size = new System.Drawing.Size(53, 18);
            med_estadoLabel.TabIndex = 10;
            med_estadoLabel.Text = "Estado:";
            // 
            // med_especialidadeLabel1
            // 
            med_especialidadeLabel1.AutoSize = true;
            med_especialidadeLabel1.ForeColor = System.Drawing.Color.DimGray;
            med_especialidadeLabel1.Location = new System.Drawing.Point(389, 62);
            med_especialidadeLabel1.Name = "med_especialidadeLabel1";
            med_especialidadeLabel1.Size = new System.Drawing.Size(97, 18);
            med_especialidadeLabel1.TabIndex = 12;
            med_especialidadeLabel1.Text = "Especialidade:";
            // 
            // med_logradouroLabel
            // 
            med_logradouroLabel.AutoSize = true;
            med_logradouroLabel.ForeColor = System.Drawing.Color.DimGray;
            med_logradouroLabel.Location = new System.Drawing.Point(6, 114);
            med_logradouroLabel.Name = "med_logradouroLabel";
            med_logradouroLabel.Size = new System.Drawing.Size(82, 18);
            med_logradouroLabel.TabIndex = 14;
            med_logradouroLabel.Text = "Logradouro:";
            // 
            // med_numeroLabel
            // 
            med_numeroLabel.AutoSize = true;
            med_numeroLabel.ForeColor = System.Drawing.Color.DimGray;
            med_numeroLabel.Location = new System.Drawing.Point(260, 114);
            med_numeroLabel.Name = "med_numeroLabel";
            med_numeroLabel.Size = new System.Drawing.Size(32, 18);
            med_numeroLabel.TabIndex = 16;
            med_numeroLabel.Text = "N.º:";
            // 
            // med_complementoLabel
            // 
            med_complementoLabel.AutoSize = true;
            med_complementoLabel.ForeColor = System.Drawing.Color.DimGray;
            med_complementoLabel.Location = new System.Drawing.Point(387, 114);
            med_complementoLabel.Name = "med_complementoLabel";
            med_complementoLabel.Size = new System.Drawing.Size(101, 18);
            med_complementoLabel.TabIndex = 18;
            med_complementoLabel.Text = "Complemento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Maroon;
            label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(193, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 31);
            label1.TabIndex = 78;
            label1.Text = "Cadastrar Médico ";
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDados.Controls.Add(med_idLabel1);
            this.pnDados.Controls.Add(this.med_idTextBox);
            this.pnDados.Controls.Add(med_nomeLabel1);
            this.pnDados.Controls.Add(this.med_nomeTextBox);
            this.pnDados.Controls.Add(med_crmvLabel1);
            this.pnDados.Controls.Add(this.med_crmvTextBox);
            this.pnDados.Controls.Add(med_bairroLabel);
            this.pnDados.Controls.Add(this.med_bairroTextBox);
            this.pnDados.Controls.Add(med_cidadeLabel);
            this.pnDados.Controls.Add(this.med_cidadeComboBox);
            this.pnDados.Controls.Add(med_estadoLabel);
            this.pnDados.Controls.Add(this.med_estadoComboBox);
            this.pnDados.Controls.Add(med_especialidadeLabel1);
            this.pnDados.Controls.Add(this.med_especialidadeComboBox);
            this.pnDados.Controls.Add(med_logradouroLabel);
            this.pnDados.Controls.Add(this.med_logradouroTextBox);
            this.pnDados.Controls.Add(med_numeroLabel);
            this.pnDados.Controls.Add(this.med_numeroTextBox);
            this.pnDados.Controls.Add(med_complementoLabel);
            this.pnDados.Controls.Add(this.med_complementoTextBox);
            this.pnDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pnDados.Location = new System.Drawing.Point(12, 53);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(676, 354);
            this.pnDados.TabIndex = 61;
            // 
            // med_idTextBox
            // 
            this.med_idTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_id", true));
            this.med_idTextBox.Enabled = false;
            this.med_idTextBox.Location = new System.Drawing.Point(6, 33);
            this.med_idTextBox.Name = "med_idTextBox";
            this.med_idTextBox.Size = new System.Drawing.Size(121, 26);
            this.med_idTextBox.TabIndex = 1;
            // 
            // tbMedicoBindingSource
            // 
            this.tbMedicoBindingSource.DataMember = "tbMedico";
            this.tbMedicoBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // med_nomeTextBox
            // 
            this.med_nomeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_nome", true));
            this.med_nomeTextBox.Location = new System.Drawing.Point(6, 83);
            this.med_nomeTextBox.Name = "med_nomeTextBox";
            this.med_nomeTextBox.Size = new System.Drawing.Size(251, 26);
            this.med_nomeTextBox.TabIndex = 3;
            // 
            // med_crmvTextBox
            // 
            this.med_crmvTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_crmvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_crmv", true));
            this.med_crmvTextBox.Location = new System.Drawing.Point(263, 83);
            this.med_crmvTextBox.Name = "med_crmvTextBox";
            this.med_crmvTextBox.Size = new System.Drawing.Size(121, 26);
            this.med_crmvTextBox.TabIndex = 5;
            // 
            // med_bairroTextBox
            // 
            this.med_bairroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_bairro", true));
            this.med_bairroTextBox.Location = new System.Drawing.Point(6, 185);
            this.med_bairroTextBox.Name = "med_bairroTextBox";
            this.med_bairroTextBox.Size = new System.Drawing.Size(251, 26);
            this.med_bairroTextBox.TabIndex = 7;
            // 
            // med_cidadeComboBox
            // 
            this.med_cidadeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_cidade", true));
            this.med_cidadeComboBox.FormattingEnabled = true;
            this.med_cidadeComboBox.Location = new System.Drawing.Point(263, 185);
            this.med_cidadeComboBox.Name = "med_cidadeComboBox";
            this.med_cidadeComboBox.Size = new System.Drawing.Size(121, 26);
            this.med_cidadeComboBox.TabIndex = 9;
            // 
            // med_estadoComboBox
            // 
            this.med_estadoComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_estado", true));
            this.med_estadoComboBox.FormattingEnabled = true;
            this.med_estadoComboBox.Location = new System.Drawing.Point(390, 185);
            this.med_estadoComboBox.Name = "med_estadoComboBox";
            this.med_estadoComboBox.Size = new System.Drawing.Size(121, 26);
            this.med_estadoComboBox.TabIndex = 11;
            // 
            // med_especialidadeComboBox
            // 
            this.med_especialidadeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_especialidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_especialidade", true));
            this.med_especialidadeComboBox.FormattingEnabled = true;
            this.med_especialidadeComboBox.Location = new System.Drawing.Point(390, 83);
            this.med_especialidadeComboBox.Name = "med_especialidadeComboBox";
            this.med_especialidadeComboBox.Size = new System.Drawing.Size(251, 26);
            this.med_especialidadeComboBox.TabIndex = 13;
            // 
            // med_logradouroTextBox
            // 
            this.med_logradouroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_logradouro", true));
            this.med_logradouroTextBox.Location = new System.Drawing.Point(6, 135);
            this.med_logradouroTextBox.Name = "med_logradouroTextBox";
            this.med_logradouroTextBox.Size = new System.Drawing.Size(251, 26);
            this.med_logradouroTextBox.TabIndex = 15;
            // 
            // med_numeroTextBox
            // 
            this.med_numeroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_numero", true));
            this.med_numeroTextBox.Location = new System.Drawing.Point(263, 135);
            this.med_numeroTextBox.Name = "med_numeroTextBox";
            this.med_numeroTextBox.Size = new System.Drawing.Size(121, 26);
            this.med_numeroTextBox.TabIndex = 17;
            // 
            // med_complementoTextBox
            // 
            this.med_complementoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.med_complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMedicoBindingSource, "med_complemento", true));
            this.med_complementoTextBox.Location = new System.Drawing.Point(390, 135);
            this.med_complementoTextBox.Name = "med_complementoTextBox";
            this.med_complementoTextBox.Size = new System.Drawing.Size(251, 26);
            this.med_complementoTextBox.TabIndex = 19;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.Location = new System.Drawing.Point(618, 19);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 63;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.PicMinimizar_Click);
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.Location = new System.Drawing.Point(651, 9);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 64;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.PicFechar_Click);
            // 
            // tbAnimalBindingSource
            // 
            this.tbAnimalBindingSource.DataMember = "tbAnimal";
            this.tbAnimalBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
   /*         this.tableAdapterManager.tbAnimalTableAdapter = null;
            this.tableAdapterManager.tbAnoTableAdapter = null;
            this.tableAdapterManager.tbAplicaçaoTableAdapter = null;
            this.tableAdapterManager.tbAtendimentoTableAdapter = null;
            this.tableAdapterManager.tbCargoTableAdapter = null;
            this.tableAdapterManager.tbCidadeTableAdapter = null;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbDiaTableAdapter = null;
            this.tableAdapterManager.tbEspecialidadeTableAdapter = null;
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
            // tbEspecieBindingSource
            // 
            this.tbEspecieBindingSource.DataMember = "tbEspecie";
            this.tbEspecieBindingSource.DataSource = this.dbSistemaDataSet1;
            // 
            // dbSistemaDataSet1
            // 
            this.dbSistemaDataSet1.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
     /*       this.tableAdapterManager1.tbAnimalTableAdapter = null;
            this.tableAdapterManager1.tbAnoTableAdapter = null;
            this.tableAdapterManager1.tbAplicaçaoTableAdapter = null;
            this.tableAdapterManager1.tbAtendimentoTableAdapter = null;
            this.tableAdapterManager1.tbCargoTableAdapter = null;
            this.tableAdapterManager1.tbCidadeTableAdapter = null;
            this.tableAdapterManager1.tbClienteTableAdapter = null;
            this.tableAdapterManager1.tbDiaTableAdapter = null;
            this.tableAdapterManager1.tbEspecialidadeTableAdapter = null;
            this.tableAdapterManager1.tbEspecieTableAdapter = this.tbEspecieTableAdapter;
            this.tableAdapterManager1.tbEstadoTableAdapter = null;
            this.tableAdapterManager1.tbExameATTableAdapter = null;
            this.tableAdapterManager1.tbIdadeTableAdapter = null;
            this.tableAdapterManager1.tbMedicoTableAdapter = null;
            this.tableAdapterManager1.tbMesTableAdapter = null;
            this.tableAdapterManager1.tbPesoTableAdapter = null;
            this.tableAdapterManager1.tbPrescriçaoTableAdapter = null;
            this.tableAdapterManager1.tbProtocoloATTableAdapter = null;
            this.tableAdapterManager1.tbRaçaTableAdapter = null;
            this.tableAdapterManager1.tbSexoTableAdapter = null;
            this.tableAdapterManager1.tbSuspeitaTableAdapter = null;
            this.tableAdapterManager1.tbTipoAtendimentoTableAdapter = null;
            this.tableAdapterManager1.tbTPExameTableAdapter = null;
            this.tableAdapterManager1.tbTPProtocoloTableAdapter = null;
            this.tableAdapterManager1.tbUsuarioTableAdapter = null;

    */
            this.tableAdapterManager1.UpdateOrder = Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbEspecieTableAdapter
            // 
   //         this.tbEspecieTableAdapter.ClearBeforeFill = true;
            // 
            // tbAnimalTableAdapter
            // 
   //         this.tbAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // tbMedicoTableAdapter
            // 
    //        this.tbMedicoTableAdapter.ClearBeforeFill = true;
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
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
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
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
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
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
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
            this.pnBotoes.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 108;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(65, 34);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 104;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 105;
            this.label3.Text = "Nanovet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_CadMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadMedico";
            this.Load += new System.EventHandler(this.Form_CadMedico_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet1)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource;
        private dbSistemaDataSet dbSistemaDataSet1;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    //    private dbSistemaDataSetTableAdapters.tbEspecieTableAdapter tbEspecieTableAdapter;
    //    private dbSistemaDataSetTableAdapters.tbAnimalTableAdapter tbAnimalTableAdapter;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.BindingSource tbMedicoBindingSource;
   //     private dbSistemaDataSetTableAdapters.tbMedicoTableAdapter tbMedicoTableAdapter;
        private System.Windows.Forms.TextBox med_idTextBox;
        private System.Windows.Forms.TextBox med_nomeTextBox;
        private System.Windows.Forms.TextBox med_crmvTextBox;
        private System.Windows.Forms.TextBox med_bairroTextBox;
        private System.Windows.Forms.ComboBox med_cidadeComboBox;
        private System.Windows.Forms.ComboBox med_estadoComboBox;
        private System.Windows.Forms.ComboBox med_especialidadeComboBox;
        private System.Windows.Forms.TextBox med_logradouroTextBox;
        private System.Windows.Forms.TextBox med_numeroTextBox;
        private System.Windows.Forms.TextBox med_complementoTextBox;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
    }
}