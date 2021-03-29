using System;
using System.Collections.Generic;

namespace TPLectureDB.EF.Models
{
    public partial class Livre
    {
        public int Identifiant { get; set; }
        public int NombrePages { get; set; }
        public string Titre { get; set; }
        public string Edition { get; set; }
        public string Isbn { get; set; }
        public short DateEdition { get; set; }
        public DateTime? DateLecture { get; set; }
        public int? Note { get; set; }
        public string Resume { get; set; }
        public string Commentaire { get; set; }
    }
}
