namespace Sistema
{
    partial class form_ConsUsuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltrarUsuario = new System.Windows.Forms.ComboBox();
            this.dgv_usr = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
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
            label6.Location = new System.Drawing.Point(407, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(210, 31);
            label6.TabIndex = 78;
            label6.Text = "Consulta Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 97;
            this.label4.Text = "Pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 96;
            this.label2.Text = "Filtrar:";
            // 
            // cbFiltrarUsuario
            // 
            this.cbFiltrarUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrarUsuario.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbFiltrarUsuario.FormattingEnabled = true;
            this.cbFiltrarUsuario.Items.AddRange(new object[] {
            "Pesquisar por Nome",
            "Pesquisar Todos",
            "Pesquisar por CPF"});
            this.cbFiltrarUsuario.Location = new System.Drawing.Point(90, 56);
            this.cbFiltrarUsuario.Name = "cbFiltrarUsuario";
            this.cbFiltrarUsuario.Size = new System.Drawing.Size(200, 26);
            this.cbFiltrarUsuario.TabIndex = 95;
            // 
            // dgv_usr
            // 
            this.dgv_usr.AllowUserToAddRows = false;
            this.dgv_usr.AllowUserToDeleteRows = false;
            this.dgv_usr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usr.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_usr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usr.GridColor = System.Drawing.Color.DimGray;
            this.dgv_usr.Location = new System.Drawing.Point(12, 136);
            this.dgv_usr.Name = "dgv_usr";
            this.dgv_usr.ReadOnly = true;
            this.dgv_usr.Size = new System.Drawing.Size(1026, 352);
            this.dgv_usr.TabIndex = 94;
            this.dgv_usr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usr_CellDoubleClick);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(90, 88);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 26);
            this.txtValor.TabIndex = 93;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Sistema.Properties.Resources.Search_20px;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(296, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(50, 26);
            this.btnPesquisar.TabIndex = 92;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFechar.Location = new System.Drawing.Point(1001, 12);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 88;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picMinimizar.Location = new System.Drawing.Point(968, 22);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 87;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 50);
            this.panel1.TabIndex = 110;
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
            // form_ConsUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltrarUsuario);
            this.Controls.Add(this.dgv_usr);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(207, 60);
            this.Name = "form_ConsUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "form_ConsUsuario";
            this.Load += new System.EventHandler(this.form_ConsUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltrarUsuario;
        private System.Windows.Forms.DataGridView dgv_usr;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}