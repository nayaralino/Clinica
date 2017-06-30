namespace Sistema
{
    partial class form_ConsTipoProtocolo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_prot = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prot)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Maroon;
            label6.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label6.ForeColor = System.Drawing.Color.White;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(215, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(297, 31);
            label6.TabIndex = 78;
            label6.Text = "Consulta Tipo Protocolo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 117;
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
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Nanovet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFechar.Location = new System.Drawing.Point(651, 12);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 102;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picMinimizar.Location = new System.Drawing.Point(618, 22);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 101;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 116;
            this.label4.Text = "Pesquisar:";
            // 
            // dgv_prot
            // 
            this.dgv_prot.AllowUserToAddRows = false;
            this.dgv_prot.AllowUserToDeleteRows = false;
            this.dgv_prot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_prot.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_prot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_prot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prot.GridColor = System.Drawing.Color.DimGray;
            this.dgv_prot.Location = new System.Drawing.Point(12, 120);
            this.dgv_prot.Name = "dgv_prot";
            this.dgv_prot.ReadOnly = true;
            this.dgv_prot.Size = new System.Drawing.Size(676, 368);
            this.dgv_prot.TabIndex = 113;
            this.dgv_prot.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prot_CellDoubleClick);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtValor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValor.Location = new System.Drawing.Point(15, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 26);
            this.txtValor.TabIndex = 112;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(221, 85);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(50, 26);
            this.btnPesquisar.TabIndex = 111;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // form_ConsTipoProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_prot);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(207, 60);
            this.Name = "form_ConsTipoProtocolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "form_ConsTipoProtocolo";
            this.Load += new System.EventHandler(this.form_ConsTipoProtocolo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_prot;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
    }
}