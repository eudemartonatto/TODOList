using System;
using System.ComponentModel.DataAnnotations;

namespace TODOList.Models
{
  public class Cliente
  {    
    public long Id { get; set; }

    [Display(Name = "e-mail")]
    public string Email { get; set; }
    [Display(Name = "Tipo do Usuário")]
    public string TipoUsuario { get; set; }
  }
}
