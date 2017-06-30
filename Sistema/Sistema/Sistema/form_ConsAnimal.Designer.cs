namespace Sistema
{
    partial class form_ConsAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConsAnimal));
            this.tbAnimalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.tbAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.tbEspecieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.tbEspecieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_ani = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbFiltrarAnimal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnimalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ani)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = System.Drawing.Color.Maroon;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Name = "label6";
            // 
            // tbAnimalBindingSource1
            // 
            this.tbAnimalBindingSource1.DataMember = "tbAnimal";
            this.tbAnimalBindingSource1.DataSource = this.dbSistemaDataSetBindingSource;
            // 
            // dbSistemaDataSetBindingSource
            // 
            this.dbSistemaDataSetBindingSource.DataSource = this.dbSistemaDataSet;
            this.dbSistemaDataSetBindingSource.Position = 0;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAnimalBindingSource
            // 
            this.tbAnimalBindingSource.DataMember = "tbAnimal";
            this.tbAnimalBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            resources.ApplyResources(this.picMinimizar, "picMinimizar");
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            resources.ApplyResources(this.picFechar, "picFechar");
            this.picFechar.Name = "picFechar";
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // tbEspecieBindingSource1
            // 
            this.tbEspecieBindingSource1.DataMember = "tbEspecie";
            this.tbEspecieBindingSource1.DataSource = this.dbSistemaDataSet;
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
    //        this.tableAdapterManager.tbIdadeTableAdapter = null;
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
            // tbEspecieBindingSource
            // 
            this.tbEspecieBindingSource.DataMember = "tbEspecie";
            this.tbEspecieBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dgv_ani
            // 
            this.dgv_ani.AllowUserToAddRows = false;
            this.dgv_ani.AllowUserToDeleteRows = false;
            this.dgv_ani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ani.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_ani.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ani.GridColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.dgv_ani, "dgv_ani");
            this.dgv_ani.Name = "dgv_ani";
            this.dgv_ani.ReadOnly = true;
            this.dgv_ani.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ani.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ani_CellDoubleClick);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // txtValor
            // 
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Name = "txtValor";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbFiltrarAnimal
            // 
            this.cbFiltrarAnimal.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.cbFiltrarAnimal, "cbFiltrarAnimal");
            this.cbFiltrarAnimal.FormattingEnabled = true;
            this.cbFiltrarAnimal.Items.AddRange(new object[] {
            resources.GetString("cbFiltrarAnimal.Items"),
            resources.GetString("cbFiltrarAnimal.Items1")});
            this.cbFiltrarAnimal.Name = "cbFiltrarAnimal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // tbAnimalBindingSource2
            // 
            this.tbAnimalBindingSource2.DataMember = "tbAnimal";
            this.tbAnimalBindingSource2.DataSource = this.dbSistemaDataSet;
            // 
            // form_ConsAnimal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.cbFiltrarAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dgv_ani);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ConsAnimal";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.form_ConsAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ani)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource1;
        private dbSistemaDataSet dbSistemaDataSet;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
 //       private dbSistemaDataSetTableAdapters.tbEspecieTableAdapter tbEspecieTableAdapter;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource;
//        private dbSistemaDataSetTableAdapters.tbAnimalTableAdapter tbAnimalTableAdapter;
  //      private System.Windows.Forms.DataGridViewTextBoxColumn anisexoDataGridViewTextBoxColumn;
     //   private System.Windows.Forms.DataGridViewTextBoxColumn aniespDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn aniraçaDataGridViewTextBoxColumn;
      //rivate System.Windows.Forms.DataGridViewTextBoxColumn aniidadeDataGridViewTextBoxColumn;
      //vate System.Windows.Forms.DataGridViewTextBoxColumn anipesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource1;
        private System.Windows.Forms.BindingSource dbSistemaDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgv_ani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbFiltrarAnimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource2;
    }
}