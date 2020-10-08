using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TODOList.Models;
using TODOList.Data;

using System.Net;
using System.Web;
using Microsoft.AspNetCore.Http;

using System.Data;
using System.Data.SQLite;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TODOList.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private static SQLiteConnection sqliteConnection;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

  

    public bool EstaLogado()
    {
      int cont = 0;
      sqliteConnection = new SQLiteConnection("Data Source=c:Database.db; Version=3;");
      sqliteConnection.Open();

      using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=Database.db"))
      {
        string _usuario = Request.Form["usuario"];
        string _senha = Request.Form["senha"];
        connect.Open();
        using (SQLiteCommand fmd = connect.CreateCommand())
        {
          fmd.CommandText = @"SELECT DISTINCT Email FROM Login WHERE Email = '" + _usuario + "' AND senha = '" + _senha + "'";
          fmd.CommandType = CommandType.Text;
          SQLiteDataReader r = fmd.ExecuteReader();
          while (r.Read())
          {
            cont++;
          }
        }
        Program.EstaLogado = cont > 0;

      }

      return cont > 0;
    }
    public IActionResult Logado()
    {
      if (EstaLogado())
      {
        return Index();
      }
      else
        return Redirect("Erro");
    }

    public IActionResult Erro()
    {
      return View();
    }
    public IActionResult Privacy()
      {
        return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
    }
}
