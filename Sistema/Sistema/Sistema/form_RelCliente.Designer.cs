namespace Sistema
{
    partial class form_RelCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbSistemaDataSet = new Sistema.dbSistemaDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new Sistema.dbSistemaDataSetTableAdapters.tbClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportCliente
            // 
            this.reportCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "dataSetCliente";
            reportDataSource1.Value = this.tbClienteBindingSource;
            this.reportCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.reportCliente.LocalReport.ReportEmbeddedResource = "Sistema.relCliente.rdlc";
            this.reportCliente.Location = new System.Drawing.Point(12, 12);
            this.reportCliente.Name = "reportCliente";
            this.reportCliente.ServerReport.BearerToken = null;
            this.reportCliente.Size = new System.Drawing.Size(896, 379);
            this.reportCliente.TabIndex = 0;
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
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // form_RelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 397);
            this.Controls.Add(this.reportCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(207, 60);
            this.Name = "form_RelCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.form_RelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportCliente;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private dbSistemaDataSet dbSistemaDataSet;
        private dbSistemaDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
    }
}