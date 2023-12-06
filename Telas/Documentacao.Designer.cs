namespace AutoPremium.Telas
{
    partial class Documentacao
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
            botao_salvar = new Button();
            tb_renavam = new TextBox();
            tb_placa = new TextBox();
            dTP_dataLicenciamento = new DateTimePicker();
            dTP_dataUltimaInspecao = new DateTimePicker();
            SuspendLayout();
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(677, 8);
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
            // botao_salvar
            // 
            botao_salvar.Cursor = Cursors.Hand;
            botao_salvar.Location = new Point(580, 372);
            botao_salvar.Name = "botao_salvar";
            botao_salvar.Size = new Size(132, 37);
            botao_salvar.TabIndex = 4;
            botao_salvar.UseVisualStyleBackColor = true;
            botao_salvar.Click += botao_salvar_Click;
            // 
            // tb_renavam
            // 
            tb_renavam.BorderStyle = BorderStyle.None;
            tb_renavam.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_renavam.Location = new Point(12, 123);
            tb_renavam.Name = "tb_renavam";
            tb_renavam.Size = new Size(315, 23);
            tb_renavam.TabIndex = 5;
            tb_renavam.KeyPress += tb_renavam_KeyPress;
            // 
            // tb_placa
            // 
            tb_placa.BorderStyle = BorderStyle.None;
            tb_placa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_placa.Location = new Point(396, 123);
            tb_placa.Name = "tb_placa";
            tb_placa.Size = new Size(315, 23);
            tb_placa.TabIndex = 6;
            // 
            // dTP_dataLicenciamento
            // 
            dTP_dataLicenciamento.CalendarMonthBackground = Color.Transparent;
            dTP_dataLicenciamento.Location = new Point(12, 171);
            dTP_dataLicenciamento.Name = "dTP_dataLicenciamento";
            dTP_dataLicenciamento.Size = new Size(315, 27);
            dTP_dataLicenciamento.TabIndex = 7;
            // 
            // dTP_dataUltimaInspecao
            // 
            dTP_dataUltimaInspecao.CalendarMonthBackground = Color.Transparent;
            dTP_dataUltimaInspecao.Location = new Point(396, 171);
            dTP_dataUltimaInspecao.Name = "dTP_dataUltimaInspecao";
            dTP_dataUltimaInspecao.Size = new Size(315, 27);
            dTP_dataUltimaInspecao.TabIndex = 8;
            // 
            // Documentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cadastro_carro_pt3;
            ClientSize = new Size(724, 428);
            Controls.Add(dTP_dataUltimaInspecao);
            Controls.Add(dTP_dataLicenciamento);
            Controls.Add(tb_placa);
            Controls.Add(tb_renavam);
            Controls.Add(botao_salvar);
            Controls.Add(botao_limpar);
            Controls.Add(botao_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Documentacao";
            Text = "Documentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_fechar;
        private Button botao_limpar;
        private Button botao_salvar;
        private TextBox tb_renavam;
        private TextBox tb_placa;
        private DateTimePicker dTP_dataLicenciamento;
        private DateTimePicker dTP_dataUltimaInspecao;
    }
}