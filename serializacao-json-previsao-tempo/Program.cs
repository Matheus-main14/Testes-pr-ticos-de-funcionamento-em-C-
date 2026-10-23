using System.Text.Json;

string WriteJSON()
{
    var weatherForecast = new WeatherForecast
    {
        Date = DateTimeOffset.Now,
        TemperatureCelsius = 25,
        Summary = "Hot"
    };

    byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherForecast);

    var path = Environment.GetFolderPath(
        Environment.SpecialFolder.MyDocuments
    ) + "\\weatherForecastUtf8.json";

    File.WriteAllBytes(path, jsonUtf8Bytes);

    return path;
}


void ReadJSON()
{
    try
    {
        var path = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments
        ) + "\\weatherForecastUtf8.json";

        byte[] jsonUtf8Bytes = File.ReadAllBytes(path);

        WeatherForecast? weatherForecast =
            JsonSerializer.Deserialize<WeatherForecast>(jsonUtf8Bytes);

        Console.WriteLine($"Data: {weatherForecast?.Date}");
        Console.WriteLine($"Temperatura: {weatherForecast?.TemperatureCelsius}");
        Console.WriteLine($"Resumo: {weatherForecast?.Summary}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro ao ler o arquivo JSON: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Bloco final executado.");
    }
}


Console.WriteLine($"Arquivo JSON criado em: {WriteJSON()}");

ReadJSON();


internal class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}