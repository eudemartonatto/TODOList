using System;
using System.ComponentModel.DataAnnotations;

namespace TODOList.Models
{
  public class Acesso
  {
    [Display(Name = "Usuário")]
    public string Email { get; set; }
    [Display(Name = "Senha de Acesso")]
    public string Senha { get; set; }
  }
}
