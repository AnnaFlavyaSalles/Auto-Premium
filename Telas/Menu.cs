using AutoPremium.Telas;

namespace AutoPremium
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_fechar.FlatAppearance.BorderSize = 0;
            botao_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_fechar.BackColor = Color.Transparent;
            botao_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_consultar.FlatAppearance.BorderSize = 0;
            botao_consultar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_consultar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_consultar.BackColor = Color.Transparent;
            botao_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_cadastrar.FlatAppearance.BorderSize = 0;
            botao_cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_cadastrar.BackColor = Color.Transparent;
        }
        private void botao_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botao_cadastrar_Click_1(object sender, EventArgs e)
        {
            InfGerais cadastrar = new InfGerais();
            this.Hide();
            cadastrar.Show();
        }

        private void botao_consultar_Click_1(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.Show();
        }
    }
}
