using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TODOList.Models
{
  public class Acesso
  {
    public long Id { get; set; }

    [Display(Name = "e-mail")]
    public string Email { get; set; }

    public string Senha { get; set; }

    [Display(Name = "Data do Acesso")]
    [DataType(DataType.DateTime, ErrorMessage = "Data Inválida")]
    public DateTime DataLogin { get; set; }

  }
}
