# Testes práticos em C#

Coleção de pequenos projetos de console em **C#** feitos durante meus estudos de Programação Orientada a Objetos, tratamento de exceções e serialização de arquivos (XML e JSON). Cada pasta é um projeto independente e pode ser executado separadamente.

## Projetos

| Pasta | O que faz | Conceitos praticados |
|---|---|---|
| [`menu-arquivos-xml-json-txt`](./menu-arquivos-xml-json-txt) | Menu no console que cria um arquivo XML, um arquivo de texto ou um arquivo JSON, conforme a opção escolhida | Classe abstrata (`ArquivoBase`), herança, polimorfismo, `switch`, `try/catch/finally` |
| [`serializacao-xml-livros`](./serializacao-xml-livros) | Grava uma lista de livros em um arquivo XML e depois lê o arquivo de volta | `XmlSerializer`, `List<T>`, `using`, tratamento de `FileNotFoundException` |
| [`serializacao-json-previsao-tempo`](./serializacao-json-previsao-tempo) | Grava e lê um objeto de previsão do tempo (`WeatherForecast`) em formato JSON | `System.Text.Json`, serialização e desserialização, leitura e escrita de arquivos |
| [`poo-veiculos-interfaces-excecoes`](./poo-veiculos-interfaces-excecoes) | Hierarquia de veículos (carro, moto e caminhão) com cálculo de consumo, e exemplo de exceção personalizada para idade inválida | Classe abstrata (`Veiculo`), interfaces (`IManutencao`, `ISeguranca`), sobrescrita de métodos, polimorfismo, exceção customizada |
| [`sistema-biblioteca-console`](./sistema-biblioteca-console) | Menu de biblioteca com cadastro de usuário, cadastro de livro, empréstimo e devolução | Laço `while`, `switch`, entrada de dados pelo console, tratamento de `FormatException` |

> **Observação:** no `sistema-biblioteca-console` os dados digitados são apenas exibidos na tela, ainda não são armazenados. É uma base para evoluir com listas ou banco de dados.

## Tecnologias

- C#
- .NET (o projeto `menu-arquivos-xml-json-txt` usa o .NET 8; os demais usam o .NET 10)
- Visual Studio Code

## Como executar

1. Instale o [SDK do .NET](https://dotnet.microsoft.com/download) (versão 8 ou 10, conforme o projeto).
2. Clone o repositório:
   ```bash
   git clone https://github.com/Matheus-main14/Testes-pr-ticos-de-funcionamento-em-C-.git
   ```
3. Entre na pasta do projeto que você quer testar, por exemplo:
   ```bash
   cd Testes-pr-ticos-de-funcionamento-em-C-/serializacao-xml-livros
   ```
4. Execute:
   ```bash
   dotnet run
   ```

Os projetos que geram arquivos (XML, JSON e texto) salvam na pasta **Documentos** do usuário e usam caminho no estilo Windows.

## Autor

**Matheus Antony de Morais**
Estudante de Tecnologia em Sistemas para Internet no IFRN

[LinkedIn](https://www.linkedin.com/in/matheus-antony-3416a2430)