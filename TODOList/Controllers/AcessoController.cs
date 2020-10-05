using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TODOList.Data;
using TODOList.Models;

namespace TODOList.Controllers
{
  public class AcessoController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    private readonly TODOListContext _context;
    public async Task<IActionResult> Acessar(long? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var acessar = await _context.Acessar.FindAsync(id);
      if (acessar == null)
      {
        return NotFound();
      }
      return View(acessar);
    }


  }
}
