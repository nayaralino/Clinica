namespace Sistema
{
    partial class form_CadAnimal
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
            System.Windows.Forms.Label ani_idLabel;
            System.Windows.Forms.Label ani_nomeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label ani_clienteLabel;
            System.Windows.Forms.Label ani_sexoLabel;
            System.Windows.Forms.Label ani_espLabel;
            System.Windows.Forms.Label ani_raçaLabel;
            System.Windows.Forms.Label ani_pesoLabel;
            System.Windows.Forms.Label ani_idadeLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label ani_cadastroLabel;
            System.Windows.Forms.Label ani_statusLabel;
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.btnPesquisarClientee = new System.Windows.Forms.Button();
            this.ani_statusComboBox = new System.Windows.Forms.ComboBox();
            this.tbAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.ani_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ani_raçaComboBox = new System.Windows.Forms.ComboBox();
            this.ani_especieComboBox = new System.Windows.Forms.ComboBox();
            this.ani_idadeTextBox = new System.Windows.Forms.TextBox();
            this.ani_pesoTextBox = new System.Windows.Forms.TextBox();
            this.ani_clienteNomeTextBox = new System.Windows.Forms.TextBox();
            this.ani_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.ani_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ani_idTextBox = new System.Windows.Forms.TextBox();
            this.ani_nomeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.tbEspecieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet1 = new Sistema.dbSistemaDataSet();
            this.tableAdapterManager1 = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.tbAnimalTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbAnimalTableAdapter();
            ani_idLabel = new System.Windows.Forms.Label();
            ani_nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ani_clienteLabel = new System.Windows.Forms.Label();
            ani_sexoLabel = new System.Windows.Forms.Label();
            ani_espLabel = new System.Windows.Forms.Label();
            ani_raçaLabel = new System.Windows.Forms.Label();
            ani_pesoLabel = new System.Windows.Forms.Label();
            ani_idadeLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ani_cadastroLabel = new System.Windows.Forms.Label();
            ani_statusLabel = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ani_idLabel
            // 
            ani_idLabel.AutoSize = true;
            ani_idLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_idLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_idLabel.Location = new System.Drawing.Point(3, 7);
            ani_idLabel.Name = "ani_idLabel";
            ani_idLabel.Size = new System.Drawing.Size(90, 17);
            ani_idLabel.TabIndex = 0;
            ani_idLabel.Text = "Cód. Animal:";
            // 
            // ani_nomeLabel
            // 
            ani_nomeLabel.AutoSize = true;
            ani_nomeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_nomeLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_nomeLabel.Location = new System.Drawing.Point(2, 109);
            ani_nomeLabel.Name = "ani_nomeLabel";
            ani_nomeLabel.Size = new System.Drawing.Size(122, 17);
            ani_nomeLabel.TabIndex = 2;
            ani_nomeLabel.Text = "Nome  do Animal:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Maroon;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(205, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(223, 31);
            label1.TabIndex = 78;
            label1.Text = "Cadastrar Animal";
            // 
            // ani_clienteLabel
            // 
            ani_clienteLabel.AutoSize = true;
            ani_clienteLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_clienteLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_clienteLabel.Location = new System.Drawing.Point(139, 8);
            ani_clienteLabel.Name = "ani_clienteLabel";
            ani_clienteLabel.Size = new System.Drawing.Size(112, 17);
            ani_clienteLabel.TabIndex = 14;
            ani_clienteLabel.Text = "Cód. do Cliente:";
            // 
            // ani_sexoLabel
            // 
            ani_sexoLabel.AutoSize = true;
            ani_sexoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_sexoLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_sexoLabel.Location = new System.Drawing.Point(2, 161);
            ani_sexoLabel.Name = "ani_sexoLabel";
            ani_sexoLabel.Size = new System.Drawing.Size(45, 17);
            ani_sexoLabel.TabIndex = 94;
            ani_sexoLabel.Text = "Sexo:";
            // 
            // ani_espLabel
            // 
            ani_espLabel.AutoSize = true;
            ani_espLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_espLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_espLabel.Location = new System.Drawing.Point(139, 161);
            ani_espLabel.Name = "ani_espLabel";
            ani_espLabel.Size = new System.Drawing.Size(65, 17);
            ani_espLabel.TabIndex = 95;
            ani_espLabel.Text = "Espécie:";
            // 
            // ani_raçaLabel
            // 
            ani_raçaLabel.AutoSize = true;
            ani_raçaLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_raçaLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_raçaLabel.Location = new System.Drawing.Point(2, 215);
            ani_raçaLabel.Name = "ani_raçaLabel";
            ani_raçaLabel.Size = new System.Drawing.Size(47, 17);
            ani_raçaLabel.TabIndex = 96;
            ani_raçaLabel.Text = "Raça:";
            // 
            // ani_pesoLabel
            // 
            ani_pesoLabel.AutoSize = true;
            ani_pesoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_pesoLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_pesoLabel.Location = new System.Drawing.Point(2, 268);
            ani_pesoLabel.Name = "ani_pesoLabel";
            ani_pesoLabel.Size = new System.Drawing.Size(46, 17);
            ani_pesoLabel.TabIndex = 97;
            ani_pesoLabel.Text = "Peso:";
            // 
            // ani_idadeLabel
            // 
            ani_idadeLabel.AutoSize = true;
            ani_idadeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_idadeLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_idadeLabel.Location = new System.Drawing.Point(139, 215);
            ani_idadeLabel.Name = "ani_idadeLabel";
            ani_idadeLabel.Size = new System.Drawing.Size(47, 17);
            ani_idadeLabel.TabIndex = 98;
            ani_idadeLabel.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DimGray;
            label3.Location = new System.Drawing.Point(3, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 17);
            label3.TabIndex = 100;
            label3.Text = "Nome do Cliente:";
            // 
            // ani_cadastroLabel
            // 
            ani_cadastroLabel.AutoSize = true;
            ani_cadastroLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            ani_cadastroLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_cadastroLabel.Location = new System.Drawing.Point(139, 268);
            ani_cadastroLabel.Name = "ani_cadastroLabel";
            ani_cadastroLabel.Size = new System.Drawing.Size(127, 17);
            ani_cadastroLabel.TabIndex = 104;
            ani_cadastroLabel.Text = "Data do Cadastro:";
            // 
            // ani_statusLabel
            // 
            ani_statusLabel.AutoSize = true;
            ani_statusLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            ani_statusLabel.ForeColor = System.Drawing.Color.DimGray;
            ani_statusLabel.Location = new System.Drawing.Point(275, 215);
            ani_statusLabel.Name = "ani_statusLabel";
            ani_statusLabel.Size = new System.Drawing.Size(54, 17);
            ani_statusLabel.TabIndex = 105;
            ani_statusLabel.Text = "Status:";
            // 
            // pnBotoes
            // 
            this.pnBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnBotoes.Controls.Add(this.btnCancelar);
            this.pnBotoes.Controls.Add(this.btnExcluir);
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnAlterar);
            this.pnBotoes.Controls.Add(this.btnNovo);
            this.pnBotoes.Controls.Add(this.btnPesquisar);
            this.pnBotoes.ForeColor = System.Drawing.Color.Black;
            this.pnBotoes.Location = new System.Drawing.Point(12, 423);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(676, 65);
            this.pnBotoes.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Image = global::Sistema.Properties.Resources.cancelar_20px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(346, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.ForeColor = System.Drawing.Color.DimGray;
            this.btnExcluir.Image = global::Sistema.Properties.Resources.excluir_20px;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(278, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 40);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalvar.Image = global::Sistema.Properties.Resources.Savar_20px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(142, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 40);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = global::Sistema.Properties.Resources.Editar_20px;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(210, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(62, 40);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.ForeColor = System.Drawing.Color.DimGray;
            this.btnNovo.Image = global::Sistema.Properties.Resources.novo_20px;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(6, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(62, 40);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(74, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(62, 40);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDados.Controls.Add(this.btnPesquisarClientee);
            this.pnDados.Controls.Add(this.ani_statusComboBox);
            this.pnDados.Controls.Add(ani_statusLabel);
            this.pnDados.Controls.Add(ani_cadastroLabel);
            this.pnDados.Controls.Add(this.ani_cadastroDateTimePicker);
            this.pnDados.Controls.Add(this.ani_raçaComboBox);
            this.pnDados.Controls.Add(this.ani_especieComboBox);
            this.pnDados.Controls.Add(this.ani_idadeTextBox);
            this.pnDados.Controls.Add(this.ani_pesoTextBox);
            this.pnDados.Controls.Add(label3);
            this.pnDados.Controls.Add(this.ani_clienteNomeTextBox);
            this.pnDados.Controls.Add(ani_idadeLabel);
            this.pnDados.Controls.Add(ani_pesoLabel);
            this.pnDados.Controls.Add(ani_raçaLabel);
            this.pnDados.Controls.Add(ani_espLabel);
            this.pnDados.Controls.Add(ani_sexoLabel);
            this.pnDados.Controls.Add(this.ani_sexoComboBox);
            this.pnDados.Controls.Add(this.btnPesquisarCliente);
            this.pnDados.Controls.Add(ani_clienteLabel);
            this.pnDados.Controls.Add(this.ani_clienteTextBox);
            this.pnDados.Controls.Add(ani_idLabel);
            this.pnDados.Controls.Add(this.ani_idTextBox);
            this.pnDados.Controls.Add(ani_nomeLabel);
            this.pnDados.Controls.Add(this.ani_nomeTextBox);
            this.pnDados.Controls.Add(this.panel2);
            this.pnDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pnDados.Location = new System.Drawing.Point(12, 56);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(676, 363);
            this.pnDados.TabIndex = 28;
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // btnPesquisarClientee
            // 
            this.btnPesquisarClientee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarClientee.BackColor = System.Drawing.Color.White;
            this.btnPesquisarClientee.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisarClientee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisarClientee.Location = new System.Drawing.Point(278, 78);
            this.btnPesquisarClientee.Name = "btnPesquisarClientee";
            this.btnPesquisarClientee.Size = new System.Drawing.Size(50, 25);
            this.btnPesquisarClientee.TabIndex = 107;
            this.btnPesquisarClientee.UseVisualStyleBackColor = false;
            this.btnPesquisarClientee.Click += new System.EventHandler(this.btnPesquisarClientee_Click);
            // 
            // ani_statusComboBox
            // 
            this.ani_statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_status", true));
            this.ani_statusComboBox.FormattingEnabled = true;
            this.ani_statusComboBox.Location = new System.Drawing.Point(278, 236);
            this.ani_statusComboBox.Name = "ani_statusComboBox";
            this.ani_statusComboBox.Size = new System.Drawing.Size(129, 26);
            this.ani_statusComboBox.TabIndex = 106;
            // 
            // tbAnimalBindingSource
            // 
            this.tbAnimalBindingSource.DataMember = "tbAnimal";
            this.tbAnimalBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ani_cadastroDateTimePicker
            // 
            this.ani_cadastroDateTimePicker.CustomFormat = " dd/MM/yyyy";
            this.ani_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbAnimalBindingSource, "ani_cadastro", true));
            this.ani_cadastroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ani_cadastroDateTimePicker.Location = new System.Drawing.Point(142, 290);
            this.ani_cadastroDateTimePicker.Name = "ani_cadastroDateTimePicker";
            this.ani_cadastroDateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.ani_cadastroDateTimePicker.TabIndex = 105;
            this.ani_cadastroDateTimePicker.Value = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            // 
            // ani_raçaComboBox
            // 
            this.ani_raçaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ANI_RAÇA", true));
            this.ani_raçaComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_raçaComboBox.FormattingEnabled = true;
            this.ani_raçaComboBox.Location = new System.Drawing.Point(5, 236);
            this.ani_raçaComboBox.Name = "ani_raçaComboBox";
            this.ani_raçaComboBox.Size = new System.Drawing.Size(131, 25);
            this.ani_raçaComboBox.TabIndex = 104;
            // 
            // ani_especieComboBox
            // 
            this.ani_especieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ANI_ESPECIE", true));
            this.ani_especieComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_especieComboBox.FormattingEnabled = true;
            this.ani_especieComboBox.Location = new System.Drawing.Point(142, 182);
            this.ani_especieComboBox.Name = "ani_especieComboBox";
            this.ani_especieComboBox.Size = new System.Drawing.Size(130, 25);
            this.ani_especieComboBox.TabIndex = 103;
            // 
            // ani_idadeTextBox
            // 
            this.ani_idadeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_idade", true));
            this.ani_idadeTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_idadeTextBox.Location = new System.Drawing.Point(142, 236);
            this.ani_idadeTextBox.Name = "ani_idadeTextBox";
            this.ani_idadeTextBox.Size = new System.Drawing.Size(130, 25);
            this.ani_idadeTextBox.TabIndex = 102;
            // 
            // ani_pesoTextBox
            // 
            this.ani_pesoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_peso", true));
            this.ani_pesoTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_pesoTextBox.Location = new System.Drawing.Point(6, 290);
            this.ani_pesoTextBox.Name = "ani_pesoTextBox";
            this.ani_pesoTextBox.Size = new System.Drawing.Size(130, 25);
            this.ani_pesoTextBox.TabIndex = 101;
            // 
            // ani_clienteNomeTextBox
            // 
            this.ani_clienteNomeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_clienteNomeTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_clienteNomeTextBox.Location = new System.Drawing.Point(5, 78);
            this.ani_clienteNomeTextBox.Name = "ani_clienteNomeTextBox";
            this.ani_clienteNomeTextBox.Size = new System.Drawing.Size(267, 25);
            this.ani_clienteNomeTextBox.TabIndex = 99;
            // 
            // ani_sexoComboBox
            // 
            this.ani_sexoComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_sexo", true));
            this.ani_sexoComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_sexoComboBox.FormattingEnabled = true;
            this.ani_sexoComboBox.Location = new System.Drawing.Point(5, 182);
            this.ani_sexoComboBox.Name = "ani_sexoComboBox";
            this.ani_sexoComboBox.Size = new System.Drawing.Size(131, 25);
            this.ani_sexoComboBox.TabIndex = 4;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(278, 78);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(0, 25);
            this.btnPesquisarCliente.TabIndex = 2;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            // 
            // ani_clienteTextBox
            // 
            this.ani_clienteTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_cliente", true));
            this.ani_clienteTextBox.Enabled = false;
            this.ani_clienteTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_clienteTextBox.Location = new System.Drawing.Point(142, 28);
            this.ani_clienteTextBox.Name = "ani_clienteTextBox";
            this.ani_clienteTextBox.Size = new System.Drawing.Size(130, 25);
            this.ani_clienteTextBox.TabIndex = 1;
            // 
            // ani_idTextBox
            // 
            this.ani_idTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_id", true));
            this.ani_idTextBox.Enabled = false;
            this.ani_idTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_idTextBox.Location = new System.Drawing.Point(5, 28);
            this.ani_idTextBox.Name = "ani_idTextBox";
            this.ani_idTextBox.Size = new System.Drawing.Size(131, 25);
            this.ani_idTextBox.TabIndex = 1;
            // 
            // ani_nomeTextBox
            // 
            this.ani_nomeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ani_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbAnimalBindingSource, "ani_nome", true));
            this.ani_nomeTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_nomeTextBox.Location = new System.Drawing.Point(5, 130);
            this.ani_nomeTextBox.Name = "ani_nomeTextBox";
            this.ani_nomeTextBox.Size = new System.Drawing.Size(267, 25);
            this.ani_nomeTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnRemoverFoto);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnAdicionarFoto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(443, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 224);
            this.panel2.TabIndex = 21;
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoverFoto.BackgroundImage = global::Sistema.Properties.Resources.excluir_20px;
            this.btnRemoverFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoverFoto.FlatAppearance.BorderSize = 0;
            this.btnRemoverFoto.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoverFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverFoto.Location = new System.Drawing.Point(117, 177);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(99, 27);
            this.btnRemoverFoto.TabIndex = 10;
            this.btnRemoverFoto.Text = "Remover";
            this.btnRemoverFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverFoto.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 145);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarFoto.BackgroundImage = global::Sistema.Properties.Resources.novo_20px;
            this.btnAdicionarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionarFoto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFoto.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdicionarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarFoto.Location = new System.Drawing.Point(12, 177);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(99, 27);
            this.btnAdicionarFoto.TabIndex = 9;
            this.btnAdicionarFoto.Text = "Adicionar";
            this.btnAdicionarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarFoto.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(55, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Foto do Animal";
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.Location = new System.Drawing.Point(651, 9);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 31;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.Location = new System.Drawing.Point(618, 19);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 30;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 89;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nanovet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbAnimalTableAdapter = null;
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
            this.tableAdapterManager.tbExameTableAdapter = null;
            this.tableAdapterManager.tbLançamentoTableAdapter = null;
            this.tableAdapterManager.tbMedicoTableAdapter = null;
            this.tableAdapterManager.tbMesTableAdapter = null;
            this.tableAdapterManager.tbPrescriçaoTableAdapter = null;
            this.tableAdapterManager.tbProtocoloTableAdapter = null;
            this.tableAdapterManager.tbRaçaTableAdapter = null;
            this.tableAdapterManager.tbSexoTableAdapter = null;
            this.tableAdapterManager.tbSTAnimalTableAdapter = null;
            this.tableAdapterManager.tbSuspeitaTableAdapter = null;
            this.tableAdapterManager.tbTPAtendimentoTableAdapter = null;
            this.tableAdapterManager.tbTPExameTableAdapter = null;
            this.tableAdapterManager.tbTPLançamentoTableAdapter = null;
            this.tableAdapterManager.tbTPProtocoloTableAdapter = null;
            this.tableAdapterManager.tbTPVacinaTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.tbVacinaTableAdapter = null;
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
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbAnimalTableAdapter = null;
            this.tableAdapterManager1.tbAnoTableAdapter = null;
            this.tableAdapterManager1.tbAplicaçaoTableAdapter = null;
            this.tableAdapterManager1.tbAtendimentoTableAdapter = null;
            this.tableAdapterManager1.tbCargoTableAdapter = null;
            this.tableAdapterManager1.tbCidadeTableAdapter = null;
            this.tableAdapterManager1.tbClienteTableAdapter = null;
            this.tableAdapterManager1.tbDiaTableAdapter = null;
            this.tableAdapterManager1.tbEspecialidadeTableAdapter = null;
            this.tableAdapterManager1.tbEspecieTableAdapter = null;
            this.tableAdapterManager1.tbEstadoTableAdapter = null;
            this.tableAdapterManager1.tbExameTableAdapter = null;
            this.tableAdapterManager1.tbLançamentoTableAdapter = null;
            this.tableAdapterManager1.tbMedicoTableAdapter = null;
            this.tableAdapterManager1.tbMesTableAdapter = null;
            this.tableAdapterManager1.tbPrescriçaoTableAdapter = null;
            this.tableAdapterManager1.tbProtocoloTableAdapter = null;
            this.tableAdapterManager1.tbRaçaTableAdapter = null;
            this.tableAdapterManager1.tbSexoTableAdapter = null;
            this.tableAdapterManager1.tbSTAnimalTableAdapter = null;
            this.tableAdapterManager1.tbSuspeitaTableAdapter = null;
            this.tableAdapterManager1.tbTPAtendimentoTableAdapter = null;
            this.tableAdapterManager1.tbTPExameTableAdapter = null;
            this.tableAdapterManager1.tbTPLançamentoTableAdapter = null;
            this.tableAdapterManager1.tbTPProtocoloTableAdapter = null;
            this.tableAdapterManager1.tbTPVacinaTableAdapter = null;
            this.tableAdapterManager1.tbUsuarioTableAdapter = null;
            this.tableAdapterManager1.tbVacinaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbAnimalTableAdapter
            // 
            this.tbAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // form_CadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadAnimal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_CadAnimal_Load);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource;
  
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource;
        private dbSistemaDataSet dbSistemaDataSet1;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
  
        private System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.TextBox ani_idTextBox;
        private System.Windows.Forms.TextBox ani_nomeTextBox;
  
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ani_clienteTextBox;
        private System.Windows.Forms.Button btnRemoverFoto;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.ComboBox ani_sexoComboBox;
        private System.Windows.Forms.TextBox ani_clienteNomeTextBox;
        private System.Windows.Forms.TextBox ani_pesoTextBox;
        private System.Windows.Forms.TextBox ani_idadeTextBox;
        private System.Windows.Forms.ComboBox ani_especieComboBox;
   
        private System.Windows.Forms.ComboBox ani_raçaComboBox;
        private System.Windows.Forms.ComboBox ani_statusComboBox;
        private System.Windows.Forms.DateTimePicker ani_cadastroDateTimePicker;
        private dbSistemaDataSetTableAdapters.tbAnimalTableAdapter tbAnimalTableAdapter;
        private System.Windows.Forms.Button btnPesquisarClientee;
    }
}