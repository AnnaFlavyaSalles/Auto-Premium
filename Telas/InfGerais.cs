using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPremium.Telas
{
    public partial class InfGerais : Form
    {
        public Veiculo VeiculoAtual { get; set; } = new Veiculo();
        public InfGerais()
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
            InfGerais infGerais = Application.OpenForms.OfType<InfGerais>().FirstOrDefault();

            infGerais.VeiculoAtual.marca = tb_marcaVei.Text;
            infGerais.VeiculoAtual.modelo = tb_modeloVei.Text;
            infGerais.VeiculoAtual.anoFab = Convert.ToInt32(tb_anoFab.Text);
            infGerais.VeiculoAtual.anoMod = Convert.ToInt32(tb_anoMod.Text);

            switch (true)
            {
                case true when rb_sedan.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Sedan";
                    break;
                case true when rb_hatch.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Hatch";
                    break;
                case true when rb_perua.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Perua";
                    break;
                case true when rb_suv.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "SUV";
                    break;
                case true when rb_cupe.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Cupê";
                    break;
                case true when rb_fastback.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Fastback";
                    break;
                case true when rb_targa.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Targa";
                    break;
                case true when rb_roadster.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Roadster";
                    break;
                case true when rb_minivan.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Minivan";
                    break;
                case true when rb_van.Checked:
                    infGerais.VeiculoAtual.tipoCarroceria = "Van";
                    break;
                default:
                    MessageBox.Show("Selecione o tipo de carroceria!!");
                    break;
            }

            infGerais.VeiculoAtual.numPortas = Convert.ToInt32(tb_numeroPort.Text);
            switch (true)
            {
                case true when rb_branco.Checked:
                    infGerais.VeiculoAtual.cor = "Branco";
                    break;
                case true when rb_preto.Checked:
                    infGerais.VeiculoAtual.cor = "Preto";
                    break;
                case true when rb_cinza.Checked:
                    infGerais.VeiculoAtual.cor = "Cinza";
                    break;
                case true when rb_vermelho.Checked:
                    infGerais.VeiculoAtual.cor = "Vermelho";
                    break;
                case true when rb_azul.Checked:
                    infGerais.VeiculoAtual.cor = "Azul";
                    break;
                case true when rb_verde.Checked:
                    infGerais.VeiculoAtual.cor = "Verde";
                    break;
                case true when rb_rosa.Checked:
                    infGerais.VeiculoAtual.cor = "Rosa";
                    break;
                case true when rb_prata.Checked:
                    infGerais.VeiculoAtual.cor = "Prata";
                    break;
                default:
                    MessageBox.Show("Selecione a cor do veículo!!");
                    break;
            }

            var tecnicasForm = new InfTecnicas();
            tecnicasForm.Show();
            this.Hide();
        }

        private void tb_anoFab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_anoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_numeroPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
