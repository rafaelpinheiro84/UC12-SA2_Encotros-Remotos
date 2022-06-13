using Cadastro_Pessoa_FS1.Classes;




// PessoaFisica metodoPf = new PessoaFisica();

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEnd = new Endereco();

// novaPf.nome = "odirlei";
// novaPf.dataNascimento = "01/01/2000";
// novaPf.cpf = "1234567890";
// novaPf.rendimento = 15000.5f;

// novoEnd.logradouro = "Alameda Barão de Limeira";
// novoEnd.numero = 539;
// novoEnd.complemento = "SENAI Informatica";
// novoEnd.endComercial = true;

// novaPf.endereco = novoEnd;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {metodoPf.validarDatanascimento(novaPf.dataNascimento)}
// ");


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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Vàlido: {metodoPj.validarCnpj(novaPj.cnpj)}");