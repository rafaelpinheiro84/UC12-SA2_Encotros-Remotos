// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;


PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "odirlei";

Console.WriteLine("Nome: " + novaPF.nome);
Console.WriteLine($"Nome: {novaPF.nome}");