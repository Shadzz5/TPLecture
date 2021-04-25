using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Models
{
    public class CommentaireViewModel
    {
        public Commentaire Commentaire{ get; set; }

        public int Identifiant { get; set; }
        public string Pseudo { get; set; }
        public string Commentaire1 { get; set; }
        public DateTime Datepublication { get; set; }
        public TimeSpan Timepublication { get; set; }
        public int IdentifiantLivre { get; set; }

        public virtual Livre IdentifiantLivreNavigation { get; set; }

    }
}
