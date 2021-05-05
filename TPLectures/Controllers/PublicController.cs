using Microsoft.AspNetCore.Mvc;
using TPLectures.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Controllers
{
    public class PublicController : Controller
    {
        lecturesContext context = new lecturesContext();
        public Livre livre { get; set; }
        public IActionResult Index()
        {
            List<Livre> livres = context.Livre.ToList();
            String titre = "La liste des fiches de lectures";

            IndexPublicViewModel model = new IndexPublicViewModel();
            model.Livres = livres;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Lecture(int id)
        {
            Livre livre = context.Livre.Find(id);
            List<Commentaire> commentaires = context.Commentaire.ToList();
            String titre = "Un livre";
            if (livre == null)
            {
                return NotFound();
            }
            LecturePublicViewModel model = new LecturePublicViewModel();
            model.Livre = livre;
            model.Commentaires = commentaires;
            model.Titre = titre;
            

            return View(model);
        }
        public IActionResult Commentaire(int id)
        {
            Commentaire commentaire = new Commentaire();
            CommentaireViewModel model = new CommentaireViewModel();
            DateTime dateTime = DateTime.Now;
            model.IdentifiantLivre = id;
            model.Pseudo = commentaire.Pseudo;
            model.Commentaire1 = commentaire.Commentaire1;
            model.Datepublication = dateTime;
            return View(model);
        }
        public IActionResult ConfirmationCommentaire(Commentaire commentaire)
        {
            if (commentaire != null)
            {
                context.Add(commentaire);

                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
