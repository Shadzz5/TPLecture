using System;
using System.Collections.Generic;

namespace TPLectureDB.EF.Models
{
    public partial class Livre
    {
        public Livre()
        {
            CommentaireNavigation = new HashSet<Commentaire>();
        }

        public int Identifiant { get; set; }
        public int NombrePages { get; set; }
        public string Titre { get; set; }
        public string Edition { get; set; }
        public string Isbn { get; set; }
        public DateTime DateEdition { get; set; }
        public DateTime? DateLecture { get; set; }
        public int? Note { get; set; }
        public string Resume { get; set; }
        public string Commentaire { get; set; }

        public virtual ICollection<Commentaire> CommentaireNavigation { get; set; }
    }
}
