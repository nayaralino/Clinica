namespace Sistema
{
    partial class form_ConsEspecie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConsEspecie));
            this.tbEspecieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.tableAdapterManager = new Sistema.dbSistemaDataSetTableAdapters.TableAdapterManager();
            this.esp_dvg = new System.Windows.Forms.DataGridView();
            this.tbEspecieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgv_esp = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esp_dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_esp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = System.Drawing.Color.Maroon;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Name = "label6";
            // 
            // tbEspecieBindingSource
            // 
            this.tbEspecieBindingSource.DataMember = "tbEspecie";
            this.tbEspecieBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
       //     this.tableAdapterManager.tbIdadeTableAdapter = null;
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
            // esp_dvg
            // 
            resources.ApplyResources(this.esp_dvg, "esp_dvg");
            this.esp_dvg.Name = "esp_dvg";
            // 
            // tbEspecieBindingSource1
            // 
            this.tbEspecieBindingSource1.DataMember = "tbEspecie";
            this.tbEspecieBindingSource1.DataSource = this.dbSistemaDataSet;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Name = "txtValor";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // dgv_esp
            // 
            this.dgv_esp.AllowUserToAddRows = false;
            this.dgv_esp.AllowUserToDeleteRows = false;
            this.dgv_esp.AllowUserToOrderColumns = true;
            this.dgv_esp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_esp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_esp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_esp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_esp.GridColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.dgv_esp, "dgv_esp");
            this.dgv_esp.Name = "dgv_esp";
            this.dgv_esp.ReadOnly = true;
            this.dgv_esp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_esp_CellDoubleClick);
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
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            resources.ApplyResources(this.picFechar, "picFechar");
            this.picFechar.Name = "picFechar";
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Name = "label4";
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
            // form_ConsEspecie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_esp);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ConsEspecie";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.form_ConsEspecie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esp_dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEspecieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_esp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource;
    //    private dbSistemaDataSetTableAdapters.tbEspecieTableAdapter tbEspecieTableAdapter;
        private dbSistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView esp_dvg;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.BindingSource tbEspecieBindingSource1;
        private System.Windows.Forms.DataGridView dgv_esp;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}