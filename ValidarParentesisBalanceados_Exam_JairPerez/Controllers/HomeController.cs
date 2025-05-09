using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ValidarParentesisBalanceados_Exam_JairPerez.Models;
using ValidarParentesisBalanceados_Exam_JairPerez.Services;

namespace ValidarParentesisBalanceados_Exam_JairPerez.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new ValidationContext())
            {
                ViewBag.History = db.ValidationRequests
                                  .OrderByDescending(r => r.RequestDate)
                                  .Take(10)
                                  .ToList(); // Obtiene las últimas 10 validaciones
            }
            return View(); // Renderiza Views/Home/Index.cshtml
        }

        [HttpPost]
        public ActionResult Validate(string inputString)
        {
            bool isValid = ParenthesesValidator.IsBalanced(inputString); // Llama al validador

            using (var db = new ValidationContext())
            {
                db.ValidationRequests.Add(new ValidationRequest // Guarda en la base de datos
                {
                    InputString = inputString,
                    IsValid = isValid, 
                    RequestDate = DateTime.Now
                });
                db.SaveChanges();
            }
            return RedirectToAction("Index"); // Recarga la página
        }
    }
}