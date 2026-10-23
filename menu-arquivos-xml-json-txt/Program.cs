using System;
using System.Text.Json;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== MENU =====");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1 - Arquivo XML");
            Console.WriteLine("2 - Arquivo");
            Console.WriteLine("3 - Arquivo JSON");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ArquivoXML();
                    break;

                case "2":
                    Arquivo();
                    break;

                case "3":
                    ArquivoJSON();
                    break;

                case "0":
                    Console.WriteLine("Programa encerrado.");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        void ArquivoXML()
        {
            ArquivoBase arquivo = new ArquivoXMLClasse();
            arquivo.Executar();
        }

        void Arquivo()
        {
            ArquivoBase arquivo = new ArquivoTexto();
            arquivo.Executar();
        }

        void ArquivoJSON()
        {
            ArquivoBase arquivo = new ArquivoJSONClasse();
            arquivo.Executar();
        }
    }
}


abstract class ArquivoBase
{
    public string NomeArquivo { get; set; }

    protected ArquivoBase(string nomeArquivo)
    {
        NomeArquivo = nomeArquivo;
    }

    public abstract void Executar();
}

class ArquivoXMLClasse : ArquivoBase
{
    public ArquivoXMLClasse() : base("livros.xml") { }

    public override void Executar()
    {
        try
        {
            List<Book> livros = new()
            {
                new Book() { Title = "O Senhor dos Anéis" },
                new Book() { Title = "O Hobbit" },
                new Book() { Title = "Harry Potter 1" }
            };

            XmlSerializer writer = new XmlSerializer(typeof(List<Book>));
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\\" + NomeArquivo;

            using FileStream arquivoXML = File.Create(path);
            writer.Serialize(arquivoXML, livros);

            Console.WriteLine($"Arquivo XML criado em: {path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar o arquivo XML: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Bloco finally do XML executado.");
        }
    }
}

class ArquivoTexto : ArquivoBase
{
    public ArquivoTexto() : base("arquivo.txt") { }

    public override void Executar()
    {
        try
        {
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\\" + NomeArquivo;

            File.WriteAllText(path, "Este é um arquivo de texto criado pelo programa.");

            Console.WriteLine($"Arquivo criado em: {path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar o arquivo: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Bloco finally do arquivo executado.");
        }
    }
}

class ArquivoJSONClasse : ArquivoBase
{
    public ArquivoJSONClasse() : base("weatherForecastUtf8.json") { }

    public override void Executar()
    {
        try
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTimeOffset.Now,
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            byte[] jsonUtf8Bytes =
                JsonSerializer.SerializeToUtf8Bytes(weatherForecast);

            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\\" + NomeArquivo;

            File.WriteAllBytes(path, jsonUtf8Bytes);

            Console.WriteLine($"Arquivo JSON criado em: {path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar o arquivo JSON: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Bloco finally do JSON executado.");
        }
    }
}

public class Book
{
    public string? Title { get; set; }
}

public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}
