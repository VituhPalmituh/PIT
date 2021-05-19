
namespace HoraRemedio
{
    partial class FormCadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.nome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraftia", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::HoraRemedio.Properties.Resources.Hora_do_Remédio___Logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Minecraftia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(181, 174);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(89, 34);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(276, 182);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(295, 26);
            this.tbNome.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Minecraftia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(164, 208);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(106, 34);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(276, 216);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(295, 26);
            this.tbSenha.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(318, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(276, 150);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(295, 26);
            this.tbUsuario.TabIndex = 8;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Minecraftia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(141, 143);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(129, 34);
            this.lbUsuario.TabIndex = 7;
            this.lbUsuario.Text = "Usuário:";
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbUsuario;
    }
}