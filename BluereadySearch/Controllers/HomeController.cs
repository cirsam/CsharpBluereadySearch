using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BluereadySearch.Models;
using BluereadySearch.Data;
using Microsoft.EntityFrameworkCore;

namespace BluereadySearch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public string EmailMessage(string firstname, string lastname, string email, string phone, string message)
        {
            IMessageClass messageClass = Factory.CreateMessage();
            messageClass.FirstName = firstname;
            messageClass.LastName = lastname;
            messageClass.Phone = phone;
            messageClass.Email = email;
            messageClass.Message = message;

            if (!ModelState.IsValid)
            {

                return string.Join("|", ModelState.Values.SelectMany(x => x.Errors).Select(state => state.ErrorMessage));

            }

            SendMessage messagesent = Factory.CreateSendMessage(messageClass);

            return messagesent.Status;
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
