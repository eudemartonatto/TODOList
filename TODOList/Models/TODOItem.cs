using System;
using System.ComponentModel.DataAnnotations;

namespace TODOList.Models
{
  public class TODOItem
  {
    public long Id { get; set; }

    [Display(Name = "Nome do Usuário")]
    public string Name { get; set; }

    [Display(Name = "Concluído")]
    public Boolean Concluido { get; set; }
    
    [Display(Name = "Data da Inserção")]
    public DateTime DataHoraInsercao { get; set; }

    [Display(Name = "Data do Vencimento")]
    public DateTime DataHoraVencimento { get; set; }

    [Display(Name = "Data da Finalização")]
    public DateTime DataHoraFinalizacao { get; set; }

    [Display(Name = "Data da Atualização")]
    public DateTime DataHoraAtualização { get; set; }

  }
}
