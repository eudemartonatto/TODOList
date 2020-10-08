using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODOList.Views.Home
{
    public class Logado : PageModel
    {
        public void Logadao()
        {
          string x = Request.Form["casinha"];
          string y = Request.Form["casinha"];
        }
    }
}
