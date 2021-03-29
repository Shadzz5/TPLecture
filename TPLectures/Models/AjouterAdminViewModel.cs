using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Models
{
    public class AjouterAdminViewModel
    {
     
        public String Titre { get; set; }
        public int Identifiant { get; set; }
        public int NombrePages { get; set; }
        [Required]
        public string Edition { get; set; }
       
        
        [Required(ErrorMessage = "L'ISBN est obligatoire !!")]
        public string Isbn { get; set; }
       
        public short DateEdition { get; set; }
        public DateTime? DateLecture { get; set; }
        public int? Note { get; set; }
        public string Resume { get; set; }
        public string Commentaire { get; set; }

    }
}
