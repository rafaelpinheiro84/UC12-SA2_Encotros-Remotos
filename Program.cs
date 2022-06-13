using Cadastro_Pessoa_FS1.Classes;


Console.WriteLine(@$"
===============================================
|      Bem vindo ao sistema de cadastro de    |
|        Pessoas Fisicas e Juridícas          |
===============================================
");


BarraCarregamento("Carregando", 500);

string? opcao;
do
{
  Console.Clear();
  Console.WriteLine(@$"
================================================
|          Escolha uma das opções abaixo       |
|--------------------------------------------- |
|          1 - Pessoa Fisica                   |
|          2 - Pessoa Jurídica                 |
|                                              |
|          0 - Sair                            |
================================================

");
  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      PessoaFisica metodoPf = new PessoaFisica();

      PessoaFisica novaPf = new PessoaFisica();
      Endereco novoEnd = new Endereco();

      novaPf.nome = "odirlei";
      novaPf.dataNascimento = "01/01/2000";
      novaPf.cpf = "1234567890";
      novaPf.rendimento = 15000.5f;

      novoEnd.logradouro = "Alameda Barão de Limeira";
      novoEnd.numero = 539;
      novoEnd.complemento = "SENAI Informatica";
      novoEnd.endComercial = true;

      novaPf.endereco = novoEnd;

      Console.Clear();
      Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.validarDatanascimento(novaPf.dataNascimento)}
");

      Console.WriteLine($"Aperte 'Enter' para continuar");
      Console.ReadLine();

      break;

    case "2":

      PessoaJuridica metodoPj = new PessoaJuridica();

      PessoaJuridica novaPj = new PessoaJuridica();
      Endereco novoEndPj = new Endereco();

      novaPj.nome = "Nome pj";
      novaPj.cnpj = "00.000.000/0001-00";
      novaPj.razaoSocial = "Razão Social Pj";
      novaPj.rendimento = 8000.5f;

      novoEndPj.logradouro = "Alameda Barão de Limeira";
      novoEndPj.numero = 539;
      novoEndPj.complemento = "SENAI Informatica";
      novoEndPj.endComercial = true;

      novaPj.endereco = novoEndPj;

      Console.Clear();
      Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
 CNPJ Vàlido: {metodoPj.validarCnpj(novaPj.cnpj)}");

      Console.WriteLine($"Aperte 'Enter' para continuar");
      Console.ReadLine();
      break;


    case "0":
      Console.Clear();
      Console.WriteLine($"Obrigado por utilizar nosso sistema");

      BarraCarregamento("finalizando", 300);

      break;

    default:
      Console.Clear();
      Console.WriteLine($"Opção invalida, por favor digite outra opção");
      Thread.Sleep(2000);
      break;
  }

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
  Console.BackgroundColor = ConsoleColor.DarkCyan;
  Console.ForegroundColor = ConsoleColor.Red;

  Console.Write($"{texto} ");

  for (var contador = 0; contador < 10; contador++)
  {
    Console.Write(". ");
    Thread.Sleep(tempo);
  }

  Console.ResetColor();
}