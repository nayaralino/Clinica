namespace Sistema
{
    partial class form_ConsRaça
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
            System.Windows.Forms.Label label6;
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.tbRaçaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbEspecieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbEspecieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.dgv_raça = new System.Windows.Forms.DataGridView();
            this.cbFiltrarRaça = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRaçaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_raça)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Maroon;
            label6.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label6.ForeColor = System.Drawing.Color.White;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(290, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(184, 31);
            label6.TabIndex = 78;
            label6.Text = "Consulta Raça ";
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFechar.Location = new System.Drawing.Point(651, 9);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 55;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picMinimizar.Location = new System.Drawing.Point(618, 19);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 54;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // tbRaçaBindingSource
            // 
            this.tbRaçaBindingSource.DataMember = "tbRaça";
            this.tbRaçaBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(90, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 26);
            this.txtValor.TabIndex = 49;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(296, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(50, 26);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbEspecieBindingSource1
            // 
            this.tbEspecieBindingSource1.DataMember = "tbEspecie";
            this.tbEspecieBindingSource1.DataSource = this.dbSistemaDataSet;
            // 
            // tbEspecieBindingSource
            // 
            this.tbEspecieBindingSource.DataMember = "tbEspecie";
            this.tbEspecieBindingSource.DataSource = this.dbSistemaDataSet;
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
      //      this.tableAdapterManager.tbIdadeTableAdapter = null;
            this.tableAdapterManager.tbLançamentoTableAdapter = null;
            this.tableAdapterManager.tbMedicoTableAdapter = null;
            this.tableAdapterManager.tbMesTableAdapter = null;
      //      this.tableAdapterManager.tbPesoTableAdapter = null;
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
            // dgv_raça
            // 
            this.dgv_raça.AllowUserToAddRows = false;
            this.dgv_raça.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_raça.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_raça.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_raça.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_raça.GridColor = System.Drawing.Color.DimGray;
            this.dgv_raça.Location = new System.Drawing.Point(12, 124);
            this.dgv_raça.Name = "dgv_raça";
            this.dgv_raça.ReadOnly = true;
            this.dgv_raça.Size = new System.Drawing.Size(676, 364);
            this.dgv_raça.TabIndex = 59;
            this.dgv_raça.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_raça_CellDoubleClick);
            // 
            // cbFiltrarRaça
            // 
            this.cbFiltrarRaça.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbFiltrarRaça.FormattingEnabled = true;
            this.cbFiltrarRaça.Items.AddRange(new object[] {
            "Pesquisar Todos",
            "Pesquisar Raças de Cachorro",
            "Pesquisar Raças de Gatos"});
            this.cbFiltrarRaça.Location = new System.Drawing.Point(90, 56);
            this.cbFiltrarRaça.Name = "cbFiltrarRaça";
            this.cbFiltrarRaça.Size = new System.Drawing.Size(200, 26);
            this.cbFiltrarRaça.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 93;
            this.label2.Text = "Filtrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 95;
            this.label4.Text = "Pesquisar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 50);
            this.panel1.TabIndex = 110;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 103;
            this.label1.Text = "Nanovet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_ConsRaça
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFiltrarRaça);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_raça);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(207, 60);
            this.Name = "form_ConsRaça";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.form_ConsRaça_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRaçaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_raça)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource1;
        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
 //       private dbSistemaDataSetTableAdapters.tbEspecieTableAdapter tbEspecieTableAdapter;
        private System.Windows.Forms.BindingSource tbRaçaBindingSource;
  //      private dbSistemaDataSetTableAdapters.tbRaçaTableAdapter tbRaçaTableAdapter;
        private System.Windows.Forms.DataGridView dgv_raça;
        private System.Windows.Forms.ComboBox cbFiltrarRaça;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}