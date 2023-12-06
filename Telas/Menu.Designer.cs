namespace AutoPremium
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botao_fechar = new Button();
            botao_consultar = new Button();
            botao_cadastrar = new Button();
            SuspendLayout();
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(677, 9);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(39, 36);
            botao_fechar.TabIndex = 0;
            botao_fechar.UseVisualStyleBackColor = true;
            botao_fechar.Click += botao_fechar_Click;
            // 
            // botao_consultar
            // 
            botao_consultar.Cursor = Cursors.Hand;
            botao_consultar.Location = new Point(284, 150);
            botao_consultar.Name = "botao_consultar";
            botao_consultar.Size = new Size(157, 57);
            botao_consultar.TabIndex = 1;
            botao_consultar.UseVisualStyleBackColor = true;
            botao_consultar.Click += botao_consultar_Click_1;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Cursor = Cursors.Hand;
            botao_cadastrar.Location = new Point(284, 276);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(157, 57);
            botao_cadastrar.TabIndex = 2;
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Menu;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(722, 428);
            Controls.Add(botao_cadastrar);
            Controls.Add(botao_consultar);
            Controls.Add(botao_fechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botao_fechar;
        private Button botao_consultar;
        private Button botao_cadastrar;
    }
}
