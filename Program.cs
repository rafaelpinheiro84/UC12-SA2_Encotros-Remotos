// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
===============================================
|      Bem vindo ao sistema de cadastro de    |
|        Pessoas Fisicas e Juridícas          |
===============================================
");

BarraCarregamento("Carregando", 500);
// Console.WriteLine($"Sem Cor!"); Para testar o Reset Color

List<PessoaFisica> listPf = new List<PessoaFisica>();
List<PessoaJuridica> listPJ = new List<PessoaJuridica>();

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

      string? opcaoPf;
      do
      {
        Console.Clear();

        Console.WriteLine(@$"
================================================
|          Escolha uma das opções abaixo       |
|--------------------------------------------- |
|          1 - Cadastrar Pessoa Físíca         |
|          2 - Mostrar Pessoas Físícas         |
|                                              |
|          0 - Voltar ao Menu Anterior         |
================================================
");
        opcaoPf = Console.ReadLine();

        switch (opcaoPf)
        {
          case "1":
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            Console.WriteLine($"Digite o nome da pessoa físíca que deseja cadastrar");
            novaPf.nome = Console.ReadLine();

            Console.Clear();

            bool dataValida;
            do
            {

              Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
              string? dataNasc = Console.ReadLine();

              dataValida = metodoPf.ValidarDatanascimento(dataNasc);
              if (dataValida)
              {
                novaPf.dataNascimento = dataNasc;
              }
              else
              {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Data digitada invalida, por favor digite uma data valida.");
                Console.ResetColor();
              }

            } while (dataValida == false);


            Console.Clear();
            Console.WriteLine($"Digite o numero do CPF");
            novaPf.cpf = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Digite o rendimento mensal(digite somente numeros)");
            novaPf.rendimento = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Digite o logradouro");
            novoEnd.logradouro = Console.ReadLine();

            Console.WriteLine($"Digite o numero");
            novoEnd.numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o comlplemento(Aperte ENTER para vazio)");
            novoEnd.complemento = Console.ReadLine();

            Console.WriteLine($"Este endereço é comercial? S/N");
            string endCom = Console.ReadLine().ToUpper();

            if (endCom == "S")
            {
              novoEnd.endComercial = true;
            }
            else
            {
              novoEnd.endComercial = false;
            }

            novaPf.endereco = novoEnd;

            // listaPf.Add(novaPf);

            //  StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
            //  sw.Write(novaPf.nome);
            //  sw.Close();

            /* // using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
             // {
             //   sw.Write($"{novaPf.nome},{novaPf.dataNascimento}");
              }
              */

            metodoPf.Inserir(novaPf);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastro realizado com sucesso!!!");
            Thread.Sleep(3000);
            Console.ResetColor();

            break;

          case "2":
            Console.Clear();

            //             if (listaPf.Count > 0)
            //             {

            //               foreach (PessoaFisica cadaPessoa in listaPf)
            //               {
            //                 Console.Clear();
            //                 Console.WriteLine(@$"
            // Nome: {cadaPessoa.nome}
            // Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
            // Data de Nascimento: {cadaPessoa.dataNascimento}
            // Taxa de imposto a ser paga é; {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
            // ");
            //                 // ToString converte para padrao moeda e corta as casas decimais
            //                 // ?:  if else

            //                 Console.WriteLine($"Aperte 'Enter' para continuar");
            //                 Console.ReadLine();
            //               }

            //             }
            //             else
            //             {
            //               Console.WriteLine($"Lista vazia!!");
            //               Thread.Sleep(3000);

            //             }

            /*
            // using (StreamReader sr = new StreamReader("rafael.txt"))
            // {

            //   string linha;
            //   while ((linha = sr.ReadLine()) != null)
            //   {
            //     Console.WriteLine($"{linha}");

            //   }
            // }
           */

            List<PessoaFisica> listaPf = metodoPf.Ler();

            foreach (PessoaFisica cadaPefisica in listaPf)
            {
              Console.Clear();
              Console.WriteLine(@$"
Nome: {cadaPefisica.nome}
Data de Nascimento {cadaPefisica.dataNascimento}
CPF: {cadaPefisica.cpf}
 ");

              Console.WriteLine($"Aperte 'Enter' para continuar");
              Console.ReadLine();
            }




            // Console.WriteLine($"Aperte 'Enter' para continuar");
            // Console.ReadLine();

            break;

          case "0":
            break;

          default:
            Console.Clear();
            Console.WriteLine($"Opção invalida, por favor digite outra opção");
            Thread.Sleep(2000);
            break;
        }


      } while (opcaoPf != "0");

      break;

    case "2":
      PessoaJuridica metodoPj = new PessoaJuridica();

      string? opcaoPJ;

      do
      {
        Console.Clear();

        Console.WriteLine(@$"
       =================================================
       |         Escolha uma das opções abaixo         |
       |-----------------------------------------------|
       |          1 - Cadastrar Pessoa Jurídica        |
       |          2 - Listar Pessoas Jurídicas         |
       |                                               |
       |          0 - Voltar ao Menu Anterior          |
       =================================================

      ");

        opcaoPJ = Console.ReadLine();

        switch (opcaoPJ)
        {
          case "1":
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            Console.Clear();
            Console.WriteLine($"Digite o nome\"fantasia\"da empresa para cadastrar.");
            novaPj.nome = Console.ReadLine();
            Console.Clear();


            bool cnpjValido;

            do
            {
              Console.WriteLine($"Digite o cnpj da empresa ex:00.000.000/0001-00");
              string? cnpjCorreto = Console.ReadLine();

              cnpjValido = metodoPj.validarCnpj(cnpjCorreto);
              if (cnpjValido)
              {
                novaPj.cnpj = cnpjCorreto;
              }
              else
              {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Cnpj incorreto, por favor digite um cnpj correto");
                Console.ResetColor();

              }

            } while (cnpjValido == false);
            Console.Clear();

            Console.WriteLine($"Digite a Razão Social da empresa");
            novaPj.razaoSocial = Console.ReadLine();
            Console.Clear();


            Console.WriteLine($"Digite o logradouro, Ex. Rua: Sabino");
            novoEndPj.logradouro = Console.ReadLine();

            Console.WriteLine($"Digite o numero");
            novoEndPj.numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite complementeo (Aperte ENTER para vazio)");
            novoEndPj.complemento = Console.ReadLine();

            novaPj.endereco = novoEndPj;

            Console.WriteLine($"Digite o rendimento mensal da empresa, (apenas numeros)");
            novaPj.rendimento = float.Parse(Console.ReadLine());
            Console.Clear();

            // listPJ.Add(novaPj);

            metodoPj.Inserir(novaPj);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Cadastro Realizado com sucesso!!!");
            Thread.Sleep(2000);
            Console.ResetColor();

            break;

          case "2":
            Console.Clear();

            // if (listPJ.Count > 0)
            // {

            //   foreach (PessoaJuridica cadaPejuridica in listPJ)
            //   {
            //     Console.Clear();
            //     Console.WriteLine(@$"
            // Nome: {cadaPejuridica.nome}
            // Razão Social: {cadaPejuridica.razaoSocial}
            // CNPJ: {cadaPejuridica.cnpj}
            // Endereço:  {cadaPejuridica.endereco.logradouro}, {cadaPejuridica.endereco.numero}, {cadaPejuridica.endereco.complemento}

            // Taxa de imposto a ser paga é: {metodoPj.PagarImposto(cadaPejuridica.rendimento).ToString("C")}
            // ");
            //     Console.WriteLine($"Aperte 'Enter' para continuar");
            //     Console.ReadLine();


            //   }
            // }
            // else
            // {
            //   Console.ForegroundColor = ConsoleColor.DarkBlue;
            //   Console.WriteLine($"Lista Vazia!!!");
            //   Thread.Sleep(3000);
            //   Console.ResetColor();
            // }



            List<PessoaJuridica> listaPJ = metodoPj.Ler();

            foreach (PessoaJuridica cadaPejuridica in listaPJ)
            {
              Console.Clear();
              Console.WriteLine(@$"
Nome: {cadaPejuridica.nome}
Razão Social: {cadaPejuridica.razaoSocial}
CNPJ: {cadaPejuridica.cnpj}
Endereço: {cadaPejuridica.endereco}
Rendimento: {cadaPejuridica.rendimento}");

              Console.WriteLine($"Aperte 'Enter' para continuar");
              Console.ReadLine();
            }


            break;

          case "0":
            break;

          default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(2000);
            break;
        }

      } while (opcao != "0");

      break;

    case "0":
      Console.Clear();

      BarraCarregamento("finalizando..", 300);

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
  Console.BackgroundColor = ConsoleColor.DarkYellow;
  Console.ForegroundColor = ConsoleColor.Black;

  Console.Write($"{texto} ");

  for (var contador = 0; contador < 10; contador++)
  {
    Console.Write(".");
    Thread.Sleep(tempo);
  }

  Console.ResetColor();
}
