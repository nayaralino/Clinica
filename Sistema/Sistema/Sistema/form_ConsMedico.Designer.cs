namespace Sistema
{
    partial class form_ConsMedico
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
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConsMedico));
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgv_med = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFiltrarMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_med)).BeginInit();
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
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Name = "txtValor";
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
            // dgv_med
            // 
            this.dgv_med.AllowUserToAddRows = false;
            this.dgv_med.AllowUserToDeleteRows = false;
            this.dgv_med.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_med.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_med.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_med.GridColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.dgv_med, "dgv_med");
            this.dgv_med.Name = "dgv_med";
            this.dgv_med.ReadOnly = true;
            this.dgv_med.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_med_CellContentClick);
            this.dgv_med.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_med_CellDoubleClick_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Name = "label4";
            // 
            // cbFiltrarMedico
            // 
            this.cbFiltrarMedico.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.cbFiltrarMedico, "cbFiltrarMedico");
            this.cbFiltrarMedico.FormattingEnabled = true;
            this.cbFiltrarMedico.Items.AddRange(new object[] {
            resources.GetString("cbFiltrarMedico.Items"),
            resources.GetString("cbFiltrarMedico.Items1"),
            resources.GetString("cbFiltrarMedico.Items2")});
            this.cbFiltrarMedico.Name = "cbFiltrarMedico";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(label6);
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // form_ConsMedico
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFiltrarMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_med);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ConsMedico";
            this.Load += new System.EventHandler(this.form_ConsMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_med)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_med;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltrarMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}