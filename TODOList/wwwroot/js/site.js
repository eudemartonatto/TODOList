
  $(document).ready(function () {
    $('.tabela').DataTable(
      {
        "language": {
          "lengthMenu": "Mostrar _MENU_ registros por Página",
          "zeroRecords": "Desculpe, nada encontrado",
          "info": "Mostrando Página _PAGE_ de _PAGES_",
          "infoEmpty": "Sem registros disponíveis",
          "infoFiltered": "(Filtrado _MAX_ registros)",
          "search": "Pesquisa:",
          "paginate": {
            "first": "Primeira",
            "last": "Última",
            "next": "Próxima",
            "previous": "Anterior"
          }
        }
        
      });
  });
