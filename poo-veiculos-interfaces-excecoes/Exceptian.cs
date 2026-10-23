try
{
    int a = int.Parse("2"); // Tentativa de conversão inválida
    int idade = -1;

    if (idade < 0)
    {
        throw new IdadeInvalidaException("A idade não pode ser negativa.");
    }
}
catch (IdadeInvalidaException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}

catch (FormatException)
{
    Console.WriteLine("Erro de formato!");
}
catch (Exception ex)
{
    Console.WriteLine("Erro genérico: " + ex.Message);
}
finally
{
    Console.WriteLine("Bloco final executado.");
}
