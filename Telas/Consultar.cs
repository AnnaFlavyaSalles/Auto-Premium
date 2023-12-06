using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoPremium.Telas
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_fechar.FlatAppearance.BorderSize = 0;
            botao_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_fechar.BackColor = Color.Transparent;
            botao_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_voltar.FlatAppearance.BorderSize = 0;
            botao_voltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_voltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_voltar.BackColor = Color.Transparent;
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

        private void botao_voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Dispose();
            menu.Show();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            using (var conexao = new MySqlConnection("server=localhost;uid=root;pwd=root;database=auto_premium_bd"))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM veiculo";
                    using (var comando = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        comando.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            InfGerais cadastro = new InfGerais();
            this.Dispose();
            cadastro.Show();
        }
    }
}
