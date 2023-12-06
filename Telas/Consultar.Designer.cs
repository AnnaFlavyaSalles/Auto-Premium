namespace AutoPremium.Telas
{
    partial class Consultar
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
            botao_cadastrar = new Button();
            botao_voltar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(677, 8);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(39, 36);
            botao_fechar.TabIndex = 1;
            botao_fechar.UseVisualStyleBackColor = true;
            botao_fechar.Click += botao_fechar_Click;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Cursor = Cursors.Hand;
            botao_cadastrar.Location = new Point(580, 367);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(134, 43);
            botao_cadastrar.TabIndex = 3;
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // botao_voltar
            // 
            botao_voltar.Cursor = Cursors.Hand;
            botao_voltar.Location = new Point(12, 367);
            botao_voltar.Name = "botao_voltar";
            botao_voltar.Size = new Size(134, 43);
            botao_voltar.TabIndex = 4;
            botao_voltar.UseVisualStyleBackColor = true;
            botao_voltar.Click += botao_voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(702, 259);
            dataGridView1.TabIndex = 5;
            // 
            // Consultar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Consultar_carro;
            ClientSize = new Size(726, 429);
            Controls.Add(dataGridView1);
            Controls.Add(botao_voltar);
            Controls.Add(botao_cadastrar);
            Controls.Add(botao_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultar";
            Text = "Consultar";
            Load += Consultar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botao_fechar;
        private Button botao_cadastrar;
        private Button botao_voltar;
        private DataGridView dataGridView1;
    }
}