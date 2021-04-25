using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Models
{
    public class ModifAjoutAdminViewModel
    {
        public Livre Livre { get; set; }

        [Required(ErrorMessage = "Un titre est obligatoire")]
        public String Titre { get; set; }
        public int Identifiant { get; set; }

        [Required(ErrorMessage = "Un numéro de page est obligatoire")]
        public int NombrePages { get; set; }

        [Required(ErrorMessage = "Une édition est obligatoire")]
        public string Edition { get; set; }

        [MaxLength(13,ErrorMessage ="L'ISBN est trop long")]
        [Required(ErrorMessage = "L'ISBN est obligatoire !!")]
        public string Isbn { get; set; }

        [Required(ErrorMessage = "Une date d'édition est obligatoire")]
        public DateTime DateEdition { get; set; }

        [Required(ErrorMessage = "Une date de lecture est obligatoire")]
        public DateTime? DateLecture { get; set; }

        [Required(ErrorMessage = "Une note est obligatoire")]
        public int? Note { get; set; }

        [Required(ErrorMessage = "Un résumer est obligatoire")]
        public string Resume { get; set; }
       

    }
}
