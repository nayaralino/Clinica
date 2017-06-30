namespace Sistema
{
    partial class form_ConsCliente
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConsCliente));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgv_cli = new System.Windows.Forms.DataGridView();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimirCliente = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cli)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = System.Drawing.Color.Maroon;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Name = "label1";
            // 
            // txtValor
            // 
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Name = "txtValor";
            // 
            // dgv_cli
            // 
            this.dgv_cli.AllowUserToAddRows = false;
            this.dgv_cli.AllowUserToDeleteRows = false;
            this.dgv_cli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cli.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_cli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cli.GridColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.dgv_cli, "dgv_cli");
            this.dgv_cli.Name = "dgv_cli";
            this.dgv_cli.ReadOnly = true;
            this.dgv_cli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cli_CellContentClick);
            this.dgv_cli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cli_CellDoubleClick);
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.cbFiltrar, "cbFiltrar");
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            resources.GetString("cbFiltrar.Items"),
            resources.GetString("cbFiltrar.Items1"),
            resources.GetString("cbFiltrar.Items2")});
            this.cbFiltrar.Name = "cbFiltrar";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(label1);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
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
            // dbSistemaDataSet
            // 
            this.dbSistemaDataSet.DataSetName = "dbSistemaDataSet";
            this.dbSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.dbSistemaDataSet;
            // 
            // btnImprimirCliente
            // 
            this.btnImprimirCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirCliente.Image = global::Sistema.Properties.Resources.Print_25px;
            resources.ApplyResources(this.btnImprimirCliente, "btnImprimirCliente");
            this.btnImprimirCliente.Name = "btnImprimirCliente";
            this.btnImprimirCliente.UseVisualStyleBackColor = false;
            this.btnImprimirCliente.Click += new System.EventHandler(this.btnImprimirCliente_Click);
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            // 
            // form_ConsCliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimirCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.dgv_cli);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_ConsCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.form_ConsCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cli)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgv_cli;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private dbSistemaDataSet dbSistemaDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private System.Windows.Forms.Button btnImprimirCliente;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //    private dbSistemaDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
    }
}