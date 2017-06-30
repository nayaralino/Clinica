namespace Sistema
{
    partial class form_CadAnimal_CadBotao
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
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.White;
            this.btnSim.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.Color.DimGray;
            this.btnSim.Location = new System.Drawing.Point(44, 69);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 0;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.White;
            this.btnNao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.Color.DimGray;
            this.btnNao.Location = new System.Drawing.Point(125, 69);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 1;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnBotoes.Controls.Add(this.label1);
            this.pnBotoes.Controls.Add(this.btnSim);
            this.pnBotoes.Controls.Add(this.btnNao);
            this.pnBotoes.ForeColor = System.Drawing.Color.Black;
            this.pnBotoes.Location = new System.Drawing.Point(219, 166);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(238, 132);
            this.pnBotoes.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastrar Animal Agora?";
            // 
            // form_CadAnimal_CadBotao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadAnimal_CadBotao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnBotoes.ResumeLayout(false);
            this.pnBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Label label1;
    }
}