
namespace HoraRemedio
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alarme = new System.Windows.Forms.Button();
            this.agenda = new System.Windows.Forms.Button();
            this.Configuração = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HoraRemedio.Properties.Resources.Hora_do_Remédio___Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraftia", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // alarme
            // 
            this.alarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarme.Location = new System.Drawing.Point(127, 191);
            this.alarme.Name = "alarme";
            this.alarme.Size = new System.Drawing.Size(442, 106);
            this.alarme.TabIndex = 2;
            this.alarme.Text = "Alarme";
            this.alarme.UseVisualStyleBackColor = true;
            // 
            // agenda
            // 
            this.agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agenda.Location = new System.Drawing.Point(127, 323);
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(442, 106);
            this.agenda.TabIndex = 3;
            this.agenda.Text = "Agenda";
            this.agenda.UseVisualStyleBackColor = true;
            this.agenda.Click += new System.EventHandler(this.button2_Click);
            // 
            // Configuração
            // 
            this.Configuração.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuração.Location = new System.Drawing.Point(179, 133);
            this.Configuração.Name = "Configuração";
            this.Configuração.Size = new System.Drawing.Size(148, 29);
            this.Configuração.TabIndex = 4;
            this.Configuração.Text = "Configurações";
            this.Configuração.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Configuração);
            this.Controls.Add(this.agenda);
            this.Controls.Add(this.alarme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Nome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alarme;
        private System.Windows.Forms.Button agenda;
        private System.Windows.Forms.Button Configuração;
    }
}