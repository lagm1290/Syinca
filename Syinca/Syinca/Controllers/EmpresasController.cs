using Syinca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Syinca.Controllers
{
    public class EmpresasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            EmpresasContext db = new EmpresasContext();
            
            return View(db.COM_Empresas.ToList());
        }
    }
}