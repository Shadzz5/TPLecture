using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TPLectureDB.EF.Models;
using TPLectures.Web.Models;

namespace TPLectures.Controllers
{
    public class AdminController : Controller
    {
        LecturesContext context = new LecturesContext();
        public IActionResult Index()
        {

            List<Livre> livres = context.Livre.ToList();
            String titre = "Accès administration";

            IndexAdminViewModel model = new IndexAdminViewModel();
            model.Livres = livres;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Lecture(int id)
        {

            Livre livre = context.Livre.Find(id);
            String titre = "Un livre";
            if (livre == null)
            {

                return NotFound();
            }
            LectureAdminViewModel model = new LectureAdminViewModel();
            model.Livre = livre;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Delete(int id)
        {

            context.Remove(context.Livre.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Modifier(int id)
        {
            Livre livre = context.Livre.Find(id);
            ModifierAdminViewModel model = new ModifierAdminViewModel();
            model.Livre = livre;
            model.Identifiant = livre.Identifiant;
            model.Titre = livre.Titre;
            model.NombrePages = livre.NombrePages;
            model.Isbn = livre.Isbn;
            model.Note = livre.Note;
            model.DateEdition = livre.DateEdition;
            model.DateLecture = livre.DateLecture;
            model.Edition = livre.Edition;
            model.Resume = livre.Resume;
            model.Commentaire = livre.Commentaire;
            return View(model);
        }
        [HttpPost]
        public IActionResult ConfirmationModif(Livre livre)
        {
            
            if (livre != null)
            {
                context.Update(livre);
                context.SaveChanges();
            }




            return RedirectToAction("Index");
        }
        public IActionResult Ajouter()
        {
            
            
            Livre livre = new Livre();
            AjouterAdminViewModel model = new AjouterAdminViewModel();
            model.Identifiant = livre.Identifiant;
            model.Titre = livre.Titre;
            model.NombrePages = livre.NombrePages;
            model.Isbn= livre.Isbn;
            model.Note = livre.Note;
            model.DateEdition = livre.DateEdition;
            model.DateLecture = livre.DateLecture;
            model.Edition = livre.Edition;
            model.Resume = livre.Resume;
            model.Commentaire = livre.Commentaire;
            return View(model);
        }
        public IActionResult ConfirmationAjout(Livre livre)
        {
                context.Add(livre);
                context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}