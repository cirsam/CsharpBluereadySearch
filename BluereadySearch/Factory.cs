using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluereadySearch.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BluereadySearch.Controllers
{
    public static class Factory
    {
        // GET: /<controller>/
        public static MessageClass CreateMessage()
        {
            return new MessageClass();
        }

        public static SendMessage CreateSendMessage(IMessageClass messageClass)
        {
            return new SendMessage(messageClass);
        }
    }
}
