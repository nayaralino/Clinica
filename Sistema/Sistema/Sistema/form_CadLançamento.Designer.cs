namespace Sistema
{
    partial class form_CadLançamento
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
            System.Windows.Forms.Label label1;
            this.pnDados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Maroon;
            label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 20F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(250, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 31);
            label1.TabIndex = 78;
            label1.Text = "Lançamentos";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pnDados.Location = new System.Drawing.Point(12, 56);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(676, 351);
            this.pnDados.TabIndex = 112;
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 111;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Properties.Resources.pet_cat_dog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nanovet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Maroon;
            this.picFechar.Image = global::Sistema.Properties.Resources.close_40px;
            this.picFechar.Location = new System.Drawing.Point(651, 5);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 101;
            this.picFechar.TabStop = false;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.picMinimizar.Image = global::Sistema.Properties.Resources.Horizontal_Line_40px1;
            this.picMinimizar.Location = new System.Drawing.Point(618, 15);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.TabIndex = 100;
            this.picMinimizar.TabStop = false;
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
            this.pnBotoes.TabIndex = 113;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // 
            // form_CadLançamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadLançamento";
            this.Text = "form_CadLançamento";
            this.Load += new System.EventHandler(this.form_CadLançamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
    }
}