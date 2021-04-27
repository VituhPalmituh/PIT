
namespace HoraRemedio
{
    partial class Form1
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
            this.cpf = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.botaoConectar = new System.Windows.Forms.Button();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
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
            // cpf
            // 
            this.cpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Minecraftia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(244, 170);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(72, 34);
            this.cpf.TabIndex = 2;
            this.cpf.Text = "CPF:";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCpf.Location = new System.Drawing.Point(308, 173);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(158, 26);
            this.textBoxCpf.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.botaoConectar);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.nomeProjeto);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label nomeProjeto;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Button botaoConectar;
        private System.Windows.Forms.Button botaoCadastrar;
    }
}

