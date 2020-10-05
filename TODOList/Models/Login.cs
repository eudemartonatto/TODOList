using System;
using System.ComponentModel.DataAnnotations;

namespace TODOList.Models
{
  public class Login
  {
    public long Id { get; set; }

    [Display(Name = "e-mail")]
    public string Email { get; set; }
    
    public string Senha { get; set; }
    
    [Display(Name = "Data do Acesso")]
    [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
    public DateTime DataLogin { get; set; }
  }
}
