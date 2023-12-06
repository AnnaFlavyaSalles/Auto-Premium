using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoPremium.Telas
{
    public partial class InfTecnicas : Form
    {
        public InfTecnicas()
        {
            InitializeComponent();
            botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_fechar.FlatAppearance.BorderSize = 0;
            botao_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_fechar.BackColor = Color.Transparent;
            botao_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_proximo.FlatAppearance.BorderSize = 0;
            botao_proximo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_proximo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_proximo.BackColor = Color.Transparent;
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

        private void botao_proximo_Click(object sender, EventArgs e)
        {
            InfGerais infTecnicas = Application.OpenForms.OfType<InfGerais>().FirstOrDefault();

            infTecnicas.VeiculoAtual.chassi = tb_numChassi.Text;
            infTecnicas.VeiculoAtual.motor = tb_numMotor.Text;

            switch (true)
            {
                case true when rb_gasolina.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "Gasolina";
                    break;
                case true when rb_diesel.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "Diesel";
                    break;
                case true when rb_etanol.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "Etanol";
                    break;
                case true when rb_biodiesel.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "Biodiesel";
                    break;
                case true when rb_gnv.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "GNV";
                    break;
                case true when rb_eletricidade.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "Elétrico";
                    break;
                case true when rb_hidrogenio.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "Hidrogênio";
                    break;
                case true when rb_glp.Checked:
                    infTecnicas.VeiculoAtual.tipoCombustivel = "GLP";
                    break;
            }

            infTecnicas.VeiculoAtual.capacidadeTanque = Convert.ToDouble(tb_capacidade.Text);

            switch (true)
            {
                case true when rb_1_0.Checked:
                    infTecnicas.VeiculoAtual.potencia = 1;
                    break;
                case true when rb_1_3.Checked:
                    infTecnicas.VeiculoAtual.potencia = 1.3;
                    break;
                case true when rb_1_4.Checked:
                    infTecnicas.VeiculoAtual.potencia = 1.4;
                    break;
                case true when rb_2_0.Checked:
                    infTecnicas.VeiculoAtual.potencia = 2.0;
                    break;
                case true when rb_2_2.Checked:
                    infTecnicas.VeiculoAtual.potencia = 2.2;
                    break;
                case true when rb_2_8.Checked:
                    infTecnicas.VeiculoAtual.potencia = 2.8;
                    break;
                case true when rb_3_2.Checked:
                    infTecnicas.VeiculoAtual.potencia = 3.2;
                    break;
                default:
                    MessageBox.Show("Selecione a potência do motor!!");
                    break;
            }

            switch (true)
            {
                case true when rb_manual.Checked:
                    infTecnicas.VeiculoAtual.transmissao = "Manual";
                    break;
                case true when rb_automatica.Checked:
                    infTecnicas.VeiculoAtual.transmissao = "Automática";
                    break;
                default:
                    MessageBox.Show("Selecione o tipo de transmissão!!");
                    break;
            }

            switch (true)
            {
                case true when rb_dianteira.Checked:
                    infTecnicas.VeiculoAtual.tracao = "Dianteira";
                    break;
                case true when rb_traseira.Checked:
                    infTecnicas.VeiculoAtual.tracao = "Traseira";
                    break;
                case true when rb_integral.Checked:
                    infTecnicas.VeiculoAtual.tracao = "Integral";
                    break;
                case true when rb_4x4.Checked:
                    infTecnicas.VeiculoAtual.tracao = "4x4";
                    break;
                default:
                    MessageBox.Show("Selecione o tipo de tração!!");
                    break;
            }

            var documentacaoForm = new Documentacao();
            documentacaoForm.Show();
            this.Hide();
        }

        private void tb_numChassi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && tb_numChassi.Text.Length == 17)
            {
                e.Handled = true;
            }
        }

        private void tb_numMotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && tb_numMotor.Text.Length >= 6 && tb_numMotor.Text.Length <=10)
            {
                e.Handled = true;
            }
        }
    }
}
