
namespace HoraRemedio
{
    partial class FormLogin
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
            this.nomeProjeto = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.botaoConectar = new System.Windows.Forms.Button();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeProjeto.AutoSize = true;
            this.nomeProjeto.Font = new System.Drawing.Font("Minecraftia", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProjeto.Location = new System.Drawing.Point(168, 12);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(477, 65);
            this.nomeProjeto.TabIndex = 1;
            this.nomeProjeto.Text = "Hora do Remédio";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Minecraftia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(210, 166);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(106, 34);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSenha.Location = new System.Drawing.Point(308, 173);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(158, 26);
            this.tbSenha.TabIndex = 3;
            // 
            // botaoConectar
            // 
            this.botaoConectar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoConectar.Location = new System.Drawing.Point(308, 211);
            this.botaoConectar.Name = "botaoConectar";
            this.botaoConectar.Size = new System.Drawing.Size(75, 23);
            this.botaoConectar.TabIndex = 4;
            this.botaoConectar.Text = "Conectar";
            this.botaoConectar.UseVisualStyleBackColor = true;
            this.botaoConectar.Click += new System.EventHandler(this.botaoConectar_Click);
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoCadastrar.Location = new System.Drawing.Point(391, 211);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrar.TabIndex = 5;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // logo
            // 
            this.logo.Image = global::HoraRemedio.Properties.Resources.Hora_do_Remédio___Logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Minecraftia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(187, 128);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(129, 34);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuário:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbUsuario.Location = new System.Drawing.Point(308, 135);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(158, 26);
            this.tbUsuario.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.botaoConectar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.nomeProjeto);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label nomeProjeto;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button botaoConectar;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
    }
}

