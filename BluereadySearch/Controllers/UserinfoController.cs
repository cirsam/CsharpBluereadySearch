using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BluereadySearch.Models;
using BluereadySearch.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BluereadySearch.Controllers
{
    public class UserinfoController : Controller
    {
        private readonly BRContext _bRContext;

        public UserinfoController(BRContext bRContext)
        {
            _bRContext = bRContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var select = _bRContext.Userinfos.Where(x=>x.UserID==1);

            return View(select);
        }
    }
}
