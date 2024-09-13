using Delt.Models.Enums;
using Delt.Utility.Checkers;
using Microsoft.AspNetCore.Mvc;

namespace Delt.Web.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chat(ProgrammerType programmerType)
        {
            ProgrammerType programmerFlag;

            if (programmerType.IsNull())
                return NotFound();

            if (programmerType == ProgrammerType.FrontEnd)
                programmerFlag = ProgrammerType.FrontEnd;
            else
                programmerFlag = ProgrammerType.BackEnd;

            return View(programmerFlag);
        }
    }
}
