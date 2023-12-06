public class Veiculo
{
    public int id { get; set; }
    public string marca { get; set; }
    public string modelo { get; set; }
    public int anoFab { get; set; }
    public int anoMod { get; set; }
    public string tipoCarroceria { get; set; }
    public int numPortas { get; set; }
    public string cor { get; set; }
    public string chassi { get; set; }
    public string motor { get; set; }
    public string tipoCombustivel { get; set; }
    public double capacidadeTanque { get; set; }
    public double potencia { get; set; }
    public string transmissao { get; set; }
    public string tracao { get; set; }
    public string renavam { get; set; }
    public string placa { get; set; }
    public DateTime dataLicenciamento { get; set; }
    public DateTime dataUltimaInspecao { get; set; }
    public Veiculo()
    {

    }
    public Veiculo(string marca, string modelo, int anoFab, int anoMod, string tipoCarroceria, int numPortas, string cor, string chassi, string motor, string tipoCombustivel, int capacidadeTanque, int potencia, string transmissao, string tracao, string renavam, string placa, DateTime dataLicenciamento, DateTime dataUltimaInspecao)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.anoFab = anoFab;
        this.anoMod = anoMod;
        this.tipoCarroceria = tipoCarroceria;
        this.numPortas = numPortas;
        this.cor = cor;
        this.chassi = chassi;
        this.motor = motor;
        this.tipoCombustivel = tipoCombustivel;
        this.capacidadeTanque = capacidadeTanque;
        this.potencia = potencia;
        this.transmissao = transmissao;
        this.tracao = tracao;
        this.renavam = renavam;
        this.placa = placa;
        this.dataLicenciamento = dataLicenciamento;
        this.dataUltimaInspecao = dataUltimaInspecao;
    }
}