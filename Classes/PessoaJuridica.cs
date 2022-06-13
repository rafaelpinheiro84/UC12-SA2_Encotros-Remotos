using System.Text.RegularExpressions;
using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
  public class PessoaJuridica : Pessoa, IPessoaJuridica
  {
    //Atributos cnpj e razao social
    public string? cnpj { get; set; }
    public string? razaoSocial { get; set; }

    //Métodos
    public override float PagarImposto(float rendimento)
    {
      throw new NotImplementedException();
    }



    public bool validarCnpj(string cnpj)
    { //Regex, método para validar dois formatos de cnpj
      if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
      {
        if (cnpj.Length == 18)
        { //condição para comprar /0001
          if (cnpj.Substring(11, 4) == "0001")
          {
            return true;
          }
        }
        else if (cnpj.Length == 14)
        {
          if (cnpj.Substring(8, 4) == "0001")
          {
            return true;
          }
        }
      }

      return false;
    }
  }
}