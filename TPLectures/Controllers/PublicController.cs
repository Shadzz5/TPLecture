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
            
            String titre = "Un livre";
            if (livre == null)
            {
                return NotFound();
            }
            LecturePublicViewModel model = new LecturePublicViewModel();
            model.Livre = livre;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Commentaire(int id)
        {
            Commentaire commentaire = context.Commentaire.Find(id);
            CommentaireViewModel model = new CommentaireViewModel();
            model.Commentaire = commentaire;
            model.Identifiant = commentaire.Identifiant;
            model.IdentifiantLivre = commentaire.IdentifiantLivre;
            model.IdentifiantLivreNavigation = commentaire.IdentifiantLivreNavigation;
            model.Pseudo = commentaire.Pseudo;
            model.Timepublication = commentaire.Timepublication;
            model.Commentaire1 = commentaire.Commentaire1;
            return View(model);
        }
        
    }
}
