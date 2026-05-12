using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SenaPay_Base.Controllers
{
    public class AprendizController : Controller
    {

        // GET: AprendizController
        public ActionResult VistaAprendiz()
        {
            return View();
        }

        // GET: AprendizController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AprendizController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AprendizController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AprendizController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AprendizController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AprendizController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AprendizController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
