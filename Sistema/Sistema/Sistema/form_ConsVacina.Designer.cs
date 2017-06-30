namespace Sistema
{
    partial class form_ConsVacina
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
            this.cbFiltrarAtendimento = new System.Windows.Forms.ComboBox();
            this.dgv_vac = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.piccFechar = new System.Windows.Forms.PictureBox();
            this.piccMinimizar = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Maroon;
            label6.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label6.ForeColor = System.Drawing.Color.White;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(407, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(191, 31);
            label6.TabIndex = 78;
            label6.Text = "Consulta Vacina";
            // 
            // cbFiltrarAtendimento
            // 
            this.cbFiltrarAtendimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltrarAtendimento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrarAtendimento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrarAtendimento.FormattingEnabled = true;
            this.cbFiltrarAtendimento.Items.AddRange(new object[] {
            "Pesquisar Todos",
            "Pesquisar por Cliente"});
            this.cbFiltrarAtendimento.Location = new System.Drawing.Point(90, 57);
            this.cbFiltrarAtendimento.Name = "cbFiltrarAtendimento";
            this.cbFiltrarAtendimento.Size = new System.Drawing.Size(200, 26);
            this.cbFiltrarAtendimento.TabIndex = 113;
            // 
            // dgv_vac
            // 
            this.dgv_vac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vac.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_vac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac.GridColor = System.Drawing.Color.DimGray;
            this.dgv_vac.Location = new System.Drawing.Point(12, 135);
            this.dgv_vac.Name = "dgv_vac";
            this.dgv_vac.Size = new System.Drawing.Size(1026, 350);
            this.dgv_vac.TabIndex = 112;
            this.dgv_vac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vac_CellContentClick);
            this.dgv_vac.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vac_CellDoubleClick);
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
            this.label4.TabIndex = 111;
            this.label4.Text = "Pesquisar:";
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
            this.label2.TabIndex = 110;
            this.label2.Text = "Filtrar:";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(90, 89);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 26);
            this.txtValor.TabIndex = 109;
            // 
            // picFechar
            // 
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFechar.Location = new System.Drawing.Point(651, 12);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 106;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picMinimizar.Location = new System.Drawing.Point(618, 22);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 105;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(296, 89);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(50, 26);
            this.btnPesquisar.TabIndex = 103;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.piccFechar);
            this.panel1.Controls.Add(this.piccMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 50);
            this.panel1.TabIndex = 114;
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
            // piccFechar
            // 
            this.piccFechar.BackColor = System.Drawing.Color.Maroon;
            this.piccFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.piccFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.piccFechar.Location = new System.Drawing.Point(1001, 9);
            this.piccFechar.Name = "piccFechar";
            this.piccFechar.Size = new System.Drawing.Size(37, 35);
            this.piccFechar.TabIndex = 54;
            this.piccFechar.TabStop = false;
            this.piccFechar.Click += new System.EventHandler(this.piccFechar_Click);
            // 
            // piccMinimizar
            // 
            this.piccMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.piccMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.piccMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.piccMinimizar.Location = new System.Drawing.Point(968, 19);
            this.piccMinimizar.Name = "piccMinimizar";
            this.piccMinimizar.Size = new System.Drawing.Size(27, 25);
            this.piccMinimizar.TabIndex = 53;
            this.piccMinimizar.TabStop = false;
            this.piccMinimizar.Click += new System.EventHandler(this.piccMinimizar_Click);
            // 
            // form_ConsVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbFiltrarAtendimento);
            this.Controls.Add(this.dgv_vac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(207, 60);
            this.Name = "form_ConsVacina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "form_ConsVacina";
            this.Load += new System.EventHandler(this.form_ConsVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFiltrarAtendimento;
        private System.Windows.Forms.DataGridView dgv_vac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piccFechar;
        private System.Windows.Forms.PictureBox piccMinimizar;
    }
}