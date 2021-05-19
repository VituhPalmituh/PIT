
namespace HoraRemedio
{
    partial class FormAgenda
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
            this.LbAgenda = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.clbAgenda = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numDia = new System.Windows.Forms.NumericUpDown();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.numMinuto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvarDia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuto)).BeginInit();
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
            // LbAgenda
            // 
            this.LbAgenda.AutoSize = true;
            this.LbAgenda.Font = new System.Drawing.Font("Minecraftia", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAgenda.Location = new System.Drawing.Point(168, 12);
            this.LbAgenda.Name = "LbAgenda";
            this.LbAgenda.Size = new System.Drawing.Size(220, 65);
            this.LbAgenda.TabIndex = 1;
            this.LbAgenda.Text = "Agenda";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(617, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // clbAgenda
            // 
            this.clbAgenda.FormattingEnabled = true;
            this.clbAgenda.Location = new System.Drawing.Point(318, 80);
            this.clbAgenda.Name = "clbAgenda";
            this.clbAgenda.Size = new System.Drawing.Size(374, 304);
            this.clbAgenda.TabIndex = 3;
            this.clbAgenda.SelectedIndexChanged += new System.EventHandler(this.clbAgenda_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover Dia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numDia
            // 
            this.numDia.Location = new System.Drawing.Point(12, 193);
            this.numDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDia.Name = "numDia";
            this.numDia.Size = new System.Drawing.Size(44, 20);
            this.numDia.TabIndex = 5;
            this.numDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMes
            // 
            this.numMes.Location = new System.Drawing.Point(62, 193);
            this.numMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMes.Name = "numMes";
            this.numMes.Size = new System.Drawing.Size(44, 20);
            this.numMes.TabIndex = 6;
            this.numMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(112, 193);
            this.numAno.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(44, 20);
            this.numAno.TabIndex = 7;
            this.numAno.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mês:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ano:";
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(12, 236);
            this.numHora.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numHora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(64, 20);
            this.numHora.TabIndex = 11;
            this.numHora.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMinuto
            // 
            this.numMinuto.Location = new System.Drawing.Point(82, 236);
            this.numMinuto.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMinuto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinuto.Name = "numMinuto";
            this.numMinuto.Size = new System.Drawing.Size(74, 20);
            this.numMinuto.TabIndex = 12;
            this.numMinuto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Minuto:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(12, 308);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(150, 26);
            this.tbDescricao.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descrição:";
            // 
            // btnSalvarDia
            // 
            this.btnSalvarDia.Location = new System.Drawing.Point(12, 377);
            this.btnSalvarDia.Name = "btnSalvarDia";
            this.btnSalvarDia.Size = new System.Drawing.Size(122, 43);
            this.btnSalvarDia.TabIndex = 22;
            this.btnSalvarDia.Text = "Salvar dia";
            this.btnSalvarDia.UseVisualStyleBackColor = true;
            this.btnSalvarDia.Click += new System.EventHandler(this.btnSalvarDia_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnSalvarDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMinuto);
            this.Controls.Add(this.numHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.numMes);
            this.Controls.Add(this.numDia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clbAgenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.LbAgenda);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbAgenda;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckedListBox clbAgenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numDia;
        private System.Windows.Forms.NumericUpDown numMes;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.NumericUpDown numMinuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvarDia;
    }
}