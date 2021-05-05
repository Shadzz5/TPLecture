using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Models
{
    public class LecturePublicViewModel
    {
        public Livre Livre { get; set; }
        public String Titre { get; set; }
        public List<Commentaire> Commentaires { get; set; }
        public Commentaire Commentaire { get; set; }

        public int Identifiant { get; set; }
        public string Pseudo { get; set; }
        public string Commentaire1 { get; set; }
        public DateTime Datepublication { get; set; }
        public TimeSpan Timepublication { get; set; }
        public int IdentifiantLivre { get; set; }
        public virtual ICollection<Commentaire> CommentaireNavigation { get; set; }

        public virtual Livre IdentifiantLivreNavigation { get; set; }
    }
}
