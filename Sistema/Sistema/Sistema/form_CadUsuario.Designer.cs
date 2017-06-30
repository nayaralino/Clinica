namespace Sistema
{
    partial class form_CadUsuario
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
            System.Windows.Forms.Label usr_idLabel;
            System.Windows.Forms.Label usr_nomeLabel;
            System.Windows.Forms.Label usr_cpfLabel;
            System.Windows.Forms.Label usr_telefoneLabel;
            System.Windows.Forms.Label usr_celularLabel;
            System.Windows.Forms.Label usr_usuarioLabel;
            System.Windows.Forms.Label usr_senhaLabel;
            System.Windows.Forms.Label usr_confirmarSenhaLabel;
            System.Windows.Forms.Label usr_emailLabel;
            System.Windows.Forms.Label usr_logradouroLabel;
            System.Windows.Forms.Label usr_numeroLabel;
            System.Windows.Forms.Label usr_complementoLabel;
            System.Windows.Forms.Label usr_bairroLabel;
            System.Windows.Forms.Label usr_cidadeLabel;
            System.Windows.Forms.Label usr_estadoLabel;
            System.Windows.Forms.Label usr_cargoLabel;
            System.Windows.Forms.Label label3;
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.usr_idTextBox = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.usr_nomeTextBox = new System.Windows.Forms.TextBox();
            this.usr_cpfTextBox = new System.Windows.Forms.TextBox();
            this.usr_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.usr_celularTextBox = new System.Windows.Forms.TextBox();
            this.usr_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.usr_senhaTextBox = new System.Windows.Forms.TextBox();
            this.usr_confirmarSenhaTextBox = new System.Windows.Forms.TextBox();
            this.usr_emailTextBox = new System.Windows.Forms.TextBox();
            this.usr_logradouroTextBox = new System.Windows.Forms.TextBox();
            this.usr_numeroTextBox = new System.Windows.Forms.TextBox();
            this.usr_complementoTextBox = new System.Windows.Forms.TextBox();
            this.usr_bairroTextBox = new System.Windows.Forms.TextBox();
            this.usr_cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.usr_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.usr_cargoComboBox = new System.Windows.Forms.ComboBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
    //        this.tbUsuarioTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbUsuarioTableAdapter();
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            usr_idLabel = new System.Windows.Forms.Label();
            usr_nomeLabel = new System.Windows.Forms.Label();
            usr_cpfLabel = new System.Windows.Forms.Label();
            usr_telefoneLabel = new System.Windows.Forms.Label();
            usr_celularLabel = new System.Windows.Forms.Label();
            usr_usuarioLabel = new System.Windows.Forms.Label();
            usr_senhaLabel = new System.Windows.Forms.Label();
            usr_confirmarSenhaLabel = new System.Windows.Forms.Label();
            usr_emailLabel = new System.Windows.Forms.Label();
            usr_logradouroLabel = new System.Windows.Forms.Label();
            usr_numeroLabel = new System.Windows.Forms.Label();
            usr_complementoLabel = new System.Windows.Forms.Label();
            usr_bairroLabel = new System.Windows.Forms.Label();
            usr_cidadeLabel = new System.Windows.Forms.Label();
            usr_estadoLabel = new System.Windows.Forms.Label();
            usr_cargoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usr_idLabel
            // 
            usr_idLabel.AutoSize = true;
            usr_idLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_idLabel.Location = new System.Drawing.Point(3, 15);
            usr_idLabel.Name = "usr_idLabel";
            usr_idLabel.Size = new System.Drawing.Size(40, 18);
            usr_idLabel.TabIndex = 71;
            usr_idLabel.Text = "Cód.:";
            // 
            // usr_nomeLabel
            // 
            usr_nomeLabel.AutoSize = true;
            usr_nomeLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_nomeLabel.Location = new System.Drawing.Point(3, 65);
            usr_nomeLabel.Name = "usr_nomeLabel";
            usr_nomeLabel.Size = new System.Drawing.Size(50, 18);
            usr_nomeLabel.TabIndex = 73;
            usr_nomeLabel.Text = "Nome:";
            // 
            // usr_cpfLabel
            // 
            usr_cpfLabel.AutoSize = true;
            usr_cpfLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_cpfLabel.Location = new System.Drawing.Point(258, 65);
            usr_cpfLabel.Name = "usr_cpfLabel";
            usr_cpfLabel.Size = new System.Drawing.Size(35, 18);
            usr_cpfLabel.TabIndex = 75;
            usr_cpfLabel.Text = "CPF:";
            // 
            // usr_telefoneLabel
            // 
            usr_telefoneLabel.AutoSize = true;
            usr_telefoneLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_telefoneLabel.Location = new System.Drawing.Point(384, 65);
            usr_telefoneLabel.Name = "usr_telefoneLabel";
            usr_telefoneLabel.Size = new System.Drawing.Size(67, 18);
            usr_telefoneLabel.TabIndex = 77;
            usr_telefoneLabel.Text = "Telefone:";
            // 
            // usr_celularLabel
            // 
            usr_celularLabel.AutoSize = true;
            usr_celularLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_celularLabel.Location = new System.Drawing.Point(511, 65);
            usr_celularLabel.Name = "usr_celularLabel";
            usr_celularLabel.Size = new System.Drawing.Size(56, 18);
            usr_celularLabel.TabIndex = 79;
            usr_celularLabel.Text = "Celular:";
            // 
            // usr_usuarioLabel
            // 
            usr_usuarioLabel.AutoSize = true;
            usr_usuarioLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_usuarioLabel.Location = new System.Drawing.Point(258, 215);
            usr_usuarioLabel.Name = "usr_usuarioLabel";
            usr_usuarioLabel.Size = new System.Drawing.Size(59, 18);
            usr_usuarioLabel.TabIndex = 81;
            usr_usuarioLabel.Text = "Usuário:";
            // 
            // usr_senhaLabel
            // 
            usr_senhaLabel.AutoSize = true;
            usr_senhaLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_senhaLabel.Location = new System.Drawing.Point(384, 215);
            usr_senhaLabel.Name = "usr_senhaLabel";
            usr_senhaLabel.Size = new System.Drawing.Size(50, 18);
            usr_senhaLabel.TabIndex = 83;
            usr_senhaLabel.Text = "Senha:";
            // 
            // usr_confirmarSenhaLabel
            // 
            usr_confirmarSenhaLabel.AutoSize = true;
            usr_confirmarSenhaLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_confirmarSenhaLabel.Location = new System.Drawing.Point(511, 215);
            usr_confirmarSenhaLabel.Name = "usr_confirmarSenhaLabel";
            usr_confirmarSenhaLabel.Size = new System.Drawing.Size(114, 18);
            usr_confirmarSenhaLabel.TabIndex = 85;
            usr_confirmarSenhaLabel.Text = "Confirmar Senha:";
            // 
            // usr_emailLabel
            // 
            usr_emailLabel.AutoSize = true;
            usr_emailLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_emailLabel.Location = new System.Drawing.Point(3, 265);
            usr_emailLabel.Name = "usr_emailLabel";
            usr_emailLabel.Size = new System.Drawing.Size(51, 18);
            usr_emailLabel.TabIndex = 87;
            usr_emailLabel.Text = "E-mail:";
            // 
            // usr_logradouroLabel
            // 
            usr_logradouroLabel.AutoSize = true;
            usr_logradouroLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_logradouroLabel.Location = new System.Drawing.Point(3, 115);
            usr_logradouroLabel.Name = "usr_logradouroLabel";
            usr_logradouroLabel.Size = new System.Drawing.Size(82, 18);
            usr_logradouroLabel.TabIndex = 89;
            usr_logradouroLabel.Text = "Logradouro:";
            // 
            // usr_numeroLabel
            // 
            usr_numeroLabel.AutoSize = true;
            usr_numeroLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_numeroLabel.Location = new System.Drawing.Point(258, 115);
            usr_numeroLabel.Name = "usr_numeroLabel";
            usr_numeroLabel.Size = new System.Drawing.Size(63, 18);
            usr_numeroLabel.TabIndex = 91;
            usr_numeroLabel.Text = "Número:";
            // 
            // usr_complementoLabel
            // 
            usr_complementoLabel.AutoSize = true;
            usr_complementoLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_complementoLabel.Location = new System.Drawing.Point(384, 115);
            usr_complementoLabel.Name = "usr_complementoLabel";
            usr_complementoLabel.Size = new System.Drawing.Size(101, 18);
            usr_complementoLabel.TabIndex = 93;
            usr_complementoLabel.Text = "Complemento:";
            // 
            // usr_bairroLabel
            // 
            usr_bairroLabel.AutoSize = true;
            usr_bairroLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_bairroLabel.Location = new System.Drawing.Point(3, 165);
            usr_bairroLabel.Name = "usr_bairroLabel";
            usr_bairroLabel.Size = new System.Drawing.Size(49, 18);
            usr_bairroLabel.TabIndex = 95;
            usr_bairroLabel.Text = "Bairro:";
            // 
            // usr_cidadeLabel
            // 
            usr_cidadeLabel.AutoSize = true;
            usr_cidadeLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_cidadeLabel.Location = new System.Drawing.Point(258, 165);
            usr_cidadeLabel.Name = "usr_cidadeLabel";
            usr_cidadeLabel.Size = new System.Drawing.Size(55, 18);
            usr_cidadeLabel.TabIndex = 97;
            usr_cidadeLabel.Text = "Cidade:";
            // 
            // usr_estadoLabel
            // 
            usr_estadoLabel.AutoSize = true;
            usr_estadoLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_estadoLabel.Location = new System.Drawing.Point(384, 165);
            usr_estadoLabel.Name = "usr_estadoLabel";
            usr_estadoLabel.Size = new System.Drawing.Size(53, 18);
            usr_estadoLabel.TabIndex = 99;
            usr_estadoLabel.Text = "Estado:";
            // 
            // usr_cargoLabel
            // 
            usr_cargoLabel.AutoSize = true;
            usr_cargoLabel.ForeColor = System.Drawing.Color.DimGray;
            usr_cargoLabel.Location = new System.Drawing.Point(3, 215);
            usr_cargoLabel.Name = "usr_cargoLabel";
            usr_cargoLabel.Size = new System.Drawing.Size(47, 18);
            usr_cargoLabel.TabIndex = 101;
            usr_cargoLabel.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Maroon;
            label3.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label3.ForeColor = System.Drawing.Color.White;
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(193, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(227, 31);
            label3.TabIndex = 78;
            label3.Text = "Cadastrar Usuário";
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
            this.pnBotoes.TabIndex = 91;
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
            this.pnDados.Controls.Add(usr_idLabel);
            this.pnDados.Controls.Add(this.usr_idTextBox);
            this.pnDados.Controls.Add(usr_nomeLabel);
            this.pnDados.Controls.Add(this.usr_nomeTextBox);
            this.pnDados.Controls.Add(usr_cpfLabel);
            this.pnDados.Controls.Add(this.usr_cpfTextBox);
            this.pnDados.Controls.Add(usr_telefoneLabel);
            this.pnDados.Controls.Add(this.usr_telefoneTextBox);
            this.pnDados.Controls.Add(usr_celularLabel);
            this.pnDados.Controls.Add(this.usr_celularTextBox);
            this.pnDados.Controls.Add(usr_usuarioLabel);
            this.pnDados.Controls.Add(this.usr_usuarioTextBox);
            this.pnDados.Controls.Add(usr_senhaLabel);
            this.pnDados.Controls.Add(this.usr_senhaTextBox);
            this.pnDados.Controls.Add(usr_confirmarSenhaLabel);
            this.pnDados.Controls.Add(this.usr_confirmarSenhaTextBox);
            this.pnDados.Controls.Add(usr_emailLabel);
            this.pnDados.Controls.Add(this.usr_emailTextBox);
            this.pnDados.Controls.Add(usr_logradouroLabel);
            this.pnDados.Controls.Add(this.usr_logradouroTextBox);
            this.pnDados.Controls.Add(usr_numeroLabel);
            this.pnDados.Controls.Add(this.usr_numeroTextBox);
            this.pnDados.Controls.Add(usr_complementoLabel);
            this.pnDados.Controls.Add(this.usr_complementoTextBox);
            this.pnDados.Controls.Add(usr_bairroLabel);
            this.pnDados.Controls.Add(this.usr_bairroTextBox);
            this.pnDados.Controls.Add(usr_cidadeLabel);
            this.pnDados.Controls.Add(this.usr_cidadeComboBox);
            this.pnDados.Controls.Add(usr_estadoLabel);
            this.pnDados.Controls.Add(this.usr_estadoComboBox);
            this.pnDados.Controls.Add(usr_cargoLabel);
            this.pnDados.Controls.Add(this.usr_cargoComboBox);
            this.pnDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pnDados.Location = new System.Drawing.Point(12, 56);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(676, 351);
            this.pnDados.TabIndex = 90;
            // 
            // usr_idTextBox
            // 
            this.usr_idTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_id", true));
            this.usr_idTextBox.Enabled = false;
            this.usr_idTextBox.Location = new System.Drawing.Point(6, 36);
            this.usr_idTextBox.Name = "usr_idTextBox";
            this.usr_idTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_idTextBox.TabIndex = 72;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usr_nomeTextBox
            // 
            this.usr_nomeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_nome", true));
            this.usr_nomeTextBox.Location = new System.Drawing.Point(6, 86);
            this.usr_nomeTextBox.Name = "usr_nomeTextBox";
            this.usr_nomeTextBox.Size = new System.Drawing.Size(248, 26);
            this.usr_nomeTextBox.TabIndex = 74;
            // 
            // usr_cpfTextBox
            // 
            this.usr_cpfTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_cpf", true));
            this.usr_cpfTextBox.Location = new System.Drawing.Point(260, 86);
            this.usr_cpfTextBox.Name = "usr_cpfTextBox";
            this.usr_cpfTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_cpfTextBox.TabIndex = 76;
            // 
            // usr_telefoneTextBox
            // 
            this.usr_telefoneTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_telefone", true));
            this.usr_telefoneTextBox.Location = new System.Drawing.Point(387, 86);
            this.usr_telefoneTextBox.Name = "usr_telefoneTextBox";
            this.usr_telefoneTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_telefoneTextBox.TabIndex = 78;
            // 
            // usr_celularTextBox
            // 
            this.usr_celularTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_celular", true));
            this.usr_celularTextBox.Location = new System.Drawing.Point(514, 86);
            this.usr_celularTextBox.Name = "usr_celularTextBox";
            this.usr_celularTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_celularTextBox.TabIndex = 80;
            // 
            // usr_usuarioTextBox
            // 
            this.usr_usuarioTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_usuario", true));
            this.usr_usuarioTextBox.Location = new System.Drawing.Point(260, 236);
            this.usr_usuarioTextBox.Name = "usr_usuarioTextBox";
            this.usr_usuarioTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_usuarioTextBox.TabIndex = 82;
            // 
            // usr_senhaTextBox
            // 
            this.usr_senhaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_senha", true));
            this.usr_senhaTextBox.Location = new System.Drawing.Point(387, 236);
            this.usr_senhaTextBox.Name = "usr_senhaTextBox";
            this.usr_senhaTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_senhaTextBox.TabIndex = 84;
            // 
            // usr_confirmarSenhaTextBox
            // 
            this.usr_confirmarSenhaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_confirmarSenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_confirmarSenha", true));
            this.usr_confirmarSenhaTextBox.Location = new System.Drawing.Point(514, 236);
            this.usr_confirmarSenhaTextBox.Name = "usr_confirmarSenhaTextBox";
            this.usr_confirmarSenhaTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_confirmarSenhaTextBox.TabIndex = 86;
            // 
            // usr_emailTextBox
            // 
            this.usr_emailTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_email", true));
            this.usr_emailTextBox.Location = new System.Drawing.Point(6, 286);
            this.usr_emailTextBox.Name = "usr_emailTextBox";
            this.usr_emailTextBox.Size = new System.Drawing.Size(248, 26);
            this.usr_emailTextBox.TabIndex = 88;
            // 
            // usr_logradouroTextBox
            // 
            this.usr_logradouroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_logradouro", true));
            this.usr_logradouroTextBox.Location = new System.Drawing.Point(6, 136);
            this.usr_logradouroTextBox.Name = "usr_logradouroTextBox";
            this.usr_logradouroTextBox.Size = new System.Drawing.Size(248, 26);
            this.usr_logradouroTextBox.TabIndex = 90;
            // 
            // usr_numeroTextBox
            // 
            this.usr_numeroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_numero", true));
            this.usr_numeroTextBox.Location = new System.Drawing.Point(260, 136);
            this.usr_numeroTextBox.Name = "usr_numeroTextBox";
            this.usr_numeroTextBox.Size = new System.Drawing.Size(121, 26);
            this.usr_numeroTextBox.TabIndex = 92;
            // 
            // usr_complementoTextBox
            // 
            this.usr_complementoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_complemento", true));
            this.usr_complementoTextBox.Location = new System.Drawing.Point(387, 136);
            this.usr_complementoTextBox.Name = "usr_complementoTextBox";
            this.usr_complementoTextBox.Size = new System.Drawing.Size(248, 26);
            this.usr_complementoTextBox.TabIndex = 94;
            // 
            // usr_bairroTextBox
            // 
            this.usr_bairroTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_bairro", true));
            this.usr_bairroTextBox.Location = new System.Drawing.Point(6, 186);
            this.usr_bairroTextBox.Name = "usr_bairroTextBox";
            this.usr_bairroTextBox.Size = new System.Drawing.Size(248, 26);
            this.usr_bairroTextBox.TabIndex = 96;
            // 
            // usr_cidadeComboBox
            // 
            this.usr_cidadeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_cidade", true));
            this.usr_cidadeComboBox.FormattingEnabled = true;
            this.usr_cidadeComboBox.Location = new System.Drawing.Point(260, 186);
            this.usr_cidadeComboBox.Name = "usr_cidadeComboBox";
            this.usr_cidadeComboBox.Size = new System.Drawing.Size(121, 26);
            this.usr_cidadeComboBox.TabIndex = 98;
            // 
            // usr_estadoComboBox
            // 
            this.usr_estadoComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_estado", true));
            this.usr_estadoComboBox.FormattingEnabled = true;
            this.usr_estadoComboBox.Location = new System.Drawing.Point(387, 186);
            this.usr_estadoComboBox.Name = "usr_estadoComboBox";
            this.usr_estadoComboBox.Size = new System.Drawing.Size(248, 26);
            this.usr_estadoComboBox.TabIndex = 100;
            // 
            // usr_cargoComboBox
            // 
            this.usr_cargoComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_cargoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usr_cargo", true));
            this.usr_cargoComboBox.FormattingEnabled = true;
            this.usr_cargoComboBox.Location = new System.Drawing.Point(6, 236);
            this.usr_cargoComboBox.Name = "usr_cargoComboBox";
            this.usr_cargoComboBox.Size = new System.Drawing.Size(248, 26);
            this.usr_cargoComboBox.TabIndex = 102;
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.Location = new System.Drawing.Point(651, 9);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 86;
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
            this.picMinimizar.TabIndex = 85;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // tbUsuarioTableAdapter
            // 
     //       this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
     /*       this.tableAdapterManager.tbAnimalTableAdapter = null;
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
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter; */
            this.tableAdapterManager.UpdateOrder = Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 103;
            this.label1.Text = "Nanovet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Controls.Add(label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 109;
            // 
            // form_CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadUsuario";
            this.Load += new System.EventHandler(this.form_CadUsuario_Load);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
//        private dbSistemaDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usr_idTextBox;
        private System.Windows.Forms.TextBox usr_nomeTextBox;
        private System.Windows.Forms.TextBox usr_cpfTextBox;
        private System.Windows.Forms.TextBox usr_telefoneTextBox;
        private System.Windows.Forms.TextBox usr_celularTextBox;
        private System.Windows.Forms.TextBox usr_usuarioTextBox;
        private System.Windows.Forms.TextBox usr_senhaTextBox;
        private System.Windows.Forms.TextBox usr_confirmarSenhaTextBox;
        private System.Windows.Forms.TextBox usr_emailTextBox;
        private System.Windows.Forms.TextBox usr_logradouroTextBox;
        private System.Windows.Forms.TextBox usr_numeroTextBox;
        private System.Windows.Forms.TextBox usr_complementoTextBox;
        private System.Windows.Forms.TextBox usr_bairroTextBox;
        private System.Windows.Forms.ComboBox usr_cidadeComboBox;
        private System.Windows.Forms.ComboBox usr_estadoComboBox;
        private System.Windows.Forms.ComboBox usr_cargoComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}