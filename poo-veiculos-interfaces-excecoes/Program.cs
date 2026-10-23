using System;
using System.Collections.Generic;

public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Combustivel { get; set; }

    public Veiculo(string marca, string modelo, int ano, string combustivel)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Combustivel = combustivel;
    }

    public abstract double CalcularConsumo(double distancia);

    public virtual void ExibirInfo()
    {
        Console.WriteLine(
            $"Veículo: {Marca} {Modelo} ({Ano}) - Combustível: {Combustivel}"
        );
    }

    public void Acelerar()
    {
        Console.WriteLine($"O {Modelo} está acelerando...");
    }
}

public interface IManutencao
{
    void RealizarRevisao();
    void TrocarOleo();
}

public interface ISeguranca
{
    void AtivarAlarme();
    void TravarPortas();
}

public class Carro : Veiculo, IManutencao, ISeguranca
{
    public Carro(string marca, string modelo, int ano, string combustivel)
        : base(marca, modelo, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 12.0;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine("Tipo: Carro (Autonomia média: 12 km/L)");
    }

    public void AtivarAlarme()
    {
        Console.WriteLine("Alarme do carro ativado.");
    }

    public void RealizarRevisao()
    {
        Console.WriteLine("Revisão do carro realizada.");
    }

    public void TravarPortas()
    {
        Console.WriteLine("Portas do carro travadas.");
    }

    public void TrocarOleo()
    {
        Console.WriteLine("Óleo do carro trocado.");
    }
}

public class Moto : Veiculo, IManutencao, ISeguranca
{
    public Moto(string marca, string modelo, int ano, string combustivel)
        : base(marca, modelo, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 35.0;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine("Tipo: Moto (Autonomia média: 35 km/L)");
    }

    public void AtivarAlarme()
    {
        Console.WriteLine("Alarme da moto ativado.");
    }

    public void RealizarRevisao()
    {
        Console.WriteLine("Revisão da moto realizada.");
    }

    public void TravarPortas()
    {
        Console.WriteLine("A moto não possui portas.");
    }

    public void TrocarOleo()
    {
        Console.WriteLine("Óleo da moto trocado.");
    }
}

public class Caminhao : Veiculo, IManutencao, ISeguranca
{
    public Caminhao(string marca, string modelo, int ano, string combustivel)
        : base(marca, modelo, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 6.0;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine("Tipo: Caminhão (Autonomia média: 6 km/L)");
    }

    public void AtivarAlarme()
    {
        Console.WriteLine("Alarme do caminhão ativado.");
    }

    public void RealizarRevisao()
    {
        Console.WriteLine("Revisão do caminhão realizada.");
    }

    public void TravarPortas()
    {
        Console.WriteLine("Portas do caminhão travadas.");
    }

    public void TrocarOleo()
    {
        Console.WriteLine("Óleo do caminhão trocado.");
    }
}

public partial class Program
{
    public static void SimularViagem(Veiculo veiculo, double distancia)
    {
        Console.WriteLine("=== SIMULAÇÃO DE VIAGEM ===");

        veiculo.ExibirInfo();
        veiculo.Acelerar();

        double consumo = veiculo.CalcularConsumo(distancia);

        Console.WriteLine($"Distância percorrida: {distancia} km");
        Console.WriteLine($"Combustível consumido: {consumo:F2} litros");

        Console.WriteLine(new string('-', 60));
    }

    public static void Main(string[] args)
    {
        List<Veiculo> frota = new List<Veiculo>
        {
            new Carro("Toyota", "Corolla", 2022, "Flex"),
            new Moto("Honda", "CB 500F", 2023, "Gasolina"),
            new Caminhao("Volvo", "FH 540", 2021, "Diesel")
        };

        double distanciaViagem = 300.0;

        foreach (Veiculo veiculo in frota)
        {
            SimularViagem(veiculo, distanciaViagem);
        }
    }
}
