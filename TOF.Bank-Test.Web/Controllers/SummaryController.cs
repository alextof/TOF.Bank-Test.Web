using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOF.Bank_Test.Web.Repositories;

namespace TOF.Bank_Test.Web.Controllers
{
    public class SummaryController : Controller
    {
        private readonly BankRepository _bankRepository;
        public SummaryController(BankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
