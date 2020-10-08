using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;


namespace TODOList.Models
{
  public class TODOItem
  {
    public long Id { get; set; }

    [Display(Name = "Nome do Usuário")]
    public string Name { get; set; }
  
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Display(Name = "Concluído")]
    public Boolean Concluido { get; set; }

    [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
    [Display(Name = "Data da Inserção")]
    public DateTime DataHoraInsercao { get; set; }

    [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
    [Display(Name = "Data do Vencimento")]
    public DateTime DataHoraVencimento { get; set; }

    [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
    [Display(Name = "Data da Finalização")]
    [AllowNull]
    public DateTime DataHoraFinalizacao { get; set; }

    [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
    [Display(Name = "Data da Atualização")]
    public DateTime DataHoraAtualizacao { get; set; }

  }
}
