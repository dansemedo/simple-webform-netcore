using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebForm.Models;

namespace WebForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Contatos()
        {

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Results([FromQuery] string name, string surname, string email, string phone, string message)
        {
            string messages = message;
            string names = name;
            string emails = email;
            string phones = phone;

            using (StreamWriter sw = new StreamWriter(@"..\\wwwroot\\wwwroot\\Contatos.csv", true))
            {
               
                sw.WriteLine($"nome: {names} ; telefone: {phones} ; email: { emails} ; mensagem: { messages} horario: { DateTime.Now} ");
            }


            ViewBag.messages = messages;
            ViewBag.names = name;
            ViewBag.emails = email;
            ViewBag.phones = phone;


            return View();

        }

    }
       

}
