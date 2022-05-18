using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Police_Inspectorate.Models;
using Police_Inspectorate.Repositories;
using Police_Inspectorate.Repositories.Interfaces;

namespace Police_Inspectorate.Controllers
{
    public class CaseController : Controller
    {
        private readonly ICaseRepository _CaseRepository;

        public CaseController(ICaseRepository CaseRepository)
        {
            _CaseRepository = CaseRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Case> caseList = _CaseRepository.GetAll();
            return View(caseList);
        }


        public IActionResult CreateCases()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult CreateCases(Case cases)
        {
            _CaseRepository.Create(cases);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _CaseRepository.GetAll();
            //var categoryFromDbFirst = _db.Gamess.FirstOrDefault(u=>u.GameId==id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCases(Case cases)
        {
            _CaseRepository.Delete(cases);
            return RedirectToAction("Index");
        }
    }
}
