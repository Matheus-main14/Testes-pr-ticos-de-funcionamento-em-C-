using System.Xml.Serialization;

string CaminhoDoArquivo()
{
    return Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "livro.xml"
    );
}

string WriteXML()
{
    List<Book> livros = new List<Book>()
    {
        new Book() { Title = "O Senhor dos Anéis" },
        new Book() { Title = "O Hobbit" },
        new Book() { Title = "Harry Potter 1" }
    };

    XmlSerializer writer = new XmlSerializer(typeof(List<Book>));
    string path = CaminhoDoArquivo();

    using (FileStream arquivoXML = File.Create(path))
    {
        writer.Serialize(arquivoXML, livros);
    }

    return path;
}

void ReadXML()
{
    try
    {
        XmlSerializer reader = new XmlSerializer(typeof(List<Book>));
        string path = CaminhoDoArquivo();

        using (StreamReader arquivoXML = new StreamReader(path))
        {
            List<Book>? livros = reader.Deserialize(arquivoXML) as List<Book>;

            if (livros == null)
            {
                Console.WriteLine("O arquivo XML está vazio ou em formato inesperado.");
                return;
            }

            foreach (var livro in livros)
            {
                Console.WriteLine($"Livro: {livro.Title}");
            }
        }
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("Arquivo XML não encontrado: " + ex.Message);
    }
    catch (Exception)
    {
        Console.WriteLine("Erro ao ler o arquivo XML.");
    }
    finally
    {
        Console.WriteLine("Bloco final executado.");
    }
}

string caminhoDoArquivo = WriteXML();
Console.WriteLine($"Arquivo XML gerado em: {caminhoDoArquivo}");
ReadXML();