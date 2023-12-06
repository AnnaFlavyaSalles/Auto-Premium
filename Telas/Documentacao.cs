using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoPremium.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoPremium.Telas
{
    public partial class Documentacao : Form
    {
        public Documentacao()
        {
            InitializeComponent();
            botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_fechar.FlatAppearance.BorderSize = 0;
            botao_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_fechar.BackColor = Color.Transparent;
            botao_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_salvar.FlatAppearance.BorderSize = 0;
            botao_salvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_salvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_salvar.BackColor = Color.Transparent;
            botao_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_limpar.FlatAppearance.BorderSize = 0;
            botao_limpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_limpar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_limpar.BackColor = Color.Transparent;
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botao_salvar_Click(object sender, EventArgs e)
        {
            InfGerais Documentacao = Application.OpenForms.OfType<InfGerais>().FirstOrDefault();

            Documentacao.VeiculoAtual.renavam = tb_renavam.Text;
            Documentacao.VeiculoAtual.placa = tb_placa.Text;
            Documentacao.VeiculoAtual.dataLicenciamento = Convert.ToDateTime(dTP_dataLicenciamento.Text);
            Documentacao.VeiculoAtual.dataUltimaInspecao = Convert.ToDateTime(dTP_dataUltimaInspecao.Text);

            if (VerificarCampos())
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir();
            }
        }

        private void tb_renavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && tb_renavam.Text.Length == 9 || tb_renavam.Text.Length == 11)
            {
                e.Handled = true;
            }
        }

        void Inserir()
        {
            InfGerais veiculo = Application.OpenForms.OfType<InfGerais>().FirstOrDefault();

            if (veiculo != null)
            {
                string marca = veiculo.VeiculoAtual.marca;
                string modelo = veiculo.VeiculoAtual.modelo;
                int anoFab = veiculo.VeiculoAtual.anoFab;
                int anoMod = veiculo.VeiculoAtual.anoMod;
                string tipoCarroceria = veiculo.VeiculoAtual.tipoCarroceria;
                int numPortas = veiculo.VeiculoAtual.numPortas;
                string cor = veiculo.VeiculoAtual.cor;
                string chassi = veiculo.VeiculoAtual.chassi;
                string motor = veiculo.VeiculoAtual.motor;
                string tipoCombustivel = veiculo.VeiculoAtual.tipoCombustivel;
                double capacidadeTanque = veiculo.VeiculoAtual.capacidadeTanque;
                double potencia = veiculo.VeiculoAtual.potencia;
                string transmissao = veiculo.VeiculoAtual.transmissao;
                string tracao = veiculo.VeiculoAtual.tracao;
                string renavam = veiculo.VeiculoAtual.renavam;
                string placa = veiculo.VeiculoAtual.placa;
                DateTime dataLicenciamento = veiculo.VeiculoAtual.dataLicenciamento;
                DateTime dataUltimaInspecao = veiculo.VeiculoAtual.dataUltimaInspecao;

                try
                {
                    Conexao conexao = new Conexao();

                    var comando = conexao.Comando("INSERT INTO veiculo (id_vei, marca_vei, modelo_vei, ano_fabricacao_vei, ano_modelo_vei, numero_portas_vei, tipo_carroceria_vei,  cor_vei," +
                        " numero_chassi_vei, numero_motor_vei, tipo_combustivel_vei, capacidade_motor_vei, potencia_motor_vei, transmissao_vei, tipo_tracao_vei, renavam_vei, numero_placa_vei, data_licenciamente_vei," +
                        " data_ultima_inspecao_vei) VALUES (null ,@marca, @modelo, @ano_fab, @ano_mod, @num_portas, @tipo_carroceria, @cor, @chassi," +
                        " @motor, @tipo_combustivel, @capacidade_tanque, @potencia, @transmissao, @tracao, @renavam, @placa, @data_licenciamento," +
                        " @data_ultima_inspecao)");

                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@modelo", modelo);
                    comando.Parameters.AddWithValue("@ano_fab", anoFab);
                    comando.Parameters.AddWithValue("@ano_mod", anoMod);
                    comando.Parameters.AddWithValue("@tipo_carroceria", tipoCarroceria);
                    comando.Parameters.AddWithValue("@num_portas", numPortas);
                    comando.Parameters.AddWithValue("@cor", cor);
                    comando.Parameters.AddWithValue("@chassi", chassi);
                    comando.Parameters.AddWithValue("@motor", motor);
                    comando.Parameters.AddWithValue("@tipo_combustivel", tipoCombustivel);
                    comando.Parameters.AddWithValue("@capacidade_tanque", capacidadeTanque);
                    comando.Parameters.AddWithValue("@potencia", potencia);
                    comando.Parameters.AddWithValue("@transmissao", transmissao);
                    comando.Parameters.AddWithValue("@tracao", tracao);
                    comando.Parameters.AddWithValue("@renavam", renavam);
                    comando.Parameters.AddWithValue("@placa", placa);
                    comando.Parameters.AddWithValue("@data_licenciamento", dataLicenciamento);
                    comando.Parameters.AddWithValue("@data_ultima_inspecao", dataUltimaInspecao);

                    var resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Veículo cadastrado!!!");
                    }

                    LimparTextBoxs();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void LimparTextBoxs()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is System.Windows.Forms.TextBox)
                {
                    (ctr as System.Windows.Forms.TextBox).Text = string.Empty;
                }
            }
        }
        private bool VerificarCampos()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is System.Windows.Forms.TextBox || ctr is System.Windows.Forms.MaskedTextBox)
                {
                    var text = ctr.Text.Replace(",", "").Replace("-", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }   
    }
}
