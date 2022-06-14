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
      if (rendimento <= 3000)
      {
        return rendimento / 100 * .03f;
      }
      else if (rendimento > 3000 && rendimento <= 6000)
      {
        return rendimento * .05f;
      }
      else if (rendimento > 6000 && rendimento <= 10000)
      {
        return rendimento * .07f;
      }
      else
      {
        return rendimento * .09f;
      }
    }


    //XX.XXX.XXX/0001-XX - XXXXXXXX0001XX
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