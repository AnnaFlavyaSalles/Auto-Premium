namespace AutoPremium.Telas
{
    partial class InfTecnicas
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
            botao_fechar = new Button();
            botao_limpar = new Button();
            botao_proximo = new Button();
            tb_numChassi = new TextBox();
            tb_numMotor = new TextBox();
            tb_capacidade = new TextBox();
            rb_gasolina = new RadioButton();
            rb_diesel = new RadioButton();
            rb_etanol = new RadioButton();
            rb_biodiesel = new RadioButton();
            rb_gnv = new RadioButton();
            rb_eletricidade = new RadioButton();
            rb_hidrogenio = new RadioButton();
            rb_glp = new RadioButton();
            rb_1_0 = new RadioButton();
            rb_1_3 = new RadioButton();
            rb_1_4 = new RadioButton();
            rb_2_0 = new RadioButton();
            rb_2_2 = new RadioButton();
            rb_2_8 = new RadioButton();
            rb_3_2 = new RadioButton();
            rb_automatica = new RadioButton();
            rb_manual = new RadioButton();
            rb_dianteira = new RadioButton();
            rb_traseira = new RadioButton();
            rb_integral = new RadioButton();
            rb_4x4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(676, 8);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(39, 36);
            botao_fechar.TabIndex = 2;
            botao_fechar.UseVisualStyleBackColor = true;
            botao_fechar.Click += botao_fechar_Click;
            // 
            // botao_limpar
            // 
            botao_limpar.Cursor = Cursors.Hand;
            botao_limpar.Location = new Point(12, 372);
            botao_limpar.Name = "botao_limpar";
            botao_limpar.Size = new Size(131, 37);
            botao_limpar.TabIndex = 3;
            botao_limpar.UseVisualStyleBackColor = true;
            // 
            // botao_proximo
            // 
            botao_proximo.Cursor = Cursors.Hand;
            botao_proximo.Location = new Point(583, 372);
            botao_proximo.Name = "botao_proximo";
            botao_proximo.Size = new Size(132, 37);
            botao_proximo.TabIndex = 4;
            botao_proximo.UseVisualStyleBackColor = true;
            botao_proximo.Click += botao_proximo_Click;
            // 
            // tb_numChassi
            // 
            tb_numChassi.BorderStyle = BorderStyle.None;
            tb_numChassi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numChassi.Location = new Point(12, 123);
            tb_numChassi.Name = "tb_numChassi";
            tb_numChassi.Size = new Size(315, 23);
            tb_numChassi.TabIndex = 5;
            tb_numChassi.KeyPress += tb_numChassi_KeyPress;
            // 
            // tb_numMotor
            // 
            tb_numMotor.BorderStyle = BorderStyle.None;
            tb_numMotor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numMotor.Location = new Point(395, 123);
            tb_numMotor.Name = "tb_numMotor";
            tb_numMotor.Size = new Size(315, 23);
            tb_numMotor.TabIndex = 6;
            tb_numMotor.KeyPress += tb_numMotor_KeyPress;
            // 
            // tb_capacidade
            // 
            tb_capacidade.BorderStyle = BorderStyle.None;
            tb_capacidade.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_capacidade.Location = new Point(395, 173);
            tb_capacidade.Name = "tb_capacidade";
            tb_capacidade.Size = new Size(315, 23);
            tb_capacidade.TabIndex = 7;
            // 
            // rb_gasolina
            // 
            rb_gasolina.AutoSize = true;
            rb_gasolina.BackColor = Color.Transparent;
            rb_gasolina.ForeColor = SystemColors.Window;
            rb_gasolina.Location = new Point(6, 13);
            rb_gasolina.Name = "rb_gasolina";
            rb_gasolina.Size = new Size(87, 24);
            rb_gasolina.TabIndex = 10;
            rb_gasolina.TabStop = true;
            rb_gasolina.Text = "Gasolina";
            rb_gasolina.UseVisualStyleBackColor = false;
            // 
            // rb_diesel
            // 
            rb_diesel.AutoSize = true;
            rb_diesel.BackColor = Color.Transparent;
            rb_diesel.ForeColor = SystemColors.Window;
            rb_diesel.Location = new Point(99, 13);
            rb_diesel.Name = "rb_diesel";
            rb_diesel.Size = new Size(71, 24);
            rb_diesel.TabIndex = 11;
            rb_diesel.TabStop = true;
            rb_diesel.Text = "Diesel";
            rb_diesel.UseVisualStyleBackColor = false;
            // 
            // rb_etanol
            // 
            rb_etanol.AutoSize = true;
            rb_etanol.BackColor = Color.Transparent;
            rb_etanol.ForeColor = SystemColors.Window;
            rb_etanol.Location = new Point(176, 13);
            rb_etanol.Name = "rb_etanol";
            rb_etanol.Size = new Size(72, 24);
            rb_etanol.TabIndex = 12;
            rb_etanol.TabStop = true;
            rb_etanol.Text = "Etanol";
            rb_etanol.UseVisualStyleBackColor = false;
            // 
            // rb_biodiesel
            // 
            rb_biodiesel.AutoSize = true;
            rb_biodiesel.BackColor = Color.Transparent;
            rb_biodiesel.ForeColor = SystemColors.Window;
            rb_biodiesel.Location = new Point(251, 12);
            rb_biodiesel.Name = "rb_biodiesel";
            rb_biodiesel.Size = new Size(91, 24);
            rb_biodiesel.TabIndex = 13;
            rb_biodiesel.TabStop = true;
            rb_biodiesel.Text = "Biodiesel";
            rb_biodiesel.UseVisualStyleBackColor = false;
            // 
            // rb_gnv
            // 
            rb_gnv.AutoSize = true;
            rb_gnv.BackColor = Color.Transparent;
            rb_gnv.ForeColor = SystemColors.Window;
            rb_gnv.Location = new Point(6, 43);
            rb_gnv.Name = "rb_gnv";
            rb_gnv.Size = new Size(60, 24);
            rb_gnv.TabIndex = 14;
            rb_gnv.TabStop = true;
            rb_gnv.Text = "GNV";
            rb_gnv.UseVisualStyleBackColor = false;
            // 
            // rb_eletricidade
            // 
            rb_eletricidade.AutoSize = true;
            rb_eletricidade.BackColor = Color.Transparent;
            rb_eletricidade.ForeColor = SystemColors.Window;
            rb_eletricidade.Location = new Point(72, 43);
            rb_eletricidade.Name = "rb_eletricidade";
            rb_eletricidade.Size = new Size(109, 24);
            rb_eletricidade.TabIndex = 15;
            rb_eletricidade.TabStop = true;
            rb_eletricidade.Text = "Eletricidade";
            rb_eletricidade.UseVisualStyleBackColor = false;
            // 
            // rb_hidrogenio
            // 
            rb_hidrogenio.AutoSize = true;
            rb_hidrogenio.BackColor = Color.Transparent;
            rb_hidrogenio.ForeColor = SystemColors.Window;
            rb_hidrogenio.Location = new Point(187, 42);
            rb_hidrogenio.Name = "rb_hidrogenio";
            rb_hidrogenio.Size = new Size(106, 24);
            rb_hidrogenio.TabIndex = 16;
            rb_hidrogenio.TabStop = true;
            rb_hidrogenio.Text = "Hidrogênio";
            rb_hidrogenio.UseVisualStyleBackColor = false;
            // 
            // rb_glp
            // 
            rb_glp.AutoSize = true;
            rb_glp.BackColor = Color.Transparent;
            rb_glp.ForeColor = SystemColors.Window;
            rb_glp.Location = new Point(293, 42);
            rb_glp.Name = "rb_glp";
            rb_glp.Size = new Size(55, 24);
            rb_glp.TabIndex = 17;
            rb_glp.TabStop = true;
            rb_glp.Text = "GLP";
            rb_glp.UseVisualStyleBackColor = false;
            // 
            // rb_1_0
            // 
            rb_1_0.AutoSize = true;
            rb_1_0.BackColor = Color.Transparent;
            rb_1_0.ForeColor = SystemColors.Window;
            rb_1_0.Location = new Point(3, 10);
            rb_1_0.Name = "rb_1_0";
            rb_1_0.Size = new Size(49, 24);
            rb_1_0.TabIndex = 18;
            rb_1_0.TabStop = true;
            rb_1_0.Text = "1.0";
            rb_1_0.UseVisualStyleBackColor = false;
            // 
            // rb_1_3
            // 
            rb_1_3.AutoSize = true;
            rb_1_3.BackColor = Color.Transparent;
            rb_1_3.ForeColor = SystemColors.Window;
            rb_1_3.Location = new Point(58, 10);
            rb_1_3.Name = "rb_1_3";
            rb_1_3.Size = new Size(49, 24);
            rb_1_3.TabIndex = 19;
            rb_1_3.TabStop = true;
            rb_1_3.Text = "1.3";
            rb_1_3.UseVisualStyleBackColor = false;
            // 
            // rb_1_4
            // 
            rb_1_4.AutoSize = true;
            rb_1_4.BackColor = Color.Transparent;
            rb_1_4.ForeColor = SystemColors.Window;
            rb_1_4.Location = new Point(113, 10);
            rb_1_4.Name = "rb_1_4";
            rb_1_4.Size = new Size(49, 24);
            rb_1_4.TabIndex = 20;
            rb_1_4.TabStop = true;
            rb_1_4.Text = "1.4";
            rb_1_4.UseVisualStyleBackColor = false;
            // 
            // rb_2_0
            // 
            rb_2_0.AutoSize = true;
            rb_2_0.BackColor = Color.Transparent;
            rb_2_0.ForeColor = SystemColors.Window;
            rb_2_0.Location = new Point(168, 10);
            rb_2_0.Name = "rb_2_0";
            rb_2_0.Size = new Size(49, 24);
            rb_2_0.TabIndex = 21;
            rb_2_0.TabStop = true;
            rb_2_0.Text = "2.0";
            rb_2_0.UseVisualStyleBackColor = false;
            // 
            // rb_2_2
            // 
            rb_2_2.AutoSize = true;
            rb_2_2.BackColor = Color.Transparent;
            rb_2_2.ForeColor = SystemColors.Window;
            rb_2_2.Location = new Point(223, 10);
            rb_2_2.Name = "rb_2_2";
            rb_2_2.Size = new Size(49, 24);
            rb_2_2.TabIndex = 22;
            rb_2_2.TabStop = true;
            rb_2_2.Text = "2.2";
            rb_2_2.UseVisualStyleBackColor = false;
            // 
            // rb_2_8
            // 
            rb_2_8.AutoSize = true;
            rb_2_8.BackColor = Color.Transparent;
            rb_2_8.ForeColor = SystemColors.Window;
            rb_2_8.Location = new Point(3, 31);
            rb_2_8.Name = "rb_2_8";
            rb_2_8.Size = new Size(49, 24);
            rb_2_8.TabIndex = 23;
            rb_2_8.TabStop = true;
            rb_2_8.Text = "2.8";
            rb_2_8.UseVisualStyleBackColor = false;
            // 
            // rb_3_2
            // 
            rb_3_2.AutoSize = true;
            rb_3_2.BackColor = Color.Transparent;
            rb_3_2.ForeColor = SystemColors.Window;
            rb_3_2.Location = new Point(58, 31);
            rb_3_2.Name = "rb_3_2";
            rb_3_2.Size = new Size(49, 24);
            rb_3_2.TabIndex = 24;
            rb_3_2.TabStop = true;
            rb_3_2.Text = "3.2";
            rb_3_2.UseVisualStyleBackColor = false;
            // 
            // rb_automatica
            // 
            rb_automatica.AutoSize = true;
            rb_automatica.BackColor = Color.Transparent;
            rb_automatica.ForeColor = SystemColors.Window;
            rb_automatica.Location = new Point(4, 11);
            rb_automatica.Name = "rb_automatica";
            rb_automatica.Size = new Size(107, 24);
            rb_automatica.TabIndex = 25;
            rb_automatica.TabStop = true;
            rb_automatica.Text = "Automática";
            rb_automatica.UseVisualStyleBackColor = false;
            // 
            // rb_manual
            // 
            rb_manual.AutoSize = true;
            rb_manual.BackColor = Color.Transparent;
            rb_manual.ForeColor = SystemColors.Window;
            rb_manual.Location = new Point(4, 30);
            rb_manual.Name = "rb_manual";
            rb_manual.Size = new Size(79, 24);
            rb_manual.TabIndex = 26;
            rb_manual.TabStop = true;
            rb_manual.Text = "Manual";
            rb_manual.UseVisualStyleBackColor = false;
            // 
            // rb_dianteira
            // 
            rb_dianteira.AutoSize = true;
            rb_dianteira.BackColor = Color.Transparent;
            rb_dianteira.ForeColor = SystemColors.Window;
            rb_dianteira.Location = new Point(4, 10);
            rb_dianteira.Name = "rb_dianteira";
            rb_dianteira.Size = new Size(91, 24);
            rb_dianteira.TabIndex = 27;
            rb_dianteira.TabStop = true;
            rb_dianteira.Text = "Dianteira";
            rb_dianteira.UseVisualStyleBackColor = false;
            // 
            // rb_traseira
            // 
            rb_traseira.AutoSize = true;
            rb_traseira.BackColor = Color.Transparent;
            rb_traseira.ForeColor = SystemColors.Window;
            rb_traseira.Location = new Point(99, 10);
            rb_traseira.Name = "rb_traseira";
            rb_traseira.Size = new Size(81, 24);
            rb_traseira.TabIndex = 28;
            rb_traseira.TabStop = true;
            rb_traseira.Text = "Traseira";
            rb_traseira.UseVisualStyleBackColor = false;
            // 
            // rb_integral
            // 
            rb_integral.AutoSize = true;
            rb_integral.BackColor = Color.Transparent;
            rb_integral.ForeColor = SystemColors.Window;
            rb_integral.Location = new Point(4, 29);
            rb_integral.Name = "rb_integral";
            rb_integral.Size = new Size(81, 24);
            rb_integral.TabIndex = 29;
            rb_integral.TabStop = true;
            rb_integral.Text = "Integral";
            rb_integral.UseVisualStyleBackColor = false;
            // 
            // rb_4x4
            // 
            rb_4x4.AutoSize = true;
            rb_4x4.BackColor = Color.Transparent;
            rb_4x4.ForeColor = SystemColors.Window;
            rb_4x4.Location = new Point(99, 29);
            rb_4x4.Name = "rb_4x4";
            rb_4x4.Size = new Size(55, 24);
            rb_4x4.TabIndex = 30;
            rb_4x4.TabStop = true;
            rb_4x4.Text = "4X4";
            rb_4x4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rb_gasolina);
            groupBox1.Controls.Add(rb_diesel);
            groupBox1.Controls.Add(rb_etanol);
            groupBox1.Controls.Add(rb_biodiesel);
            groupBox1.Controls.Add(rb_gnv);
            groupBox1.Controls.Add(rb_eletricidade);
            groupBox1.Controls.Add(rb_hidrogenio);
            groupBox1.Controls.Add(rb_glp);
            groupBox1.ForeColor = Color.Transparent;
            groupBox1.Location = new Point(9, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 72);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(rb_1_0);
            groupBox2.Controls.Add(rb_1_3);
            groupBox2.Controls.Add(rb_1_4);
            groupBox2.Controls.Add(rb_2_0);
            groupBox2.Controls.Add(rb_2_2);
            groupBox2.Controls.Add(rb_2_8);
            groupBox2.Controls.Add(rb_3_2);
            groupBox2.ForeColor = Color.Transparent;
            groupBox2.Location = new Point(9, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 53);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(rb_automatica);
            groupBox3.Controls.Add(rb_manual);
            groupBox3.ForeColor = Color.Transparent;
            groupBox3.Location = new Point(395, 242);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 54);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(rb_dianteira);
            groupBox4.Controls.Add(rb_traseira);
            groupBox4.Controls.Add(rb_integral);
            groupBox4.Controls.Add(rb_4x4);
            groupBox4.ForeColor = Color.Transparent;
            groupBox4.Location = new Point(9, 300);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 53);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            // 
            // InfTecnicas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cadastro_carro_pt2;
            ClientSize = new Size(727, 430);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tb_capacidade);
            Controls.Add(tb_numMotor);
            Controls.Add(tb_numChassi);
            Controls.Add(botao_proximo);
            Controls.Add(botao_limpar);
            Controls.Add(botao_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfTecnicas";
            Text = "InfTecnicas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_fechar;
        private Button botao_limpar;
        private Button botao_proximo;
        private TextBox tb_numChassi;
        private TextBox tb_numMotor;
        private TextBox tb_capacidade;
        private RadioButton rb_gasolina;
        private RadioButton rb_diesel;
        private RadioButton rb_etanol;
        private RadioButton rb_biodiesel;
        private RadioButton rb_gnv;
        private RadioButton rb_eletricidade;
        private RadioButton rb_hidrogenio;
        private RadioButton rb_glp;
        private RadioButton rb_1_0;
        private RadioButton rb_1_3;
        private RadioButton rb_1_4;
        private RadioButton rb_2_0;
        private RadioButton rb_2_2;
        private RadioButton rb_2_8;
        private RadioButton rb_3_2;
        private RadioButton rb_automatica;
        private RadioButton rb_manual;
        private RadioButton rb_dianteira;
        private RadioButton rb_traseira;
        private RadioButton rb_integral;
        private RadioButton rb_4x4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}