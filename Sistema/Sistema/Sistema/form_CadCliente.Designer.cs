namespace Sistema
{
    partial class form_CadCliente
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
            System.Windows.Forms.Label cli_idLabel;
            System.Windows.Forms.Label cli_nomeLabel;
            System.Windows.Forms.Label cli_cpfLabel;
            System.Windows.Forms.Label cli_bairroLabel;
            System.Windows.Forms.Label cli_cidadeLabel;
            System.Windows.Forms.Label cli_estadoLabel;
            System.Windows.Forms.Label cli_logradouroLabel;
            System.Windows.Forms.Label cli_numeroLabel;
            System.Windows.Forms.Label cli_complementoLabel;
            System.Windows.Forms.Label cli_telefoneLabel;
            System.Windows.Forms.Label cli_celularLabel;
            System.Windows.Forms.Label cli_emailLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cli_cadastroLabel;
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.cli_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.cli_idTextBox = new System.Windows.Forms.TextBox();
            this.cli_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cli_cpfTextBox = new System.Windows.Forms.TextBox();
            this.cli_celularTextBox = new System.Windows.Forms.TextBox();
            this.cli_bairroTextBox = new System.Windows.Forms.TextBox();
            this.cli_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cli_cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cli_emailTextBox = new System.Windows.Forms.TextBox();
            this.cli_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cli_logradouroTextBox = new System.Windows.Forms.TextBox();
            this.cli_complementoTextBox = new System.Windows.Forms.TextBox();
            this.cli_numeroTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.tbClienteTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbClienteTableAdapter();
            cli_idLabel = new System.Windows.Forms.Label();
            cli_nomeLabel = new System.Windows.Forms.Label();
            cli_cpfLabel = new System.Windows.Forms.Label();
            cli_bairroLabel = new System.Windows.Forms.Label();
            cli_cidadeLabel = new System.Windows.Forms.Label();
            cli_estadoLabel = new System.Windows.Forms.Label();
            cli_logradouroLabel = new System.Windows.Forms.Label();
            cli_numeroLabel = new System.Windows.Forms.Label();
            cli_complementoLabel = new System.Windows.Forms.Label();
            cli_telefoneLabel = new System.Windows.Forms.Label();
            cli_celularLabel = new System.Windows.Forms.Label();
            cli_emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cli_cadastroLabel = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // cli_idLabel
            // 
            cli_idLabel.AutoSize = true;
            cli_idLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_idLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_idLabel.Location = new System.Drawing.Point(6, 9);
            cli_idLabel.Name = "cli_idLabel";
            cli_idLabel.Size = new System.Drawing.Size(43, 17);
            cli_idLabel.TabIndex = 0;
            cli_idLabel.Text = "Cód.:";
            // 
            // cli_nomeLabel
            // 
            cli_nomeLabel.AutoSize = true;
            cli_nomeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_nomeLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_nomeLabel.Location = new System.Drawing.Point(6, 59);
            cli_nomeLabel.Name = "cli_nomeLabel";
            cli_nomeLabel.Size = new System.Drawing.Size(51, 17);
            cli_nomeLabel.TabIndex = 2;
            cli_nomeLabel.Text = "Nome:";
            // 
            // cli_cpfLabel
            // 
            cli_cpfLabel.AutoSize = true;
            cli_cpfLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_cpfLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_cpfLabel.Location = new System.Drawing.Point(6, 109);
            cli_cpfLabel.Name = "cli_cpfLabel";
            cli_cpfLabel.Size = new System.Drawing.Size(42, 17);
            cli_cpfLabel.TabIndex = 4;
            cli_cpfLabel.Text = "CPF:";
            // 
            // cli_bairroLabel
            // 
            cli_bairroLabel.AutoSize = true;
            cli_bairroLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_bairroLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_bairroLabel.Location = new System.Drawing.Point(7, 211);
            cli_bairroLabel.Name = "cli_bairroLabel";
            cli_bairroLabel.Size = new System.Drawing.Size(51, 17);
            cli_bairroLabel.TabIndex = 6;
            cli_bairroLabel.Text = "Bairro:";
            // 
            // cli_cidadeLabel
            // 
            cli_cidadeLabel.AutoSize = true;
            cli_cidadeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_cidadeLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_cidadeLabel.Location = new System.Drawing.Point(258, 211);
            cli_cidadeLabel.Name = "cli_cidadeLabel";
            cli_cidadeLabel.Size = new System.Drawing.Size(58, 17);
            cli_cidadeLabel.TabIndex = 8;
            cli_cidadeLabel.Text = "Cidade:";
            // 
            // cli_estadoLabel
            // 
            cli_estadoLabel.AutoSize = true;
            cli_estadoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_estadoLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_estadoLabel.Location = new System.Drawing.Point(385, 211);
            cli_estadoLabel.Name = "cli_estadoLabel";
            cli_estadoLabel.Size = new System.Drawing.Size(58, 17);
            cli_estadoLabel.TabIndex = 10;
            cli_estadoLabel.Text = "Estado:";
            // 
            // cli_logradouroLabel
            // 
            cli_logradouroLabel.AutoSize = true;
            cli_logradouroLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_logradouroLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_logradouroLabel.Location = new System.Drawing.Point(7, 161);
            cli_logradouroLabel.Name = "cli_logradouroLabel";
            cli_logradouroLabel.Size = new System.Drawing.Size(86, 17);
            cli_logradouroLabel.TabIndex = 12;
            cli_logradouroLabel.Text = "Logradouro:";
            // 
            // cli_numeroLabel
            // 
            cli_numeroLabel.AutoSize = true;
            cli_numeroLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_numeroLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_numeroLabel.Location = new System.Drawing.Point(260, 161);
            cli_numeroLabel.Name = "cli_numeroLabel";
            cli_numeroLabel.Size = new System.Drawing.Size(64, 17);
            cli_numeroLabel.TabIndex = 14;
            cli_numeroLabel.Text = "Numero:";
            // 
            // cli_complementoLabel
            // 
            cli_complementoLabel.AutoSize = true;
            cli_complementoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_complementoLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_complementoLabel.Location = new System.Drawing.Point(384, 161);
            cli_complementoLabel.Name = "cli_complementoLabel";
            cli_complementoLabel.Size = new System.Drawing.Size(104, 17);
            cli_complementoLabel.TabIndex = 16;
            cli_complementoLabel.Text = "Complemento:";
            // 
            // cli_telefoneLabel
            // 
            cli_telefoneLabel.AutoSize = true;
            cli_telefoneLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_telefoneLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_telefoneLabel.Location = new System.Drawing.Point(130, 109);
            cli_telefoneLabel.Name = "cli_telefoneLabel";
            cli_telefoneLabel.Size = new System.Drawing.Size(66, 17);
            cli_telefoneLabel.TabIndex = 18;
            cli_telefoneLabel.Text = "Telefone:";
            // 
            // cli_celularLabel
            // 
            cli_celularLabel.AutoSize = true;
            cli_celularLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_celularLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_celularLabel.Location = new System.Drawing.Point(257, 109);
            cli_celularLabel.Name = "cli_celularLabel";
            cli_celularLabel.Size = new System.Drawing.Size(58, 17);
            cli_celularLabel.TabIndex = 20;
            cli_celularLabel.Text = "Celular:";
            // 
            // cli_emailLabel
            // 
            cli_emailLabel.AutoSize = true;
            cli_emailLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_emailLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_emailLabel.Location = new System.Drawing.Point(384, 109);
            cli_emailLabel.Name = "cli_emailLabel";
            cli_emailLabel.Size = new System.Drawing.Size(49, 17);
            cli_emailLabel.TabIndex = 22;
            cli_emailLabel.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Maroon;
            label1.Font = new System.Drawing.Font("Engadi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(215, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(248, 38);
            label1.TabIndex = 78;
            label1.Text = "Cadastrar Cliente";
            // 
            // cli_cadastroLabel
            // 
            cli_cadastroLabel.AutoSize = true;
            cli_cadastroLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_cadastroLabel.ForeColor = System.Drawing.Color.DimGray;
            cli_cadastroLabel.Location = new System.Drawing.Point(3, 261);
            cli_cadastroLabel.Name = "cli_cadastroLabel";
            cli_cadastroLabel.Size = new System.Drawing.Size(127, 17);
            cli_cadastroLabel.TabIndex = 24;
            cli_cadastroLabel.Text = "Data do Cadastro:";
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
            this.pnBotoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(121)))), ((int)(((byte)(125)))));
            this.pnBotoes.Location = new System.Drawing.Point(12, 415);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(676, 75);
            this.pnBotoes.TabIndex = 84;
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
            this.btnPesquisar.TabIndex = 14;
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
            this.btnCancelar.TabIndex = 18;
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
            this.btnExcluir.TabIndex = 17;
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
            this.btnAlterar.TabIndex = 16;
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
            this.btnSalvar.TabIndex = 15;
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
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDados.Controls.Add(this.cli_cadastroDateTimePicker);
            this.pnDados.Controls.Add(cli_cadastroLabel);
            this.pnDados.Controls.Add(cli_idLabel);
            this.pnDados.Controls.Add(this.cli_idTextBox);
            this.pnDados.Controls.Add(cli_nomeLabel);
            this.pnDados.Controls.Add(this.cli_nomeTextBox);
            this.pnDados.Controls.Add(cli_cpfLabel);
            this.pnDados.Controls.Add(cli_bairroLabel);
            this.pnDados.Controls.Add(this.cli_cpfTextBox);
            this.pnDados.Controls.Add(this.cli_celularTextBox);
            this.pnDados.Controls.Add(this.cli_bairroTextBox);
            this.pnDados.Controls.Add(cli_telefoneLabel);
            this.pnDados.Controls.Add(cli_celularLabel);
            this.pnDados.Controls.Add(cli_cidadeLabel);
            this.pnDados.Controls.Add(this.cli_telefoneTextBox);
            this.pnDados.Controls.Add(this.cli_cidadeComboBox);
            this.pnDados.Controls.Add(cli_estadoLabel);
            this.pnDados.Controls.Add(this.cli_emailTextBox);
            this.pnDados.Controls.Add(this.cli_estadoComboBox);
            this.pnDados.Controls.Add(cli_emailLabel);
            this.pnDados.Controls.Add(cli_logradouroLabel);
            this.pnDados.Controls.Add(this.cli_logradouroTextBox);
            this.pnDados.Controls.Add(this.cli_complementoTextBox);
            this.pnDados.Controls.Add(this.cli_numeroTextBox);
            this.pnDados.Controls.Add(cli_complementoLabel);
            this.pnDados.Controls.Add(cli_numeroLabel);
            this.pnDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.ForeColor = System.Drawing.Color.White;
            this.pnDados.Location = new System.Drawing.Point(12, 56);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(676, 353);
            this.pnDados.TabIndex = 83;
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // cli_cadastroDateTimePicker
            // 
            this.cli_cadastroDateTimePicker.CustomFormat = " dd/MM/yyyy";
            this.cli_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbClienteBindingSource, "cli_cadastro", true));
            this.cli_cadastroDateTimePicker.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_cadastroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cli_cadastroDateTimePicker.Location = new System.Drawing.Point(6, 282);
            this.cli_cadastroDateTimePicker.Name = "cli_cadastroDateTimePicker";
            this.cli_cadastroDateTimePicker.Size = new System.Drawing.Size(249, 25);
            this.cli_cadastroDateTimePicker.TabIndex = 27;
            this.cli_cadastroDateTimePicker.Value = new System.DateTime(2017, 3, 25, 0, 0, 0, 0);
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cli_idTextBox
            // 
            this.cli_idTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_id", true));
            this.cli_idTextBox.Enabled = false;
            this.cli_idTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_idTextBox.Location = new System.Drawing.Point(6, 30);
            this.cli_idTextBox.Name = "cli_idTextBox";
            this.cli_idTextBox.Size = new System.Drawing.Size(130, 25);
            this.cli_idTextBox.TabIndex = 1;
            // 
            // cli_nomeTextBox
            // 
            this.cli_nomeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_nome", true));
            this.cli_nomeTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_nomeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_nomeTextBox.Location = new System.Drawing.Point(6, 80);
            this.cli_nomeTextBox.Name = "cli_nomeTextBox";
            this.cli_nomeTextBox.Size = new System.Drawing.Size(249, 25);
            this.cli_nomeTextBox.TabIndex = 2;
            // 
            // cli_cpfTextBox
            // 
            this.cli_cpfTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_cpf", true));
            this.cli_cpfTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_cpfTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_cpfTextBox.Location = new System.Drawing.Point(6, 130);
            this.cli_cpfTextBox.Name = "cli_cpfTextBox";
            this.cli_cpfTextBox.Size = new System.Drawing.Size(121, 25);
            this.cli_cpfTextBox.TabIndex = 3;
            // 
            // cli_celularTextBox
            // 
            this.cli_celularTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_celular", true));
            this.cli_celularTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_celularTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_celularTextBox.Location = new System.Drawing.Point(260, 130);
            this.cli_celularTextBox.Name = "cli_celularTextBox";
            this.cli_celularTextBox.Size = new System.Drawing.Size(121, 25);
            this.cli_celularTextBox.TabIndex = 5;
            // 
            // cli_bairroTextBox
            // 
            this.cli_bairroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_bairro", true));
            this.cli_bairroTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_bairroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_bairroTextBox.Location = new System.Drawing.Point(7, 232);
            this.cli_bairroTextBox.Name = "cli_bairroTextBox";
            this.cli_bairroTextBox.Size = new System.Drawing.Size(248, 25);
            this.cli_bairroTextBox.TabIndex = 10;
            // 
            // cli_telefoneTextBox
            // 
            this.cli_telefoneTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_telefone", true));
            this.cli_telefoneTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_telefoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_telefoneTextBox.Location = new System.Drawing.Point(133, 130);
            this.cli_telefoneTextBox.Name = "cli_telefoneTextBox";
            this.cli_telefoneTextBox.Size = new System.Drawing.Size(122, 25);
            this.cli_telefoneTextBox.TabIndex = 4;
            // 
            // cli_cidadeComboBox
            // 
            this.cli_cidadeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_cidade", true));
            this.cli_cidadeComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_cidadeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_cidadeComboBox.FormattingEnabled = true;
            this.cli_cidadeComboBox.Location = new System.Drawing.Point(261, 232);
            this.cli_cidadeComboBox.Name = "cli_cidadeComboBox";
            this.cli_cidadeComboBox.Size = new System.Drawing.Size(121, 25);
            this.cli_cidadeComboBox.TabIndex = 11;
            // 
            // cli_emailTextBox
            // 
            this.cli_emailTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_email", true));
            this.cli_emailTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_emailTextBox.Location = new System.Drawing.Point(387, 130);
            this.cli_emailTextBox.Name = "cli_emailTextBox";
            this.cli_emailTextBox.Size = new System.Drawing.Size(247, 25);
            this.cli_emailTextBox.TabIndex = 6;
            // 
            // cli_estadoComboBox
            // 
            this.cli_estadoComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_estado", true));
            this.cli_estadoComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_estadoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_estadoComboBox.FormattingEnabled = true;
            this.cli_estadoComboBox.Location = new System.Drawing.Point(388, 232);
            this.cli_estadoComboBox.Name = "cli_estadoComboBox";
            this.cli_estadoComboBox.Size = new System.Drawing.Size(247, 25);
            this.cli_estadoComboBox.TabIndex = 12;
            // 
            // cli_logradouroTextBox
            // 
            this.cli_logradouroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_logradouro", true));
            this.cli_logradouroTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_logradouroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_logradouroTextBox.Location = new System.Drawing.Point(6, 182);
            this.cli_logradouroTextBox.Name = "cli_logradouroTextBox";
            this.cli_logradouroTextBox.Size = new System.Drawing.Size(249, 25);
            this.cli_logradouroTextBox.TabIndex = 7;
            // 
            // cli_complementoTextBox
            // 
            this.cli_complementoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_complemento", true));
            this.cli_complementoTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_complementoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_complementoTextBox.Location = new System.Drawing.Point(388, 182);
            this.cli_complementoTextBox.Name = "cli_complementoTextBox";
            this.cli_complementoTextBox.Size = new System.Drawing.Size(247, 25);
            this.cli_complementoTextBox.TabIndex = 9;
            // 
            // cli_numeroTextBox
            // 
            this.cli_numeroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cli_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cli_numero", true));
            this.cli_numeroTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_numeroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cli_numeroTextBox.Location = new System.Drawing.Point(261, 182);
            this.cli_numeroTextBox.Name = "cli_numeroTextBox";
            this.cli_numeroTextBox.Size = new System.Drawing.Size(121, 25);
            this.cli_numeroTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 50);
            this.panel1.TabIndex = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nanovet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.Location = new System.Drawing.Point(651, 12);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 79;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.Location = new System.Drawing.Point(618, 22);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 78;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
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
     //       this.tableAdapterManager.tbIdadeTableAdapter = null;
            this.tableAdapterManager.tbLançamentoTableAdapter = null;
            this.tableAdapterManager.tbMedicoTableAdapter = null;
            this.tableAdapterManager.tbMesTableAdapter = null;
     //       this.tableAdapterManager.tbPesoTableAdapter = null;
            this.tableAdapterManager.tbPrescriçaoTableAdapter = null;
            this.tableAdapterManager.tbProtocoloTableAdapter = null;
            this.tableAdapterManager.tbRaçaTableAdapter = null;
            this.tableAdapterManager.tbSexoTableAdapter = null;
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
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // form_CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(702, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadCliente";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.form_CadCliente_Load);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        protected System.Windows.Forms.Panel pnDados;
        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
  //      private dbSistemaDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cli_idTextBox;
        private System.Windows.Forms.TextBox cli_nomeTextBox;
        private System.Windows.Forms.TextBox cli_cpfTextBox;
        private System.Windows.Forms.TextBox cli_bairroTextBox;
        private System.Windows.Forms.ComboBox cli_cidadeComboBox;
        private System.Windows.Forms.ComboBox cli_estadoComboBox;
        private System.Windows.Forms.TextBox cli_logradouroTextBox;
        private System.Windows.Forms.TextBox cli_numeroTextBox;
        private System.Windows.Forms.TextBox cli_complementoTextBox;
        private System.Windows.Forms.TextBox cli_telefoneTextBox;
        private System.Windows.Forms.TextBox cli_celularTextBox;
        private System.Windows.Forms.TextBox cli_emailTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private dbSistemaDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.DateTimePicker cli_cadastroDateTimePicker;
    }
}