using System;
using System.Collections.Generic;

namespace TPLectureDB.EF.Models
{
    public partial class Commentaire
    {
        public int Identifiant { get; set; }
        public string Pseudo { get; set; }
        public string Commentaire1 { get; set; }
        public DateTime Datepublication { get; set; }
        public TimeSpan Timepublication { get; set; }
        public int IdentifiantLivre { get; set; }

        public virtual Livre IdentifiantLivreNavigation { get; set; }
    }
}
