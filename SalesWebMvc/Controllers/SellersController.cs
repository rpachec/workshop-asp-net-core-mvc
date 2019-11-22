using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        //depend~encia para o ServiceService
        //injeção de dependência
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }


        //Esse controller chama o arquivo que tiver o nome
        //Index na pasta com o mesmo sufixo desta classe
        //(neste caso, a pasta Sellers)

        //Controlador encaminhou a requisição para a view
        public IActionResult Index()
        {
            //ao clicar no Index Seller, deveremos
            //executar o método FindAll do SellerServices
            var list = _sellerService.FindAll();


            return View(list);
        }
    }
}