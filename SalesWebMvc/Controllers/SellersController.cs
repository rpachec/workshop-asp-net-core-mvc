using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //Esse controller chama o arquivo que tiver o nome
        //Index na pasta com o mesmo sufixo desta classe
        //(neste caso, a pasta Sellers)

        //Controlador encaminhou a requisição para a view
        public IActionResult Index()
        {
            return View();
        }
    }
}