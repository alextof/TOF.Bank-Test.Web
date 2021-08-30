using Microsoft.AspNetCore.Mvc;
using TOF.Bank_Test.Web.Repositories;

namespace TOF.Bank_Test.Web.Controllers
{
    public class MovementController : Controller
    {
        private readonly BankRepository _bankRepository;
        public MovementController(BankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public IActionResult Index()
        {
            var list = _bankRepository.GetAllMovements();
            return View(list);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(object transfer)
        {

            var isSuccessful = _bankRepository.AddTransfer(transfer);

            if (isSuccessful)
                return Ok();
            else
                return BadRequest();
            
        }
    }
}
